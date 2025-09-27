using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System;

namespace DiGi.Analytical.Classes
{
    public class FaceSplitEventArgs : EventArgs
    {
        public FaceSplitEventArgs(Face? input, PolygonalFace3D? polygonalFace3D)
        {
            Input = input;
            PolygonalFace3D = polygonalFace3D;
        }

        public bool Handled { get; set; } = false;
        
        public Face? Input { get; }

        public PolygonalFace3D? PolygonalFace3D { get; }
        
        public IUniqueReference? UniqueReference { get; set; }
    }
}
