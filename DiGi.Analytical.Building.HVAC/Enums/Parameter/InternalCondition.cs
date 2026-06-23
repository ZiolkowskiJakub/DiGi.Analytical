using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.ComponentModel;

namespace DiGi.Analytical.Building.HVAC.Enums
{
    /// <summary>
    /// Defines the available parameters for an internal condition in the HVAC analytical model.
    /// </summary>
    [AssociatedTypes(typeof(IInternalCondition)), Description("Internal condition parameter")]
    public enum InternalConditionParameter
    {
        /// <summary>
        /// Represents the internal gain parameter for an internal condition.
        /// </summary>
        [ParameterProperties("be61a143-04fd-418c-a184-ce435c274280", "InternalGain", "Internal Gain"), ObjectParameterValue(true, true, typeof(Classes.InternalGain))] InternalGain,

        /// <summary>
        /// Specifies that the internal condition parameter is a thermostat.
        /// </summary>
        [ParameterProperties("3686aa6d-3590-4bcf-8382-c2c086f5874b", "Thermostat", "Thermostat"), ObjectParameterValue(true, true, typeof(Classes.Thermostat))] Thermostat,

        /// <summary>Represents the heating emitter internal condition parameter.</summary>
        [ParameterProperties("1cb95e8b-fb84-4d87-ae53-7949f9235874", "HeatingEmitter", "Heating Emitter"), ObjectParameterValue(true, true, typeof(Classes.HeatingEmitter))] HeatingEmitter,

        /// <summary>
        /// Represents the cooling emitter internal condition parameter.
        /// </summary>
        [ParameterProperties("210d1fa2-66ba-4721-917a-4d52f2689767", "CoolingEmitter", "Cooling Emitter"), ObjectParameterValue(true, true, typeof(Classes.CoolingEmitter))] CoolingEmitter,

        /// <summary>Represents the system properties parameter for the internal condition.</summary>
        [ParameterProperties("be085040-2032-4008-bb44-b1aa78b1ef32", "SystemProperties", "System Properties"), ObjectParameterValue(true, true, typeof(Classes.SystemProperties))] SystemProperties,
    }
}