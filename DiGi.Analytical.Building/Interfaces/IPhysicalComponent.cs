using DiGi.Analytical.Building.Enums;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for physical building components with a defined structure position.
    /// </summary>
    public interface IPhysicalComponent : IComponent, IBuildingBoundable3D, IConstructable
    {
        /// <summary>
        /// Gets the position of the component within the building structure.
        /// </summary>
        StructurePosition StructurePosition { get; }
    }

    /// <summary>
    /// Interface for physical components with a specific type of 3D geometry.
    /// </summary>
    /// <typeparam name="T">The type of the 3D geometry.</typeparam>
    public interface IPhysicalComponent<T> : IPhysicalComponent, IBuildingGeometryObject<T> where T : IGeometry3D
    {
    }
}