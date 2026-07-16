using DiGi.Core.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for building objects that support serialization.
    /// </summary>
    public interface IBuildingSerializableObject : IBuildingObject, ISerializableObject
    {
    }
}