using DiGi.Analytical.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    public class AnalyticalCluster : UniqueObjectCluster<IUniqueAnalytical>, IAnalytical
    {
        public AnalyticalCluster()
            :base()
        {
        }

        public AnalyticalCluster(JsonObject jsonObject) 
            : base(jsonObject)
        {
        }

        public AnalyticalCluster(AnalyticalCluster analyticalCluster)
            : base(analyticalCluster)
        {
        }

        public AnalyticalCluster(IEnumerable<IUniqueAnalytical> analyticals) 
            : base(analyticals)
        {
        }
    }

}
