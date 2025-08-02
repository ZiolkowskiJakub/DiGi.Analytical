using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class SpaceInternalConditionRelation : OneToOneBidirectionalRelation<ISpace, IInternalCondition>, IBuildingRelation
    {
        [JsonInclude, JsonPropertyName("HourRange")]
        private HourRange hourRange;

        [JsonInclude, JsonPropertyName("Id")]
        private string id;

        public SpaceInternalConditionRelation(ISpace space, IInternalCondition internalCondition, HourRange hourRange, string id)
            : base(space, internalCondition)
        {
            this.hourRange = Core.Query.Clone(hourRange);
            this.id = id;
        }

        public SpaceInternalConditionRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public SpaceInternalConditionRelation(SpaceInternalConditionRelation spaceInternalConditionRelation)
            :base(spaceInternalConditionRelation)
        {
            if(spaceInternalConditionRelation != null)
            {
                hourRange = Core.Query.Clone(spaceInternalConditionRelation.hourRange);
                id = spaceInternalConditionRelation.id;
            }
        }

        [JsonIgnore]
        public HourRange HourRange
        {
            get
            {
                return Core.Query.Clone(hourRange);
            }
        }

        [JsonIgnore]
        public string Id
        {
            get
            {
                return id;
            }
        }
    }
}
