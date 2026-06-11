namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Provides an abstract base implementation for solvers designed to split face elements.
    /// </summary>
    public abstract class FaceSplitSolver : SplitSolver<Face>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaceSplitSolver"/> class.
        /// </summary>
        /// <param name="tolerance">The distance tolerance used for geometric calculations during face splitting.</param>
        public FaceSplitSolver(double tolerance = Core.Constants.Tolerance.Distance)
            : base(tolerance)
        {
        }
    }
}