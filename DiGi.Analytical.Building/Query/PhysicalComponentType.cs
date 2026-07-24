using DiGi.Analytical.Building.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Constants;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        /// <summary>
        /// Determines the <see cref="Enums.PhysicalComponentType"/> of the given <see cref="IComponent"/>.
        /// <para>Components already carrying a physical type are classified by their interface: an <see cref="IWall"/> gives <see cref="Enums.PhysicalComponentType.Wall"/>, an <see cref="IFloor"/> gives <see cref="Enums.PhysicalComponentType.Floor"/> and an <see cref="IRoof"/> gives <see cref="Enums.PhysicalComponentType.Roof"/>.</para>
        /// <para>An <see cref="IAir"/> carries no physical type, therefore it is classified geometrically: the normal of the plane of its <see cref="IFace3D"/> geometry is passed to <see cref="PhysicalComponentType(Vector3D, double)"/>. An air of any other geometry cannot be classified.</para>
        /// </summary>
        /// <param name="component">The component to be classified.</param>
        /// <param name="tolerance">The angle tolerance, in radians, within which the normal of an <see cref="IAir"/> still counts as horizontal, i.e. as belonging to a wall. Not used for components classified by their interface.</param>
        /// <returns>The <see cref="Enums.PhysicalComponentType"/> of the component, or <see cref="Enums.PhysicalComponentType.Undefined"/> when the component is null or cannot be classified.</returns>
        /// <seealso cref="Modify.ConvertAirs{TAir}(Classes.BuildingModel, System.Collections.Generic.IEnumerable{TAir}, System.Collections.Generic.IEnumerable{Enums.PhysicalComponentType}, double)"/>
        public static PhysicalComponentType PhysicalComponentType(this IComponent? component, double tolerance = Tolerance.Angle)
        {
            if(component is null)
            {
                return Enums.PhysicalComponentType.Undefined;
            }

            if(component is IWall)
            {
                return Enums.PhysicalComponentType.Wall;
            }

            if (component is IFloor)
            {
                return Enums.PhysicalComponentType.Floor;
            }

            if (component is IRoof)
            {
                return Enums.PhysicalComponentType.Roof;
            }

            if(component is IAir)
            {
                if(component.Geometry3D<IGeometry3D>() is not IGeometry3D geometry3D)
                {
                    return Enums.PhysicalComponentType.Undefined;
                }

                if(geometry3D is IFace3D face3D)
                {
                    return PhysicalComponentType(face3D.Plane?.Normal, tolerance);
                }
            }

            return Enums.PhysicalComponentType.Undefined;
        }

        /// <summary>
        /// Determines the <see cref="Enums.PhysicalComponentType"/> represented by the given normal.
        /// <para>The normal is normalized and its dot product with <see cref="Geometry.Spatial.Constants.Vector3D.WorldZ"/> is taken, which equals the sine of the tilt of the surface away from vertical. A normal lying within <paramref name="tolerance"/> of horizontal gives <see cref="Enums.PhysicalComponentType.Wall"/>, a normal pointing downwards gives <see cref="Enums.PhysicalComponentType.Floor"/> and a normal pointing upwards gives <see cref="Enums.PhysicalComponentType.Roof"/>.</para>
        /// </summary>
        /// <param name="normal">The normal of the surface to be classified.</param>
        /// <param name="tolerance">The angle tolerance, in radians, within which the normal still counts as horizontal, i.e. as belonging to a wall.</param>
        /// <returns>The <see cref="Enums.PhysicalComponentType"/> represented by the normal, or <see cref="Enums.PhysicalComponentType.Undefined"/> when the normal is null or has no unit vector.</returns>
        public static PhysicalComponentType PhysicalComponentType(this Vector3D? normal, double tolerance = Tolerance.Angle)
        {
            if(normal?.Unit is not Vector3D unit)
            {
                return Enums.PhysicalComponentType.Undefined;
            }

            double value = unit.DotProduct(Geometry.Spatial.Constants.Vector3D.WorldZ);
            if (System.Math.Abs(value) <= System.Math.Sin(tolerance))
            {
                return Enums.PhysicalComponentType.Wall;
            }

            if (value < 0)
            {
                return Enums.PhysicalComponentType.Floor;
            }

            return Enums.PhysicalComponentType.Roof;
        }
    }
}
