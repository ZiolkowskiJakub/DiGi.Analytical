using DiGi.Analytical.Interfaces;
using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Represents a geometric shell consisting of a collection of faces, providing functionality for spatial analysis and analytical geometry operations.
    /// </summary>
    public class Shell : Geometry.Spatial.Classes.Polyhedron<Face>, IAnalyticalGeometry
    {
        [JsonInclude, JsonPropertyName("Guid")]
        private readonly Guid guid = Guid.NewGuid();

        [JsonInclude, JsonPropertyName("UniqueReference")]
        private readonly IUniqueReference? uniqueReference;

        /// <summary>
        /// Initializes a new instance of the <see cref="Shell"/> class by copying an existing shell instance.
        /// </summary>
        /// <param name="shell">The source <see cref="Shell"/> instance to copy from.</param>
        public Shell(Shell shell)
            : base(shell)
        {
            if (shell is not null)
            {
                guid = shell.guid;
                uniqueReference = Core.Query.Clone(shell.UniqueReference);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shell"/> class using the provided <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the shell; can be null.</param>
        public Shell(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shell"/> class using the specified unique reference and collection of faces.
        /// </summary>
        /// <param name="uniqueReference">The unique reference to assign to this shell.</param>
        /// <param name="faces">The collection of <see cref="Face"/> objects that compose the shell.</param>
        public Shell(IUniqueReference? uniqueReference, IEnumerable<Face> faces)
            : base(faces)
        {
            this.uniqueReference = Core.Query.Clone(uniqueReference);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shell"/> class with a specified unique identifier and an optional source shell to clone properties from.
        /// </summary>
        /// <param name="guid">The unique identifier for the shell.</param>
        /// <param name="shell">An optional existing shell object used to initialize the reference data.</param>
        public Shell(Guid guid, Shell? shell)
            : base(shell)
        {
            this.guid = guid;

            if (shell != null)
            {
                uniqueReference = Core.Query.Clone(shell.uniqueReference);
            }
        }

        /// <summary>
        /// Gets the unique global identifier of the shell.
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
        /// Gets the unique identifier of the shell.
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
        /// Gets the unique reference associated with this shell.
        /// </summary>
        /// <remarks>
        /// A fresh clone is returned on every call, so read this property into a local instead of calling it repeatedly, and compare it with <see cref="Core.Query.Equals(IReference?, IReference?)"/> - == is reference equality between two <see cref="IUniqueReference"/> typed operands and is false even when both sides come from the same shell.
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
            return new Shell(this);
        }

        /// <summary>
        /// Creates a duplicate of the current object, optionally with a new GUID.
        /// </summary>
        /// <param name="guid">The optional GUID to assign to the duplicated object.</param>
        /// <returns>A duplicate of the current object as an <see cref="T:DiGi.Core.Interfaces.IGuidObject" />, or null if duplication fails.</returns>
        public IGuidObject? Duplicate(Guid? guid = null)
        {
            if (guid is null)
            {
                return new Shell(this);
            }

            return new Shell(guid.Value, this);
        }
    }
}