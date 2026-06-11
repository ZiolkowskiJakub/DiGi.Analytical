using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Provides data for events related to splitting coplanar faces.
    /// </summary>
    public class CoplanarFaceSplitEventArgs : FaceSplitEventArgs
    {
        private readonly List<Face>? outputs;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoplanarFaceSplitEventArgs"/> class.
        /// </summary>
        /// <param name="input">The input <see cref="Face"/> that was split. This value can be null.</param>
        /// <param name="outputs">A collection of <see cref="Face"/> objects resulting from the coplanar face split. This value can be null.</param>
        /// <param name="polygonalFace3D">The <see cref="PolygonalFace3D"/> representing the planar polygonal face associated with the split. This value can be null.</param>
        public CoplanarFaceSplitEventArgs(Face? input, IEnumerable<Face>? outputs, PolygonalFace3D? polygonalFace3D)
            : base(input, polygonalFace3D)
        {
            this.outputs = outputs is null ? null : [.. outputs];
        }

        /// <summary>Gets the list of resulting <see cref="T:DiGi.Geometry.Spatial.Classes.Face" /> objects produced by the coplanar face split operation.</summary>
        public List<Face>? Outputs
        {
            get
            {
                return outputs is null ? null : [.. outputs];
            }
        }
    }
}