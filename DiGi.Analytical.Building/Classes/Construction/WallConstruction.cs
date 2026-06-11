using DiGi.Analytical.Building.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents the construction properties and specifications for a wall component within the analytical building model.
    /// </summary>
    public class WallConstruction : ComponentConstruction<IWall>, IWallConstruction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WallConstruction"/> class.
        /// </summary>
        public WallConstruction()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WallConstruction"/> class using an existing <see cref="WallConstruction"/> instance.
        /// </summary>
        /// <param name="wallConstruction">The source <see cref="WallConstruction"/> instance to copy from. This value can be null.</param>
        public WallConstruction(WallConstruction? wallConstruction)
            : base(wallConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WallConstruction"/> class using a specified unique identifier and an optional source construction.
        /// </summary>
        /// <param name="guid">The unique identifier for the wall construction.</param>
        /// <param name="wallConstruction">An optional existing <see cref="WallConstruction"/> instance to use as a template or source for initialization.</param>
        public WallConstruction(System.Guid guid, WallConstruction? wallConstruction)
            : base(guid, wallConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WallConstruction"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the wall construction. This value can be null.</param>
        public WallConstruction(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}