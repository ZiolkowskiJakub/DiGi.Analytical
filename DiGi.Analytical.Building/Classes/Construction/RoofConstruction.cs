using DiGi.Analytical.Building.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents the construction details of a roof component within the analytical building model.
    /// </summary>
    public class RoofConstruction : ComponentConstruction<IRoof>, IRoofConstruction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoofConstruction"/> class.
        /// </summary>
        public RoofConstruction()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoofConstruction"/> class using the specified existing construction.
        /// </summary>
        /// <param name="roofConstruction">The source <see cref="RoofConstruction"/> instance to copy from.</param>
        public RoofConstruction(RoofConstruction? roofConstruction)
            : base(roofConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoofConstruction"/> class using a specified unique identifier and an optional source construction.
        /// </summary>
        /// <param name="guid">The unique global identifier for the roof construction.</param>
        /// <param name="roofConstruction">An optional existing <see cref="RoofConstruction"/> instance to initialize from.</param>
        public RoofConstruction(System.Guid guid, RoofConstruction? roofConstruction)
            : base(guid, roofConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoofConstruction"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data used to initialize the roof construction instance.</param>
        public RoofConstruction(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}