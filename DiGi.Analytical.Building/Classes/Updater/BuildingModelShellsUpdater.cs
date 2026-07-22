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
    /// Writes a collection of analytical shells back into a <see cref="BuildingModel"/> as spaces bounded by components.
    /// <para>Every shell is processed by a <see cref="BuildingModelShellUpdater"/>, all of them sharing one set of caches. That is what makes a component bounding two of the updated spaces be created once and assigned to both, and what keeps the result independent of the order the shells are given in.</para>
    /// <para>This is the entry point to use whenever more than one shell is written into a model, for example after splitting the spaces of a model - see BuildingModel.TrySplit.</para>
    /// </summary>
    /// <seealso cref="BuildingModelShellUpdater"/>
    /// <seealso cref="BuildingModelFaceUpdater"/>
    public class BuildingModelShellsUpdater : BuildingModelUpdater
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModelShellsUpdater"/> class.
        /// </summary>
        /// <param name="value">The building model to be updated in place.</param>
        public BuildingModelShellsUpdater(BuildingModel value)
            : base(value)
        {
        }

        /// <summary>
        /// Gets or sets the shells to be written into the building model.
        /// <para>The reference of every shell selects the space it represents, therefore two shells describing two different spaces must not carry the same reference.</para>
        /// </summary>
        public List<Shell>? Shells { get; set; }

        /// <summary>
        /// Gets or sets the distance tolerance used for geometric comparisons and operations during the shell update process. The default value is <see cref="Core.Constants.Tolerance.Distance"/>.
        /// <para>It is passed on to every <see cref="BuildingModelShellUpdater"/> created by this updater.</para>
        /// </summary>
        public double Tolerance { get; set; } = Core.Constants.Tolerance.Distance;

        /// <summary>
        /// Gets or sets the components created during the update process, grouped by the <see cref="IUniqueReference"/> of the component they originate from and keyed by the internal point of the face they were created from.
        /// <para>Populated by the update and shared by all the shells; supply an existing cache to continue an update started by another instance of this updater.</para>
        /// </summary>
        public Dictionary<IUniqueReference, List<Tuple<Point3D, IComponent>>>? UpdatedComponents { get; set; } = null;

        /// <summary>
        /// Gets or sets the spaces assigned to the components during the update process, keyed by the unique identifier of the component.
        /// <para>Populated by the update and shared by all the shells, so that a component bounding two of the updated spaces keeps both assignments.</para>
        /// </summary>
        public Dictionary<Guid, List<ISpace>>? UpdatedComponentSpaces { get; set; } = null;

        /// <summary>
        /// Writes <see cref="Shells"/> into the building model as spaces bounded by components.
        /// </summary>
        /// <returns>True if at least one shell was written into the model; otherwise, false.</returns>
        public override bool Update()
        {
            return Update(out _);
        }

        /// <summary>
        /// Writes <see cref="Shells"/> into the building model as spaces bounded by components and returns those spaces.
        /// <para>The identifiers of the spaces of all the shells are collected before the first shell is processed, so that assignments of a component to any of them can be recognized as outdated and rebuilt from the shells regardless of the order the shells are processed in. Assignments to spaces outside this update are preserved.</para>
        /// </summary>
        /// <param name="spaces">When this method returns, contains a list of <see cref="ISpace"/> objects that were updated or created; otherwise, null.</param>
        /// <returns>True if at least one shell was written into the model; otherwise, false.</returns>
        public bool Update(out List<ISpace>? spaces)
        {
            spaces = null;

            if (Value is null || Shells is null || Shells.Count == 0)
            {
                return false;
            }

            BuildingModelShellUpdater buildingModelShellUpdater = new(Value)
            {
                Tolerance = Tolerance
            };

            UpdatedComponents ??= [];
            UpdatedComponentSpaces ??= [];

            // Spaces rebuilt by this update have to be known upfront, so that outdated assignments are recognized regardless of the order the shells are processed in
            HashSet<Guid> processedSpaceGuids = [];
            foreach (Shell shell in Shells)
            {
                if (shell?.UniqueReference is GuidReference guidReference)
                {
                    processedSpaceGuids.Add(guidReference.Guid);
                }
            }

            spaces = [];

            foreach (Shell shell in Shells)
            {
                if (shell is null)
                {
                    continue;
                }

                buildingModelShellUpdater.Shell = shell;
                buildingModelShellUpdater.UpdatedComponents = UpdatedComponents;
                buildingModelShellUpdater.UpdatedComponentSpaces = UpdatedComponentSpaces;
                buildingModelShellUpdater.ProcessedSpaceGuids = processedSpaceGuids;

                if (!buildingModelShellUpdater.Update(out ISpace? space) || space is null)
                {
                    continue;
                }

                spaces.Add(space);
            }

            return spaces != null && spaces.Count > 0;
        }
    }
}