using DiGi.Analytical.Interfaces;
using DiGi.Core;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Represents a storage file specifically designed for managing and persisting <see cref="IMaterial"/> instances.
    /// </summary>
    public class MaterialsFile : Core.IO.File.Classes.StorageFile<IMaterial>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialsFile"/> class using the specified file path.
        /// </summary>
        /// <param name="path">The file system path to the materials file. This value can be null.</param>
        public MaterialsFile(string? path)
            : base(path)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialsFile"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the materials file.</param>
        public MaterialsFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialsFile"/> class using an existing <see cref="MaterialsFile"/> instance.
        /// </summary>
        /// <param name="materialsFile">The source <see cref="MaterialsFile"/> instance to copy from.</param>
        public MaterialsFile(MaterialsFile? materialsFile)
            : base(materialsFile)
        {
        }

        /// <summary>
        /// Retrieves the unique reference for the specified material.
        /// </summary>
        /// <param name="material">The material to retrieve the reference for.</param>
        /// <returns>The unique reference associated with the specified material, or null.</returns>
        public override UniqueReference? GetUniqueReference(IMaterial? material)
        {
            return material?.UniqueReference();
        }
    }
}