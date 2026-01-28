using DiGi.Analytical.Interfaces;
using DiGi.Core;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    public class MaterialsFile : Core.IO.File.Classes.StorageFile<IMaterial>
    {
        public MaterialsFile(string? path)
            : base(path)
        {
        }

        public MaterialsFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public MaterialsFile(MaterialsFile? materialsFile)
            : base(materialsFile)
        {
        }

        public override UniqueReference? GetUniqueReference(IMaterial? material)
        {
            return material?.UniqueReference();
        }
    }
}