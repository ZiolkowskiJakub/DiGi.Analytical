using DiGi.Analytical.Building.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="BuildingModel"/> from the specified collection of polyhedrons.
        /// </summary>
        /// <param name="polyhedrons">The collection of <see cref="IPolyhedron"/> objects to be used for creating the building model.</param>
        /// <returns>A new instance of <see cref="BuildingModel"/> if the provided collection is not null; otherwise, <c>null</c>.</returns>
        public static BuildingModel? BuildingModel(this IEnumerable<IPolyhedron> polyhedrons)
        {
            if (polyhedrons is null)
            {
                return null;
            }

            throw new System.NotImplementedException();

            //return new BuildingModel();
        }
    }
}