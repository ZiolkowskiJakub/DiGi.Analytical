using System.ComponentModel;

namespace DiGi.Analytical.Building.HVAC.Enums
{
    public enum ExternalPartitionType_2002
    {
        [Description("Residential building multilayer wall")] ResidentialBuilding_Wall_Multilayer,
        [Description("Residential building solid wall")] ResidentialBuilding_Wall_Solid,
        [Description("Residential building roof over heated rooms")] ResidentialBuilding_Roof,
        [Description("Residential building floor over unheated spaces")] ResidentialBuilding_Floor_OverUnheatedSpaces,
        [Description("Residential building floor on ground")] ResidentialBuilding_Floor,
        [Description("Residential building window or balcony door (climatic zones I, II, III)")] ResidentialBuilding_Window_ZoneA,
        [Description("Residential building window or balcony door (climatic zones IV, V)")] ResidentialBuilding_Window_ZoneB,
        [Description("Residential building roof window or skylight")] ResidentialBuilding_Window_Skylight,
        [Description("Residential building door")] ResidentialBuilding_Door,

        [Description("Public building solid wall")] PublicBuilding_Wall_Solid,
        [Description("Public building wall with window and door openings")] PublicBuilding_Wall_WithWindowAndDoor,
        [Description("Public building wall with balcony brackets penetrating the wall")] PublicBuilding_Wall_WithBaconyBrackets,
        [Description("Public building roof over heated rooms")] PublicBuilding_Roof,
        [Description("Public building floor over unheated spaces")] PublicBuilding_Floor_OverUnheatedSpaces,
        [Description("Public building floor on ground")] PublicBuilding_Floor,
        [Description("Public building window")] PublicBuilding_Window,
        [Description("Public building roof window or skylight")] PublicBuilding_Window_Skylight,
        [Description("Public building door")] PublicBuilding_Door,
    }
}
