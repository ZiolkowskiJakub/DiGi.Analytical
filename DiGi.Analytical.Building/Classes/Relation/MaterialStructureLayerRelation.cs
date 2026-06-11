using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a one-to-one bidirectional relation between a material and a structure layer.
    /// </summary>
    public class MaterialStructureLayerRelation : OneToOneBidirectionalRelation<IMaterial, IStructureLayer>, IBuildingRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialStructureLayerRelation"/> class.
        /// </summary>
        /// <param name="material">The material to be associated with the structure layer.</param>
        /// <param name="structureLayer">The structure layer to be associated with the material.</param>
        public MaterialStructureLayerRelation(IMaterial? material, IStructureLayer? structureLayer)
            : base(material, structureLayer)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialStructureLayerRelation"/> class using an existing relation instance.
        /// </summary>
        /// <param name="materialStructureLayerRelation">The source <see cref="MaterialStructureLayerRelation"/> instance to copy from.</param>
        public MaterialStructureLayerRelation(MaterialStructureLayerRelation? materialStructureLayerRelation)
            : base(materialStructureLayerRelation)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialStructureLayerRelation"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the relation.</param>
        public MaterialStructureLayerRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}