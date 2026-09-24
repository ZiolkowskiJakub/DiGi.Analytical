using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts the 3D geometry from the specified building geometry object as a specific type.
        /// <para>Returns a result only when the conversion yields exactly one geometry. When it yields several (for example a face with holes requested as <see cref="IPolygonal3D"/>), use <see cref="Geometry3Ds{TGeometry3D}(IBuildingGeometry3DObject?)"/>.</para>
        /// </summary>
        /// <typeparam name="TGeometry3D">The type of 3D geometry to return, which must implement <see cref="IGeometry3D"/>.</typeparam>
        /// <param name="buildingGeometry3DObject">The building geometry object from which the 3D geometry is extracted.</param>
        /// <returns>The extracted 3D geometry of type <typeparamref name="TGeometry3D"/>, or <see langword="null"/> if the object is null, the geometry cannot be converted, or the conversion yields several geometries.</returns>
        public static TGeometry3D? Geometry3D<TGeometry3D>(this IBuildingGeometry3DObject? buildingGeometry3DObject) where TGeometry3D : IGeometry3D
        {
            List<TGeometry3D>? geometries = Geometry3Ds<TGeometry3D>(buildingGeometry3DObject);

            return geometries is { Count: 1 } ? geometries[0] : default;
        }
    }
}
