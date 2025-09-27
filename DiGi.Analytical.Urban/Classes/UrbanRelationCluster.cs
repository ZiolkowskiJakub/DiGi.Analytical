using DiGi.Analytical.Interfaces;
using DiGi.Analytical.Urban.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Urban.Classes
{
    public class UrbanRelationCluster : UniqueObjectRelationCluster<IAnalyticalGuidObject, IUrbanRelation>, IUrbanObject
    {
        public UrbanRelationCluster()
            : base()
        {
        }

        public UrbanRelationCluster(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public UrbanRelationCluster(UrbanRelationCluster? urbanRelationCluster)
            : base(urbanRelationCluster)
        {
        }

        public UrbanRelationCluster(IEnumerable<IAnalyticalGuidObject>? analyticalGuidObjects)
            : base(analyticalGuidObjects)
        {
        }
    }
}
