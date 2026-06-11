using DiGi.Analytical.Building.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents the relationship between an opening construction and its associated structure layers.
    /// </summary>
    public abstract class OpeningConstructionStructureLayersRelation : ConstructionStructureLayersRelation<IOpeningConstruction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningConstructionStructureLayersRelation"/> class using the specified opening construction and structure layer.
        /// </summary>
        /// <param name="openingConstruction">The opening construction associated with this relation.</param>
        /// <param name="structureLayer">The structure layer associated with this relation.</param>
        public OpeningConstructionStructureLayersRelation(IOpeningConstruction? openingConstruction, IStructureLayer? structureLayer)
            : base(openingConstruction, Core.Query.CloneAndFilterNulls([structureLayer]))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningConstructionStructureLayersRelation"/> class using the specified opening construction and a collection of structure layers.
        /// </summary>
        /// <param name="openingConstruction">The opening construction associated with this relation.</param>
        /// <param name="structureLayers">The collection of structure layers associated with this relation.</param>
        public OpeningConstructionStructureLayersRelation(IOpeningConstruction? openingConstruction, IEnumerable<IStructureLayer>? structureLayers)
            : base(openingConstruction, structureLayers)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningConstructionStructureLayersRelation"/> class based on an existing relation.
        /// </summary>
        /// <param name="openingConstructionStructureLayersRelation">The source relation used to initialize the new instance.</param>
        public OpeningConstructionStructureLayersRelation(OpeningConstructionStructureLayersRelation? openingConstructionStructureLayersRelation)
            : base(openingConstructionStructureLayersRelation)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningConstructionStructureLayersRelation"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the instance.</param>
        public OpeningConstructionStructureLayersRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}