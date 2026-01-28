using DiGi.Analytical.Building.Interfaces;
using DiGi.Core;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class InternalConditionsFile : Core.IO.File.Classes.StorageFile<IInternalCondition>
    {
        public InternalConditionsFile(string? path)
            : base(path)
        {
        }

        public InternalConditionsFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public InternalConditionsFile(InternalConditionsFile? internalConditionsFile)
            : base(internalConditionsFile)
        {
        }

        public override UniqueReference? GetUniqueReference(IInternalCondition? internalCondition)
        {
            return internalCondition?.UniqueReference();
        }
    }
}