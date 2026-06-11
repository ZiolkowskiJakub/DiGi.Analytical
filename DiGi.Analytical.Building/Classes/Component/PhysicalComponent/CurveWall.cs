using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a wall defined by a curved geometry.
    /// </summary>
    /// <typeparam name="TCurve3D">The type of the 3D curve used to define the wall's path, which must implement <see cref="ICurve3D"/>.</typeparam>
    public class CurveWall<TCurve3D> : Wall<TCurve3D>, ICurveWall<TCurve3D> where TCurve3D : ICurve3D
    {
        [JsonInclude, JsonPropertyName("Vector"), Description("Vector")]
        private readonly Vector3D? vector;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurveWall{TCurve3D}"/> class.
        /// </summary>
        /// <param name="curve3D">The base 3D curve defining the wall path.</param>
        /// <param name="height">The height of the wall as a double.</param>
        /// <param name="direction">The <see cref="Vector3D"/> direction vector used to determine the orientation and extrusion of the wall.</param>
        public CurveWall(TCurve3D? curve3D, double height, Vector3D? direction)
                    : base(curve3D)
        {
            vector = direction?.Unit * height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurveWall{TCurve3D}"/> class using the specified curve and height, with the direction defaulting to the world Z-axis.
        /// </summary>
        /// <param name="curve3D">The 3D curve that defines the base of the wall.</param>
        /// <param name="height">The height of the wall.</param>
        public CurveWall(TCurve3D? curve3D, double height)
            : base(curve3D)
        {
            vector = DiGi.Geometry.Spatial.Constants.Vector3D.WorldZ * height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurveWall{TCurve3D}"/> class by copying an existing instance.
        /// </summary>
        /// <param name="curveWall">The source <see cref="CurveWall{TCurve3D}"/> instance from which to copy properties.</param>
        public CurveWall(CurveWall<TCurve3D>? curveWall)
            : base(curveWall)
        {
            if (curveWall != null)
            {
                vector = curveWall.vector == null ? null : new Vector3D(curveWall.vector);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurveWall{TCurve3D}"/> class using a unique identifier and an existing curve wall instance.
        /// </summary>
        /// <param name="guid">The unique identifier for the object.</param>
        /// <param name="curveWall">The existing <see cref="CurveWall{TCurve3D}"/> instance to copy properties from.</param>
        public CurveWall(System.Guid guid, CurveWall<TCurve3D>? curveWall)
            : base(guid, curveWall)
        {
            if (curveWall != null)
            {
                vector = Core.Query.Clone(curveWall.vector);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurveWall{TCurve3D}"/> class using an existing wall, a base curve, a height, and a specific direction vector.
        /// </summary>
        /// <param name="wall">The <see cref="IWall"/> to use as a basis for initialization.</param>
        /// <param name="curve3D">The base 3D curve defining the wall path.</param>
        /// <param name="height">The height of the wall.</param>
        /// <param name="direction">The <see cref="Vector3D"/> defining the direction in which the wall extends from its base curve.</param>
        public CurveWall(IWall wall, TCurve3D? curve3D, double height, Vector3D? direction)
            : base(wall, curve3D)
        {
            vector = direction?.Unit * height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurveWall{TCurve3D}"/> class using an existing wall, a 3D curve, and a specified height, with the direction defaulting to World Z.
        /// </summary>
        /// <param name="wall">The base wall object used for initialization.</param>
        /// <param name="curve3D">The 3D curve defining the geometry of the curved wall.</param>
        /// <param name="height">The height of the wall along the World Z axis.</param>
        public CurveWall(IWall wall, TCurve3D? curve3D, double height)
            : base(wall, curve3D)
        {
            vector = DiGi.Geometry.Spatial.Constants.Vector3D.WorldZ * height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurveWall{TCurve3D}"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the instance.</param>
        public CurveWall(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the <see cref="Vector3D"/> that defines the direction and magnitude of the curved wall's extrusion.
        /// </summary>
        [JsonIgnore]
        public Vector3D? Vector
        {
            get
            {
                return vector == null ? null : new Vector3D(vector);
            }

            set
            {
                Vector = value;
            }
        }

        /// <summary>
        /// Gets the axis-aligned bounding box of the curved wall.
        /// </summary>
        /// <returns>The <see cref="BoundingBox3D"/> encompassing the curved wall, or null if it cannot be determined.</returns>
        public override BoundingBox3D? GetBoundingBox()
        {
            return GetSurface3D()?.GetBoundingBox();
        }

        /// <summary>
        /// Retrieves the 3D surface representation of the curved wall.
        /// </summary>
        /// <returns>The <see cref="ISurface3D"/> representing the wall's surface if it can be determined; otherwise, <c>null</c>.</returns>
        public ISurface3D? GetSurface3D()
        {
            if (vector == null)
            {
                return null;
            }

            ICurve3D? curve3D = Geometry;
            if (curve3D == null)
            {
                return null;
            }

            if (curve3D is not Segment3D segment3D)
            {
                throw new System.NotImplementedException();
            }

            if (segment3D.Start is not Point3D point3D_1)
            {
                return null;
            }

            if (segment3D.End is not Point3D point3D_2)
            {
                return null;
            }

            if (segment3D.End.GetMoved(vector) is not Point3D point3D_3)
            {
                return null;
            }

            if (segment3D.Start.GetMoved(vector) is not Point3D point3D_4)
            {
                return null;
            }

            Plane plane = new(point3D_1, point3D_2, point3D_3);

            return new PolygonalFace3D(plane, DiGi.Geometry.Planar.Create.PolygonalFace2D(new Polygon2D([plane.Convert(point3D_1)!, plane.Convert(point3D_2)!, plane.Convert(point3D_3)!, plane.Convert(point3D_4)!])));
        }
    }

    /// <summary>
    /// Represents a wall defined by a 3D curve.
    /// </summary>
    public class CurveWall : CurveWall<ICurve3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurveWall"/> class.
        /// </summary>
        /// <param name="curve3D">The <see cref="ICurve3D"/> that defines the base path of the curved wall.</param>
        /// <param name="height">The height of the curved wall.</param>
        /// <param name="direction">The <see cref="Vector3D"/> representing the direction of the curved wall.</param>
        public CurveWall(ICurve3D? curve3D, double height, Vector3D? direction)
            : base(curve3D, height, direction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurveWall"/> class with the specified curve and height.
        /// </summary>
        /// <param name="curve3D">The 3D curve that defines the base path of the wall.</param>
        /// <param name="height">The height of the wall.</param>
        public CurveWall(ICurve3D? curve3D, double height)
            : base(curve3D, height)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurveWall"/> class using an existing wall, a curve, height, and direction.
        /// </summary>
        /// <param name="wall">The <see cref="IWall"/> object to use as a basis for initialization.</param>
        /// <param name="curve3D">The <see cref="ICurve3D"/> that defines the base of the curved wall.</param>
        /// <param name="height">The height of the wall.</param>
        /// <param name="direction">The <see cref="Vector3D"/> representing the direction of the wall's extrusion.</param>
        public CurveWall(IWall wall, ICurve3D? curve3D, double height, Vector3D? direction)
            : base(wall, curve3D, height, direction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurveWall"/> class using an existing wall, a specified 3D curve, and a height.
        /// </summary>
        /// <param name="wall">The source wall used to initialize properties for the new curved wall.</param>
        /// <param name="curve3D">The 3D curve that defines the path of the curved wall.</param>
        /// <param name="height">The height of the curved wall.</param>
        public CurveWall(IWall wall, ICurve3D? curve3D, double height)
            : base(wall, curve3D, height)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurveWall"/> class using the specified <see cref="CurveWall"/> instance.
        /// </summary>
        /// <param name="curveWall">The <see cref="CurveWall"/> instance to copy from.</param>
        public CurveWall(CurveWall? curveWall)
            : base(curveWall)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurveWall"/> class with a specified unique identifier and an existing curve wall.
        /// </summary>
        /// <param name="guid">The unique global identifier for the object.</param>
        /// <param name="curveWall">The source <see cref="CurveWall{ICurve3D}"/> instance used to initialize the new object.</param>
        public CurveWall(System.Guid guid, CurveWall<ICurve3D>? curveWall)
            : base(guid, curveWall)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurveWall"/> class from the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to populate the properties of the new <see cref="CurveWall"/> instance.</param>
        public CurveWall(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}
