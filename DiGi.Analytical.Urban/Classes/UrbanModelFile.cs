using DiGi.Analytical.Urban.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Urban.Classes
{
    /// <summary>
    /// Represents a file that stores and manages an <see cref="UrbanModel"/>.
    /// </summary>
    public class UrbanModelFile : Core.IO.File.Classes.ValueFile<UrbanModel>, IUrbanObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrbanModelFile"/> class using the specified <see cref="UrbanModelFile"/>.
        /// </summary>
        /// <param name="urbanModelFile">The <see cref="UrbanModelFile"/> instance to copy from.</param>
        public UrbanModelFile(UrbanModelFile? urbanModelFile)
            : base(urbanModelFile)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrbanModelFile"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the urban model file.</param>
        public UrbanModelFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrbanModelFile"/> class using the specified file path.
        /// </summary>
        /// <param name="path">The path to the urban model file.</param>
        public UrbanModelFile(string? path)
            : base(path)
        {
        }
    }
}