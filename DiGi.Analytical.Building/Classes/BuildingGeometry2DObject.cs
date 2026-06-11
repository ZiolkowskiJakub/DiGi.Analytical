using DiGi.Analytical.Building.Interfaces;
using DiGi.Core;
using DiGi.Geometry.Planar.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents an abstract base class for two-dimensional geometric objects within a building's analytical model.
    /// </summary>
    public abstract class BuildingGeometry2DObject : BuildingObject, IBuildingGeometry2DObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry2DObject"/> class based on an existing <see cref="BuildingGeometry2DObject"/> object.
        /// </summary>
        /// <param name="buildingGeometry2DObject">The <see cref="BuildingGeometry2DObject"/> object to copy from.</param>
        public BuildingGeometry2DObject(BuildingGeometry2DObject? buildingGeometry2DObject)
            : base(buildingGeometry2DObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry2DObject"/> class with a specified unique identifier and an optional source object.
        /// </summary>
        /// <param name="guid">The unique global identifier for the building geometry 2D object.</param>
        /// <param name="buildingGeometry2DObject">An optional existing <see cref="BuildingGeometry2DObject"/> instance used to initialize the current instance.</param>
        public BuildingGeometry2DObject(System.Guid guid, BuildingGeometry2DObject? buildingGeometry2DObject)
            : base(guid, buildingGeometry2DObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry2DObject"/> class.
        /// </summary>
        public BuildingGeometry2DObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry2DObject{T}"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the building geometry 2D object.</param>
        public BuildingGeometry2DObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry2DObject"/> class using the specified unique identifier.
        /// </summary>
        /// <param name="guid">The unique global identifier for the object.</param>
        public BuildingGeometry2DObject(System.Guid guid)
            : base(guid)
        {
        }
    }

    /// <summary>
    /// Represents an abstract base class for objects that possess two-dimensional building geometry.
    /// </summary>
    /// <typeparam name="T">The type of the 2D geometry.</typeparam>
    public abstract class BuildingGeometry2DObject<T> : BuildingGeometry2DObject, IBuildingGeometry2DObject<T> where T : IGeometry2D
    {
        [JsonInclude, JsonPropertyName("Geometry"), Description("Geometry")]
        private readonly T? geometry;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry2DObject{T}"/> class with the specified geometry.
        /// </summary>
        /// <param name="geometry">The geometry to assign to the object; can be null.</param>
        public BuildingGeometry2DObject(T? geometry)
            : base()
        {
            if (geometry != null)
            {
                this.geometry = geometry.Clone<T>();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry2DObject"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the building geometry 2D object.</param>
        public BuildingGeometry2DObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry2DObject{T}"/> class by copying an existing building geometry 2D object.
        /// </summary>
        /// <param name="buildingGeometry2DObject">The source <see cref="BuildingGeometry2DObject{T}"/> object to copy from.</param>
        public BuildingGeometry2DObject(BuildingGeometry2DObject<T>? buildingGeometry2DObject)
            : base(buildingGeometry2DObject)
        {
            if (buildingGeometry2DObject != null)
            {
                if (buildingGeometry2DObject.geometry != null)
                {
                    geometry = buildingGeometry2DObject.geometry.Clone<T>();
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingGeometry2DObject{T}"/> class using the specified unique identifier and an existing building geometry object.
        /// </summary>
        /// <param name="guid">The unique identifier for the object.</param>
        /// <param name="buildingGeometry2DObject">The source building geometry object from which to clone properties and geometry.</param>
        public BuildingGeometry2DObject(System.Guid guid, BuildingGeometry2DObject<T>? buildingGeometry2DObject)
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

        /// <summary>
        /// Gets the two-dimensional geometry of the building object.
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
