using System.ComponentModel;

namespace DiGi.Analytical.Building.Enums
{
    /// <summary>
    /// Specifies the kind of physical building component an element represents or is to be converted into.
    /// <para>The value drives the class created by <see cref="Classes.BuildingModel.ConvertAir(Interfaces.IAir, PhysicalComponentType, out Interfaces.IPhysicalComponent)"/>.</para>
    /// </summary>
    [Description("Physical component type")]
    public enum PhysicalComponentType
    {
        /// <summary>
        /// The physical component type could not be determined. No conversion is performed for this value.
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// A vertical component, i.e. one whose normal is roughly perpendicular to the world Z axis. Converts into a <see cref="Classes.SurfaceWall"/>.
        /// </summary>
        [Description("Wall")] Wall,

        /// <summary>
        /// A horizontal component facing upwards. Converts into a <see cref="Classes.SurfaceRoof"/>.
        /// </summary>
        [Description("Roof")] Roof,

        /// <summary>
        /// A horizontal component facing downwards. Converts into a <see cref="Classes.FaceFloor"/>.
        /// </summary>
        [Description("Floor")] Floor
    }
}
