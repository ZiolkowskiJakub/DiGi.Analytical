using DiGi.Analytical.Building.Interfaces;
using DiGi.Core;
using DiGi.Geometry.Spatial.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents an abstract base class for all three-dimensional geometric objects within a building's analytical model.
    /// </summary>
    public abstract class BuildingGeometry3DObject : BuildingObject, IBuildingGeometry3DObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry3DObject"/> class using the specified object.
        /// </summary>
        /// <param name="buildingGeometry3DObject">The <see cref="BuildingGeometry3DObject"/> object to copy from or use for initialization.</param>
        public BuildingGeometry3DObject(BuildingGeometry3DObject? buildingGeometry3DObject)
            : base(buildingGeometry3DObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry3DObject"/> class with a specified unique identifier and an optional existing object.
        /// </summary>
        /// <param name="guid">The unique global identifier for the building geometry 3D object.</param>
        /// <param name="buildingGeometry3DObject">An optional <see cref="BuildingGeometry3DObject"/> instance to initialize from.</param>
        public BuildingGeometry3DObject(System.Guid guid, BuildingGeometry3DObject? buildingGeometry3DObject)
            : base(guid, buildingGeometry3DObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry3DObject"/> class.
        /// </summary>
        public BuildingGeometry3DObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry3DObject"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the building geometry 3D object.</param>
        public BuildingGeometry3DObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry3DObject"/> class with the specified unique identifier.
        /// </summary>
        /// <param name="guid">The unique global identifier for the building geometry 3D object.</param>
        public BuildingGeometry3DObject(System.Guid guid)
            : base(guid)
        {
        }
    }

    /// <summary>
    /// Represents an abstract base class for 3D building geometry objects that encapsulate a specific type of 3D geometry.
    /// </summary>
    /// <typeparam name="T">The type of the 3D geometry, which must implement <see cref="IGeometry3D"/>.</typeparam>
    public abstract class BuildingGeometry3DObject<T> : BuildingGeometry3DObject, IBuildingGeometry3DObject<T> where T : IGeometry3D
    {
        [JsonInclude, JsonPropertyName("Geometry"), Description("Geometry")]
        private readonly T? geometry;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry3DObject{T}"/> class with the specified 3D geometry.
        /// </summary>
        /// <param name="geometry">The 3D geometry to assign to this object. The provided geometry is cloned if it is not null.</param>
        public BuildingGeometry3DObject(T? geometry)
            : base()
        {
            if (geometry != null)
            {
                this.geometry = geometry.Clone<T>();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry3DObject"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="System.Text.Json.Nodes.JsonObject"/> containing the data to initialize the object. This value can be null.</param>
        public BuildingGeometry3DObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry3DObject{T}"/> class using an existing building geometry 3D object.
        /// </summary>
        /// <param name="buildingGeometry3DObject">The source building geometry 3D object to copy from.</param>
        public BuildingGeometry3DObject(BuildingGeometry3DObject<T>? buildingGeometry3DObject)
            : base(buildingGeometry3DObject)
        {
            if (buildingGeometry3DObject != null)
            {
                if (buildingGeometry3DObject.geometry != null)
                {
                    geometry = buildingGeometry3DObject.geometry.Clone<T>();
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry3DObject{T}"/> class with the specified unique identifier and an optional source building geometry 3D object.
        /// </summary>
        /// <param name="guid">The unique identifier for the object.</param>
        /// <param name="buildingGeometry3DObject">An optional existing building geometry 3D object to copy data from.</param>
        public BuildingGeometry3DObject(System.Guid guid, BuildingGeometry3DObject<T>? buildingGeometry3DObject)
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

        /// <summary>
        /// </summary>
        [JsonIgnore]
        public T? Geometry
        {
            get
            {
                if (geometry == null)
                {
                    return default;
                }

                return geometry.Clone<T>();
            }
        }
    }
}
