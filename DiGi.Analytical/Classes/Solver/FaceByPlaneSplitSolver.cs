using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Provides functionality to solve the splitting of a face using a specified plane.
    /// </summary>
    public class FaceByPlaneSplitSolver : FaceSplitSolver
    {
        private Plane? plane;

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceByPlaneSplitSolver"/> class.
        /// </summary>
        /// <param name="tolerance">The distance tolerance used for geometric operations during the split process.</param>
        public FaceByPlaneSplitSolver(double tolerance = Core.Constants.Tolerance.Distance)
            : base(tolerance)
        {
        }

        /// <summary>
        /// Gets or sets the <see cref="T:DiGi.Geometry.Spatial.Classes.Plane" /> used to split the face.
        /// </summary>
        /// <value>
        /// The <see cref="T:DiGi.Geometry.Spatial.Classes.Plane" /> instance used for splitting, or <c>null</c> if no plane is defined.
        /// </value>
        public Plane? Plane
        {
            get
            {
                return Core.Query.Clone(plane);
            }

            set
            {
                plane = Core.Query.Clone(value);
            }
        }

        /// <summary>
        /// Attempts to solve the face splitting operation using a specified plane.
        /// </summary>
        /// <returns>A <see cref="T:System.Boolean" /> value indicating whether the face was successfully split; returns <see langword="false" /> if the plane is not defined.</returns>
        public override bool Solve()
        {
            outputs = null;

            if (plane is null)
            {
                return false;
            }

            throw new System.NotImplementedException();

            //DiGi.Geometry.Spatial.Query.TrySplit(plane, );
        }
    }
}