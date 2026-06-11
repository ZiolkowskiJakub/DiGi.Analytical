using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a building floor that is defined by a 3D face geometry.
    /// </summary>
    public class FaceFloor : Floor<IFace3D>, IFaceFloor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaceFloor"/> class using an existing <see cref="FaceFloor"/> instance.
        /// </summary>
        /// <param name="faceFloor">The source <see cref="FaceFloor"/> instance to copy from.</param>
        public FaceFloor(FaceFloor? faceFloor)
            : base(faceFloor)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceFloor"/> class using the specified geometry.
        /// </summary>
        /// <param name="geometry">The 3D face geometry to associate with this floor instance.</param>
        public FaceFloor(IFace3D? geometry)
            : base(geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceFloor"/> class with a specified unique identifier and an existing <see cref="FaceFloor"/> object.
        /// </summary>
        /// <param name="guid">The unique identifier for the floor face.</param>
        /// <param name="faceFloor">An optional <see cref="FaceFloor"/> instance to initialize from.</param>
        public FaceFloor(System.Guid guid, FaceFloor? faceFloor)
            : base(guid, faceFloor)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceFloor"/> class using the specified floor and geometry.
        /// </summary>
        /// <param name="floor">The source floor object to initialize from.</param>
        /// <param name="geometry">The 3D face geometry associated with this floor.</param>
        public FaceFloor(IFloor? floor, IFace3D? geometry)
            : base(floor, geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceFloor"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="System.Text.Json.Nodes.JsonObject"/> containing the data used to initialize this instance.</param>
        public FaceFloor(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the axis-aligned bounding box of the face floor.
        /// </summary>
        /// <returns>The three-dimensional bounding box encompassing the face floor, or null if it cannot be determined.</returns>
        public override BoundingBox3D? GetBoundingBox()
        {
            return Geometry?.GetBoundingBox();
        }
    }
}