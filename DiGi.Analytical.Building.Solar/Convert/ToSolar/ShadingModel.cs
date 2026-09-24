using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Object.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Solar.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Solar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a building model into a shading model for solar analysis.
        /// <para>Every component is a receiver and every shade is shading-only. Equivalent to <see cref="ToSolar(Classes.BuildingModel?, IEnumerable{Classes.BuildingModel}?, Func{IComponent, bool}?)"/> with no surroundings and no receiver filter.</para>
        /// </summary>
        /// <param name="buildingModel">The building model to convert.</param>
        /// <returns>A <see cref="ShadingModel"/> if the conversion is successful; otherwise, <c>null</c>.</returns>
        public static ShadingModel? ToSolar(this Classes.BuildingModel? buildingModel)
        {
            return ToSolar(buildingModel, null, null);
        }

        /// <summary>
        /// Converts a building and its surroundings into a shading model for solar analysis.
        /// <para>Receivers are the components of <paramref name="buildingModel"/> accepted by <paramref name="receiverFilter"/> (all components when it is null). Every other component of the analysed building, every shade of the analysed building, and every component and shade of <paramref name="buildingModels_Surrounding"/> is shading-only: it casts shade on the receivers, is never shaded itself and gets no results.</para>
        /// <para>No distance or height culling is applied - the caller chooses the surroundings (search radius). A surrounding model with the <see cref="Classes.BuildingModel"/> guid of the analysed model, or one already added, is skipped.</para>
        /// <para>A component whose geometry converts to several faces yields one element per face, all carrying the component's <see cref="GuidReference"/>; group by <see cref="ShadingElement.Reference"/> to aggregate results per component. The model is returned even when it holds no receiver.</para>
        /// <para>Openings (<see cref="IOpening"/>) are not components and are not converted: the host component's face goes in whole, so windows and doors neither get results of their own nor punch holes in the receiver. Terrain is not added.</para>
        /// </summary>
        /// <param name="buildingModel">The analysed building model; its <see cref="Classes.BuildingModel.BuildingInformation"/> supplies the time zone and coordinates.</param>
        /// <param name="buildingModels_Surrounding">The surrounding building models added as shade casters only, or null for none.</param>
        /// <param name="receiverFilter">Selects the components of <paramref name="buildingModel"/> that receive results, or null to select all of them.</param>
        /// <returns>A <see cref="ShadingModel"/> if the conversion is successful; otherwise, <c>null</c>.</returns>
        public static ShadingModel? ToSolar(this Classes.BuildingModel? buildingModel, IEnumerable<Classes.BuildingModel>? buildingModels_Surrounding, Func<IComponent, bool>? receiverFilter = null)
        {
            if (buildingModel is null)
            {
                return null;
            }

            ShadingModel result = new(buildingModel.BuildingInformation.UTC, buildingModel.BuildingInformation.Coordinates);

            // TODO [Geometry3DMultiFace]: replace with Query.Geometry3D once ZiolkowskiJakub/DiGi.Analytical#6 ships multi-face support - it throws NotImplementedException when the geometry converts to more than one face.
            List<IPolygonalFace3D>? polygonalFace3Ds(IBuildingGeometry3DObject buildingGeometry3DObject)
            {
                IGeometry3D? geometry3D = buildingGeometry3DObject switch
                {
                    CurveWall<ICurve3D> curveWall => curveWall.GetSurface3D(),
                    IGeometryObject<IFace3D> geometryObject => geometryObject.Geometry,
                    IGeometryObject<ISurface3D> geometryObject => geometryObject.Geometry,
                    _ => null,
                };

                return geometry3D is null ? null : Geometry.Spatial.Query.Convert<IPolygonalFace3D>(geometry3D);
            }

            void add(IBuildingGeometry3DObject buildingGeometry3DObject, bool shadingOnly)
            {
                List<IPolygonalFace3D>? polygonalFace3Ds_BuildingGeometry3DObject = polygonalFace3Ds(buildingGeometry3DObject);
                if (polygonalFace3Ds_BuildingGeometry3DObject is null)
                {
                    return;
                }

                string? reference = new GuidReference(buildingGeometry3DObject).ToString();
                foreach (IPolygonalFace3D polygonalFace3D in polygonalFace3Ds_BuildingGeometry3DObject)
                {
                    result.Update(new ShadingElement(reference, polygonalFace3D, shadingOnly));
                }
            }

            void addShades(Classes.BuildingModel buildingModel_Temp)
            {
                List<IShade>? shades = buildingModel_Temp.GetShades<IShade>();
                if (shades is null)
                {
                    return;
                }

                foreach (IShade shade in shades)
                {
                    add(shade, true);
                }
            }

            List<IComponent>? components = buildingModel.GetComponents<IComponent>();
            if (components is not null)
            {
                foreach (IComponent component in components)
                {
                    add(component, receiverFilter is not null && !receiverFilter(component));
                }
            }

            addShades(buildingModel);

            if (buildingModels_Surrounding is not null)
            {
                HashSet<Guid> guids = [buildingModel.Guid];
                foreach (Classes.BuildingModel? buildingModel_Surrounding in buildingModels_Surrounding)
                {
                    if (buildingModel_Surrounding is null || !guids.Add(buildingModel_Surrounding.Guid))
                    {
                        continue;
                    }

                    List<IComponent>? components_Surrounding = buildingModel_Surrounding.GetComponents<IComponent>();
                    if (components_Surrounding is not null)
                    {
                        foreach (IComponent component in components_Surrounding)
                        {
                            add(component, true);
                        }
                    }

                    addShades(buildingModel_Surrounding);
                }
            }

            return result;
        }
    }
}
