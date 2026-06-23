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
    /// Represents an abstract base class for all physical components within the analytical building model, providing core functionality for structural positioning and identity.
    /// </summary>
    public abstract class PhysicalComponent : Component, IPhysicalComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponent"/> class using an existing physical component.
        /// </summary>
        /// <param name="physicalComponent">The source <see cref="PhysicalComponent"/> to copy properties from.</param>
        public PhysicalComponent(PhysicalComponent? physicalComponent)
            : base(physicalComponent)
        {
            if (physicalComponent is not null)
            {
                physicalComponent.StructurePosition = StructurePosition;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponent"/> class using a specified unique identifier and an optional existing physical component.
        /// </summary>
        /// <param name="guid">The unique global identifier for the physical component.</param>
        /// <param name="physicalComponent">An optional <see cref="PhysicalComponent"/> instance to initialize from.</param>
        public PhysicalComponent(System.Guid guid, PhysicalComponent? physicalComponent)
            : base(guid, physicalComponent)
        {
            if (physicalComponent is not null)
            {
                physicalComponent.StructurePosition = StructurePosition;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponent"/> class.
        /// </summary>
        public PhysicalComponent()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponent"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the component; can be null.</param>
        public PhysicalComponent(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponent"/> class using the specified unique identifier.
        /// </summary>
        /// <param name="guid">The unique global identifier for the physical component.</param>
        public PhysicalComponent(System.Guid guid)
            : base(guid)
        {
        }

        /// <summary>
        /// Gets or sets the position of the physical component within the structure.
        /// </summary>
        [JsonInclude, JsonPropertyName("StructurePosition"), Description("Structure Position")]
        public StructurePosition StructurePosition { get; set; }
    }

    /// <summary>
    /// Represents an abstract base class for components that possess a physical presence and spatial positioning within a structure.
    /// </summary>
    /// <typeparam name="T">The type of 3D geometry.</typeparam>
    public abstract class PhysicalComponent<T> : PhysicalComponent, IPhysicalComponent<T> where T : IGeometry3D
    {
        [JsonInclude, JsonPropertyName("Geometry"), Description("Geometry")]
        private readonly T? geometry;

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponent{T}"/> class with the specified geometry.
        /// </summary>
        /// <param name="geometry">The geometry to assign to the component; this object is cloned if it is not null.</param>
        public PhysicalComponent(T? geometry)
            : base()
        {
            if (geometry != null)
            {
                this.geometry = geometry.Clone<T>();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponent{T}"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the component.</param>
        public PhysicalComponent(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponent{T}"/> class by copying the properties and geometry from an existing physical component.
        /// </summary>
        /// <param name="physicalComponent">The source physical component to copy data from.</param>
        public PhysicalComponent(PhysicalComponent<T>? physicalComponent)
            : base(physicalComponent)
        {
            if (physicalComponent != null)
            {
                if (physicalComponent.geometry != null)
                {
                    geometry = physicalComponent.geometry.Clone<T>();
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponent{T}"/> class using an existing physical component and a specific geometry.
        /// </summary>
        /// <param name="physicalComponent">The source physical component to copy properties from.</param>
        /// <param name="geometry">The geometry to assign to the new component.</param>
        public PhysicalComponent(PhysicalComponent? physicalComponent, T? geometry)
            : base(physicalComponent)
        {
            if (geometry != null)
            {
                this.geometry = geometry.Clone<T>();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponent{T}"/> class with a specified unique identifier and an optional existing physical component to clone geometry from.
        /// </summary>
        /// <param name="guid">The unique identifier for the new physical component.</param>
        /// <param name="physicalComponent">An optional existing physical component used to initialize the current instance's geometry.</param>
        public PhysicalComponent(System.Guid guid, PhysicalComponent<T>? physicalComponent)
            : base(guid, physicalComponent)
        {
            if (physicalComponent != null)
            {
                if (physicalComponent.geometry != null)
                {
                    geometry = physicalComponent.geometry.Clone<T>();
                }
            }
        }

        /// <summary>
        /// Gets the three-dimensional geometry of the physical component.
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