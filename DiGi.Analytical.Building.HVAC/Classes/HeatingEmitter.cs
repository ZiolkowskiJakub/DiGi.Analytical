using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    public class HeatingEmitter : Emitter
    {
        public HeatingEmitter()
            : base()
        {

        }

        public HeatingEmitter(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public HeatingEmitter(HeatingEmitter heatingEmitter)
            : base(heatingEmitter)
        {

        }
    }
}
