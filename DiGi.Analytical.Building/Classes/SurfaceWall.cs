using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class SurfaceWall : Wall<ISurface3D>, ISurfaceWall
    {
        public SurfaceWall(SurfaceWall surfaceWall)
            : base(surfaceWall)
        {

        }

        public SurfaceWall(ISurface3D surface3D)
            : base(surface3D)
        {

        }

        public SurfaceWall(System.Guid guid, SurfaceWall surfaceWall)
            : base(guid, surfaceWall)
        {

        }

        public SurfaceWall(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
