using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Classes
{
    public class BuildingModelShellUpdater : BuildingModelUpdater
    {
        public BuildingModelShellUpdater(BuildingModel value)
            : base(value)
        {
        }

        public Shell? Shell { get; set; }

        public double Tolerance { get; set; } = Core.Constants.Tolerance.Distance;

        public HashSet<IUniqueReference>? UpdatedComponentUniqueReferences { get; set; } = null;

        public override bool Update()
        {
            return Update(out _);
        }

        public bool Update(out ISpace? space)
        {
            space = null;

            if (Value is null)
            {
                return false;
            }

            if (Shell?.PolygonalFaces is not List<Face> faces)
            {
                return false;
            }

            space = Value.GetObject<ISpace>(Shell.UniqueReference as GuidReference);
            if (space is null)
            {
                if (Shell.GetInternalPoint(Tolerance) is not Point3D internalPoint)
                {
                    return false;
                }

                space = new Space(internalPoint, null);
            }

            BuildingModelFaceUpdater buildingModelFaceUpdater = new(Value);

            List<IComponent> components = [];

            UpdatedComponentUniqueReferences ??= [];

            while (faces.Count > 0)
            {
                Face? face = faces[0];
                IUniqueReference? uniqueReference = face?.UniqueReference;

                List<Face> faces_Temp = faces.FindAll(x => x?.UniqueReference == uniqueReference);
                faces.RemoveAll(faces_Temp.Contains);

                int startIndex = 0;

                if (uniqueReference is null || !UpdatedComponentUniqueReferences.Contains(uniqueReference))
                {
                    buildingModelFaceUpdater.Face = face;
                    if (buildingModelFaceUpdater.Update(out IComponent? component) && component != null)
                    {
                        components.Add(component);
                    }

                    startIndex = 1;

                    if (uniqueReference is not null)
                    {
                        UpdatedComponentUniqueReferences.Add(uniqueReference);
                    }
                }

                for (int i = startIndex; i < faces_Temp.Count; i++)
                {
                    PolygonalFace3D? polygonalFace3D = Geometry.Spatial.Create.PolygonalFace3D(faces_Temp[i]);
                    if (polygonalFace3D is null)
                    {
                        continue;
                    }

                    face = new(null, polygonalFace3D);

                    buildingModelFaceUpdater.Face = face;
                    if (buildingModelFaceUpdater.Update(out IComponent? component) && component != null)
                    {
                        components.Add(component);
                    }
                }
            }

            Guid guid = space.Guid;

            foreach (IComponent component_Temp in components)
            {
                List<ISpace>? spaces = Value.GetSpaces(component_Temp);
                if (spaces == null || spaces.Count == 0)
                {
                    Value.Assign(component_Temp, space);
                    continue;
                }

                if (spaces.Find(x => x.Guid == guid) != null)
                {
                    continue;
                }

                Value.Assign(component_Temp, spaces[0], space);
            }

            return space != null;
        }
    }
}