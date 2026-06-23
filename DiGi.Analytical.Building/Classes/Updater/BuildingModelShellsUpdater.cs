using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Provides functionality to update shell components within a <see cref="BuildingModel"/>.
    /// </summary>
    public class BuildingModelShellsUpdater : BuildingModelUpdater
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModelShellsUpdater"/> class.
        /// </summary>
        /// <param name="value">The building model to be updated.</param>
        public BuildingModelShellsUpdater(BuildingModel value)
            : base(value)
        {
        }

        /// <summary>
        /// Gets or sets the collection of shell elements to be updated in the building model.
        /// </summary>
        public List<Shell>? Shells { get; set; }

        /// <summary>
        /// Gets or sets the distance tolerance used for geometric comparisons and operations during the shell update process. The default value is <see cref="Core.Constants.Tolerance.Distance"/>.
        /// </summary>
        public double Tolerance { get; set; } = Core.Constants.Tolerance.Distance;

        /// <summary>Gets or sets the set of unique references for the components that have been updated.</summary>
        public HashSet<IUniqueReference>? UpdatedComponentUniqueReferences { get; set; } = null;

        /// <summary>
        /// Performs the update operation for the building model shells.
        /// </summary>
        /// <returns>True if any changes were made; otherwise, false.</returns>
        public override bool Update()
        {
            return Update(out _);
        }

        /// <summary>
        /// Updates the building model shells and retrieves the associated spaces.
        /// </summary>
        /// <param name="spaces">When this method returns, contains a list of <see cref="ISpace"/> objects that were updated or created; otherwise, null.</param>
        /// <returns>True if the update operation was successful; otherwise, false.</returns>
        public bool Update(out List<ISpace>? spaces)
        {
            spaces = null;

            if (Value is null || Shells is null || Shells.Count == 0)
            {
                return false;
            }

            BuildingModelShellUpdater buildingModelShellUpdater = new(Value);

            UpdatedComponentUniqueReferences ??= [];

            spaces = [];

            foreach (Shell shell in Shells)
            {
                if (shell is null)
                {
                    continue;
                }

                buildingModelShellUpdater.Shell = shell;
                buildingModelShellUpdater.UpdatedComponentUniqueReferences = UpdatedComponentUniqueReferences;

                if (!buildingModelShellUpdater.Update(out ISpace? space) || space is null)
                {
                    continue;
                }

                spaces.Add(space);
                UpdatedComponentUniqueReferences = buildingModelShellUpdater.UpdatedComponentUniqueReferences;
            }

            return spaces != null && spaces.Count > 0;
        }
    }
}