using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Classes
{
    public class BuildingModelShellUpdater : BuildingModelUpdater
    {
        public double Tolerance { get; set; } = Core.Constans.Tolerance.Distance;
        
        public Shell? Shell { get; set; }

        public string? Name { get; set; }

        public BuildingModelShellUpdater(BuildingModel value)
            :base(value)
        {

        }

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

                space = new Space(internalPoint, Name);
            }

            BuildingModelFaceUpdater buildingModelFaceUpdater = new(Value);

            List<IComponent> components = [];

            while (faces.Count > 0)
            {
                List<Face> faces_Temp = faces.FindAll(x => x.UniqueReference == faces[0].UniqueReference);
                faces.RemoveAll(faces_Temp.Contains);

                buildingModelFaceUpdater.Face = faces_Temp[0];
                if (buildingModelFaceUpdater.Update(out IComponent? component) && component != null)
                {
                    components.Add(component);
                }

                for (int i = 1; i < faces_Temp.Count; i++)
                {
                    PolygonalFace3D? polygonalFace3D = Geometry.Spatial.Create.PolygonalFace3D(faces_Temp[i]);
                    if (polygonalFace3D is null)
                    {
                        continue;
                    }

                    Face face = new(null, polygonalFace3D);

                    buildingModelFaceUpdater.Face = face;
                    if (buildingModelFaceUpdater.Update(out component) && component != null)
                    {
                        components.Add(component);
                    }
                }
            }

            System.Guid guid = space.Guid;

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
