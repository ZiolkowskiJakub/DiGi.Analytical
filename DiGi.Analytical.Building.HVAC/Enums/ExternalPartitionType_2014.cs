using System.ComponentModel;

namespace DiGi.Analytical.Building.HVAC.Enums
{
    public enum ExternalPartitionType_2014
    {
        [Description("Wall")] Wall,
        [Description("Roof over heated rooms")] Roof,
        [Description("Floor over unheated spaces")] Floor_OverUnheatedSpaces,
        [Description("Floor on ground")] Floor,
        [Description("Window or balcony door")] Window,
        [Description("Roof window or skylight")] Window_Skylight,
        [Description("Door")] Door,
    }
}