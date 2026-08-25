using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Classes;
using DiGi.Geometry.Spatial;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        /// <summary>
        /// Checks that every space of a building model is bounded by a closed shell.
        /// <para>Complements <see cref="IsValid(BuildingModel)"/>, which only checks that the components sit on usable planes - a model can pass that and still be a set of surfaces that does not enclose anything.</para>
        /// </summary>
        /// <param name="buildingModel">The building model to check.</param>
        /// <param name="tolerance">The distance tolerance used to weld coincident vertices while pairing the edges of the shell.</param>
        /// <returns><see langword="true"/> when the building model holds at least one space and every one of them is enclosed; otherwise, <see langword="false"/>.</returns>
        public static bool IsEnclosed(this BuildingModel? buildingModel, double tolerance = Core.Constants.Tolerance.Distance)
        {
            return IsEnclosed(buildingModel, false, tolerance);
        }

        /// <summary>
        /// Checks that every space of a building model is bounded by a closed shell.
        /// <para>The shell of a space is assembled by <see cref="BuildingModel.GetShells{TSpace}(IEnumerable{TSpace}, DiGi.Geometry.Core.Enums.Side?, DiGi.Geometry.Core.Enums.Orientation?, DiGi.Geometry.Core.Enums.Orientation?, double)"/>, which resolves a curve wall into the surface it sweeps, so a model extruded from a footprint and a model converted from CityGML are both covered.</para>
        /// <para>A space contributing no shell - it carries no component, or fewer than the four faces a closed solid needs - fails the check rather than being skipped, since a space without a boundary is exactly the state this is meant to catch.</para>
        /// <para><paramref name="tolerance"/> is an upper bound, not an exact value: a shell closing at a finer tolerance is enclosed. For the default criterion that is now automatic, because <see cref="DiGi.Geometry.Spatial.Query.IsClosed{TPolygonalFace3D}(DiGi.Geometry.Spatial.Classes.Polyhedron{TPolygonalFace3D}?, bool, double)"/> is monotonic in tolerance - a shell closing at a finer value closes at the requested one too. The <paramref name="manifold"/> criterion is scale-relative and is not, so a shell that fails it at the requested tolerance is retried at finer ones through <see cref="DiGi.Geometry.Spatial.Query.ClosingTolerance{TPolygonalFace3D}(DiGi.Geometry.Spatial.Classes.Polyhedron{TPolygonalFace3D}?, IEnumerable{double}?, bool)"/> before it is rejected.</para>
        /// </summary>
        /// <param name="buildingModel">The building model to check.</param>
        /// <param name="manifold">When <see langword="true"/>, every edge of a shell must be used exactly twice, so an edge shared by three or more faces is rejected.</param>
        /// <param name="tolerance">The coarsest distance tolerance the vertices of a shell may be welded at while pairing its edges.</param>
        /// <returns><see langword="true"/> when the building model holds at least one space and every one of them is enclosed; otherwise, <see langword="false"/>.</returns>
        public static bool IsEnclosed(this BuildingModel? buildingModel, bool manifold, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (buildingModel is null)
            {
                return false;
            }

            List<Space>? spaces = buildingModel.GetSpaces<Space>();
            if (spaces is null || spaces.Count == 0)
            {
                return false;
            }

            List<Shell>? shells = buildingModel.GetShells(spaces, tolerance: tolerance);
            if (shells is null || shells.Count != spaces.Count)
            {
                return false;
            }

            // Ascending, so the retry only ever narrows the tolerance.
            double[] tolerances = [Core.Constants.Tolerance.Distance, 1E-05, 0.0001, Core.Constants.Tolerance.MacroDistance, 0.01];

            foreach (Shell shell in shells)
            {
                if (shell.IsClosed(manifold, tolerance))
                {
                    continue;
                }

                // The default criterion is monotonic, so a shell open at the requested tolerance is open at every
                // finer one and there is nothing to retry. Only the scale-relative manifold criterion can still
                // succeed further down the ladder.
                if (!manifold)
                {
                    return false;
                }

                double? closingTolerance = shell.ClosingTolerance(tolerances, true);
                if (closingTolerance is null || closingTolerance.Value >= tolerance)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
