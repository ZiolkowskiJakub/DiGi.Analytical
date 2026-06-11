using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Provides the event data for a non-coplanar face split operation.
    /// </summary>
    public class NonCoplanarFaceSplitEventArgs : FaceSplitEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NonCoplanarFaceSplitEventArgs"/> class.
        /// </summary>
        /// <param name="input">The <see cref="Face"/> that is being split; this value can be null.</param>
        /// <param name="polygonalFace3D">The <see cref="PolygonalFace3D"/> involved in the non-coplanar face split operation; this value can be null.</param>
        public NonCoplanarFaceSplitEventArgs(Face? input, PolygonalFace3D? polygonalFace3D)
            : base(input, polygonalFace3D)
        {
        }
    }
}