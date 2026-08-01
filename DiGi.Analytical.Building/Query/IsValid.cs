using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        /// <summary>
        /// Checks that a building model is non-null and that every component sits on a usable, finite plane.
        /// </summary>
        /// <param name="buildingModel">The building model to check.</param>
        /// <returns><see langword="true"/> when the building model is non-null and all components carry finite plane normals; otherwise, <see langword="false"/>.</returns>
        public static bool IsValid(this BuildingModel? buildingModel)
        {
            if (buildingModel is null)
            {
                return false;
            }

            List<IComponent>? components = buildingModel.GetComponents<IComponent>();
            if (components is null)
            {
                return true;
            }

            foreach (IComponent component in components)
            {
                if (component?.Surface3D() is not IPolygonalFace3D polygonalFace3D)
                {
                    continue;
                }

                Vector3D? normal = polygonalFace3D.Plane?.Normal;
                if (normal is null)
                {
                    return false;
                }

                if (double.IsNaN(normal.X) || double.IsNaN(normal.Y) || double.IsNaN(normal.Z)
                    || double.IsInfinity(normal.X) || double.IsInfinity(normal.Y) || double.IsInfinity(normal.Z))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
