using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IOpeningConstruction : IGeometry2DConstruction
    {

    }

    public interface IOpeningConstruction<TOpening> : IOpeningConstruction, IGeometry2DConstruction<TOpening, ISurface2D> where TOpening : IOpening
    {

    }
}
