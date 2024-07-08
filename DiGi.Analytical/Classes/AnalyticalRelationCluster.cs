using DiGi.Analytical.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    public class AnalyticalRelationCluster : UniqueObjectRelationCluster<IAnalyticalUniqueObject>, IAnalyticalObject
    {
        public AnalyticalRelationCluster()
            :base()
        {
        }

        public AnalyticalRelationCluster(JsonObject jsonObject) 
            : base(jsonObject)
        {
        }

        public AnalyticalRelationCluster(AnalyticalRelationCluster analyticalCluster)
            : base(analyticalCluster)
        {
        }

        public AnalyticalRelationCluster(IEnumerable<IAnalyticalUniqueObject> analyticals) 
            : base(analyticals)
        {
        }
    }

}
