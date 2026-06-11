using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents an abstract base class for air components within a building analytical model.
    /// </summary>
    /// <typeparam name="T">The type of 3D geometry associated with the air component, which must implement <see cref="IGeometry3D"/>.</typeparam>
    public abstract class Air<T> : AbstractComponent<T>, IAir<T> where T : IGeometry3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Air{T}"/> class using the specified geometry.
        /// </summary>
        /// <param name="geometry">The geometry to be associated with this air component.</param>
        public Air(T? geometry)
            : base(geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Air{T}"/> class using an existing air component.
        /// </summary>
        /// <param name="air">The source <see cref="Air{T}"/> instance to copy from.</param>
        public Air(Air<T>? air)
            : base(air)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Air{T}"/> class using a specified unique identifier and an existing air object.
        /// </summary>
        /// <param name="guid">The unique identifier for the air component.</param>
        /// <param name="air">An optional existing air object to initialize from.</param>
        public Air(Guid guid, Air<T>? air)
            : base(guid, air)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Air{T}"/> class using an existing air component and a specified geometry.
        /// </summary>
        /// <param name="air">The source air component from which properties are copied.</param>
        /// <param name="geometry">The geometry associated with this air component.</param>
        public Air(IAir? air, T? geometry)
            : base(air as AbstractComponent, geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Air{T}"/> class using the specified unique identifier and geometry.
        /// </summary>
        /// <param name="guid">The unique identifier for the object.</param>
        /// <param name="geometry">The 3D geometry associated with the air component.</param>
        public Air(Guid guid, T? geometry)
            : base(guid, geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Air{T}"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the instance.</param>
        public Air(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}
