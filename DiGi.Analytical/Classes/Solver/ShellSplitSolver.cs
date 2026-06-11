namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Provides an abstract base implementation for solvers specialized in splitting shell elements.
    /// </summary>
    public abstract class ShellSplitSolver : SplitSolver<Shell>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShellSplitSolver"/> class.
        /// </summary>
        /// <param name="tolerance">The distance tolerance used for splitting operations. Defaults to <see cref="Core.Constants.Tolerance.Distance"/>.</param>
        public ShellSplitSolver(double tolerance = Core.Constants.Tolerance.Distance)
            : base(tolerance)
        {
        }
    }
}