using DiGi.Analytical.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    public class AnalyticalFace : AnalyticalGeometry<PolygonalFace3D>, IAnalyticalFace, IPolygonalFace3DObject
    {
        public AnalyticalFace(PolygonalFace3D polygonalFace3D)
            :base(polygonalFace3D)
        {
        }

        public AnalyticalFace(UniqueReference uniqueReference, PolygonalFace3D polygonalFace3D)
            : base(polygonalFace3D)
        {
        }

        public AnalyticalFace(AnalyticalFace analyticalFace)
            :base(analyticalFace)
        {

        }

        public AnalyticalFace(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

    }
}
