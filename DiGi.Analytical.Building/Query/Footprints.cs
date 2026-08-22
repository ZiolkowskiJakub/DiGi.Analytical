using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the outline a building model occupies on the ground, as the shapes its components cover when seen from above.
        /// <para>Openings within the outline are kept, so a building around a courtyard gives a face with the courtyard as an internal edge.</para>
        /// </summary>
        /// <param name="buildingModel">The building model to get the outline of. This value can be null.</param>
        /// <param name="tolerance">The distance tolerance used for the projection, and the smallest area a projected component must cover to count.</param>
        /// <returns>The outline of the building model, an empty list when none of its components covers any ground, or <see langword="null"/> when the building model is null.</returns>
        public static List<PolygonalFace2D>? Footprints(this BuildingModel? buildingModel, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (buildingModel == null)
            {
                return null;
            }

            return Footprints(buildingModel.GetComponents<IComponent>(), tolerance);
        }

        /// <summary>
        /// Gets the outlines a collection of building models occupies on the ground (see <see cref="Footprints(BuildingModel?, double)"/>).
        /// </summary>
        /// <remarks>
        /// The outlines are only joined per building, never across buildings, so each building keeps its own face and two buildings sharing a party wall stay two faces.
        /// </remarks>
        /// <param name="buildingModels">The building models to get the outlines of. This value can be null.</param>
        /// <param name="tolerance">The distance tolerance used for the projection, and the smallest area a projected component must cover to count.</param>
        /// <returns>The outlines of all the building models, or <see langword="null"/> when the collection is null.</returns>
        public static List<PolygonalFace2D>? Footprints(this IEnumerable<BuildingModel>? buildingModels, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (buildingModels == null)
            {
                return null;
            }

            List<PolygonalFace2D> result = [];
            foreach (BuildingModel buildingModel in buildingModels)
            {
                List<PolygonalFace2D>? polygonalFace2Ds = Footprints(buildingModel, tolerance);
                if (polygonalFace2Ds == null)
                {
                    continue;
                }

                result.AddRange(polygonalFace2Ds);
            }

            return result;
        }

        /// <summary>
        /// Gets the outline a collection of building components occupies on the ground, as the joined shapes they cover when seen from above.
        /// </summary>
        /// <remarks>
        /// This is the overload to call when the components are already at hand: <see cref="BuildingModel.GetComponents{TComponent}()"/> hands out a clone of every component it returns, so reaching the same components through the building model twice pays for them twice.
        /// <para>A component standing on its edge, a wall above all, covers no ground at all and is left out by the area test rather than by its type, which is what keeps the outline correct for a model whose walls are not vertical.</para>
        /// </remarks>
        /// <param name="components">The components to get the outline of. This value can be null.</param>
        /// <param name="tolerance">The distance tolerance used for the projection, and the smallest area a projected component must cover to count.</param>
        /// <returns>The outline of the components, an empty list when none of them covers any ground, or <see langword="null"/> when the collection is null.</returns>
        public static List<PolygonalFace2D>? Footprints(this IEnumerable<IComponent>? components, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (components == null)
            {
                return null;
            }

            Plane plane = Geometry.Spatial.Constants.Plane.WorldZ;

            List<IPolygonalFace2D> polygonalFace2Ds = [];
            foreach (IComponent component in components)
            {
                ISurface3D? surface3D = component?.Surface3D();
                if (surface3D == null)
                {
                    continue;
                }

                // The projection of a stored component can fail on geometry the projector has no case for.
                // One such component must not cost the caller the outline of the whole building, which is
                // how the conversion of a component to a scene node treats the same risk.
                ProjectionResult? projectionResult;
                try
                {
                    projectionResult = Geometry.Spatial.Create.ProjectionResult(plane, surface3D, tolerance);
                }
                catch (System.Exception)
                {
                    projectionResult = null;
                }

                if (projectionResult == null)
                {
                    continue;
                }

                List<IPolygonalFace2D>? polygonalFace2Ds_Component = projectionResult.GetGeometry2Ds<IPolygonalFace2D>();
                if (polygonalFace2Ds_Component == null || polygonalFace2Ds_Component.Count == 0)
                {
                    // A component that projects to a plain ring has no openings of its own to carry over.
                    List<IPolygonal2D>? polygonal2Ds = projectionResult.GetGeometry2Ds<IPolygonal2D>();
                    if (polygonal2Ds == null)
                    {
                        continue;
                    }

                    polygonalFace2Ds_Component = [];
                    foreach (IPolygonal2D polygonal2D in polygonal2Ds)
                    {
                        PolygonalFace2D? polygonalFace2D_Ring = Geometry.Planar.Create.PolygonalFace2D(polygonal2D, null, tolerance);
                        if (polygonalFace2D_Ring == null)
                        {
                            continue;
                        }

                        polygonalFace2Ds_Component.Add(polygonalFace2D_Ring);
                    }
                }

                foreach (IPolygonalFace2D polygonalFace2D in polygonalFace2Ds_Component)
                {
                    if (polygonalFace2D == null || polygonalFace2D.GetArea() < tolerance)
                    {
                        continue;
                    }

                    polygonalFace2Ds.Add(polygonalFace2D);
                }
            }

            if (polygonalFace2Ds.Count == 0)
            {
                return [];
            }

            return Geometry.Planar.Query.Union(polygonalFace2Ds) ?? [];
        }
    }
}
