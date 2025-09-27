using DiGi.Analytical.Delegates;
using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Collections.Generic;

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
