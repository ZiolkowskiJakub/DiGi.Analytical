using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class SpaceInternalCondition : SerializableObject, IBuildingObject
    {
        [JsonInclude, JsonPropertyName("Id"), Description("Id")]
        private readonly string? id;

        [JsonInclude, JsonPropertyName("InternalCondition"), Description("InternalCondition")]
        private readonly IInternalCondition? internalCondition;

        [JsonInclude, JsonPropertyName("HourRange"), Description("HourRange")]
        private readonly HourRange? hourRange;

        public SpaceInternalCondition(IInternalCondition? internalCondition, HourRange? hourRange, string? id = null)
            : base()
        {
            this.internalCondition = Core.Query.Clone(internalCondition);
            this.hourRange = Core.Query.Clone(hourRange);
            this.id = id;
        }

        public SpaceInternalCondition(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public SpaceInternalCondition(SpaceInternalCondition? spaceInternalCondition)
            : base(spaceInternalCondition)
        {
            if (spaceInternalCondition != null)
            {
                internalCondition = Core.Query.Clone(spaceInternalCondition.internalCondition);
                hourRange = Core.Query.Clone(spaceInternalCondition.hourRange);
                id = spaceInternalCondition.id;
            }
        }

        [JsonIgnore]
        public string? Id
        {
            get
            {
                return id;
            }
        }

        [JsonIgnore]
        public IInternalCondition? InternalCondition
        {
            get
            {
                return Core.Query.Clone(internalCondition);
            }
        }

        [JsonIgnore]
        public HourRange? HourRange
        {
            get
            {
                return hourRange;
            }
        }
    }
}