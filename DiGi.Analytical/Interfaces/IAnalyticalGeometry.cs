using DiGi.Core.Parameter.Interfaces;
using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Interfaces
{
    public interface IAnalyticalGeometry : IAnalyticalUniqueObject, IParametrizedGuidObject, IGeometry3DObject
    {
    }

    public interface IAnalyticalGeometry<T> : IAnalyticalGeometry, IGeometry3DObject<T> where T : IGeometry3D
    {
    }
}
