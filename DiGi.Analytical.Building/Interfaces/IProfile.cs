namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for time-series profiles that provide indexed double values.
    /// </summary>
    public interface IProfile : IBuildingSerializableObject
    {
        /// <summary>
        /// Gets the number of values in the profile.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Gets the value at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the value to retrieve.</param>
        /// <returns>The double value at the specified index.</returns>
        double this[int index] { get; }

        /// <summary>
        /// Gets the array of all profile values.
        /// </summary>
        double[]? Values { get; }
    }
}