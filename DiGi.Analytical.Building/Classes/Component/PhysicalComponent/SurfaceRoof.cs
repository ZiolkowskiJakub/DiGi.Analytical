using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class SurfaceRoof : Roof<ISurface3D>, ISurfaceRoof
    {
        public SurfaceRoof(SurfaceRoof? surfaceRoof)
            : base(surfaceRoof)
        {

        }

        public SurfaceRoof(ISurface3D? geometry)
            : base(geometry)
        {

        }

        public SurfaceRoof(System.Guid guid, SurfaceRoof? surfaceRoof)
            : base(guid, surfaceRoof)
        {

        }

        public SurfaceRoof(IRoof? roof, ISurface3D? geometry)
            : base(roof, geometry)
        {

        }

        public SurfaceRoof(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public override BoundingBox3D? GetBoundingBox()
        {
            return Geometry?.GetBoundingBox();
        }
    }
}
