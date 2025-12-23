using DiGi.Geometry.Spatial.Classes;

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
