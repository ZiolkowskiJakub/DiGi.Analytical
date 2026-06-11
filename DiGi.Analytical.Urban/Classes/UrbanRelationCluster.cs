using DiGi.Analytical.Interfaces;
using DiGi.Analytical.Urban.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Urban.Classes
{
    /// <summary>
    /// Represents a cluster of urban relations associated with analytical GUID objects, implementing the urban object interface.
    /// </summary>
    public class UrbanRelationCluster : UniqueObjectRelationCluster<IAnalyticalGuidObject, IUrbanRelation>, IUrbanObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrbanRelationCluster"/> class.
        /// </summary>
        public UrbanRelationCluster()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrbanRelationCluster"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the instance. This value can be null.</param>
        public UrbanRelationCluster(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrbanRelationCluster"/> class using an existing <see cref="UrbanRelationCluster"/> instance.
        /// </summary>
        /// <param name="urbanRelationCluster">The source <see cref="UrbanRelationCluster"/> instance to copy from.</param>
        public UrbanRelationCluster(UrbanRelationCluster? urbanRelationCluster)
            : base(urbanRelationCluster)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrbanRelationCluster"/> class using the specified collection of analytical GUID objects.
        /// </summary>
        /// <param name="analyticalGuidObjects">The collection of <see cref="IAnalyticalGuidObject"/> instances to initialize the cluster with.</param>
        public UrbanRelationCluster(IEnumerable<IAnalyticalGuidObject>? analyticalGuidObjects)
            : base(analyticalGuidObjects)
        {
        }
    }
}