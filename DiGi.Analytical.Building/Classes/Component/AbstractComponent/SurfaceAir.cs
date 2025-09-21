using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class SurfaceAir : Air<ISurface3D>, ISurfaceShade
    {
        public SurfaceAir(SurfaceAir? surfaceAir)
            : base(surfaceAir)
        {

        }

        public SurfaceAir(ISurface3D? surface3D)
            : base(surface3D)
        {

        }

        public SurfaceAir(System.Guid guid, SurfaceAir? surfaceAir)
            : base(guid, surfaceAir)
        {

        }

        public SurfaceAir(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public override BoundingBox3D? GetBoundingBox()
        {
            return Geometry?.GetBoundingBox();
        }
    }
}
