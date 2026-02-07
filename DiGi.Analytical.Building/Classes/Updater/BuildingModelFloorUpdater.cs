using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Classes
{
    internal class BuildingModelFloorUpdater : BuildingModelUpdater
    {
        public BuildingModelFloorUpdater(BuildingModel? value)
            : base(value)
        {
        }

        public int FloorCount { get; set; } = -1;

        public double Tolerance { get; set; } = Core.Constants.Tolerance.Distance;

        public override bool Update()
        {
            if (FloorCount < 2 || Value is null)
            {
                return false;
            }

            List<Shell>? shells = Value.GetShells<ISpace>();
            if (shells == null || shells.Count == 0)
            {
                return false;
            }

            BoundingBox3D? boundingBox3D = Geometry.Spatial.Create.BoundingBox3D(shells.ConvertAll(x => x.GetBoundingBox()).FilterNulls());
            if (boundingBox3D is null)
            {
                return false;
            }

            double minElevation = boundingBox3D.Min.Z;

            double maxElevation = boundingBox3D.Max.Z;

            double height = minElevation - maxElevation;

            double floorHeight = System.Math.Round(height / FloorCount, 1);

            ShellByPlaneSplitSolver shellByPlaneSplitSolver = new(Tolerance);
            shellByPlaneSplitSolver.FaceSplit += (s, e) =>
            {
                e.UniqueReference = e.Input?.UniqueReference ?? new GuidReference(typeof(SurfaceAir), System.Guid.NewGuid());
                e.Handled = true;
            };

            bool split = false;

            double currentElevation = minElevation;
            while (currentElevation < maxElevation)
            {
                Plane? plane = Geometry.Spatial.Create.Plane(currentElevation);
                if (plane is null)
                {
                    break;
                }

                shellByPlaneSplitSolver.Plane = plane;

                for (int i = shells.Count - 1; i >= 0; i--)
                {
                    shellByPlaneSplitSolver.Input = shells[i];
                    if (!shellByPlaneSplitSolver.Solve())
                    {
                        continue;
                    }

                    List<Shell>? shells_Split = shellByPlaneSplitSolver.Outputs;
                    if (shells_Split is null || shells_Split.Count == 0)
                    {
                        continue;
                    }

                    split = true;

                    shells.RemoveAt(i);

                    shells.AddRange(shells_Split);
                }

                currentElevation += floorHeight;
            }

            if (!split)
            {
                return false;
            }

            BuildingModelShellsUpdater buildingModelShellsUpdater = new(Value)
            {
                Tolerance = Tolerance,
                Shells = shells,
            };

            return buildingModelShellsUpdater.Update();
        }
    }
}