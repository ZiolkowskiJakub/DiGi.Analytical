using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Classes
{
    internal class FloorSolver : ISolver
    {
        public FloorSolverOptions? FloorSolverOptions { get; set; }

        public BuildingModel? BuildingModel { get; set; }

        public bool Solve()
        {
            if(FloorSolverOptions is null || BuildingModel is null)
            {
                return false;
            }

            if(BuildingModel.GetBoundingBox() is not BoundingBox3D boundingBox3D)
            {
                return false;
            }

            double buildingHeight = boundingBox3D.Height;

            double floorHeight = System.Math.Round(buildingHeight / FloorSolverOptions.FloorCount, 1);

            

            List<IComponent>? components = BuildingModel.GetComponents<IComponent>();
            if(components is null || components.Count == 0)
            {
                return false;
            }




            return true;
        }
    }
}
