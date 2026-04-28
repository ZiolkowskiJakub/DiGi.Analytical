using System.ComponentModel;

namespace DiGi.Analytical.Building.HVAC.Enums
{
    public enum ExternalPartitionType_2009
    {
        [Description("Residential building wall")] ResidentialBuilding_Wall,
        [Description("Residential building roof over heated rooms")] ResidentialBuilding_Roof,
        [Description("Residential building floor over unheated spaces")] ResidentialBuilding_Floor_OverUnheatedSpaces,
        [Description("Residential building floor on ground")] ResidentialBuilding_Floor,
        [Description("Residential building window or balcony door (climatic zones I, II, III)")] ResidentialBuilding_Window_ZoneA,
        [Description("Residential building window or balcony door (climatic zones IV, V)")] ResidentialBuilding_Window_ZoneB,
        [Description("Residential building roof window or skylight")] ResidentialBuilding_Window_Skylight,
        [Description("Residential building door")] ResidentialBuilding_Door,

        [Description("Public building wall")] PublicBuilding_Wall,
        [Description("Public building roof over heated rooms")] PublicBuilding_Roof,
        [Description("Public building floor over unheated spaces")] PublicBuilding_Floor_OverUnheatedSpaces,
        [Description("Public building floor on ground")] PublicBuilding_Floor,
        [Description("Public building window")] PublicBuilding_Window,
        [Description("Public building roof window or skylight")] PublicBuilding_Window_Skylight,
        [Description("Public building door")] PublicBuilding_Door,
    }
}
