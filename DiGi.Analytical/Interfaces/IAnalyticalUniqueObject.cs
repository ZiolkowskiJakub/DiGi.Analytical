using DiGi.Core.Interfaces;

namespace DiGi.Analytical.Interfaces
{
    /// <summary>
    /// Interface for analytical objects that require both unique object identification and GUID support.
    /// </summary>
    public interface IAnalyticalGuidObject : IAnalyticalUniqueObject, IGuidObject
    {
    }
}