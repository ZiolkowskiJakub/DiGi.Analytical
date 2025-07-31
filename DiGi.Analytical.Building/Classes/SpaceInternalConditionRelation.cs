using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class SpaceInternalConditionRelation : OneToOneBidirectionalRelation<ISpace, IInternalCondition>, IBuildingRelation
    {
        [JsonInclude, JsonPropertyName("Range")]
        private Range<int> range;

        [JsonInclude, JsonPropertyName("Id")]
        private string id;

        public SpaceInternalConditionRelation(ISpace space, IInternalCondition internalCondition, Range<int> range, string id)
            : base(space, internalCondition)
        {
            this.range = Core.Query.Clone(range);
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
                range = Core.Query.Clone(spaceInternalConditionRelation.range);
                id = spaceInternalConditionRelation.id;
            }
        }

        [JsonIgnore]
        public Range<int> Range
        {
            get
            {
                return Core.Query.Clone(range);
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
