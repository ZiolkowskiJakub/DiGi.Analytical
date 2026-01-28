using DiGi.Analytical.Urban.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Urban.Classes
{
    public class UrbanModelFile : Core.IO.File.Classes.ValueFile<UrbanModel>, IUrbanObject
    {
        public UrbanModelFile(UrbanModelFile? urbanModelFile)
            : base(urbanModelFile)
        {
        }

        public UrbanModelFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public UrbanModelFile(string? path)
            : base(path)
        {
        }
    }
}