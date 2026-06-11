using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Provides functionality to update a <see cref="BuildingModel"/> specifically associated with a <see cref="Face"/>.
    /// </summary>
    public class BuildingModelFaceUpdater : BuildingModelUpdater
    {
        /// <summary>
        /// Gets or sets the face used for updating the building model.
        /// </summary>
        public Face? Face { get; set; }

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
        /// <param name="value">The building model to be updated.</param>
        /// <param name="Face">The face associated with the update operation.</param>
        public BuildingModelFaceUpdater(BuildingModel? value, Face? Face)
            : base(value)
        {
            this.Face = Face;
        }

        /// <summary>
        /// Performs the update operation for the building model face.
        /// </summary>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        public override bool Update()
        {
            return Update(out _);
        }

        /// <summary>
        /// Performs an update operation on the building model face and retrieves the updated component.
        /// </summary>
        /// <param name="component">When this method returns, contains the <see cref="IComponent"/> that was updated; otherwise, null.</param>
        /// <returns>True if any changes were made or the update was successful; otherwise, false.</returns>
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