using System.Collections.Generic;
using DiGi.Solar.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System;

namespace DiGi.Analytical.Building.Solar
{
    public static partial class Convert
    {
        public static ShadingModel? ToSolar(this Classes.BuildingModel? buildingModel)
        {
            if(buildingModel is null)
            {
                return null;
            }

            ShadingModel result = new (buildingModel.BuildingInformation.UTC, buildingModel.BuildingInformation.Coordinates);

            List<IComponent>? components = buildingModel.GetComponents<IComponent>();
            if(components is null)
            {
                return null;
            }

            foreach(IComponent component in components)
            {
                IPolygonalFace3D? polygonalFace3D = Query.Geometry3D<IPolygonalFace3D>(component);
                if(polygonalFace3D is null)
                {
                    continue;
                }

                ShadingElement shadingElement = new (new GuidReference(component).ToString(), polygonalFace3D, component is IShade);
                result.Update(shadingElement);
            }

            return result;
        }
    }
}
