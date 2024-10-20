using DiGi.Analytical.Interfaces;
using DiGi.Core;
using DiGi.Core.Relation.Classes;

namespace DiGi.Analytical.Classes
{
    public class AnalyticalModel : UniqueObjectRelationClusterModel<IAnalyticalUniqueObject, IAnalyticalRelation>, IAnalyticalUniqueObject
    {
        public AnalyticalModel()
            : base()
        {

        }

        public AnalyticalModel(AnalyticalModel analyticalModel)
            : base(analyticalModel)
        {

        }

        public bool Add(IAnalyticalFace analyticalFace)
        {
            if(analyticalFace == null)
            {
                return false;
            }

            return uniqueObjectRelationCluster.Update(analyticalFace.Clone<IAnalyticalFace>());
        }

        public bool Add(IAnalyticalSpace analyticalSpace)
        {
            if (analyticalSpace == null)
            {
                return false;
            }

            return uniqueObjectRelationCluster.Update(analyticalSpace.Clone<IAnalyticalSpace>());
        }

        public bool Add(IAnalyticalFaceData analyticalFaceData)
        {
            if (analyticalFaceData == null)
            {
                return false;
            }

            return uniqueObjectRelationCluster.Update(analyticalFaceData.Clone<IAnalyticalFaceData>());
        }

        public bool Add(IAnalyticalSpaceData analyticalSpaceData)
        {
            if (analyticalSpaceData == null)
            {
                return false;
            }

            return uniqueObjectRelationCluster.Update(analyticalSpaceData.Clone<IAnalyticalSpaceData>());
        }
    }

}
