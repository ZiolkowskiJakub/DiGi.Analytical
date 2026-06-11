using DiGi.Analytical.Building.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents an abstract base class for all building objects, providing fundamental properties for unique identification and parameterization within the analytical building model.
    /// </summary>
    public abstract class BuildingObject : Core.Parameter.Classes.ParametrizedGuidObject, IBuildingObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingObject"/> class using the specified building object.
        /// </summary>
        /// <param name="buildingObject">The building object to initialize from.</param>
        public BuildingObject(BuildingObject? buildingObject)
            : base(buildingObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingObject"/> class using the specified unique identifier and an optional existing building object.
        /// </summary>
        /// <param name="guid">The unique global identifier to assign to this object.</param>
        /// <param name="buildingObject">An optional <see cref="BuildingObject"/> instance used to initialize the current instance.</param>
        public BuildingObject(System.Guid guid, BuildingObject? buildingObject)
            : base(guid, buildingObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingObject"/> class.
        /// </summary>
        public BuildingObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingObject"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the building object. This value can be null.</param>
        public BuildingObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingObject"/> class with the specified unique identifier.
        /// </summary>
        /// <param name="guid">The unique global identifier for the building object.</param>
        public BuildingObject(System.Guid guid)
            : base(guid)
        {
        }
    }
}