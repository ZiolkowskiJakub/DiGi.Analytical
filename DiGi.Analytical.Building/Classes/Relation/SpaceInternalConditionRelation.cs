using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a one-to-one bidirectional relationship between a space and an internal condition,
    /// providing metadata such as the hour range during which the condition applies.
    /// </summary>
    public class SpaceInternalConditionRelation : OneToOneBidirectionalRelation<ISpace, IInternalCondition>, IBuildingRelation
    {
        [JsonInclude, JsonPropertyName("HourRange")]
        private readonly HourRange? hourRange;

        [JsonInclude, JsonPropertyName("Id")]
        private readonly string? id;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceInternalConditionRelation"/> class.
        /// </summary>
        /// <param name="space">The space associated with this relation.</param>
        /// <param name="internalCondition">The internal condition associated with this relation.</param>
        /// <param name="hourRange">The hour range during which the internal condition applies to the space.</param>
        /// <param name="id">The unique identifier for the relation.</param>
        public SpaceInternalConditionRelation(ISpace? space, IInternalCondition? internalCondition, HourRange? hourRange, string? id)
            : base(space, internalCondition)
        {
            this.hourRange = Core.Query.Clone(hourRange);
            this.id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceInternalConditionRelation"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the relation.</param>
        public SpaceInternalConditionRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceInternalConditionRelation"/> class by copying the properties of an existing relation instance.
        /// </summary>
        /// <param name="spaceInternalConditionRelation">The source <see cref="SpaceInternalConditionRelation"/> instance to copy from, or <see langword="null"/>.</param>
        public SpaceInternalConditionRelation(SpaceInternalConditionRelation? spaceInternalConditionRelation)
            : base(spaceInternalConditionRelation)
        {
            if (spaceInternalConditionRelation != null)
            {
                hourRange = Core.Query.Clone(spaceInternalConditionRelation.hourRange);
                id = spaceInternalConditionRelation.id;
            }
        }

        /// <summary>
        /// Gets the hour range associated with the relation between the space and the internal condition.
        /// </summary>
        [JsonIgnore]
        public HourRange? HourRange
        {
            get
            {
                return Core.Query.Clone(hourRange);
            }
        }

        /// <summary>
        /// Gets the unique identifier of the space internal condition relation.
        /// </summary>
        [JsonIgnore]
        public string? Id
        {
            get
            {
                return id;
            }
        }
    }
}