using DiGi.Analytical.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.Analytical
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to split the specified <see cref="Face"/> using a collection of other faces.
        /// <para>Each resulting face inherits the <see cref="IUniqueReference"/> of a coplanar cutting <see cref="Face"/> containing it, or the <see cref="IUniqueReference"/> of the split <see cref="Face"/> when no coplanar cutting face matches.</para>
        /// </summary>
        /// <param name="face">The <see cref="Face"/> instance to be split.</param>
        /// <param name="faces">A collection of <see cref="Face"/> instances used as splitting boundaries.</param>
        /// <param name="result">When this method returns, contains a <see cref="List{Face}"/> of the resulting split faces if successful; otherwise, null.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance for intersection calculations.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the face was successfully split.</returns>
        public static bool TrySplit(this Face? face, IEnumerable<Face>? faces, out List<Face>? result, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            result = null;

            if (face == null || faces == null)
            {
                return false;
            }

            List<Face> faces_Cutting = [];
            foreach (Face face_Temp in faces)
            {
                if (face_Temp == null)
                {
                    continue;
                }

                faces_Cutting.Add(face_Temp);
            }

            if (faces_Cutting.Count == 0)
            {
                return false;
            }

            if (!Geometry.Spatial.Query.TrySplit(face, faces_Cutting, out List<PolygonalFace3D>? polygonalFace3Ds, tolerance) || polygonalFace3Ds == null || polygonalFace3Ds.Count == 0)
            {
                return false;
            }

            List<Tuple<BoundingBox3D, Face>> tuples_Coplanar = [];
            for (int i = 0; i < faces_Cutting.Count; i++)
            {
                Face face_Cutting = faces_Cutting[i];

                if (!Geometry.Spatial.Query.Coplanar(face, face_Cutting, tolerance))
                {
                    continue;
                }

                if (face_Cutting.GetBoundingBox() is not BoundingBox3D boundingBox3D)
                {
                    continue;
                }

                tuples_Coplanar.Add(new Tuple<BoundingBox3D, Face>(boundingBox3D, face_Cutting));
            }

            IUniqueReference? uniqueReference_Face = face.UniqueReference;

            result = [];
            for (int i = 0; i < polygonalFace3Ds.Count; i++)
            {
                PolygonalFace3D polygonalFace3D = polygonalFace3Ds[i];

                IUniqueReference? uniqueReference = uniqueReference_Face;

                if (tuples_Coplanar.Count != 0 && polygonalFace3D.GetInternalPoint(tolerance) is Point3D point3D_Internal)
                {
                    Tuple<BoundingBox3D, Face>? tuple_Coplanar = tuples_Coplanar.Find(x => x.Item1.InRange(point3D_Internal, tolerance) && x.Item2.InRange(point3D_Internal, tolerance));
                    if (tuple_Coplanar != null)
                    {
                        uniqueReference = tuple_Coplanar.Item2.UniqueReference;
                    }
                }

                result.Add(new Face(uniqueReference, polygonalFace3D));
            }

            return result.Count != 0;
        }

        /// <summary>
        /// Attempts to split the specified <see cref="Shell"/> using a collection of other shells.
        /// <para>The resulting <see cref="Shell"/> inherits the <see cref="IUniqueReference"/> of the split <see cref="Shell"/> and each of its faces inherits the <see cref="IUniqueReference"/> resolved for that face.</para>
        /// </summary>
        /// <param name="shell">The <see cref="Shell"/> to be split.</param>
        /// <param name="shells">An <see cref="IEnumerable{Shell}"/> of shells used for the splitting process.</param>
        /// <param name="result">When this method returns, contains the resulting <see cref="Shell"/> if the operation succeeded; otherwise, null.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the split was successful.</returns>
        public static bool TrySplit(this Shell? shell, IEnumerable<Shell>? shells, out Shell? result, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            result = null;

            if (shell == null || shells == null)
            {
                return false;
            }

            List<Face>? faces = shell.PolygonalFaces;
            if (faces == null || faces.Count == 0)
            {
                return false;
            }

            List<Tuple<Face, BoundingBox3D?, List<Face>>> tuples = [];
            for (int i = 0; i < faces.Count; i++)
            {
                Face face = faces[i];
                if (face == null)
                {
                    continue;
                }

                tuples.Add(new Tuple<Face, BoundingBox3D?, List<Face>>(face, face.GetBoundingBox(), []));
            }

            foreach (Shell shell_Temp in shells)
            {
                if (shell_Temp == null)
                {
                    continue;
                }

                List<Face>? faces_Temp = shell_Temp.PolygonalFaces;
                if (faces_Temp == null || faces_Temp.Count == 0)
                {
                    continue;
                }

                for (int i = 0; i < faces_Temp.Count; i++)
                {
                    Face face_Temp = faces_Temp[i];
                    if (face_Temp?.GetBoundingBox() is not BoundingBox3D boundingBox3D)
                    {
                        continue;
                    }

                    for (int j = 0; j < tuples.Count; j++)
                    {
                        BoundingBox3D? boundingBox3D_Target = tuples[j].Item2;
                        if (boundingBox3D_Target != null && boundingBox3D.InRange(boundingBox3D_Target, tolerance))
                        {
                            tuples[j].Item3.Add(face_Temp);
                        }
                    }
                }
            }

            List<Face> faces_Result = [];
            bool splitAny = false;

            for (int i = 0; i < tuples.Count; i++)
            {
                Tuple<Face, BoundingBox3D?, List<Face>> tuple = tuples[i];

                if (tuple.Item3.Count > 0 && TrySplit(tuple.Item1, tuple.Item3, out List<Face>? faces_Split, tolerance) && faces_Split != null && faces_Split.Count != 0)
                {
                    faces_Result.AddRange(faces_Split);
                    splitAny = true;
                }
                else
                {
                    faces_Result.Add(tuple.Item1);
                }
            }

            if (!splitAny || faces_Result.Count == 0)
            {
                return false;
            }

            Shell shell_Result = new(shell.UniqueReference, faces_Result);
            if (shell_Result.Count == 0)
            {
                return false;
            }

            result = shell_Result;
            return true;
        }

        /// <summary>
        /// Attempts to split a collection of shells by each other.
        /// <para>Shells that are not split are copied to the result with their <see cref="IUniqueReference"/> preserved.</para>
        /// </summary>
        /// <param name="shells">The <see cref="IEnumerable{Shell}"/> of shells to split.</param>
        /// <param name="result">When this method returns, contains the <see cref="List{Shell}"/> of resulting shells if the operation succeeded; otherwise, null.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used to determine splitting boundaries.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the split was successful.</returns>
        public static bool TrySplit(this IEnumerable<Shell>? shells, out List<Shell>? result, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            result = null;

            if (shells == null)
            {
                return false;
            }

            List<Tuple<BoundingBox3D, Shell>> tuples = [];
            foreach (Shell shell in shells)
            {
                if (shell?.GetBoundingBox() is not BoundingBox3D boundingBox3D)
                {
                    continue;
                }

                tuples.Add(new Tuple<BoundingBox3D, Shell>(boundingBox3D, shell));
            }

            result = [];
            bool splitAny = false;

            for (int i = 0; i < tuples.Count; i++)
            {
                Tuple<BoundingBox3D, Shell> tuple_1 = tuples[i];

                List<Shell> shells_Temp = [];
                for (int j = 0; j < tuples.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    Tuple<BoundingBox3D, Shell> tuple_2 = tuples[j];

                    if (!tuple_1.Item1.InRange(tuple_2.Item1, tolerance))
                    {
                        continue;
                    }

                    shells_Temp.Add(tuple_2.Item2);
                }

                Shell shell;

                if (shells_Temp.Count > 0 && TrySplit(tuple_1.Item2, shells_Temp, out Shell? shell_Temp, tolerance) && shell_Temp != null)
                {
                    shell = shell_Temp;
                    splitAny = true;
                }
                else
                {
                    shell = new Shell(tuple_1.Item2);
                }

                result.Add(shell);
            }

            if (!splitAny || result.Count == 0)
            {
                result = null;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Attempts to split a <see cref="Shell"/> using a specified plane.
        /// <para>Each resulting <see cref="Shell"/> inherits the <see cref="IUniqueReference"/> of the split <see cref="Shell"/>, each resulting <see cref="Face"/> inherits the <see cref="IUniqueReference"/> of the <see cref="Face"/> it originates from and faces created on the cutting plane are left without an <see cref="IUniqueReference"/>.</para>
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used to perform the split operation.</param>
        /// <param name="shell">The <see cref="Shell"/> that is to be split.</param>
        /// <param name="result">When this method returns, contains a <see cref="List{Shell}"/> of the resulting shells if the operation succeeded; otherwise, null.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for intersection calculations.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the shell was successfully split.</returns>
        /// <remarks>
        /// The resulting shells describe geometry only. Writing them back into an analytical model, so that the components bounding the split spaces are rebuilt, is done by the updaters of DiGi.Analytical.Building - see BuildingModelShellsUpdater and BuildingModel.TrySplit.
        /// </remarks>
        public static bool TrySplit(this Plane? plane, Shell? shell, out List<Shell>? result, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            result = null;

            if (plane == null || shell == null)
            {
                return false;
            }

            List<Face>? faces = shell.PolygonalFaces;
            if (faces == null || faces.Count == 0)
            {
                return false;
            }

            PlanarIntersectionResult? planarIntersectionResult = Geometry.Spatial.Create.PlanarIntersectionResult(plane, shell, tolerance);
            if (planarIntersectionResult == null || !planarIntersectionResult.Any() || planarIntersectionResult.GetGeometry3Ds<PolygonalFace3D>() is not List<PolygonalFace3D> polygonalFace3Ds_Plane || polygonalFace3Ds_Plane.Count == 0)
            {
                return false;
            }

            List<Face> faces_Split = [];
            for (int i = 0; i < faces.Count; i++)
            {
                Face face = faces[i];
                if (face == null)
                {
                    continue;
                }

                if (Geometry.Spatial.Query.TrySplit(plane, face, out List<PolygonalFace3D>? polygonalFace3Ds, tolerance) && polygonalFace3Ds != null && polygonalFace3Ds.Count != 0)
                {
                    IUniqueReference? uniqueReference_Face = face.UniqueReference;

                    for (int j = 0; j < polygonalFace3Ds.Count; j++)
                    {
                        faces_Split.Add(new Face(uniqueReference_Face, polygonalFace3Ds[j]));
                    }
                }
                else
                {
                    faces_Split.Add(face);
                }
            }

            if (!DiGi.Core.Query.Filter(faces_Split, x => Geometry.Spatial.Query.Above(plane, x?.GetBoundingBox()?.GetCentroid(), tolerance), out List<Face>? faces_Above, out List<Face>? faces_Below))
            {
                return false;
            }

            IUniqueReference? uniqueReference_Shell = shell.UniqueReference;

            List<Shell> CreateShells(List<Face>? faces_Input)
            {
                List<Shell> shells = [];

                if (faces_Input == null)
                {
                    return shells;
                }

                List<IPolygonalFace3D> polygonalFace3Ds_Input = [];
                for (int i = 0; i < faces_Input.Count; i++)
                {
                    polygonalFace3Ds_Input.Add(faces_Input[i]);
                }

                for (int i = 0; i < polygonalFace3Ds_Plane.Count; i++)
                {
                    polygonalFace3Ds_Input.Add(new Face(null, polygonalFace3Ds_Plane[i]));
                }

                while (polygonalFace3Ds_Input.Count > 0)
                {
                    IPolygonalFace3D polygonalFace3D = polygonalFace3Ds_Input[0];
                    polygonalFace3Ds_Input.RemoveAt(0);

                    if (!Geometry.Spatial.Query.TryGetConnectedPolygonalFace3Ds(polygonalFace3D, polygonalFace3Ds_Input, out List<IPolygonalFace3D>? polygonalFace3Ds_Connected, out List<IPolygonalFace3D>? polygonalFace3Ds_Disconnected, tolerance))
                    {
                        continue;
                    }

                    if (polygonalFace3Ds_Connected == null)
                    {
                        continue;
                    }

                    polygonalFace3Ds_Connected.Add(polygonalFace3D);

                    polygonalFace3Ds_Input = polygonalFace3Ds_Disconnected ?? [];

                    List<Face> faces_Shell = [];
                    for (int i = 0; i < polygonalFace3Ds_Connected.Count; i++)
                    {
                        if (polygonalFace3Ds_Connected[i] is Face face)
                        {
                            faces_Shell.Add(face);
                        }
                    }

                    if (faces_Shell.Count == 0)
                    {
                        continue;
                    }

                    Shell shell_Temp = new(uniqueReference_Shell, faces_Shell);
                    if (shell_Temp.Count == 0)
                    {
                        continue;
                    }

                    shells.Add(shell_Temp);
                }

                return shells;
            }

            result = [];

            result.AddRange(CreateShells(faces_Above));
            result.AddRange(CreateShells(faces_Below));

            return result.Count != 0;
        }

        /// <summary>
        /// Attempts to split a <see cref="Face"/> using the specified plane.
        /// <para>Each resulting <see cref="Face"/> inherits the <see cref="IUniqueReference"/> of the split <see cref="Face"/>.</para>
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used as the splitting surface.</param>
        /// <param name="face">The <see cref="Face"/> instance to be split.</param>
        /// <param name="result">When this method returns, contains a <see cref="List{Face}"/> of the resulting faces if the operation succeeded; otherwise, null.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for intersection calculations.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the split was successful.</returns>
        public static bool TrySplit(this Plane? plane, Face? face, out List<Face>? result, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            result = null;

            if (plane == null || face == null)
            {
                return false;
            }

            if (!Geometry.Spatial.Query.TrySplit(plane, face, out List<PolygonalFace3D>? polygonalFace3Ds, tolerance) || polygonalFace3Ds == null || polygonalFace3Ds.Count == 0)
            {
                return false;
            }

            IUniqueReference? uniqueReference = face.UniqueReference;

            result = [];
            for (int i = 0; i < polygonalFace3Ds.Count; i++)
            {
                result.Add(new Face(uniqueReference, polygonalFace3Ds[i]));
            }

            return result.Count != 0;
        }
    }
}
