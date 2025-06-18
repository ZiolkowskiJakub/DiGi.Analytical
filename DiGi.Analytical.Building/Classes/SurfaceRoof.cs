using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class SurfaceRoof : Roof<ISurface3D>, ISurfaceRoof
    {
        public SurfaceRoof(SurfaceRoof surfaceRoof)
            : base(surfaceRoof)
        {

        }

        public SurfaceRoof(ISurface3D surface3D)
            : base(surface3D)
        {

        }

        public SurfaceRoof(System.Guid guid, SurfaceRoof surfaceRoof)
            : base(guid, surfaceRoof)
        {

        }

        public SurfaceRoof(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
