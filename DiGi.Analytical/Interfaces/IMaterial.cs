using DiGi.Core.Interfaces;

namespace DiGi.Analytical.Interfaces
{
    /// <summary>
    /// Interface for materials that combine analytical GUID identification with naming and description capabilities.
    /// </summary>
    public interface IMaterial : IAnalyticalGuidObject, INamedObject, IDescribableObject
    {
    }
}