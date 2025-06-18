using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class FaceFloor : Floor<IFace3D>, IFaceFloor
    {
        public FaceFloor(FaceFloor faceFloor)
            : base(faceFloor)
        {

        }

        public FaceFloor(IFace3D face3D)
            : base(face3D)
        {

        }

        public FaceFloor(System.Guid guid, FaceFloor faceFloor)
            : base(guid, faceFloor)
        {

        }

        public FaceFloor(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
