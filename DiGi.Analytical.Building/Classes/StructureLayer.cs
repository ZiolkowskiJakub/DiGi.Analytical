using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Represents a structural layer within a building component, defining its sequence index and physical thickness.
    /// </summary>
    public class StructureLayer : GuidObject, IStructureLayer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureLayer"/> class using an existing <see cref="StructureLayer"/> object.
        /// </summary>
        /// <param name="structureLayer">The source <see cref="StructureLayer"/> object to copy from.</param>
        public StructureLayer(StructureLayer? structureLayer)
            : base(structureLayer)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructureLayer"/> class with the specified index and thickness.
        /// </summary>
        /// <param name="index">The index of the structure layer.</param>
        /// <param name="thickness">The thickness of the structure layer.</param>
        public StructureLayer(int index, double thickness)
            : base()
        {
            Index = index;
            Thickness = thickness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructureLayer"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public StructureLayer(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the index of the structure layer.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Gets or sets the thickness of the structure layer.
        /// </summary>
        public double Thickness { get; set; }
    }
}