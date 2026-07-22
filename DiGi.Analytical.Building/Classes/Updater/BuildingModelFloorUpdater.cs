using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Slices all the spaces of a <see cref="BuildingModel"/> into <see cref="FloorCount"/> storeys of equal height.
    /// <para>The height of a storey is derived from the overall bounding box of the spaces of the model and rounded to one decimal place. The model is then cut by a horizontal plane on every resulting level: spaces crossed by a plane are replaced by the part below and the part above it, the components bounding them are rebuilt and a floor is created on the plane.</para>
    /// <para>Use BuildingModel.TrySplit directly when a single, explicitly placed division is needed - this updater is a convenience wrapper applying it on evenly distributed elevations.</para>
    /// </summary>
    /// <remarks>
    /// Openings hosted by a component that gets cut are not re-hosted onto the resulting components, they stay assigned to the one keeping the identifier of the original component.
    /// </remarks>
    /// <seealso cref="BuildingModelShellsUpdater"/>
    public class BuildingModelFloorUpdater : BuildingModelUpdater
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModelFloorUpdater"/> class.
        /// </summary>
        /// <param name="value">The <see cref="BuildingModel"/> instance to be updated in place.</param>
        public BuildingModelFloorUpdater(BuildingModel? value)
            : base(value)
        {
        }

        /// <summary>
        /// Gets or sets the number of storeys the building model is partitioned into.
        /// <para>Values lower than two leave the model untouched, a model of two storeys is cut by one plane placed in the middle of its height.</para>
        /// </summary>
        public int FloorCount { get; set; } = -1;

        /// <summary>
        /// Gets or sets the construction assigned to the floors created on the cutting planes.
        /// <para>When null an air component is created on every cutting plane instead of a floor.</para>
        /// </summary>
        public IFloorConstruction? FloorConstruction { get; set; } = null;

        /// <summary>
        /// Gets or sets the minimal height of the part of a space above a cutting plane.
        /// <para>Spaces whose part above a plane is lower than this value are not cut by that plane and stay combined with the space below it. The default value places no practical limit, so that the storeys follow <see cref="FloorCount"/>.</para>
        /// </summary>
        public double MinHeight { get; set; } = Core.Constants.Tolerance.Distance;

        /// <summary>
        /// Gets or sets the distance tolerance used for geometric operations during the update.
        /// <para>It is passed on to every split of the model and is the lower limit of the storey height below which the model is not cut at all.</para>
        /// </summary>
        public double Tolerance { get; set; } = Core.Constants.Tolerance.Distance;

        /// <summary>
        /// Cuts the spaces of the building model into <see cref="FloorCount"/> storeys and writes the result back into the model.
        /// </summary>
        /// <returns><see langword="true"/> if at least one space was cut; otherwise, <see langword="false"/>.</returns>
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

            double height = maxElevation - minElevation;
            if (double.IsNaN(height) || height <= Tolerance)
            {
                return false;
            }

            double floorHeight = System.Math.Round(height / FloorCount, 1);
            if (double.IsNaN(floorHeight) || floorHeight <= Tolerance)
            {
                return false;
            }

            bool result = false;

            // Cutting planes are placed between the storeys, a plane on the bottom of the model would not cut anything
            double currentElevation = minElevation + floorHeight;
            while (currentElevation < maxElevation - Tolerance)
            {
                if (Modify.TrySplit(Value, currentElevation, MinHeight, FloorConstruction, null, Tolerance))
                {
                    result = true;
                }

                currentElevation += floorHeight;
            }

            return result;
        }
    }
}
