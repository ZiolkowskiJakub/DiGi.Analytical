using DiGi.Analytical.Building.Interfaces;
using DiGi.Core;
using System.Text.Json.Nodes;
using System.ComponentModel;
using System.Text.Json.Serialization;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class BuildingGeometry3DObject : BuildingObject, IBuildingGeometry3DObject
    {
        public BuildingGeometry3DObject(BuildingGeometry3DObject buildingGeometry3DObject)
            : base(buildingGeometry3DObject)
        {

        }

        public BuildingGeometry3DObject(System.Guid guid, BuildingGeometry3DObject buildingGeometry3DObject)
            : base(guid, buildingGeometry3DObject)
        {

        }

        public BuildingGeometry3DObject()
            : base()
        {

        }

        public BuildingGeometry3DObject(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public BuildingGeometry3DObject(System.Guid guid)
            : base(guid)
        {

        }
    }

    public abstract class BuildingGeometry3DObject<T> : BuildingGeometry3DObject, IBuildingGeometry3DObject<T> where T : IGeometry3D
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

        public BuildingGeometry3DObject(T geometry)
            : base()
        {

            if(geometry != null)
            {
                this.geometry = geometry.Clone<T>();
            }
        }

        public BuildingGeometry3DObject(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public BuildingGeometry3DObject(BuildingGeometry3DObject<T> buildingGeometry3DObject)
            : base(buildingGeometry3DObject)
        {
            if(buildingGeometry3DObject != null)
            {
                if(buildingGeometry3DObject.geometry != null)
                {
                    geometry = buildingGeometry3DObject.geometry.Clone<T>();
                }
            }
        }

        public BuildingGeometry3DObject(System.Guid guid, BuildingGeometry3DObject<T> buildingGeometry3DObject)
            : base(guid, buildingGeometry3DObject)
        {
            if (buildingGeometry3DObject != null)
            {
                if (buildingGeometry3DObject.geometry != null)
                {
                    geometry = buildingGeometry3DObject.geometry.Clone<T>();
                }
            }
        }
    }
}
