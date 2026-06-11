using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a one-to-many bidirectional relationship between a construction object and its associated structure layers.
    /// </summary>
    /// <typeparam name="TConstruction">The type of the construction object, which must implement <see cref="IConstruction"/>.</typeparam>
    public abstract class ConstructionStructureLayersRelation<TConstruction> : OneToManyBidirectionalRelation<TConstruction, IStructureLayer>, IBuildingRelation where TConstruction : IConstruction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionStructureLayersRelation{TConstruction}"/> class using the specified construction and structure layer.
        /// </summary>
        /// <param name="construction">The construction associated with this relation.</param>
        /// <param name="structureLayer">The structure layer to be associated with the construction.</param>
        public ConstructionStructureLayersRelation(TConstruction? construction, IStructureLayer? structureLayer)
            : base(construction, Core.Query.CloneAndFilterNulls([structureLayer]))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionStructureLayersRelation{TConstruction}"/> class with the specified construction and collection of structure layers.
        /// </summary>
        /// <param name="construction">The construction associated with this relation.</param>
        /// <param name="structureLayers">The collection of structure layers associated with this relation.</param>
        public ConstructionStructureLayersRelation(TConstruction? construction, IEnumerable<IStructureLayer>? structureLayers)
            : base(construction, structureLayers)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionStructureLayersRelation{TConstruction}"/> class using an existing relation instance.
        /// </summary>
        /// <param name="constructionStructureLayersRelation">The source relation instance from which values are copied.</param>
        public ConstructionStructureLayersRelation(ConstructionStructureLayersRelation<TConstruction>? constructionStructureLayersRelation)
            : base(constructionStructureLayersRelation)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionStructureLayersRelation{TConstruction}"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to reconstruct the relation instance.</param>
        public ConstructionStructureLayersRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}
