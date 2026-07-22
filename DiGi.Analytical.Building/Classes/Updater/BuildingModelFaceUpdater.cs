using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Writes a single analytical <see cref="Face"/> back into a <see cref="BuildingModel"/> as a component.
    /// <para>The <see cref="DiGi.Core.Interfaces.IUniqueReference"/> of the face, when it is a <see cref="GuidReference"/>, identifies the component the face originates from. That component is rebuilt with the geometry of the face, keeping its type, its construction and the spaces it is assigned to. A face without a resolvable reference becomes a new <see cref="SurfaceAir"/>.</para>
    /// <para>The type of the rebuilt component follows the type of the source component: <see cref="IWall"/> becomes a <see cref="SurfaceWall"/>, <see cref="IFloor"/> a <see cref="FaceFloor"/>, <see cref="IRoof"/> a <see cref="SurfaceRoof"/> and <see cref="IAir"/> a <see cref="SurfaceAir"/>.</para>
    /// </summary>
    /// <remarks>
    /// Openings (windows and doors) hosted by the source component are NOT re-hosted by this updater. When a component is rebuilt as several components, its openings stay assigned to the one keeping the identifier of the source component. Re-hosting requires a public counterpart of the currently private BuildingModel.Assign(IComponent, IOpening) method.
    /// </remarks>
    /// <seealso cref="BuildingModelShellUpdater"/>
    public class BuildingModelFaceUpdater : BuildingModelUpdater
    {
        /// <summary>
        /// Gets or sets the face the component is created from.
        /// <para>Its <see cref="Face.UniqueReference"/> selects the source component, its geometry becomes the geometry of the created component.</para>
        /// </summary>
        public Face? Face { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier to be assigned to the updated component.
        /// <para>When null the created component keeps the identifier of the component referenced by <see cref="Face"/> and therefore REPLACES it in the model. When set the component is stored under the given identifier as an additional component, keeping the type and the construction of the source component.</para>
        /// <para>Use a fresh identifier for every face beyond the first one when a single source component was split into several faces, so that the fragments do not overwrite each other.</para>
        /// </summary>
        public System.Guid? Guid { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModelFaceUpdater"/> class.
        /// </summary>
        /// <param name="value">The building model associated with this updater.</param>
        public BuildingModelFaceUpdater(BuildingModel? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModelFaceUpdater"/> class with the specified building model and face.
        /// </summary>
        /// <param name="value">The building model to be updated in place.</param>
        /// <param name="Face">The face the component is created from.</param>
        public BuildingModelFaceUpdater(BuildingModel? value, Face? Face)
            : base(value)
        {
            this.Face = Face;
        }

        /// <summary>
        /// Creates or rebuilds the component represented by <see cref="Face"/> and stores it in the building model.
        /// </summary>
        /// <returns>True if a component was created or rebuilt; otherwise, false.</returns>
        public override bool Update()
        {
            return Update(out _);
        }

        /// <summary>
        /// Creates or rebuilds the component represented by <see cref="Face"/>, stores it in the building model and returns it.
        /// <para>The component is stored together with the construction and the space assignments of its source component. When <see cref="Guid"/> is null the source component is replaced, otherwise an additional component is created.</para>
        /// </summary>
        /// <param name="component">When this method returns, contains the created or rebuilt <see cref="IComponent"/>; otherwise, null.</param>
        /// <returns>True if a component was created or rebuilt; otherwise, false.</returns>
        public bool Update(out IComponent? component)
        {
            component = null;

            if (Face is null || Value is null)
            {
                return false;
            }

            IComponent? component_Existing = Value.GetObject<IComponent>(Face.UniqueReference as GuidReference);
            if (component_Existing is IWall wall)
            {
                component = Update_Wall(wall);
            }
            else if (component_Existing is IFloor floor)
            {
                component = Update_Floor(floor);
            }
            else if (component_Existing is IRoof roof)
            {
                component = Update_Roof(roof);
            }
            else if (component_Existing is IAir air)
            {
                component = Update_Air(air);
            }
            else
            {
                component = Update_Air();
            }

            return component != null;
        }

        private IComponent? Update_Air(IAir? air = null)
        {
            if (Value is null)
            {
                return null;
            }

            Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D = Geometry.Spatial.Create.PolygonalFace3D(Face);
            if (polygonalFace3D is null)
            {
                return null;
            }

            List<ISpace>? spaces = null;
            SurfaceAir? surfaceAir;

            if (air != null)
            {
                spaces = Value.GetSpaces(air);
                surfaceAir = new(air, polygonalFace3D);

                if (surfaceAir.Guid != air.Guid)
                {
                    throw new System.NotImplementedException();
                }
            }
            else
            {
                surfaceAir = new(polygonalFace3D);
            }

            if (Guid is System.Guid guid)
            {
                surfaceAir = new(guid, surfaceAir);
            }

            if (!Value.Update(surfaceAir))
            {
                return null;
            }

            if (spaces != null && spaces.Count != 0)
            {
                if (spaces.Count == 1)
                {
                    Value.Assign(surfaceAir, spaces[0]);
                }
                else
                {
                    Value.Assign(surfaceAir, spaces[0], spaces[1]);
                }
            }

            return surfaceAir;
        }

        private IComponent? Update_Floor(IFloor? floor)
        {
            if (Value is null)
            {
                return null;
            }

            Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D = Geometry.Spatial.Create.PolygonalFace3D(Face);
            if (polygonalFace3D is null)
            {
                return null;
            }

            List<ISpace>? spaces = null;
            IFloorConstruction? floorConstruction = null;
            FaceFloor? faceFloor;

            if (floor != null)
            {
                spaces = Value.GetSpaces(floor);
                floorConstruction = Value.GetFloorConstruction(floor);
                faceFloor = new(floor, polygonalFace3D);

                if (faceFloor.Guid != floor.Guid)
                {
                    throw new System.NotImplementedException();
                }
            }
            else
            {
                faceFloor = new(polygonalFace3D);
            }

            if (Guid is System.Guid guid)
            {
                faceFloor = new(guid, faceFloor);
            }

            if (!Value.Update(faceFloor))
            {
                return null;
            }

            if (floorConstruction is not null)
            {
                Value.Assign(faceFloor, floorConstruction);
            }

            if (spaces != null && spaces.Count != 0)
            {
                if (spaces.Count == 1)
                {
                    Value.Assign(faceFloor, spaces[0]);
                }
                else
                {
                    Value.Assign(faceFloor, spaces[0], spaces[1]);
                }
            }

            return faceFloor;
        }

        private IComponent? Update_Roof(IRoof? roof)
        {
            if (Value is null)
            {
                return null;
            }

            Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D = Geometry.Spatial.Create.PolygonalFace3D(Face);
            if (polygonalFace3D is null)
            {
                return null;
            }

            List<ISpace>? spaces = null;
            IRoofConstruction? roofConstruction = null;
            SurfaceRoof? surfaceRoof;

            if (roof != null)
            {
                spaces = Value.GetSpaces(roof);
                roofConstruction = Value.GetRoofConstruction(roof);
                surfaceRoof = new(roof, polygonalFace3D);

                if (surfaceRoof.Guid != roof.Guid)
                {
                    throw new System.NotImplementedException();
                }
            }
            else
            {
                surfaceRoof = new(polygonalFace3D);
            }

            if (Guid is System.Guid guid)
            {
                surfaceRoof = new(guid, surfaceRoof);
            }

            if (!Value.Update(surfaceRoof))
            {
                return null;
            }

            if (roofConstruction is not null)
            {
                Value.Assign(surfaceRoof, roofConstruction);
            }

            if (spaces != null && spaces.Count != 0)
            {
                if (spaces.Count == 1)
                {
                    Value.Assign(surfaceRoof, spaces[0]);
                }
                else
                {
                    Value.Assign(surfaceRoof, spaces[0], spaces[1]);
                }
            }

            return surfaceRoof;
        }

        private IComponent? Update_Wall(IWall? wall)
        {
            if (Value is null)
            {
                return null;
            }

            Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D = Geometry.Spatial.Create.PolygonalFace3D(Face);
            if (polygonalFace3D is null)
            {
                return null;
            }

            List<ISpace>? spaces = null;
            IWallConstruction? wallConstruction = null;
            SurfaceWall? surfaceWall;

            if (wall != null)
            {
                spaces = Value.GetSpaces(wall);
                wallConstruction = Value.GetWallConstruction(wall);
                surfaceWall = new(wall, polygonalFace3D);

                if (surfaceWall.Guid != wall.Guid)
                {
                    throw new System.NotImplementedException();
                }
            }
            else
            {
                surfaceWall = new(polygonalFace3D);
            }

            if (Guid is System.Guid guid)
            {
                surfaceWall = new(guid, surfaceWall);
            }

            if (!Value.Update(surfaceWall))
            {
                return null;
            }

            if (wallConstruction is not null)
            {
                Value.Assign(surfaceWall, wallConstruction);
            }

            if (spaces != null && spaces.Count != 0)
            {
                if (spaces.Count == 1)
                {
                    Value.Assign(surfaceWall, spaces[0]);
                }
                else
                {
                    Value.Assign(surfaceWall, spaces[0], spaces[1]);
                }
            }

            return surfaceWall;
        }
    }
}