using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Classes
{
    internal class BuildingModelFloorUpdater : BuildingModelUpdater
    {
        public BuildingModelFloorUpdaterOptions? BuildingModelFloorUpdaterOptions { get; set; }

        public BuildingModelFloorUpdater(BuildingModel? value)
            : base(value)
        {

        }

        public override bool Update()
        {
            if(BuildingModelFloorUpdaterOptions is null || Value is null)
            {
                return false;
            }

            if(Value.GetBoundingBox() is not BoundingBox3D boundingBox3D)
            {
                return false;
            }

            double buildingHeight = boundingBox3D.Height;

            double floorHeight = System.Math.Round(buildingHeight / BuildingModelFloorUpdaterOptions.FloorCount, 1);

            List<IComponent>? components = Value.GetComponents<IComponent>();
            if(components is null || components.Count == 0)
            {
                return false;
            }

            return true;
        }
    }
}
