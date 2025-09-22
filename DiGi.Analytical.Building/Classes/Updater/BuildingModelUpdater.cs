using DiGi.Core.Interfaces;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class BuildingModelUpdater : IUpdater<BuildingModel>
    {
        public BuildingModel? Value { get; set; }

        public BuildingModelUpdater(BuildingModel? value)
        {
            Value = value;
        }

        public abstract bool Update();
    }
}
