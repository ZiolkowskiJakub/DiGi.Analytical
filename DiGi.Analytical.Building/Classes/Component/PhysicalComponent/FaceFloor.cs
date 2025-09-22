using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class FaceFloor : Floor<IFace3D>, IFaceFloor
    {
        public FaceFloor(FaceFloor? faceFloor)
            : base(faceFloor)
        {

        }

        public FaceFloor(IFace3D? geometry)
            : base(geometry)
        {

        }

        public FaceFloor(System.Guid guid, FaceFloor? faceFloor)
            : base(guid, faceFloor)
        {

        }

        public FaceFloor(IFloor? floor, IFace3D? geometry)
            : base(floor, geometry)
        {

        }

        public FaceFloor(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public override BoundingBox3D? GetBoundingBox()
        {
            return Geometry?.GetBoundingBox();
        }
    }
}
