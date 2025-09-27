using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.Analytical.Classes
{
    public class NonCoplanarFaceSplitEventArgs : FaceSplitEventArgs
    {
        public NonCoplanarFaceSplitEventArgs(Face? input, PolygonalFace3D? polygonalFace3D)
            : base(input, polygonalFace3D)
        {

        }
    }
}
