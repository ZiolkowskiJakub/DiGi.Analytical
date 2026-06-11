using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a bidirectional one-to-many relationship between a building component and its associated spaces.
    /// </summary>
    public class SpaceRelation : OneToManyBidirectionalRelation<IComponent, ISpace>, IBuildingRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceRelation"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the relation; may be <see langword="null"/>.</param>
        public SpaceRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceRelation"/> class.
        /// </summary>
        /// <param name="component">The <see cref="IComponent"/> that is part of this relation.</param>
        /// <param name="space">The <see cref="ISpace"/> that is part of this relation.</param>
        public SpaceRelation(IComponent? component, ISpace? space)
            : base(component, Core.Query.CloneAndFilterNulls([space]))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceRelation"/> class with a specified component and two spaces.
        /// </summary>
        /// <param name="component">The component associated with the relation.</param>
        /// <param name="space_1">The first space associated with the relation.</param>
        /// <param name="space_2">The second space associated with the relation.</param>
        public SpaceRelation(IComponent? component, ISpace? space_1, ISpace? space_2)
            : base(component, Core.Query.CloneAndFilterNulls([space_1, space_2]))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceRelation"/> class by copying an existing relation.
        /// </summary>
        /// <param name="spaceRelation">The source <see cref="SpaceRelation"/> instance to copy from.</param>
        public SpaceRelation(SpaceRelation? spaceRelation)
            : base(spaceRelation)
        {
        }
    }
}