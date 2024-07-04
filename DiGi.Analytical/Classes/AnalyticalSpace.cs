using DiGi.Analytical.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    public class AnalyticalSpace : AnalyticalGeometry<Point3D>, IAnalyticalSpace, IPoint3DObject
    {
        public AnalyticalSpace(Point3D point3D)
            : base(point3D)
        {
        }

        public AnalyticalSpace(UniqueReference uniqueReference, Point3D point3D)
            : base(uniqueReference, point3D)
        {
        }

        public AnalyticalSpace(AnalyticalSpace analyticalSpace)
            : base(analyticalSpace)
        {

        }

        public AnalyticalSpace(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
