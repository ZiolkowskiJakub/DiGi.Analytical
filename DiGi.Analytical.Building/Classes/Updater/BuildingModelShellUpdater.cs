using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Writes a single analytical <see cref="Shell"/> back into a <see cref="BuildingModel"/> as a space bounded by components.
    /// <para>The <see cref="DiGi.Core.Interfaces.IUniqueReference"/> of the shell identifies the space it represents; when it cannot be resolved a new <see cref="Space"/> is created at the internal point of the shell. Every face of the shell is then turned into a component by <see cref="BuildingModelFaceUpdater"/> and assigned to that space.</para>
    /// <para>Faces sharing the same <see cref="Face.UniqueReference"/> originate from one component: the first of them keeps the identifier of that component, the remaining ones become additional components of the same type and construction.</para>
    /// </summary>
    /// <remarks>
    /// References are compared by value, not with the equality operators. Those operators are declared on <see cref="DiGi.Core.Classes.SerializableReference"/> and do not apply to <see cref="DiGi.Core.Interfaces.IUniqueReference"/> typed operands, while <see cref="Face.UniqueReference"/> returns a fresh clone on every call - comparing with == therefore never matches.
    /// </remarks>
    /// <seealso cref="BuildingModelShellsUpdater"/>
    /// <seealso cref="BuildingModelFaceUpdater"/>
    public class BuildingModelShellUpdater : BuildingModelUpdater
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModelShellUpdater"/> class.
        /// </summary>
        /// <param name="value">The building model to be updated in place.</param>
        public BuildingModelShellUpdater(BuildingModel value)
            : base(value)
        {
        }

        /// <summary>
        /// Gets or sets the shell to be written into the building model.
        /// <para>Its reference selects the space, its faces become the components bounding that space.</para>
        /// </summary>
        public Shell? Shell { get; set; }

        /// <summary>
        /// Gets or sets the distance tolerance used during the building model shell update process.
        /// <para>It is used to obtain the internal points of the shell and of its faces, and to decide whether a face matches a component already created for the same source component.</para>
        /// </summary>
        public double Tolerance { get; set; } = Core.Constants.Tolerance.Distance;

        /// <summary>
        /// Gets or sets the components created during the shell update process, grouped by the <see cref="IUniqueReference"/> of the component they originate from and keyed by the internal point of the face they were created from.
        /// <para>Sharing the same instance across several shells makes a component that bounds more than one space be created once and reused, instead of being duplicated for every shell. It also decides which fragment of a split component keeps the identifier of that component: the first one added for a given reference.</para>
        /// <para>Left null a private cache is created for the single shell, which is enough when the shells are updated one by one and none of their components is shared.</para>
        /// </summary>
        public Dictionary<IUniqueReference, List<Tuple<Point3D, IComponent>>>? UpdatedComponents { get; set; } = null;

        /// <summary>
        /// Gets or sets the spaces assigned to the components during the shell update process, keyed by the unique identifier of the component.
        /// <para>Sharing the same instance across several shells lets a component bounding two spaces keep both assignments, instead of the second shell overwriting the assignment made by the first one.</para>
        /// </summary>
        public Dictionary<Guid, List<ISpace>>? UpdatedComponentSpaces { get; set; } = null;

        /// <summary>
        /// Gets or sets the unique identifiers of the spaces that are rebuilt during the current update process.
        /// <para>Assignments of a component to any of those spaces are treated as outdated and are replaced by the assignments derived from the updated shells; assignments to spaces outside this set are preserved, which keeps neighbouring spaces that are not part of the update untouched.</para>
        /// <para>The set has to be complete BEFORE the first shell is processed, otherwise the outcome depends on the order the shells are updated in. <see cref="BuildingModelShellsUpdater"/> seeds it from all its shells upfront.</para>
        /// </summary>
        public HashSet<Guid>? ProcessedSpaceGuids { get; set; } = null;

        /// <summary>
        /// Writes <see cref="Shell"/> into the building model as a space bounded by components.
        /// </summary>
        /// <returns>True if the shell was written into the model; otherwise, false.</returns>
        public override bool Update()
        {
            return Update(out _);
        }

        /// <summary>
        /// Writes <see cref="Shell"/> into the building model as a space bounded by components and returns that space.
        /// <para>The space is taken from the model when the reference of the shell resolves to one, otherwise a new <see cref="Space"/> is created at the internal point of the shell. Components are created face by face, reusing the ones already created for the same source component, and are assigned to the space afterwards.</para>
        /// </summary>
        /// <param name="space">When this method returns, contains the <see cref="ISpace"/> the components were assigned to; otherwise, null.</param>
        /// <returns>True if the shell was written into the model; otherwise, false.</returns>
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

            UpdatedComponents ??= [];
            UpdatedComponentSpaces ??= [];
            ProcessedSpaceGuids ??= [];

            Guid guid = space.Guid;

            ProcessedSpaceGuids.Add(guid);

            while (faces.Count > 0)
            {
                Face? face = faces[0];
                IUniqueReference? uniqueReference = face?.UniqueReference;

                // References have to be compared by value, the equality operators are declared on SerializableReference and do not apply to IUniqueReference typed operands
                List<Face> faces_Temp = faces.FindAll(x => Core.Query.Equals(x?.UniqueReference, uniqueReference));
                faces.RemoveAll(faces_Temp.Contains);

                List<Tuple<Point3D, IComponent>>? tuples = null;

                if (uniqueReference is not null && !UpdatedComponents.TryGetValue(uniqueReference, out tuples))
                {
                    tuples = [];
                    UpdatedComponents[uniqueReference] = tuples;
                }

                for (int i = 0; i < faces_Temp.Count; i++)
                {
                    Face face_Temp = faces_Temp[i];
                    if (face_Temp is null)
                    {
                        continue;
                    }

                    Point3D? internalPoint = face_Temp.GetInternalPoint(Tolerance);

                    if (tuples is not null && internalPoint is not null)
                    {
                        Tuple<Point3D, IComponent>? tuple = tuples.Find(x => x.Item1.Distance(internalPoint) <= Tolerance);
                        if (tuple is not null)
                        {
                            components.Add(tuple.Item2);
                            continue;
                        }
                    }

                    // TODO: openings hosted by the updated component are not re-hosted onto the additional components created here
                    buildingModelFaceUpdater.Face = face_Temp;
                    buildingModelFaceUpdater.Guid = tuples is null || tuples.Count == 0 ? null : Guid.NewGuid();

                    if (!buildingModelFaceUpdater.Update(out IComponent? component) || component is null)
                    {
                        continue;
                    }

                    components.Add(component);

                    if (tuples is not null && internalPoint is not null)
                    {
                        tuples.Add(new Tuple<Point3D, IComponent>(internalPoint, component));
                    }
                }
            }

            foreach (IComponent component_Temp in components)
            {
                if (!UpdatedComponentSpaces.TryGetValue(component_Temp.Guid, out List<ISpace>? spaces_Component) || spaces_Component is null)
                {
                    spaces_Component = [];

                    List<ISpace>? spaces = Value.GetSpaces(component_Temp);
                    if (spaces is not null)
                    {
                        foreach (ISpace space_Temp in spaces)
                        {
                            if (ProcessedSpaceGuids.Contains(space_Temp.Guid))
                            {
                                continue;
                            }

                            spaces_Component.Add(space_Temp);
                        }
                    }

                    UpdatedComponentSpaces[component_Temp.Guid] = spaces_Component;
                }

                if (spaces_Component.Find(x => x.Guid == guid) is null)
                {
                    spaces_Component.Add(space);
                }

                if (spaces_Component.Count == 1)
                {
                    Value.Assign(component_Temp, spaces_Component[0]);
                }
                else if (spaces_Component.Count > 1)
                {
                    Value.Assign(component_Temp, spaces_Component[0], spaces_Component[1]);
                }
            }

            return space != null;
        }
    }
}