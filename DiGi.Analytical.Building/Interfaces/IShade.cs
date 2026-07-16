using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for shading building elements such as overhangs or louvers.
    /// </summary>
    public interface IShade : IBuildingGeometry3DObject
    {
    }

    /// <summary>
    /// Interface for shading elements with a specific type of 3D geometry.
    /// </summary>
    /// <typeparam name="T">The type of the 3D geometry.</typeparam>
    public interface IShade<T> : IShade, IBuildingGeometryObject<T> where T : IGeometry3D
    {
    }
}