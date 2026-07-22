using DiGi.Analytical.Interfaces;
using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Represents a polygonal face within the analytical geometry system, providing spatial properties and unique identification.
    /// </summary>
    public class Face : Geometry.Spatial.Classes.PolygonalFace3D, IAnalyticalGeometry
    {
        [JsonInclude, JsonPropertyName("Guid")]
        private readonly Guid guid = Guid.NewGuid();

        [JsonInclude, JsonPropertyName("UniqueReference")]
        private readonly IUniqueReference? uniqueReference;

        /// <summary>
        /// Initializes a new instance of the <see cref="Face" /> class using the specified <see cref="Geometry.Spatial.Classes.PolygonalFace3D" /> instance.
        /// </summary>
        /// <param name="polygonalFace3D">The <see cref="Geometry.Spatial.Classes.PolygonalFace3D" /> instance to copy from. This value can be null.</param>
        public Face(Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D)
            : base(polygonalFace3D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Face"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the face. This value can be null.</param>
        public Face(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Face"/> class by copying the properties from an existing <see cref="Face"/> instance.
        /// </summary>
        /// <param name="face">The source <see cref="Face"/> instance to copy from. If null, a default instance is initialized.</param>
        public Face(Face? face)
            : base(face)
        {
            if (face != null)
            {
                guid = face.Guid;
                uniqueReference = Core.Query.Clone(face.uniqueReference);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Face"/> class with a specified unique identifier and an optional existing face to clone references from.
        /// </summary>
        /// <param name="guid">The unique global identifier for the new face.</param>
        /// <param name="face">An optional existing <see cref="Face"/> instance used as a source for cloning properties.</param>
        public Face(Guid guid, Face? face)
            : base(face)
        {
            this.guid = guid;

            if (face != null)
            {
                uniqueReference = Core.Query.Clone(face.uniqueReference);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DiGi.Analytical.Classes.Face" /> class using the specified unique reference and polygonal face data.
        /// </summary>
        /// <param name="uniqueReference">The <see cref="T:DiGi.Core.Interfaces.IUniqueReference" /> used to uniquely identify the face. This value can be null.</param>
        /// <param name="polygonalFace3D">The <see cref="T:DiGi.Geometry.Spatial.Classes.PolygonalFace3D" /> instance providing the geometric data for the face. This value can be null.</param>
        public Face(IUniqueReference? uniqueReference, Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D)
            : base(polygonalFace3D)
        {
            this.uniqueReference = Core.Query.Clone(uniqueReference);
        }

        /// <summary>
        /// Gets the unique identifier for the face.
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
        /// Gets the unique identifier of the face.
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
        /// Gets the unique reference associated with this face.
        /// </summary>
        /// <remarks>
        /// A fresh clone is returned on every call, so read this property into a local instead of calling it repeatedly, and compare it with <see cref="Core.Query.Equals(IReference?, IReference?)"/> - == is reference equality between two <see cref="IUniqueReference"/> typed operands and is false even when both sides come from the same face.
        /// </remarks>
        [JsonIgnore]
        public IUniqueReference? UniqueReference
        {
            get
            {
                return Core.Query.Clone(uniqueReference);
            }
        }

        /// <summary>
        /// Creates a clone of the current instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> that is a copy of the current instance, or null.</returns>
        public override ISerializableObject? Clone()
        {
            return new Face(this);
        }

        /// <summary>
        /// Creates a duplicate of the current face, optionally with a specified GUID.
        /// </summary>
        /// <param name="guid">The optional GUID to assign to the duplicated object.</param>
        /// <returns>A duplicate of the current object as an <see cref="T:DiGi.Core.Interfaces.IGuidObject" />, or null if duplication fails.</returns>
        public IGuidObject? Duplicate(Guid? guid = null)
        {
            if (guid is null)
            {
                return new Face(this);
            }

            return new Face(guid.Value, this);
        }
    }
}