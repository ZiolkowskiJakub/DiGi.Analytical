namespace DiGi.Analytical.Classes
{
    public abstract class FaceSplitSolver : SplitSolver<Face>
    {
        public FaceSplitSolver(double tolerance = Core.Constants.Tolerance.Distance)
            : base(tolerance)
        {
        }
    }
}