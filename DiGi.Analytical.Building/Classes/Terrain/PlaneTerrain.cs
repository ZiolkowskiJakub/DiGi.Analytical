using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a terrain element that is defined by an infinite plane.
    /// </summary>
    public class PlaneTerrain : Terrain<Plane>, IPlaneTerrain
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaneTerrain"/> class using the specified plane.
        /// </summary>
        /// <param name="plane">The plane to be used as the terrain geometry.</param>
        public PlaneTerrain(Plane? plane)
            : base(plane)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaneTerrain"/> class using the specified <see cref="PlaneTerrain"/> instance.
        /// </summary>
        /// <param name="planeTerrain">The <see cref="PlaneTerrain"/> instance to copy from.</param>
        public PlaneTerrain(PlaneTerrain? planeTerrain)
            : base(planeTerrain)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaneTerrain"/> class with a specified unique identifier and an optional source plane terrain.
        /// </summary>
        /// <param name="guid">The unique identifier for the object.</param>
        /// <param name="planeTerrain">An optional existing <see cref="PlaneTerrain"/> instance to initialize from.</param>
        public PlaneTerrain(System.Guid guid, PlaneTerrain? planeTerrain)
            : base(guid, planeTerrain)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaneTerrain"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public PlaneTerrain(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}
