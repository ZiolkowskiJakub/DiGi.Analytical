namespace DiGi.Analytical.Classes
{
    public abstract class ShellSplitSolver : SplitSolver<Shell>
    {
        public ShellSplitSolver(double tolerance = Core.Constants.Tolerance.Distance)
            : base(tolerance)
        {
        }
    }
}