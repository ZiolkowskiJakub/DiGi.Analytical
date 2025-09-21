using DiGi.Analytical.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.Analytical
{
    public static partial class Query
    {
        public static List<Shell>? Split(this Plane plane, Shell? shell, double tolerance = Core.Constans.Tolerance.Distance)
        {
            if(shell is null || plane is null)
            {
                return null;
            }

            List<Polyhedron>? polyhedrons = Geometry.Spatial.Query.Split(plane, shell, tolerance);
            if (polyhedrons is null || polyhedrons.Count < 2 || shell.PolygonalFaces is not List<Face> faces)
            {
                return [Core.Query.Clone(shell)];
            }

            List<List<IPolygonalFace3D>> polygonalFace3Ds = [];
            foreach (Polyhedron polyhedron in polyhedrons)
            {
                if(polyhedron.PolygonalFaces is not List<IPolygonalFace3D> polygonalFace3Ds_Polyhedron)
                {
                    continue;
                }

                foreach (IPolygonalFace3D polygonalFace3D in polygonalFace3Ds_Polyhedron)
                {
                    if(polygonalFace3D is not Face face)
                    {
                        continue;
                    }

                    int index = faces.FindIndex(x => x.UniqueReference == face.UniqueReference);
                    if(index == -1)
                    {
                        continue;
                    }

                    faces.RemoveAt(index);
                }

                polygonalFace3Ds.Add(polygonalFace3Ds_Polyhedron);
            }

            List<Tuple<BoundingBox3D, Face>> tuples = [];
            foreach(Face face in faces)
            {
                if(face?.GetBoundingBox() is not BoundingBox3D boundingBox3D)
                {
                    continue;
                }

                tuples.Add(new Tuple<BoundingBox3D, Face>(boundingBox3D, face));
            }

            List<Shell> result = [];
            foreach(List<IPolygonalFace3D> polygonalFace3Ds_Shell in polygonalFace3Ds)
            {
                List<Face> faces_Shell = [];
                foreach(IPolygonalFace3D polygonalFace3D in polygonalFace3Ds_Shell)
                {
                    if(polygonalFace3D is Face face)
                    {
                        faces_Shell.Add(face);
                        continue;
                    }

                    if(polygonalFace3D is not PolygonalFace3D polygonalFace3D_Temp)
                    {
                        throw new NotImplementedException();
                    }

                    if(polygonalFace3D_Temp.GetInternalPoint(tolerance) is not Point3D internalPoint)
                    {
                        continue;
                    }

                    Face? closestFace = null;

                    List<Tuple<BoundingBox3D, Face>> tuples_Temp = tuples.FindAll(x => x.Item1.InRange(internalPoint, tolerance));
                    if (tuples_Temp.Count == 1)
                    {
                        closestFace = tuples_Temp[0].Item2;
                    }
                    if (tuples_Temp.Count > 1)
                    {
                        Geometry.Spatial.Query.ClosestPoint(internalPoint, tuples_Temp.ConvertAll(x => x.Item2), out closestFace, out _, tolerance);
                    }
                    else
                    {
                        Geometry.Spatial.Query.ClosestPoint(internalPoint, faces, out closestFace, out _, tolerance);
                    }

                    Face face_Shell = closestFace == null ? new Face(polygonalFace3D_Temp) : new Face(closestFace.UniqueReference, polygonalFace3D_Temp);

                    faces_Shell.Add(face_Shell);
                }

                if(faces_Shell.Count == 0)
                {
                    continue;
                }

                result.Add(new Shell(shell.UniqueReference, faces_Shell));
            }

            return result;
        }
    }
}