using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class SurfaceAir : Air<ISurface3D>, ISurfaceAir
    {
        public SurfaceAir(SurfaceAir? surfaceAir)
            : base(surfaceAir)
        {
        }

        public SurfaceAir(ISurface3D? geometry)
            : base(geometry)
        {
        }

        public SurfaceAir(System.Guid guid, SurfaceAir? surfaceAir)
            : base(guid, surfaceAir)
        {
        }

        public SurfaceAir(IAir? air, ISurface3D? geometry)
            : base(air, geometry)
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