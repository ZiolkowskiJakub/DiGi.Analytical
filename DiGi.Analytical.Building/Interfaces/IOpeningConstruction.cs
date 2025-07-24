using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IOpeningConstruction : IGeometry2DConstruction
    {
        IStructure PaneStructure { get; }
        IStructure FrameStructure { get; }
    }

    public interface IOpeningConstruction<TConstructable> : IOpeningConstruction, IGeometry2DConstruction<TConstructable, ISurface2D> where TConstructable : IConstructable
    {

    }
}
