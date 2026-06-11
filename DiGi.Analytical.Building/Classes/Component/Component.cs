using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents an abstract base class for building components within the analytical 3D geometry model.
    /// </summary>
    public abstract class Component : BuildingGeometry3DObject, Interfaces.IComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Component"/> class based on an existing <see cref="Component"/> instance.
        /// </summary>
        /// <param name="component">The source <see cref="Component"/> used to initialize this instance. This value can be null.</param>
        public Component(Component? component)
            : base(component)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Component"/> class using the specified unique identifier and an optional source component.
        /// </summary>
        /// <param name="guid">The unique global identifier for the component.</param>
        /// <param name="component">An optional existing <see cref="Component"/> instance to initialize from.</param>
        public Component(System.Guid guid, Component? component)
            : base(guid, component)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Component"/> class.
        /// </summary>
        public Component()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Component"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the component. This value can be null.</param>
        public Component(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Component"/> class with the specified unique identifier.
        /// </summary>
        /// <param name="guid">The unique global identifier for the component.</param>
        public Component(System.Guid guid)
            : base(guid)
        {
        }

        /// <summary>
        /// Gets the axis-aligned bounding box of the component.
        /// </summary>
        /// <returns>The <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D" /> encompassing the component, or null if it cannot be determined.</returns>
        public abstract BoundingBox3D? GetBoundingBox();
    }
}