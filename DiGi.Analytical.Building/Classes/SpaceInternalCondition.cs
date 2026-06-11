using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents the internal environmental conditions of a space within a building, typically associated with a specific time interval.
    /// </summary>
    public class SpaceInternalCondition : SerializableObject, IBuildingObject
    {
        [JsonInclude, JsonPropertyName("Id"), Description("Id")]
        private readonly string? id;

        [JsonInclude, JsonPropertyName("InternalCondition"), Description("InternalCondition")]
        private readonly IInternalCondition? internalCondition;

        [JsonInclude, JsonPropertyName("HourRange"), Description("HourRange")]
        private readonly HourRange? hourRange;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceInternalCondition"/> class.
        /// </summary>
        /// <param name="internalCondition">The internal condition to be associated with the space.</param>
        /// <param name="hourRange">The hour range during which this internal condition is applicable.</param>
        /// <param name="id">The optional unique identifier for the space internal condition.</param>
        public SpaceInternalCondition(IInternalCondition? internalCondition, HourRange? hourRange, string? id = null)
            : base()
        {
            this.internalCondition = Core.Query.Clone(internalCondition);
            this.hourRange = Core.Query.Clone(hourRange);
            this.id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceInternalCondition"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object from which to initialize the instance. This value can be null.</param>
        public SpaceInternalCondition(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceInternalCondition"/> class by cloning an existing instance.
        /// </summary>
        /// <param name="spaceInternalCondition">The source <see cref="SpaceInternalCondition"/> instance to copy from.</param>
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

        /// <summary>
        /// Gets the unique identifier for the space internal condition.
        /// </summary>
        [JsonIgnore]
        public string? Id
        {
            get
            {
                return id;
            }
        }

        /// <summary>
        /// Gets the internal condition associated with the space.
        /// </summary>
        [JsonIgnore]
        public IInternalCondition? InternalCondition
        {
            get
            {
                return Core.Query.Clone(internalCondition);
            }
        }

        /// <summary>
        /// Gets the hour range associated with the internal condition of the space.
        /// </summary>
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