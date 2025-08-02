using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.ComponentModel;


namespace DiGi.Analytical.Building.HVAC.Enums
{
    [AssociatedTypes(typeof(IInternalCondition)), Description("Internal condition parameter")]
    public enum SpaceParameter
    {
        [ParameterProperties("be61a143-04fd-418c-a184-ce435c274280", "InternalGain", "Internal Gain"), ObjectParameterValue(true, true, typeof(Classes.InternalGain))] InternalGain,
        [ParameterProperties("3686aa6d-3590-4bcf-8382-c2c086f5874b", "Thermostat", "Thermostat"), ObjectParameterValue(true, true, typeof(Classes.Thermostat))] Thermostat,
        [ParameterProperties("1cb95e8b-fb84-4d87-ae53-7949f9235874", "HeatingEmitter", "Heating Emitter"), ObjectParameterValue(true, true, typeof(Classes.HeatingEmitter))] HeatingEmitter,
        [ParameterProperties("210d1fa2-66ba-4721-917a-4d52f2689767", "CoolingEmitter", "Cooling Emitter"), ObjectParameterValue(true, true, typeof(Classes.CoolingEmitter))] CoolingEmitter,
        [ParameterProperties("be085040-2032-4008-bb44-b1aa78b1ef32", "SystemProperties", "System Properties"), ObjectParameterValue(true, true, typeof(Classes.SystemProperties))] SystemProperties,
    }
}
