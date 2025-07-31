namespace DiGi.Analytical.Building.Interfaces
{
    public interface IProfile : IBuildingSerializableObject
    {
        string Category { get; }

        int Count { get; }

        double this[int index] { get; }

        double[] Values { get; }
    }
}
