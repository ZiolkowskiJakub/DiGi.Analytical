using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class SpaceInternalCondition : SerializableObject, IBuildingObject
    {
        [JsonInclude, JsonPropertyName("Id"), Description("Id")]
        private string id;

        [JsonInclude, JsonPropertyName("InternalCondition"), Description("InternalCondition")]
        private IInternalCondition internalCondition;

        [JsonInclude, JsonPropertyName("Range"), Description("Range")]
        private Range<int> range;
        
        public SpaceInternalCondition(IInternalCondition internalCondition, Range<int> range, string id = null)
            : base()
        {
            this.internalCondition = Core.Query.Clone(internalCondition);
            this.range = Core.Query.Clone(range);
            this.id = id;
        }

        public SpaceInternalCondition(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public SpaceInternalCondition(SpaceInternalCondition spaceInternalCondition)
            : base(spaceInternalCondition)
        {
            if (spaceInternalCondition != null)
            {
                internalCondition = Core.Query.Clone(spaceInternalCondition.internalCondition);
                range = Core.Query.Clone(spaceInternalCondition.range);
                id = spaceInternalCondition.id;
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

        [JsonIgnore]
        public IInternalCondition InternalCondition
        {
            get
            {
                return Core.Query.Clone(internalCondition);
            }
        }
        
        [JsonIgnore]
        public Range<int> Range
        {
            get
            {
                return range;
            }
        }
    }
}
