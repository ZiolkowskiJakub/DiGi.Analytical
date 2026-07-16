using DiGi.Core.Parameter.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for internal conditions that define thermal and comfort parameters for building spaces.
    /// </summary>
    public interface IInternalCondition : IBuildingGuidObject, IBuildingNamedObject, IParametrizedObject
    {
        /// <summary>
        /// Gets the description of the internal condition.
        /// </summary>
        string? Description { get; }
    }
}