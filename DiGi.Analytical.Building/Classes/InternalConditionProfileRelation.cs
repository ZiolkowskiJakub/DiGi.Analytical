using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class InternalConditionProfileRelation : OneToOneBidirectionalRelation<IInternalCondition, IProfile>, IBuildingRelation
    {
        [JsonInclude, JsonPropertyName("Category")]
        private string category;

        public InternalConditionProfileRelation(IInternalCondition internalCondition, IProfile profile, string category)
            : base(internalCondition, profile)
        {
            this.category = category;
        }

        [JsonIgnore]
        public string Category
        {
            get
            {
                return category;
            }
        }
    }
}
