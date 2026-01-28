using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Classes
{
    public class CoplanarFaceSplitEventArgs : FaceSplitEventArgs
    {
        private readonly List<Face>? outputs;

        public CoplanarFaceSplitEventArgs(Face? input, IEnumerable<Face>? outputs, PolygonalFace3D? polygonalFace3D)
            : base(input, polygonalFace3D)
        {
            this.outputs = outputs is null ? null : [.. outputs];
        }

        public List<Face>? Outputs
        {
            get
            {
                return outputs is null ? null : [.. outputs];
            }
        }
    }
}