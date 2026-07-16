using DiGi.Analytical.Delegates;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Provides functionality to split a shell using a specified plane as the cutting surface.
    /// </summary>
    public class ShellByPlaneSplitSolver : ShellSplitSolver
    {
        private Plane? plane;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellByPlaneSplitSolver"/> class.
        /// </summary>
        /// <param name="tolerance">The distance tolerance used for geometric operations during the splitting process.</param>
        public ShellByPlaneSplitSolver(double tolerance = Core.Constants.Tolerance.Distance)
            : base(tolerance)
        {
        }

        /// <summary>
        /// Occurs when a face split is performed during the shell splitting process.
        /// </summary>
        public event FaceSplitEventHandler? FaceSplit;

        /// <summary>
        /// Occurs when a shell split is completed during the solving process.
        /// </summary>
        public event ShellSplitEventHandler? ShellSplit;

        /// <summary>
        /// Gets or sets the <see cref="Plane" /> used to split the shell.
        /// </summary>
        /// <value>
        /// The <see cref="Plane" /> instance, or <c>null</c> if no plane is defined.
        /// </value>
        public Plane? Plane
        {
            get
            {
                return Core.Query.Clone(plane);
            }

            set
            {
                plane = Core.Query.Clone(value);
            }
        }

        /// <summary>
        /// Splits the shell using the specified plane.
        /// </summary>
        /// <returns>A <see cref="System.Boolean" /> value indicating whether the splitting operation was successful.</returns>
        public override bool Solve()
        {
            outputs = null;

            if (!Geometry.Spatial.Query.TrySplit(plane, input, out List<Polyhedron>? polyhedrons, Tolerance) || polyhedrons is null || polyhedrons.Count < 1)
            {
                return false;
            }

            if (input?.PolygonalFaces is not List<Face> faces)
            {
                return false;
            }

            List<List<IPolygonalFace3D>?> polygonalFace3Ds = [];
            foreach (Polyhedron polyhedron in polyhedrons)
            {
                List<IPolygonalFace3D>? polygonalFace3Ds_Polyhedron = polyhedron.PolygonalFaces;

                if (polygonalFace3Ds_Polyhedron is not null)
                {
                    foreach (IPolygonalFace3D polygonalFace3D in polygonalFace3Ds_Polyhedron)
                    {
                        if (polygonalFace3D is not Face face)
                        {
                            continue;
                        }

                        int index = faces.FindIndex(x => x.UniqueReference == face.UniqueReference);
                        if (index == -1)
                        {
                            continue;
                        }

                        faces.RemoveAt(index);
                    }
                }

                polygonalFace3Ds.Add(polygonalFace3Ds_Polyhedron);
            }

            List<Tuple<BoundingBox3D, Face>> tuples = [];
            foreach (Face face in faces)
            {
                if (face?.GetBoundingBox() is not BoundingBox3D boundingBox3D)
                {
                    continue;
                }

                tuples.Add(new Tuple<BoundingBox3D, Face>(boundingBox3D, face));
            }

            outputs = [];

            void faceSplit(object s, FaceSplitEventArgs e) { e.UniqueReference = e.Input?.UniqueReference; e.Handled = true; }

            void shellSplit(object s, ShellSplitEventArgs e) { e.UniqueReference = e.Input?.UniqueReference; e.Handled = true; }

            for (int i = 0; i < polygonalFace3Ds.Count; i++)
            {
                List<IPolygonalFace3D>? polygonalFace3Ds_Shell = polygonalFace3Ds[i];
                if (polygonalFace3Ds_Shell is null)
                {
                    continue;
                }

                List<Face> faces_Shell = [];
                foreach (IPolygonalFace3D polygonalFace3D in polygonalFace3Ds_Shell)
                {
                    if (polygonalFace3D is Face face)
                    {
                        faces_Shell.Add(face);
                        continue;
                    }

                    if (polygonalFace3D is not PolygonalFace3D polygonalFace3D_Temp)
                    {
                        throw new NotImplementedException();
                    }

                    if (polygonalFace3D_Temp.GetInternalPoint(Tolerance) is not Point3D internalPoint)
                    {
                        continue;
                    }

                    Face? closestFace = null;

                    List<Tuple<BoundingBox3D, Face>> tuples_Temp = tuples.FindAll(x => x.Item1.InRange(internalPoint, Tolerance));
                    if (tuples_Temp.Count == 1)
                    {
                        closestFace = tuples_Temp[0].Item2;
                    }
                    else if (tuples_Temp.Count > 1)
                    {
                        Geometry.Spatial.Query.ClosestPoint(internalPoint, tuples_Temp.ConvertAll(x => x.Item2), out closestFace, out _, Tolerance);
                    }

                    FaceSplitEventArgs faceSplitEventArgs = new(closestFace, polygonalFace3D_Temp);

                    FaceSplit?.Invoke(this, faceSplitEventArgs);

                    if (!faceSplitEventArgs.Handled)
                    {
                        faceSplit(this, faceSplitEventArgs);
                    }

                    Face face_Shell = new(faceSplitEventArgs.UniqueReference, polygonalFace3D_Temp);

                    if (closestFace is null && face_Shell.GetBoundingBox() is BoundingBox3D boundingBox)
                    {
                        tuples.Add(new Tuple<BoundingBox3D, Face>(boundingBox, face_Shell));
                    }

                    faces_Shell.Add(face_Shell);
                }

                if (faces_Shell.Count == 0)
                {
                    continue;
                }

                ShellSplitEventArgs shellSplitEventArgs = new(input, polyhedrons[i]);
                ShellSplit?.Invoke(this, shellSplitEventArgs);

                if (!shellSplitEventArgs.Handled)
                {
                    shellSplit(this, shellSplitEventArgs);
                }

                outputs.Add(new Shell(shellSplitEventArgs.UniqueReference, faces_Shell));
            }

            return true;
        }
    }
}