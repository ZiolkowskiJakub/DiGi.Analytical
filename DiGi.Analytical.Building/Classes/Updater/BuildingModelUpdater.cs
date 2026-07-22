using DiGi.Core.Interfaces;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Provides an abstract base class for implementing logic to update a <see cref="BuildingModel"/>.
    /// <para>An updater is a mutable command object: assign <see cref="Value"/> together with the inputs declared by the derived class and call <see cref="Update()"/>. The same instance can be reused for several updates by reassigning its inputs.</para>
    /// </summary>
    /// <remarks>
    /// The building model is held by reference and is NOT cloned, therefore every update modifies the model given on the input in place. Invalid or incomplete input never throws, the update returns false instead. The updaters of the family are layered: <see cref="BuildingModelFloorUpdater"/> works on a whole model, <see cref="BuildingModelShellsUpdater"/> on a collection of shells, <see cref="BuildingModelShellUpdater"/> on a single shell and <see cref="BuildingModelFaceUpdater"/> on a single face, each one driving the layer below it.
    /// </remarks>
    public abstract class BuildingModelUpdater : IUpdater<BuildingModel>
    {
        /// <summary>
        /// Gets or sets the building model associated with the updater.
        /// <para>The model is referenced, not cloned, so <see cref="Update()"/> writes its results directly into this instance.</para>
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
        /// <para>Implementations modify <see cref="Value"/> in place and return false, without throwing, when the model or the inputs of the updater are missing or cannot be processed.</para>
        /// </summary>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        public abstract bool Update();
    }
}