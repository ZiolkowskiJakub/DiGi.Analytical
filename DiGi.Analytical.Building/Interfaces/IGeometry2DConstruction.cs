using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IGeometry2DConstruction : IConstruction
    {

    }

    public interface IGeometry2DConstruction<TConstructable> : IGeometry2DConstruction, IConstruction<TConstructable> where TConstructable : IConstructable
    {

    }

    public interface IGeometry2DConstruction<TConstructable, TGeometry2D> : IGeometry2DConstruction<TConstructable>  where TGeometry2D : IGeometry2D where TConstructable : IConstructable
    {
        TGeometry2D Geometry { get; }
    }
}
