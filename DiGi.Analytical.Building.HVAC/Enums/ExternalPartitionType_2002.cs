using System.ComponentModel;

namespace DiGi.Analytical.Building.HVAC.Enums
{
    /// <summary>
    /// Specifies the types of external partition elements for residential and public buildings according to the 2002 classification standard.
    /// </summary>
    public enum ExternalPartitionType_2002
    {
        /// <summary>
        /// Represents a residential building multilayer wall.
        /// </summary>
        [Description("Residential building multilayer wall")] ResidentialBuilding_Wall_Multilayer,

        /// <summary>
        /// Residential building solid wall.
        /// </summary>
        [Description("Residential building solid wall")] ResidentialBuilding_Wall_Solid,

        /// <summary>
        /// Residential building roof over heated rooms.
        /// </summary>
        [Description("Residential building roof over heated rooms")] ResidentialBuilding_Roof,

        /// <summary>
        /// Represents a residential building floor located over unheated spaces.
        /// </summary>
        [Description("Residential building floor over unheated spaces")] ResidentialBuilding_Floor_OverUnheatedSpaces,

        /// <summary>
        /// Represents a residential building floor on ground.
        /// </summary>
        [Description("Residential building floor on ground")] ResidentialBuilding_Floor,

        /// <summary>
        /// Represents a residential building window or balcony door (climatic zones I, II, III).
        /// </summary>
        [Description("Residential building window or balcony door (climatic zones I, II, III)")] ResidentialBuilding_Window_ZoneA,

        /// <summary>
        /// Residential building window or balcony door (climatic zones IV, V).
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
        /// Public building solid wall.
        /// </summary>
        [Description("Public building solid wall")] PublicBuilding_Wall_Solid,

        /// <summary>
        /// Represents a public building wall with window and door openings.
        /// </summary>
        [Description("Public building wall with window and door openings")] PublicBuilding_Wall_WithWindowAndDoor,

        /// <summary>
        /// Public building wall with balcony brackets penetrating the wall.
        /// </summary>
        [Description("Public building wall with balcony brackets penetrating the wall")] PublicBuilding_Wall_WithBaconyBrackets,

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
        /// Represents a public building window partition type.
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