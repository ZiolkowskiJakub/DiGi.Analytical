using DiGi.Analytical.Building.Interfaces;
using DiGi.Core;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a storage file specifically designed to manage and persist a collection of internal conditions.
    /// </summary>
    public class InternalConditionsFile : Core.IO.File.Classes.StorageFile<IInternalCondition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalConditionsFile"/> class using the specified file path.
        /// </summary>
        /// <param name="path">The path to the internal conditions file.</param>
        public InternalConditionsFile(string? path)
            : base(path)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalConditionsFile"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data for the internal conditions file.</param>
        public InternalConditionsFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalConditionsFile"/> class using an existing <see cref="InternalConditionsFile"/> instance.
        /// </summary>
        /// <param name="internalConditionsFile">The source <see cref="InternalConditionsFile"/> instance to copy from.</param>
        public InternalConditionsFile(InternalConditionsFile? internalConditionsFile)
            : base(internalConditionsFile)
        {
        }

        /// <summary>
        /// Retrieves the unique reference for the specified internal condition.
        /// </summary>
        /// <param name="internalCondition">The internal condition to retrieve the reference for.</param>
        /// <returns>The unique reference associated with the specified internal condition, or null.</returns>
        public override UniqueReference? GetUniqueReference(IInternalCondition? internalCondition)
        {
            return internalCondition?.UniqueReference();
        }
    }
}