using DiGi.Analytical.Interfaces;
using DiGi.Core;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Classes
{
    public abstract class SplitSolver<TAnalyticalGeometry> : IOneToManySolver<TAnalyticalGeometry, TAnalyticalGeometry> where TAnalyticalGeometry : IAnalyticalGeometry
    {
        protected TAnalyticalGeometry? input;

        protected List<TAnalyticalGeometry>? outputs;

        public SplitSolver(double tolerance = Core.Constants.Tolerance.Distance)
        {
            Tolerance = tolerance;
        }

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

        public List<TAnalyticalGeometry>? Outputs
        {
            get
            {
                return Core.Query.Clone(outputs)?.FilterNulls();
            }
        }

        public double Tolerance { get; }

        public abstract bool Solve();
    }
}