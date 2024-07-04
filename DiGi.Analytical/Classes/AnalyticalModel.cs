using DiGi.Analytical.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.ComponentModel;
using System.Text.Json.Serialization;
using DiGi.Core;

namespace DiGi.Analytical.Classes
{
    public class AnalyticalModel : UniqueParametrizedObject, IUniqueAnalytical
    {
        [JsonInclude, JsonPropertyName("AnalyticalCluster"), Description("AnalyticalCluster")]
        private AnalyticalCluster analyticalCluster = new AnalyticalCluster();

        public AnalyticalModel()
            : base()
        {

        }

        public AnalyticalModel(AnalyticalModel analyticalModel)
            : base(analyticalModel)
        {
            analyticalCluster = analyticalModel?.analyticalCluster?.Clone<AnalyticalCluster>();
        }

        public bool Add(IAnalyticalFace analyticalFace)
        {
            if(analyticalFace == null)
            {
                return false;
            }

            return analyticalCluster.Update(analyticalFace);
        }

        public bool Add(IAnalyticalSpace analyticalSpace)
        {
            if (analyticalSpace == null)
            {
                return false;
            }

            return analyticalCluster.Update(analyticalSpace);
        }

        public bool Add(IAnalyticalFaceData analyticalFaceData)
        {
            if (analyticalFaceData == null)
            {
                return false;
            }

            return analyticalCluster.Update(analyticalFaceData);
        }

        public bool Add(IAnalyticalSpaceData analyticalSpaceData)
        {
            if (analyticalSpaceData == null)
            {
                return false;
            }

            return analyticalCluster.Update(analyticalSpaceData);
        }
    }

}
