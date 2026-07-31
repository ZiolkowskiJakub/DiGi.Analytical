using DiGi.Analytical.Building.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Provides an abstract base implementation for the construction of a specific constructable component.
    /// </summary>
    /// <typeparam name="TConstructable">The type of the constructable object, which must implement the <see cref="IConstructable"/> interface.</typeparam>
    public abstract class ComponentConstruction<TConstructable> : PhysicalComponentConstruction, IPhysicalComponentConstruction<TConstructable> where TConstructable : IConstructable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentConstruction{TConstructable}"/> class.
        /// </summary>
        public ComponentConstruction()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentConstruction{TConstructable}"/> class using the specified component construction.
        /// </summary>
        /// <param name="componentConstruction">The existing component construction instance from which to copy properties.</param>
        public ComponentConstruction(ComponentConstruction<TConstructable>? componentConstruction)
            : base(componentConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentConstruction{TConstructable}"/> class using the specified unique identifier and an optional source construction object.
        /// </summary>
        /// <param name="guid">The unique global identifier for this component construction.</param>
        /// <param name="componentConstruction">An optional existing <see cref="ComponentConstruction{TConstructable}"/> instance to initialize from.</param>
        public ComponentConstruction(System.Guid guid, ComponentConstruction<TConstructable>? componentConstruction)
            : base(guid, componentConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentConstruction{TConstructable}"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the construction instance.</param>
        public ComponentConstruction(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}