using DiGi.Analytical.Building.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core;
using DiGi.Geometry.Spatial.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents an abstract base class for all analytical building components, providing core functionality and implementing the <see cref="IComponent"/> interface.
    /// </summary>
    public abstract class AbstractComponent : Component, Interfaces.IComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractComponent"/> class using an existing <see cref="AbstractComponent"/> instance.
        /// </summary>
        /// <param name="abstractComponent">The source component to copy data from.</param>
        public AbstractComponent(AbstractComponent? abstractComponent)
            : base(abstractComponent)
        {
            if (abstractComponent is not null)
            {
                StructurePosition = abstractComponent.StructurePosition;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractComponent"/> class using a specified unique identifier and an optional existing component.
        /// </summary>
        /// <param name="guid">The unique global identifier for the component.</param>
        /// <param name="abstractComponent">An optional <see cref="AbstractComponent"/> to initialize from.</param>
        public AbstractComponent(System.Guid guid, AbstractComponent? abstractComponent)
            : base(guid, abstractComponent)
        {
            if (abstractComponent is not null)
            {
                StructurePosition = abstractComponent.StructurePosition;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractComponent"/> class.
        /// </summary>
        public AbstractComponent()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractComponent"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the component.</param>
        public AbstractComponent(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractComponent"/> class using the specified unique identifier.
        /// </summary>
        /// <param name="guid">The unique identifier for the component.</param>
        public AbstractComponent(System.Guid guid)
            : base(guid)
        {
        }

        /// <summary>
        /// Gets or sets the structure position of the component.
        /// </summary>
        [JsonInclude, JsonPropertyName("StructurePosition"), Description("Structure Position")]
        public StructurePosition StructurePosition { get; set; }
    }

    /// <summary>
    /// Provides a base implementation for components that incorporate 3D geometry.
    /// </summary>
    /// <typeparam name="T">The type of the 3D geometry, which must implement <see cref="IGeometry3D"/>.</typeparam>
    public abstract class AbstractComponent<T> : AbstractComponent, IAbstractComponent<T> where T : IGeometry3D
    {
        [JsonInclude, JsonPropertyName("Geometry"), Description("Geometry")]
        private readonly T? geometry;

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractComponent{T}"/> class with the specified geometry.
        /// </summary>
        /// <param name="geometry">The geometry object to associate with this component. This value can be null.</param>
        public AbstractComponent(T? geometry)
            : base()
        {
            if (geometry != null)
            {
                this.geometry = geometry.Clone<T>();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractComponent{T}"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the component.</param>
        public AbstractComponent(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractComponent{T}"/> class using an existing component as a source for cloning.
        /// </summary>
        /// <param name="abstractComponent">The source <see cref="AbstractComponent{T}"/> instance to copy data from. This value can be null.</param>
        public AbstractComponent(AbstractComponent<T>? abstractComponent)
            : base(abstractComponent)
        {
            if (abstractComponent != null)
            {
                if (abstractComponent.geometry != null)
                {
                    geometry = abstractComponent.geometry.Clone<T>();
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractComponent{T}"/> class using an existing abstract component and a specific geometry.
        /// </summary>
        /// <param name="abstractComponent">The source abstract component from which to copy base properties.</param>
        /// <param name="geometry">The geometry object to be assigned to this component.</param>
        public AbstractComponent(AbstractComponent? abstractComponent, T? geometry)
            : base(abstractComponent)
        {
            this.geometry = geometry.Clone<T>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractComponent{T}"/> class using the specified unique identifier and an optional source component.
        /// </summary>
        /// <param name="guid">The globally unique identifier for the component.</param>
        /// <param name="abstractComponent">An optional source <see cref="AbstractComponent{T}"/> instance to copy properties from.</param>
        public AbstractComponent(System.Guid guid, AbstractComponent<T>? abstractComponent)
            : base(guid, abstractComponent)
        {
            if (abstractComponent != null)
            {
                if (abstractComponent.geometry != null)
                {
                    geometry = abstractComponent.geometry.Clone<T>();
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractComponent{T}"/> class with the specified unique identifier and geometry.
        /// </summary>
        /// <param name="guid">The unique identifier for the component.</param>
        /// <param name="geometry">The geometry associated with the component.</param>
        public AbstractComponent(System.Guid guid, T? geometry)
            : base(guid)
        {
            if (geometry is not null)
            {
                this.geometry = geometry.Clone<T>();
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