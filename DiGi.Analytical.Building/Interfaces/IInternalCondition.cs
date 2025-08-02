using DiGi.Core.Parameter.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IInternalCondition : IBuildingGuidObject, IBuildingNamedObject, IParametrizedObject
    {
        string Description { get; }
    }
}
