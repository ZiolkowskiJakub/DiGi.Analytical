using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.PointCloud.Spatial.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a terrain element that is defined by a 3D point cloud, such as a surveyed ground surface.
    /// </summary>
    public class PointCloudTerrain : Terrain<PointCloud3D>, IPointCloudTerrain
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PointCloudTerrain"/> class using the specified point cloud.
        /// </summary>
        /// <param name="pointCloud3D">The point cloud to be used as the terrain geometry.</param>
        public PointCloudTerrain(PointCloud3D? pointCloud3D)
            : base(pointCloud3D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointCloudTerrain"/> class using the specified <see cref="PointCloudTerrain"/> instance.
        /// </summary>
        /// <param name="pointCloudTerrain">The <see cref="PointCloudTerrain"/> instance to copy from.</param>
        public PointCloudTerrain(PointCloudTerrain? pointCloudTerrain)
            : base(pointCloudTerrain)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointCloudTerrain"/> class with a specified unique identifier and an optional source point cloud terrain.
        /// </summary>
        /// <param name="guid">The unique identifier for the object.</param>
        /// <param name="pointCloudTerrain">An optional existing <see cref="PointCloudTerrain"/> instance to initialize from.</param>
        public PointCloudTerrain(System.Guid guid, PointCloudTerrain? pointCloudTerrain)
            : base(guid, pointCloudTerrain)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointCloudTerrain"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public PointCloudTerrain(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}
