using DiGi.Core.Interfaces;

namespace DiGi.Analytical.Interfaces
{
    /// <summary>
    /// Interface for analytical objects that combine analytical functionality with unique object identification.
    /// </summary>
    public interface IAnalyticalUniqueObject : IAnalyticalObject, IUniqueObject
    {
    }
}