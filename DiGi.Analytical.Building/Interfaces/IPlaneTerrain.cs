using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for terrain elements defined by an infinite plane geometry.
    /// </summary>
    public interface IPlaneTerrain : ITerrain<Plane>, IBuildingPlaneObject
    {
    }
}
