using DiGi.Analytical.Building.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Create
    {
        public static BuildingModel? BuildingModel(this IEnumerable<IPolyhedron> polyhedrons)
        {
            if (polyhedrons is null)
            {
                return null;
            }

            return new BuildingModel();
        }
    }
}