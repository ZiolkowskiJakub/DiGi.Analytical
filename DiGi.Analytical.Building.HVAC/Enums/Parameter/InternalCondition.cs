using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.ComponentModel;


namespace DiGi.Analytical.Building.Enums
{
    [AssociatedTypes(typeof(IInternalCondition)), Description("Internal condition parameter")]
    public enum SpaceParameter
    {
        [ParameterProperties("08eb33ec-bbf0-42ba-98cd-b2fe6b268ad7", "Lighting radiant proportion", "Lighting radiant proportion [-]"), DoubleParameterValue(0.0, 1.0)] LightingRadiantProportion,
        [ParameterProperties("deda6ffd-1954-46d4-81de-eab609f1351b", "Occupant radiant proportion", "Occupant radiant proportion [-]"), DoubleParameterValue(0.0, 1.0)] OccupantRadiantProportion,
        [ParameterProperties("7e535c2b-7e22-4057-906e-c965d34402c3", "Equipment radiant proportion", "Equipment radiant proportion [-]"), DoubleParameterValue(0.0, 1.0)] EquipmentRadiantProportion,

        [ParameterProperties("e712839e-1d37-4c3a-9e64-99ce7dff7807", "Lighting view coefficient", "Lighting view coefficient [-]"), DoubleParameterValue(0.0, 1.0)] LightingViewCoefficient,
        [ParameterProperties("5cbde6f4-95b1-4c7b-aa50-59a928d9ad08", "Occupant view coefficient", "Occupant view coefficient [-]"), DoubleParameterValue(0.0, 1.0)] OccupantViewCoefficient,
        [ParameterProperties("be61a143-04fd-418c-a184-ce435c274280", "Equipment view coefficient", "Equipment view coefficient [-]"), DoubleParameterValue(0.0, 1.0)] EquipmentViewCoefficient,
    }
}
