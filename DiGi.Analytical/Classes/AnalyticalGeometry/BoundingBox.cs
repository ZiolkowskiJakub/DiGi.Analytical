using DiGi.Analytical.Interfaces;
using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Represents a three-dimensional bounding box used in analytical geometry, extending basic spatial boundaries with unique identification properties.
    /// </summary>
    public class BoundingBox : Geometry.Spatial.Classes.BoundingBox3D, IAnalyticalGeometry
    {
        [JsonInclude, JsonPropertyName("Guid")]
        private readonly Guid guid = Guid.NewGuid();

        [JsonInclude, JsonPropertyName("UniqueReference")]
        private readonly IUniqueReference? uniqueReference;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DiGi.Analytical.Classes.BoundingBox" /> class using the specified <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D" />.
        /// </summary>
        /// <param name="boundingBox3D">The optional <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D" /> used to initialize the bounding box.</param>
        public BoundingBox(Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D)
            : base(boundingBox3D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the bounding box. This value can be null.</param>
        public BoundingBox(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox"/> class by copying the values from an existing <see cref="BoundingBox"/> instance.
        /// </summary>
        /// <param name="boundingBox">The source <see cref="BoundingBox"/> instance to copy data from. This value can be null.</param>
        public BoundingBox(BoundingBox? boundingBox)
            : base(boundingBox)
        {
            if (boundingBox != null)
            {
                guid = boundingBox.Guid;
                uniqueReference = Core.Query.Clone(boundingBox.uniqueReference);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox"/> class with a specified unique identifier and an optional existing bounding box.
        /// </summary>
        /// <param name="guid">The unique global identifier to assign to this object.</param>
        /// <param name="boundingBox">An optional <see cref="BoundingBox"/> instance used to initialize base spatial properties and clone the unique reference.</param>
        public BoundingBox(Guid guid, BoundingBox? boundingBox)
            : base(boundingBox)
        {
            this.guid = guid;

            if (boundingBox != null)
            {
                uniqueReference = Core.Query.Clone(boundingBox.uniqueReference);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DiGi.Analytical.Classes.BoundingBox"/> class using the specified unique reference and 3D bounding box.
        /// </summary>
        /// <param name="uniqueReference">The <see cref="T:DiGi.Core.Interfaces.IUniqueReference"/> that uniquely identifies this bounding box.</param>
        /// <param name="boundingBox3D">The <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D"/> used to initialize the spatial boundaries of the bounding box.</param>
        public BoundingBox(IUniqueReference? uniqueReference, Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D)
            : base(boundingBox3D)
        {
            this.uniqueReference = Core.Query.Clone(uniqueReference);
        }

        /// <summary>
        /// Gets the unique global identifier of the bounding box.
        /// </summary>
        [JsonIgnore]
        public Guid Guid
        {
            get
            {
                return guid;
            }
        }

        /// <summary>
        /// Gets the unique identifier of the bounding box.
        /// </summary>
        [JsonIgnore]
        public string? UniqueId
        {
            get
            {
                return Core.Query.UniqueId(Guid);
            }
        }

        /// <summary>
        /// Gets the unique reference for the bounding box.
        /// </summary>
        [JsonIgnore]
        public IUniqueReference? UniqueReference
        {
            get
            {
                return Core.Query.Clone(uniqueReference);
            }
        }

        /// <summary>
        /// Creates a duplicate of the current bounding box, optionally with a new GUID.
        /// </summary>
        /// <param name="guid">The optional GUID to assign to the duplicated object.</param>
        /// <returns>A duplicate of the current object as an <see cref="T:DiGi.Core.Interfaces.IGuidObject" />, or null if duplication fails.</returns>
        public IGuidObject? Duplicate(Guid? guid = null)
        {
            if (guid is null)
            {
                return new BoundingBox(this);
            }

            return new BoundingBox(guid.Value, this);
        }
    }
}