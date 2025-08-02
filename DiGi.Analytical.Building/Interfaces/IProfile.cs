namespace DiGi.Analytical.Building.Interfaces
{
    public interface IProfile : IBuildingSerializableObject
    {
        int Count { get; }

        double this[int index] { get; }

        double[] Values { get; }
    }
}
