using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Modify
    {
        /// <summary>
        /// Attempts to split the spaces of the given <see cref="BuildingModel"/> by a horizontal plane placed on the given elevation.
        /// <para>Each space crossed by the plane is replaced by a lower and an upper space. The part containing the internal point of the original space keeps the original <see cref="ISpace"/>, the remaining parts become new spaces carrying the name, description, internal conditions and zone assignments of the original space.</para>
        /// <para>Components bounding those spaces are rebuilt out of the split faces: the first part of a component keeps the identifier of the original component, the remaining parts are created as new components of the same type, all of them keeping the construction of the original component. Faces created on the cutting plane become a single <see cref="FaceFloor"/> assigned to <paramref name="floorConstruction"/> (or a single <see cref="SurfaceAir"/> when <paramref name="floorConstruction"/> is null) shared by both spaces; any other face without a source component becomes a <see cref="SurfaceAir"/>.</para>
        /// </summary>
        /// <remarks>
        /// Openings (windows and doors) hosted by a split component are NOT re-hosted onto the component fragment that geometrically contains them - they stay assigned to the fragment that inherits the identifier of the original component. Re-hosting requires a public counterpart of the currently private BuildingModel.Assign(IComponent, IOpening) method.
        /// </remarks>
        /// <param name="buildingModel">The <see cref="BuildingModel"/> to be split. The model is modified in place.</param>
        /// <param name="elevation">The elevation the horizontal cutting plane is placed on.</param>
        /// <param name="minHeight">The minimal height of the part of a space above the cutting plane. Spaces with a smaller part above the plane are not split and stay combined.</param>
        /// <param name="floorConstruction">The <see cref="IFloorConstruction"/> assigned to the floors created on the cutting plane. When null a <see cref="SurfaceAir"/> is created instead of a <see cref="FaceFloor"/>.</param>
        /// <param name="spaces">The spaces to be split. When null all spaces of the <paramref name="buildingModel"/> are taken.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether at least one space was split.</returns>
        /// <seealso cref="BuildingModelShellsUpdater"/>
        /// <seealso cref="BuildingModelFloorUpdater"/>
        public static bool TrySplit(
            this BuildingModel? buildingModel,
            double elevation,
            double minHeight = 1,
            IFloorConstruction? floorConstruction = null,
            IEnumerable<ISpace>? spaces = null,
            double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (buildingModel == null)
            {
                return false;
            }

            spaces ??= buildingModel.GetSpaces<ISpace>();
            if (spaces == null)
            {
                return false;
            }

            Plane? plane = Geometry.Spatial.Create.Plane(elevation);
            if (plane == null)
            {
                return false;
            }

            List<Shell> shells = [];
            List<Tuple<Point3D, IComponent>> tuples_Plane = [];

            foreach (ISpace space in spaces)
            {
                if (space == null)
                {
                    continue;
                }

                Shell? shell = buildingModel.GetShell(space, tolerance: tolerance);
                if (shell?.GetBoundingBox() is not BoundingBox3D boundingBox3D)
                {
                    continue;
                }

                // Part of the space above the cutting plane is too small to become a separate space
                if (boundingBox3D.MaxZ - elevation < minHeight)
                {
                    continue;
                }

                if (elevation - boundingBox3D.MinZ < tolerance)
                {
                    continue;
                }

                if (!Analytical.Query.TrySplit(plane, shell, out List<Shell>? shells_Split, tolerance) || shells_Split == null || shells_Split.Count < 2)
                {
                    continue;
                }

                Point3D? point3D_Space = space.Geometry;

                int index_Base = -1;

                if (point3D_Space != null)
                {
                    for (int i = 0; i < shells_Split.Count; i++)
                    {
                        if (shells_Split[i].Inside(point3D_Space, tolerance))
                        {
                            index_Base = i;
                            break;
                        }
                    }
                }

                if (index_Base == -1)
                {
                    double z_Min = double.MaxValue;
                    for (int i = 0; i < shells_Split.Count; i++)
                    {
                        if (shells_Split[i].GetBoundingBox()?.GetCentroid() is not Point3D point3D_Centroid || point3D_Centroid.Z >= z_Min)
                        {
                            continue;
                        }

                        z_Min = point3D_Centroid.Z;
                        index_Base = i;
                    }
                }

                if (index_Base == -1)
                {
                    continue;
                }

                // Distance measured from the internal point of the original space straight down to the closest surface below
                double distance = double.NaN;

                if (point3D_Space != null && Geometry.Spatial.Create.IntersectionResult3D(shell, new Ray3D(point3D_Space, new Vector3D(0, 0, -1)), tolerance)?.GetGeometry3Ds<Point3D>() is List<Point3D> point3Ds_Intersection)
                {
                    double z_Max = double.MinValue;
                    for (int i = 0; i < point3Ds_Intersection.Count; i++)
                    {
                        double z = point3Ds_Intersection[i].Z;
                        if (z < point3D_Space.Z - tolerance && z > z_Max)
                        {
                            z_Max = z;
                        }
                    }

                    if (z_Max != double.MinValue)
                    {
                        distance = point3D_Space.Z - z_Max;
                    }
                }

                for (int i = 0; i < shells_Split.Count; i++)
                {
                    Shell shell_Part = shells_Split[i];

                    if (shell_Part.PolygonalFaces is not List<Face> faces || faces.Count < 4)
                    {
                        continue;
                    }

                    ISpace? space_Part;

                    if (i == index_Base)
                    {
                        space_Part = space;
                    }
                    else
                    {
                        Point3D? point3D_Internal = null;

                        if (point3D_Space != null && !double.IsNaN(distance))
                        {
                            Point3D point3D_Temp = new(point3D_Space.X, point3D_Space.Y, elevation + distance);
                            if (shell_Part.Inside(point3D_Temp, tolerance))
                            {
                                point3D_Internal = point3D_Temp;
                            }
                        }

                        point3D_Internal ??= shell_Part.GetInternalPoint(tolerance);
                        if (point3D_Internal == null)
                        {
                            continue;
                        }

                        Space space_New = new(point3D_Internal, space.Name);

                        if (space is Space space_Temp)
                        {
                            space_New.Description = space_Temp.Description;
                        }

                        if (!buildingModel.Update(space_New))
                        {
                            continue;
                        }

                        if (buildingModel.GetSpaceInternalConditions(space) is List<SpaceInternalCondition> spaceInternalConditions)
                        {
                            for (int j = 0; j < spaceInternalConditions.Count; j++)
                            {
                                SpaceInternalCondition spaceInternalCondition = spaceInternalConditions[j];
                                buildingModel.Assign(space_New, spaceInternalCondition.InternalCondition, spaceInternalCondition.HourRange, spaceInternalCondition.Id);
                            }
                        }

                        if (buildingModel.GetZones<IZone>() is List<IZone> zones)
                        {
                            for (int j = 0; j < zones.Count; j++)
                            {
                                IZone zone = zones[j];

                                if (buildingModel.GetSpaces(zone) is not List<ISpace> spaces_Zone || spaces_Zone.Find(x => x.Guid == space.Guid) == null)
                                {
                                    continue;
                                }

                                spaces_Zone.Add(space_New);
                                buildingModel.Assign(zone, spaces_Zone);
                            }
                        }

                        space_Part = space_New;
                    }

                    List<Face> faces_Part = [];

                    for (int j = 0; j < faces.Count; j++)
                    {
                        Face face = faces[j];

                        // Face originating from an existing component or a face which does not lie on the cutting plane, the latter becomes an air component
                        if (face.UniqueReference != null || face.GetBoundingBox() is not BoundingBox3D boundingBox3D_Face || Math.Abs(boundingBox3D_Face.MinZ - elevation) > tolerance || Math.Abs(boundingBox3D_Face.MaxZ - elevation) > tolerance)
                        {
                            faces_Part.Add(face);
                            continue;
                        }

                        if (face.GetInternalPoint(tolerance) is not Point3D point3D_Face || Geometry.Spatial.Create.PolygonalFace3D(face) is not PolygonalFace3D polygonalFace3D)
                        {
                            faces_Part.Add(face);
                            continue;
                        }

                        IComponent? component = tuples_Plane.Find(x => x.Item1.Distance(point3D_Face) <= tolerance)?.Item2;

                        if (component == null)
                        {
                            if (floorConstruction != null)
                            {
                                FaceFloor? faceFloor = Create.FaceFloor(polygonalFace3D, tolerance);
                                if (faceFloor == null || !buildingModel.Assign(faceFloor, floorConstruction))
                                {
                                    faces_Part.Add(face);
                                    continue;
                                }

                                component = faceFloor;
                            }
                            else
                            {
                                SurfaceAir? surfaceAir = Create.SurfaceAir(polygonalFace3D, tolerance);
                                if (surfaceAir == null || !buildingModel.Update(surfaceAir))
                                {
                                    faces_Part.Add(face);
                                    continue;
                                }

                                component = surfaceAir;
                            }

                            tuples_Plane.Add(new Tuple<Point3D, IComponent>(point3D_Face, component));
                        }

                        faces_Part.Add(new Face(new GuidReference(component), polygonalFace3D));
                    }

                    shells.Add(new Shell(new GuidReference(space_Part), faces_Part));
                }
            }

            if (shells.Count == 0)
            {
                return false;
            }

            BuildingModelShellsUpdater buildingModelShellsUpdater = new(buildingModel)
            {
                Shells = shells,
                Tolerance = tolerance
            };

            return buildingModelShellsUpdater.Update(out List<ISpace>? spaces_Updated) && spaces_Updated != null && spaces_Updated.Count != 0;
        }
    }
}
