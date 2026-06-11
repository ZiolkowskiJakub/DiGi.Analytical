using System.ComponentModel;

namespace DiGi.Analytical.Building.HVAC.Enums
{
    /// <summary>
    /// Specifies the type of external partition for building thermal analysis according to the 2009 standard, categorizing elements for both residential and public buildings.
    /// </summary>
    public enum ExternalPartitionType_2009
    {
        /// <summary>
        /// Represents a residential building wall.
        /// </summary>
        [Description("Residential building wall")] ResidentialBuilding_Wall,
        /// <summary>
        /// Represents a residential building roof over heated rooms.
        /// </summary>
        [Description("Residential building roof over heated rooms")] ResidentialBuilding_Roof,
        /// <summary>
        /// Represents a residential building floor located over unheated spaces.
        /// </summary>
        [Description("Residential building floor over unheated spaces")] ResidentialBuilding_Floor_OverUnheatedSpaces,
        /// <summary>
        /// Represents a residential building floor on the ground.
        /// </summary>
        [Description("Residential building floor on ground")] ResidentialBuilding_Floor,
        /// <summary>
        /// Represents a residential building window or balcony door (climatic zones I, II, III).
        /// </summary>
        [Description("Residential building window or balcony door (climatic zones I, II, III)")] ResidentialBuilding_Window_ZoneA,
        /// <summary>
        /// Represents a residential building window or balcony door located in climatic zones IV and V.
        /// </summary>
        [Description("Residential building window or balcony door (climatic zones IV, V)")] ResidentialBuilding_Window_ZoneB,
        /// <summary>
        /// Represents a residential building roof window or skylight.
        /// </summary>
        [Description("Residential building roof window or skylight")] ResidentialBuilding_Window_Skylight,
        /// <summary>
        /// Represents a residential building door.
        /// </summary>
        [Description("Residential building door")] ResidentialBuilding_Door,

        /// <summary>
        /// Represents a public building wall.
        /// </summary>
        [Description("Public building wall")] PublicBuilding_Wall,
        /// <summary>
        /// Represents a public building roof over heated rooms.
        /// </summary>
        [Description("Public building roof over heated rooms")] PublicBuilding_Roof,
        /// <summary>
        /// Represents a public building floor located over unheated spaces.
        /// </summary>
        [Description("Public building floor over unheated spaces")] PublicBuilding_Floor_OverUnheatedSpaces,
        /// <summary>
        /// Represents a public building floor on ground.
        /// </summary>
        [Description("Public building floor on ground")] PublicBuilding_Floor,
        /// <summary>
        /// Represents a public building window.
        /// </summary>
        [Description("Public building window")] PublicBuilding_Window,
        /// <summary>
        /// Represents a public building roof window or skylight.
        /// </summary>
        [Description("Public building roof window or skylight")] PublicBuilding_Window_Skylight,
        /// <summary>
        /// Represents a public building door.
        /// </summary>
        [Description("Public building door")] PublicBuilding_Door,
    }
}