using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    /// <summary>
    /// Represents a cooling emitter component within the HVAC system used to remove heat from a space.
    /// </summary>
    public class CoolingEmitter : Emitter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoolingEmitter"/> class.
        /// </summary>
        public CoolingEmitter()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoolingEmitter"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the cooling emitter. This value can be null.</param>
        public CoolingEmitter(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoolingEmitter"/> class using the specified <see cref="HeatingEmitter"/>.
        /// </summary>
        /// <param name="heatingEmitter">The <see cref="HeatingEmitter"/> instance used to initialize this object.</param>
        public CoolingEmitter(HeatingEmitter? heatingEmitter)
            : base(heatingEmitter)
        {
        }
    }
}