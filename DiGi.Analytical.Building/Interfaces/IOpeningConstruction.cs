using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for constructions that define opening elements.
    /// </summary>
    public interface IOpeningConstruction : IGeometry2DConstruction
    {
    }

    /// <summary>
    /// Interface for opening constructions associated with a specific opening type.
    /// </summary>
    /// <typeparam name="TOpening">The type of the opening element.</typeparam>
    public interface IOpeningConstruction<TOpening> : IOpeningConstruction, IGeometry2DConstruction<TOpening, ISurface2D> where TOpening : IOpening
    {
    }
}