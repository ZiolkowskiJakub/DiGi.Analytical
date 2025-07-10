using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class SurfaceShade : Shade<ISurface3D>, ISurfaceShade
    {
        public SurfaceShade(SurfaceShade surfaceShade)
            : base(surfaceShade)
        {

        }

        public SurfaceShade(ISurface3D surface3D)
            : base(surface3D)
        {

        }

        public SurfaceShade(System.Guid guid, SurfaceShade surfaceShade)
            : base(guid, surfaceShade)
        {

        }

        public SurfaceShade(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
