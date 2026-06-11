using DiGi.Analytical.Building.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents the construction details and properties of a floor component within the analytical building model.
    /// </summary>
    public class FloorConstruction : ComponentConstruction<IFloor>, IFloorConstruction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FloorConstruction"/> class.
        /// </summary>
        public FloorConstruction()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloorConstruction"/> class using the specified existing construction.
        /// </summary>
        /// <param name="floorConstruction">The source <see cref="FloorConstruction"/> instance to copy from.</param>
        public FloorConstruction(FloorConstruction? floorConstruction)
            : base(floorConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloorConstruction"/> class with a specified unique identifier and an optional existing construction.
        /// </summary>
        /// <param name="guid">The unique global identifier for the floor construction.</param>
        /// <param name="floorConstruction">An optional <see cref="FloorConstruction"/> instance to initialize from.</param>
        public FloorConstruction(System.Guid guid, FloorConstruction? floorConstruction)
            : base(guid, floorConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloorConstruction"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the floor construction properties. This value can be null.</param>
        public FloorConstruction(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}