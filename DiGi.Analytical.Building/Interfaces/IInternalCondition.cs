using System.Collections.Generic;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IInternalCondition : IBuildingGuidObject, IBuildingNamedObject
    {
        List<IProfile> Profiles { get; }
        
        IProfile this[string category] { get; }
    }
}
