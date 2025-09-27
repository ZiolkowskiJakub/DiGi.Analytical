using DiGi.Analytical.Delegates;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Analytical.Classes
{
    public class FaceByPlaneSplitSolver : FaceSplitSolver
    {
        private Plane? plane;

        public FaceByPlaneSplitSolver(double tolerance = Core.Constans.Tolerance.Distance)
            : base(tolerance)
        {

        }

        public Plane? Plane
        {
            get
            {
                return Core.Query.Clone(plane);
            }

            set
            {
                plane = Core.Query.Clone(value);
            }
        }

        public override bool Solve()
        {
            outputs = null;

            if(plane is null)
            {
                return false;
            }

            throw new System.NotImplementedException();

            //DiGi.Geometry.Spatial.Query.TrySplit(plane, );
        }
    }
}
