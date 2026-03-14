namespace DiGi.Analytical.Classes
{
    public abstract class FaceSplitSolver : SplitSolver<Face>
    {
        public FaceSplitSolver(double tolerance = Core.Constans.Tolerance.Distance)
            : base(tolerance)
        {
        }
    }
}