using DiGi.Analytical.Building.Interfaces;
using DiGi.Core;
using System.Text.Json.Nodes;
using System.ComponentModel;
using System.Text.Json.Serialization;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class BuildingGeometry2DObject : BuildingObject, IBuildingGeometry2DObject
    {
        public BuildingGeometry2DObject(BuildingGeometry2DObject buildingGeometry2DObject)
            : base(buildingGeometry2DObject)
        {

        }

        public BuildingGeometry2DObject(System.Guid guid, BuildingGeometry2DObject buildingGeometry2DObject)
            : base(guid, buildingGeometry2DObject)
        {

        }

        public BuildingGeometry2DObject()
            : base()
        {

        }

        public BuildingGeometry2DObject(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public BuildingGeometry2DObject(System.Guid guid)
            : base(guid)
        {

        }
    }

    public abstract class BuildingGeometry2DObject<T> : BuildingGeometry2DObject, IBuildingGeometry2DObject<T> where T : IGeometry2D
    {
        [JsonInclude, JsonPropertyName("Geometry"), Description("Geometry")]
        private T geometry;

        [JsonIgnore]
        public T Geometry
        {
            get
            {
                if(geometry == null)
                {
                    return default;
                }

                return geometry.Clone<T>();
            }
        }

        public BuildingGeometry2DObject(T geometry)
            : base()
        {

            if(geometry != null)
            {
                this.geometry = geometry.Clone<T>();
            }
        }

        public BuildingGeometry2DObject(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public BuildingGeometry2DObject(BuildingGeometry2DObject<T> buildingGeometry2DObject)
            : base(buildingGeometry2DObject)
        {
            if(buildingGeometry2DObject != null)
            {
                if(buildingGeometry2DObject.geometry != null)
                {
                    geometry = buildingGeometry2DObject.geometry.Clone<T>();
                }
            }
        }

        public BuildingGeometry2DObject(System.Guid guid, BuildingGeometry2DObject<T> buildingGeometry2DObject)
            : base(guid, buildingGeometry2DObject)
        {
            if (buildingGeometry2DObject != null)
            {
                if (buildingGeometry2DObject.geometry != null)
                {
                    geometry = buildingGeometry2DObject.geometry.Clone<T>();
                }
            }
        }
    }
}
