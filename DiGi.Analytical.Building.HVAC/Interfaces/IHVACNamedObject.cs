using DiGi.Analytical.Building.Interfaces;

namespace DiGi.Analytical.Building.HVAC.Interfaces
{
    /// <summary>
    /// Interface for HVAC objects that have a name.
    /// </summary>
    public interface IHVACNamedObject : IHVACObject, IBuildingNamedObject
    {
    }
}