using DiGi.Analytical.Building.Interfaces;
using DiGi.Core;
using System.Text.Json.Nodes;
using System.ComponentModel;
using System.Text.Json.Serialization;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class BuildingGeometryObject : BuildingObject, IBuildingGeometryObject
    {
        public BuildingGeometryObject(BuildingGeometryObject buildingGeometryObject)
            : base(buildingGeometryObject)
        {

        }

        public BuildingGeometryObject(System.Guid guid, BuildingGeometryObject buildingGeometryObject)
            : base(guid, buildingGeometryObject)
        {

        }

        public BuildingGeometryObject()
            : base()
        {

        }

        public BuildingGeometryObject(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public BuildingGeometryObject(System.Guid guid)
            : base(guid)
        {

        }
    }

    public abstract class BuildingGeometryObject<T> : BuildingGeometryObject, IBuildingGeometryObject<T> where T : IGeometry3D
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

        public BuildingGeometryObject(T geometry)
            : base()
        {

            if(geometry != null)
            {
                this.geometry = geometry.Clone<T>();
            }
        }

        public BuildingGeometryObject(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public BuildingGeometryObject(BuildingGeometryObject<T> buildingGeometryObject)
            : base(buildingGeometryObject)
        {
            if(buildingGeometryObject != null)
            {
                if(buildingGeometryObject.geometry != null)
                {
                    geometry = buildingGeometryObject.geometry.Clone<T>();
                }
            }
        }

        public BuildingGeometryObject(System.Guid guid, BuildingGeometryObject<T> buildingGeometryObject)
            : base(guid, buildingGeometryObject)
        {
            if (buildingGeometryObject != null)
            {
                if (buildingGeometryObject.geometry != null)
                {
                    geometry = buildingGeometryObject.geometry.Clone<T>();
                }
            }
        }
    }
}
