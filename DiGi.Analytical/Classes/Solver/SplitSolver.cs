using DiGi.Analytical.Interfaces;
using DiGi.Core;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Provides a base abstract implementation for solvers that split a single analytical geometry entity into one or more resulting entities.
    /// <para>A solver is a mutable command object: assign <see cref="Input"/> together with the cutting geometry declared by the derived class, call <see cref="Solve"/> and read <see cref="Outputs"/>. Unlike the updaters of DiGi.Analytical.Building it works purely on analytical geometry and never touches a building model, therefore its results have to be written back separately.</para>
    /// <para>Derived solvers raise split events, letting a handler decide which <see cref="DiGi.Core.Interfaces.IUniqueReference"/> each resulting entity receives; without a handler the reference of the split entity is inherited.</para>
    /// </summary>
    /// <typeparam name="TAnalyticalGeometry">The type of the analytical geometry being processed, which must implement <see cref="IAnalyticalGeometry"/>.</typeparam>
    public abstract class SplitSolver<TAnalyticalGeometry> : IOneToManySolver<TAnalyticalGeometry, TAnalyticalGeometry> where TAnalyticalGeometry : IAnalyticalGeometry
    {
        protected TAnalyticalGeometry? input;

        protected List<TAnalyticalGeometry>? outputs;

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitSolver{TAnalyticalGeometry}"/> class.
        /// </summary>
        /// <param name="tolerance">The distance tolerance to be used for geometric operations.</param>
        public SplitSolver(double tolerance = Core.Constants.Tolerance.Distance)
        {
            Tolerance = tolerance;
        }

        /// <summary>
        /// </summary>
        public TAnalyticalGeometry? Input
        {
            get
            {
                return Core.Query.Clone(input);
            }

            set
            {
                input = Core.Query.Clone(value);
            }
        }

        /// <summary>
        /// Gets the resulting list of output analytical geometry objects from the solver, filtered to remove any null values.
        /// </summary>
        public List<TAnalyticalGeometry>? Outputs
        {
            get
            {
                return Core.Query.Clone(outputs)?.FilterNulls();
            }
        }

        /// <summary>
        /// Gets the tolerance value used by the solver for geometric calculations and comparisons.
        /// </summary>
        public double Tolerance { get; }

        /// <summary>
        /// Executes the splitting operation for the analytical geometry.
        /// </summary>
        /// <returns>A <see cref="System.Boolean" /> value indicating whether the solution was successfully found.</returns>
        public abstract bool Solve();
    }
}