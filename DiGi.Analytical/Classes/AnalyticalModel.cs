using DiGi.Analytical.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.ComponentModel;
using System.Text.Json.Serialization;
using DiGi.Core;
using DiGi.Core.Interfaces;

namespace DiGi.Analytical.Classes
{
    public class AnalyticalModel : UniqueParametrizedObject, IAnalyticalUniqueObject, IModel
    {
        [JsonInclude, JsonPropertyName("AnalyticalRelationCluster"), Description("AnalyticalRelationCluster")]
        private AnalyticalRelationCluster analyticalRelationCluster = new AnalyticalRelationCluster();

        public AnalyticalModel()
            : base()
        {

        }

        public AnalyticalModel(AnalyticalModel analyticalModel)
            : base(analyticalModel)
        {
            analyticalRelationCluster = analyticalModel?.analyticalRelationCluster?.Clone<AnalyticalRelationCluster>();
        }

        public bool Add(IAnalyticalFace analyticalFace)
        {
            if(analyticalFace == null)
            {
                return false;
            }

            return analyticalRelationCluster.Update(analyticalFace.Clone<IAnalyticalFace>());
        }

        public bool Add(IAnalyticalSpace analyticalSpace)
        {
            if (analyticalSpace == null)
            {
                return false;
            }

            return analyticalRelationCluster.Update(analyticalSpace.Clone<IAnalyticalSpace>());
        }

        public bool Add(IAnalyticalFaceData analyticalFaceData)
        {
            if (analyticalFaceData == null)
            {
                return false;
            }

            return analyticalRelationCluster.Update(analyticalFaceData.Clone<IAnalyticalFaceData>());
        }

        public bool Add(IAnalyticalSpaceData analyticalSpaceData)
        {
            if (analyticalSpaceData == null)
            {
                return false;
            }

            return analyticalRelationCluster.Update(analyticalSpaceData.Clone<IAnalyticalSpaceData>());
        }
    }

}
