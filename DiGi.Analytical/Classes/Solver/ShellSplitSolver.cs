namespace DiGi.Analytical.Classes
{
    public abstract class ShellSplitSolver : SplitSolver<Shell>
    {
        public ShellSplitSolver(double tolerance = Core.Constans.Tolerance.Distance)
            : base(tolerance)
        {
        }
    }
}