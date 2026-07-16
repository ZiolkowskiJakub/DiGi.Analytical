using DiGi.Analytical.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for building objects that combine serialization with GUID-based identification.
    /// </summary>
    public interface IBuildingGuidObject : IBuildingSerializableObject, IAnalyticalGuidObject
    {
    }
}