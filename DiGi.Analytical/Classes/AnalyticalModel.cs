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

            return analyticalRelationCluster.Update(analyticalFace);
        }

        public bool Add(IAnalyticalSpace analyticalSpace)
        {
            if (analyticalSpace == null)
            {
                return false;
            }

            return analyticalRelationCluster.Update(analyticalSpace);
        }

        public bool Add(IAnalyticalFaceData analyticalFaceData)
        {
            if (analyticalFaceData == null)
            {
                return false;
            }

            return analyticalRelationCluster.Update(analyticalFaceData);
        }

        public bool Add(IAnalyticalSpaceData analyticalSpaceData)
        {
            if (analyticalSpaceData == null)
            {
                return false;
            }

            return analyticalRelationCluster.Update(analyticalSpaceData);
        }
    }

}
