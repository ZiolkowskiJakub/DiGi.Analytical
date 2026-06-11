using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    /// <summary>
    /// Represents a heating emitter component within the HVAC system used for thermal analysis.
    /// </summary>
    public class HeatingEmitter : Emitter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeatingEmitter"/> class.
        /// </summary>
        public HeatingEmitter()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeatingEmitter"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to populate the properties of the heating emitter; can be null.</param>
        public HeatingEmitter(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeatingEmitter"/> class using an existing <see cref="HeatingEmitter"/> instance.
        /// </summary>
        /// <param name="heatingEmitter">The source <see cref="HeatingEmitter"/> instance to copy from.</param>
        public HeatingEmitter(HeatingEmitter? heatingEmitter)
            : base(heatingEmitter)
        {
        }
    }
}