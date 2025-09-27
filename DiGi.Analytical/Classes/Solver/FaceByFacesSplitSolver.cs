using DiGi.Analytical.Delegates;
using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.Analytical.Classes
{
    public class FaceByFacesSplitSolver : FaceSplitSolver
    {
        private List<Face>? faces;

        public FaceByFacesSplitSolver(double tolerance = Core.Constans.Tolerance.Distance)
            : base(tolerance)
        {

        }

        public event CoplanarFaceSplitEventHandler? CoplanarFaceSplit;

        public event NonCoplanarFaceSplitEventHandler? NonCoplanarFaceSplit;
        
        public List<Face>? Faces
        {
            get
            {
                return Core.Query.Clone(outputs)?.FilterNulls();
            }

            set
            {
                faces = Core.Query.Clone(value)?.FilterNulls();
            }
        }
        
        public override bool Solve()
        {
            outputs = null;

            if (faces is null)
            {
                return false;
            }

            if (input?.GetBoundingBox() is not BoundingBox3D boundingBox)
            {
                return false;
            }

            if (input.Plane is not Plane plane)
            {
                return false;
            }

            List<Tuple<BoundingBox3D, Face>> tuples = [];
            foreach (Face face_Temp in faces)
            {
                if (face_Temp?.GetBoundingBox() is not BoundingBox3D boundingBox_Temp)
                {
                    continue;
                }

                if (!boundingBox.InRange(boundingBox_Temp, Tolerance))
                {
                    continue;
                }

                tuples.Add(new Tuple<BoundingBox3D, Face>(boundingBox_Temp, face_Temp));
            }

            if (tuples.Count == 0)
            {
                return false;
            }

            if (!Geometry.Spatial.Query.TrySplit(input, tuples.ConvertAll(x => x.Item2), out List<PolygonalFace3D>? polygonalFace3Ds) || polygonalFace3Ds is null || polygonalFace3Ds.Count == 0)
            {
                return false;
            }

            outputs = [];

            void nonCoplanarFaceSplit(object s, NonCoplanarFaceSplitEventArgs e) { e.UniqueReference = e.Input?.UniqueReference; e.Handled = true; }

            List<Tuple<BoundingBox3D, Face>> tuples_Coplanar = tuples.FindAll(x => plane.Coplanar(x.Item2.Plane, Tolerance));
            if (tuples_Coplanar.Count == 0)
            {
                foreach(PolygonalFace3D polygonalFace3D in polygonalFace3Ds)
                {
                    NonCoplanarFaceSplitEventArgs nonCoplanarFaceSplitEventArgs = new(input, polygonalFace3D);

                    NonCoplanarFaceSplit?.Invoke(this, nonCoplanarFaceSplitEventArgs);

                    if(!nonCoplanarFaceSplitEventArgs.Handled)
                    {
                        nonCoplanarFaceSplit(this, nonCoplanarFaceSplitEventArgs);
                    }

                    outputs.Add(new Face(nonCoplanarFaceSplitEventArgs.UniqueReference, polygonalFace3D));
                }

                return outputs.Count != 0;
            }

            void coplanarFaceSplit(object s, CoplanarFaceSplitEventArgs e) { e.UniqueReference = e.Input?.UniqueReference; e.Handled = true; }

            foreach (PolygonalFace3D polygonalFace3D in polygonalFace3Ds)
            {
                if (polygonalFace3D.GetInternalPoint(Tolerance) is not Point3D internalPoint)
                {
                    continue;
                }

                List<Face> faces_Coplanar = tuples_Coplanar.FindAll(x => x.Item1.InRange(internalPoint, Tolerance) && x.Item2.InRange(internalPoint, Tolerance)).ConvertAll(x => x.Item2);
                if (tuples_Coplanar.Count == 0)
                {
                    NonCoplanarFaceSplitEventArgs nonCoplanarFaceSplitEventArgs = new(input, polygonalFace3D);

                    NonCoplanarFaceSplit?.Invoke(this, nonCoplanarFaceSplitEventArgs);

                    if (!nonCoplanarFaceSplitEventArgs.Handled)
                    {
                        nonCoplanarFaceSplit(this, nonCoplanarFaceSplitEventArgs);
                    }

                    outputs.Add(new Face(nonCoplanarFaceSplitEventArgs.UniqueReference, polygonalFace3D));
                    continue;
                }

                CoplanarFaceSplitEventArgs coplanarFaceSplitEventArgs = new (input, faces_Coplanar, polygonalFace3D);
                CoplanarFaceSplit?.Invoke(this, coplanarFaceSplitEventArgs);

                if (!coplanarFaceSplitEventArgs.Handled)
                {
                    coplanarFaceSplit(this, coplanarFaceSplitEventArgs);
                }

                outputs.Add(new Face(coplanarFaceSplitEventArgs.UniqueReference, polygonalFace3D));
                continue;

            }

            return outputs.Count != 0;
        }
    }
}
