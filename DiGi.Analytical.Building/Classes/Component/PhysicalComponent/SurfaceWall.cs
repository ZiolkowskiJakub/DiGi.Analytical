using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class SurfaceWall : Wall<ISurface3D>, ISurfaceWall
    {
        public SurfaceWall(SurfaceWall? surfaceWall)
            : base(surfaceWall)
        {

        }

        public SurfaceWall(ISurface3D? geometry)
            : base(geometry)
        {

        }

        public SurfaceWall(System.Guid guid, SurfaceWall? surfaceWall)
            : base(guid, surfaceWall)
        {

        }

        public SurfaceWall(IWall? wall, ISurface3D? geometry)
            : base(wall, geometry)
        {

        }

        public SurfaceWall(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public override BoundingBox3D? GetBoundingBox()
        {
            return Geometry?.GetBoundingBox();
        }
    }
}
