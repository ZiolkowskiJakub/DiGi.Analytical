using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    public class CoolingEmitter : Emitter
    {
        public CoolingEmitter()
            : base()
        {

        }

        public CoolingEmitter(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public CoolingEmitter(HeatingEmitter heatingEmitter)
            : base(heatingEmitter)
        {

        }
    }
}
