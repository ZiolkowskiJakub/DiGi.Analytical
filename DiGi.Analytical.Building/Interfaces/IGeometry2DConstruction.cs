using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for constructions that define 2D geometry.
    /// </summary>
    public interface IGeometry2DConstruction : IConstruction
    {
    }

    /// <summary>
    /// Interface for 2D geometry constructions associated with a specific constructable type.
    /// </summary>
    /// <typeparam name="TConstructable">The type of the constructable element.</typeparam>
    public interface IGeometry2DConstruction<TConstructable> : IGeometry2DConstruction, IConstruction<TConstructable> where TConstructable : IConstructable
    {
    }

    /// <summary>
    /// Interface for 2D geometry constructions with a specific geometry type and constructable type.
    /// </summary>
    /// <typeparam name="TConstructable">The type of the constructable element.</typeparam>
    /// <typeparam name="TGeometry2D">The type of the 2D geometry.</typeparam>
    public interface IGeometry2DConstruction<TConstructable, TGeometry2D> : IGeometry2DConstruction<TConstructable> where TGeometry2D : IGeometry2D where TConstructable : IConstructable
    {
        /// <summary>
        /// Gets the 2D geometry of the construction.
        /// </summary>
        TGeometry2D? Geometry { get; }
    }
}