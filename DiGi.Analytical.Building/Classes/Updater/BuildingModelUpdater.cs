using DiGi.Core.Interfaces;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Provides an abstract base class for implementing logic to update a <see cref="BuildingModel"/>.
    /// </summary>
    public abstract class BuildingModelUpdater : IUpdater<BuildingModel>
    {
        /// <summary>
        /// Gets or sets the building model associated with the updater.
        /// </summary>
        public BuildingModel? Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModelUpdater"/> class.
        /// </summary>
        /// <param name="value">The <see cref="BuildingModel"/> instance to be managed by this updater.</param>
        public BuildingModelUpdater(BuildingModel? value)
        {
            Value = value;
        }

        /// <summary>
        /// Performs the update operation on the building model.
        /// </summary>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        public abstract bool Update();
    }
}