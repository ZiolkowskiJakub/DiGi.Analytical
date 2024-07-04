using DiGi.Analytical.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    public abstract class AnalyticalGeometryData : UniqueParametrizedObject, IAnalyticalGeometryData
    {
        public AnalyticalGeometryData()
            :base()
        {

        }

        public AnalyticalGeometryData(System.Guid guid)
            : base(guid)
        {

        }

        public AnalyticalGeometryData(AnalyticalGeometryData analyticalGeometryData)
            : base(analyticalGeometryData)
        {

        }

        public AnalyticalGeometryData(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
