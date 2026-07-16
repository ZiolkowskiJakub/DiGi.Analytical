using DiGi.Core.Interfaces;

namespace DiGi.Analytical.Urban.Interfaces
{
    /// <summary>
    /// Interface for urban objects that combine urban object functionality with GUID identification.
    /// </summary>
    public interface IUrbanGuidObject : IUrbanObject, IGuidObject
    {
    }
}