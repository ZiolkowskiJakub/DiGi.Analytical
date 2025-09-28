using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Classes;
using DiGi.Analytical.Urban.Interfaces;
using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Interfaces;
using DiGi.Core.Parameter.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

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
