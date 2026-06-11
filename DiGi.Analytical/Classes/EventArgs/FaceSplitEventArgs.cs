using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Provides data for events that occur when a face is split.
    /// </summary>
    public class FaceSplitEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaceSplitEventArgs"/> class.
        /// </summary>
        /// <param name="input">The <see cref="Face"/> input face. This value can be null.</param>
        /// <param name="polygonalFace3D">The <see cref="PolygonalFace3D"/> representing the polygonal face in 3D space. This value can be null.</param>
        public FaceSplitEventArgs(Face? input, PolygonalFace3D? polygonalFace3D)
        {
            Input = input;
            PolygonalFace3D = polygonalFace3D;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the face split event has been handled.
        /// </summary>
        public bool Handled { get; set; } = false;

        /// <summary>
        /// Gets the input face used in the split operation.
        /// </summary>
        public Face? Input { get; }

        /// <summary>
        /// Gets the <see cref="T:DiGi.Geometry.Spatial.Classes.PolygonalFace3D" /> representing a planar polygonal face in 3D space associated with the face split event.
        /// </summary>
        public PolygonalFace3D? PolygonalFace3D { get; }

        /// <summary>
        /// Gets or sets the unique reference associated with the face split event.
        /// </summary>
        public IUniqueReference? UniqueReference { get; set; }
    }
}