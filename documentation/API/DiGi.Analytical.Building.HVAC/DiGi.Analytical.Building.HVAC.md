#### [DiGi\.Analytical\.Building\.HVAC](index.md 'index')

## DiGi\.Analytical\.Building\.HVAC Namespace
### Classes

<a name='DiGi.Analytical.Building.HVAC.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Analytical.Building.HVAC.Create.RegulatedHeatTransferCoefficientsManager()'></a>

## Create\.RegulatedHeatTransferCoefficientsManager\(\) Method

Creates and initializes a new instance of the [RegulatedHeatTransferCoefficientsManager\(\)](DiGi.Analytical.Building.HVAC.md#DiGi.Analytical.Building.HVAC.Create.RegulatedHeatTransferCoefficientsManager() 'DiGi\.Analytical\.Building\.HVAC\.Create\.RegulatedHeatTransferCoefficientsManager\(\)') class populated with predefined regulatory heat transfer coefficients\.

```csharp
public static DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager RegulatedHeatTransferCoefficientsManager();
```

#### Returns
[RegulatedHeatTransferCoefficientsManager](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficientsManager')  
A configured instance of [RegulatedHeatTransferCoefficientsManager\(\)](DiGi.Analytical.Building.HVAC.md#DiGi.Analytical.Building.HVAC.Create.RegulatedHeatTransferCoefficientsManager() 'DiGi\.Analytical\.Building\.HVAC\.Create\.RegulatedHeatTransferCoefficientsManager\(\)')\.

<a name='DiGi.Analytical.Building.HVAC.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Analytical.Building.HVAC.Modify.Assign(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,string)'></a>

## Modify\.Assign\(this BuildingModel, ISpace, IInternalCondition, string\) Method

Assigns a specified internal condition to a space within the building model\.

```csharp
public static bool Assign(this DiGi.Analytical.Building.Classes.BuildingModel? buildingModel, DiGi.Analytical.Building.Interfaces.ISpace? space, DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition, string? id=null);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Modify.Assign(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,string).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') instance that manages the assignment\.

<a name='DiGi.Analytical.Building.HVAC.Modify.Assign(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,string).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace') to which the internal condition is assigned\.

<a name='DiGi.Analytical.Building.HVAC.Modify.Assign(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,string).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition') to be applied to the space\.

<a name='DiGi.Analytical.Building.HVAC.Modify.Assign(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional unique identifier for the assignment\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the internal condition was successfully assigned; otherwise, false\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetHeatingEmitter(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter)'></a>

## Modify\.SetHeatingEmitter\(this InternalCondition, CoolingEmitter\) Method

Sets the cooling emitter for the specified internal condition\.

```csharp
public static bool SetHeatingEmitter(this DiGi.Analytical.Building.Classes.InternalCondition? internalCondition, DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter? coolingEmitter);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Modify.SetHeatingEmitter(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Classes\.InternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.internalcondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition')

The internal condition instance to modify\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetHeatingEmitter(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter).coolingEmitter'></a>

`coolingEmitter` [CoolingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.CoolingEmitter')

The cooling emitter to assign to the internal condition\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the cooling emitter was successfully set; otherwise, false\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetHeatingEmitter(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter)'></a>

## Modify\.SetHeatingEmitter\(this InternalCondition, HeatingEmitter\) Method

Sets the heating emitter for the specified internal condition\.

```csharp
public static bool SetHeatingEmitter(this DiGi.Analytical.Building.Classes.InternalCondition? internalCondition, DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter? heatingEmitter);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Modify.SetHeatingEmitter(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Classes\.InternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.internalcondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition')

The internal condition to modify\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetHeatingEmitter(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter).heatingEmitter'></a>

`heatingEmitter` [HeatingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.HeatingEmitter')

The heating emitter to assign\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the value was successfully set; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetInternalGain(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Classes.InternalGain)'></a>

## Modify\.SetInternalGain\(this InternalCondition, InternalGain\) Method

Sets the internal gain for the specified internal condition\.

```csharp
public static bool SetInternalGain(this DiGi.Analytical.Building.Classes.InternalCondition? internalCondition, DiGi.Analytical.Building.HVAC.Classes.InternalGain? internalGain);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Modify.SetInternalGain(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Classes.InternalGain).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Classes\.InternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.internalcondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition')

The internal condition instance to modify\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetInternalGain(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Classes.InternalGain).internalGain'></a>

`internalGain` [InternalGain](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.InternalGain 'DiGi\.Analytical\.Building\.HVAC\.Classes\.InternalGain')

The internal gain value to be set\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the internal gain was successfully set; otherwise, false\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetProfile(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,DiGi.Analytical.Building.Interfaces.IProfile)'></a>

## Modify\.SetProfile\(this InternalCondition, InternalGainProfileType, IProfile\) Method

Sets a specific internal gain profile for the provided internal condition\.

```csharp
public static bool SetProfile(this DiGi.Analytical.Building.Classes.InternalCondition? internalCondition, DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType internalGainProfileType, DiGi.Analytical.Building.Interfaces.IProfile? profile);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Modify.SetProfile(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,DiGi.Analytical.Building.Interfaces.IProfile).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Classes\.InternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.internalcondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition')

The internal condition instance to modify\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetProfile(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,DiGi.Analytical.Building.Interfaces.IProfile).internalGainProfileType'></a>

`internalGainProfileType` [InternalGainProfileType](DiGi.Analytical.Building.HVAC.Enums.md#DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType 'DiGi\.Analytical\.Building\.HVAC\.Enums\.InternalGainProfileType')

The type of internal gain profile to be assigned\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetProfile(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,DiGi.Analytical.Building.Interfaces.IProfile).profile'></a>

`profile` [DiGi\.Analytical\.Building\.Interfaces\.IProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iprofile 'DiGi\.Analytical\.Building\.Interfaces\.IProfile')

The profile implementation to assign to the specified internal gain profile type\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the profile was successfully set; otherwise, false\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetProfile(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,DiGi.Analytical.Building.Interfaces.IProfile)'></a>

## Modify\.SetProfile\(this InternalCondition, ThermostatProfileType, IProfile\) Method

Sets the specified profile for a thermostat of the given profile type within the internal condition\.

```csharp
public static bool SetProfile(this DiGi.Analytical.Building.Classes.InternalCondition? internalCondition, DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType thermostatProfileType, DiGi.Analytical.Building.Interfaces.IProfile? profile);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Modify.SetProfile(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,DiGi.Analytical.Building.Interfaces.IProfile).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Classes\.InternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.internalcondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition')

The internal condition instance to modify\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetProfile(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,DiGi.Analytical.Building.Interfaces.IProfile).thermostatProfileType'></a>

`thermostatProfileType` [ThermostatProfileType](DiGi.Analytical.Building.HVAC.Enums.md#DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType 'DiGi\.Analytical\.Building\.HVAC\.Enums\.ThermostatProfileType')

The type of thermostat profile to set\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetProfile(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,DiGi.Analytical.Building.Interfaces.IProfile).profile'></a>

`profile` [DiGi\.Analytical\.Building\.Interfaces\.IProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iprofile 'DiGi\.Analytical\.Building\.Interfaces\.IProfile')

The profile to assign to the specified thermostat profile type\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the profile was successfully set or updated; otherwise, false\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetSystemProperties(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Classes.SystemProperties)'></a>

## Modify\.SetSystemProperties\(this InternalCondition, SystemProperties\) Method

Sets the system properties for the specified internal condition\.

```csharp
public static bool SetSystemProperties(this DiGi.Analytical.Building.Classes.InternalCondition? internalCondition, DiGi.Analytical.Building.HVAC.Classes.SystemProperties? systemProperties);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Modify.SetSystemProperties(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Classes.SystemProperties).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Classes\.InternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.internalcondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition')

The internal condition instance to modify\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetSystemProperties(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Classes.SystemProperties).systemProperties'></a>

`systemProperties` [SystemProperties](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.SystemProperties 'DiGi\.Analytical\.Building\.HVAC\.Classes\.SystemProperties')

The system properties to be assigned\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the system properties were successfully set; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetThermostat(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Classes.Thermostat)'></a>

## Modify\.SetThermostat\(this InternalCondition, Thermostat\) Method

Sets the thermostat parameter for the specified internal condition\.

```csharp
public static bool SetThermostat(this DiGi.Analytical.Building.Classes.InternalCondition? internalCondition, DiGi.Analytical.Building.HVAC.Classes.Thermostat? thermostat);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Modify.SetThermostat(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Classes.Thermostat).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Classes\.InternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.internalcondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition')

The internal condition instance to be modified\.

<a name='DiGi.Analytical.Building.HVAC.Modify.SetThermostat(thisDiGi.Analytical.Building.Classes.InternalCondition,DiGi.Analytical.Building.HVAC.Classes.Thermostat).thermostat'></a>

`thermostat` [Thermostat](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Thermostat 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Thermostat')

The thermostat object to assign to the internal condition\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the thermostat was successfully set; otherwise, false\.

<a name='DiGi.Analytical.Building.HVAC.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Analytical.Building.HVAC.Query.CoolingEmitter(thisDiGi.Analytical.Building.Interfaces.IInternalCondition)'></a>

## Query\.CoolingEmitter\(this IInternalCondition\) Method

Retrieves the cooling emitter associated with the specified internal condition\.

```csharp
public static DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter? CoolingEmitter(this DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Query.CoolingEmitter(thisDiGi.Analytical.Building.Interfaces.IInternalCondition).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition from which to retrieve the cooling emitter\.

#### Returns
[CoolingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.CoolingEmitter')  
The [CoolingEmitter\(this IInternalCondition\)](DiGi.Analytical.Building.HVAC.md#DiGi.Analytical.Building.HVAC.Query.CoolingEmitter(thisDiGi.Analytical.Building.Interfaces.IInternalCondition) 'DiGi\.Analytical\.Building\.HVAC\.Query\.CoolingEmitter\(this DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition\)') if found; otherwise, `null`\.

<a name='DiGi.Analytical.Building.HVAC.Query.HeatingEmitter(thisDiGi.Analytical.Building.Interfaces.IInternalCondition)'></a>

## Query\.HeatingEmitter\(this IInternalCondition\) Method

Retrieves the heating emitter associated with the specified internal condition\.

```csharp
public static DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter? HeatingEmitter(this DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Query.HeatingEmitter(thisDiGi.Analytical.Building.Interfaces.IInternalCondition).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition from which to retrieve the heating emitter\.

#### Returns
[HeatingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.HeatingEmitter')  
The [HeatingEmitter\(this IInternalCondition\)](DiGi.Analytical.Building.HVAC.md#DiGi.Analytical.Building.HVAC.Query.HeatingEmitter(thisDiGi.Analytical.Building.Interfaces.IInternalCondition) 'DiGi\.Analytical\.Building\.HVAC\.Query\.HeatingEmitter\(this DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition\)') if found; otherwise, `null`\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,string)'></a>

## Query\.IndexedDoubles\(this BuildingModel, ISpace, Range\<int\>, InternalGainProfileType, string\) Method

Retrieves a collection of double\-precision floating\-point values for the specified internal gain profile within a given space and index range\.

```csharp
public static DiGi.Core.Classes.IndexedDoubles? IndexedDoubles(this DiGi.Analytical.Building.Classes.BuildingModel? buildingModel, DiGi.Analytical.Building.Interfaces.ISpace? space, DiGi.Core.Classes.Range<int>? range, DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType internalGainProfileType, string? id=null);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,string).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model to query\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,string).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space from which to retrieve the data\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,string).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of indices for the values to be retrieved\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,string).internalGainProfileType'></a>

`internalGainProfileType` [InternalGainProfileType](DiGi.Analytical.Building.HVAC.Enums.md#DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType 'DiGi\.Analytical\.Building\.HVAC\.Enums\.InternalGainProfileType')

The type of internal gain profile to query\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional identifier used to filter or specify the data source\.

#### Returns
[DiGi\.Core\.Classes\.IndexedDoubles](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.indexeddoubles 'DiGi\.Core\.Classes\.IndexedDoubles')  
An [DiGi\.Core\.Classes\.IndexedDoubles](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.indexeddoubles 'DiGi\.Core\.Classes\.IndexedDoubles') instance containing the retrieved values, or `null` if any required parameters are null or invalid\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,string)'></a>

## Query\.IndexedDoubles\(this BuildingModel, ISpace, Range\<int\>, ThermostatProfileType, string\) Method

Retrieves a collection of double\-precision floating\-point values mapped to integer indices for a specified thermostat profile within a building space\.

```csharp
public static DiGi.Core.Classes.IndexedDoubles? IndexedDoubles(this DiGi.Analytical.Building.Classes.BuildingModel? buildingModel, DiGi.Analytical.Building.Interfaces.ISpace? space, DiGi.Core.Classes.Range<int>? range, DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType thermostatProfileType, string? id=null);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,string).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model containing the data\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,string).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space associated with the thermostat profile\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,string).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of indices to retrieve\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,string).thermostatProfileType'></a>

`thermostatProfileType` [ThermostatProfileType](DiGi.Analytical.Building.HVAC.Enums.md#DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType 'DiGi\.Analytical\.Building\.HVAC\.Enums\.ThermostatProfileType')

The type of thermostat profile to query\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional identifier for the specific profile or data source\.

#### Returns
[DiGi\.Core\.Classes\.IndexedDoubles](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.indexeddoubles 'DiGi\.Core\.Classes\.IndexedDoubles')  
An [DiGi\.Core\.Classes\.IndexedDoubles](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.indexeddoubles 'DiGi\.Core\.Classes\.IndexedDoubles') instance containing the retrieved values, or `null` if the building model, space, range, or profile type is invalid or undefined\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,System.Enum,string)'></a>

## Query\.IndexedDoubles\(this BuildingModel, ISpace, Range\<int\>, Enum, string\) Method

Retrieves a collection of indexed double\-precision floating\-point values for a specific space and profile type within the building model\.

```csharp
public static DiGi.Core.Classes.IndexedDoubles? IndexedDoubles(this DiGi.Analytical.Building.Classes.BuildingModel? buildingModel, DiGi.Analytical.Building.Interfaces.ISpace? space, DiGi.Core.Classes.Range<int>? range, System.Enum? @enum, string? id=null);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,System.Enum,string).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') instance to query\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,System.Enum,string).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace') associated with the data retrieval\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,System.Enum,string).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of integers defining the index range\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,System.Enum,string).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value specifying the profile type, such as [ThermostatProfileType](DiGi.Analytical.Building.HVAC.Enums.md#DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType 'DiGi\.Analytical\.Building\.HVAC\.Enums\.ThermostatProfileType') or [InternalGainProfileType](DiGi.Analytical.Building.HVAC.Enums.md#DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType 'DiGi\.Analytical\.Building\.HVAC\.Enums\.InternalGainProfileType')\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Core.Classes.Range_int_,System.Enum,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional unique identifier for the internal condition\.

#### Returns
[DiGi\.Core\.Classes\.IndexedDoubles](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.indexeddoubles 'DiGi\.Core\.Classes\.IndexedDoubles')  
An [DiGi\.Core\.Classes\.IndexedDoubles](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.indexeddoubles 'DiGi\.Core\.Classes\.IndexedDoubles') instance if matching data is found; otherwise, `null`\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,int,int,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,string)'></a>

## Query\.IndexedDoubles\(this BuildingModel, ISpace, int, int, InternalGainProfileType, string\) Method

Retrieves a collection of double\-precision floating\-point values mapped to integer indices for a specific internal gain profile within a specified range\.

```csharp
public static DiGi.Core.Classes.IndexedDoubles? IndexedDoubles(this DiGi.Analytical.Building.Classes.BuildingModel? buildingModel, DiGi.Analytical.Building.Interfaces.ISpace? space, int start, int end, DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType internalGainProfileType, string? id=null);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,int,int,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,string).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model containing the data\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,int,int,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,string).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space associated with the internal gain profile\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,int,int,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,string).start'></a>

`start` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The starting index of the value range to retrieve\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,int,int,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,string).end'></a>

`end` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The ending index of the value range to retrieve\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,int,int,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,string).internalGainProfileType'></a>

`internalGainProfileType` [InternalGainProfileType](DiGi.Analytical.Building.HVAC.Enums.md#DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType 'DiGi\.Analytical\.Building\.HVAC\.Enums\.InternalGainProfileType')

The type of internal gain profile to be retrieved\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,int,int,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional identifier for the specific internal gain profile\.

#### Returns
[DiGi\.Core\.Classes\.IndexedDoubles](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.indexeddoubles 'DiGi\.Core\.Classes\.IndexedDoubles')  
An [DiGi\.Core\.Classes\.IndexedDoubles](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.indexeddoubles 'DiGi\.Core\.Classes\.IndexedDoubles') instance containing the values if successful; otherwise, `null`\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,int,int,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,string)'></a>

## Query\.IndexedDoubles\(this BuildingModel, ISpace, int, int, ThermostatProfileType, string\) Method

Retrieves a collection of double\-precision floating\-point values mapped to integer indices for a specified thermostat profile within a given space and range\.

```csharp
public static DiGi.Core.Classes.IndexedDoubles? IndexedDoubles(this DiGi.Analytical.Building.Classes.BuildingModel? buildingModel, DiGi.Analytical.Building.Interfaces.ISpace? space, int start, int end, DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType thermostatProfileType, string? id=null);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,int,int,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,string).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model containing the data\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,int,int,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,string).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space associated with the thermostat profile\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,int,int,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,string).start'></a>

`start` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The starting index of the requested range\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,int,int,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,string).end'></a>

`end` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The ending index of the requested range\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,int,int,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,string).thermostatProfileType'></a>

`thermostatProfileType` [ThermostatProfileType](DiGi.Analytical.Building.HVAC.Enums.md#DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType 'DiGi\.Analytical\.Building\.HVAC\.Enums\.ThermostatProfileType')

The type of thermostat profile to be retrieved\.

<a name='DiGi.Analytical.Building.HVAC.Query.IndexedDoubles(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Building.Interfaces.ISpace,int,int,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional identifier for the specific profile instance\.

#### Returns
[DiGi\.Core\.Classes\.IndexedDoubles](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.indexeddoubles 'DiGi\.Core\.Classes\.IndexedDoubles')  
An [DiGi\.Core\.Classes\.IndexedDoubles](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.indexeddoubles 'DiGi\.Core\.Classes\.IndexedDoubles') instance containing the values if successful; otherwise, `null`\.

<a name='DiGi.Analytical.Building.HVAC.Query.InternalGain(thisDiGi.Analytical.Building.Interfaces.IInternalCondition)'></a>

## Query\.InternalGain\(this IInternalCondition\) Method

Retrieves the internal gain from the specified internal condition\.

```csharp
public static DiGi.Analytical.Building.HVAC.Classes.InternalGain? InternalGain(this DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Query.InternalGain(thisDiGi.Analytical.Building.Interfaces.IInternalCondition).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition to retrieve the internal gain from\.

#### Returns
[InternalGain](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.InternalGain 'DiGi\.Analytical\.Building\.HVAC\.Classes\.InternalGain')  
The [InternalGain\(this IInternalCondition\)](DiGi.Analytical.Building.HVAC.md#DiGi.Analytical.Building.HVAC.Query.InternalGain(thisDiGi.Analytical.Building.Interfaces.IInternalCondition) 'DiGi\.Analytical\.Building\.HVAC\.Query\.InternalGain\(this DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition\)') if successfully retrieved; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Analytical.Building.HVAC.Query.Profile(thisDiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType)'></a>

## Query\.Profile\(this IInternalCondition, InternalGainProfileType\) Method

Retrieves the internal gain profile for the specified profile type from the given internal condition\.

```csharp
public static DiGi.Analytical.Building.Interfaces.IProfile? Profile(this DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition, DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType internalGainProfileType);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Query.Profile(thisDiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition instance to query\.

<a name='DiGi.Analytical.Building.HVAC.Query.Profile(thisDiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType).internalGainProfileType'></a>

`internalGainProfileType` [InternalGainProfileType](DiGi.Analytical.Building.HVAC.Enums.md#DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType 'DiGi\.Analytical\.Building\.HVAC\.Enums\.InternalGainProfileType')

The specific internal gain profile type to retrieve\.

#### Returns
[DiGi\.Analytical\.Building\.Interfaces\.IProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iprofile 'DiGi\.Analytical\.Building\.Interfaces\.IProfile')  
The matching [DiGi\.Analytical\.Building\.Interfaces\.IProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iprofile 'DiGi\.Analytical\.Building\.Interfaces\.IProfile') if found; otherwise, `null`\.

<a name='DiGi.Analytical.Building.HVAC.Query.Profile(thisDiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType)'></a>

## Query\.Profile\(this IInternalCondition, ThermostatProfileType\) Method

Retrieves the specified thermostat profile for the given internal condition\.

```csharp
public static DiGi.Analytical.Building.Interfaces.IProfile? Profile(this DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition, DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType thermostatProfileType);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Query.Profile(thisDiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition instance to query\.

<a name='DiGi.Analytical.Building.HVAC.Query.Profile(thisDiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType).thermostatProfileType'></a>

`thermostatProfileType` [ThermostatProfileType](DiGi.Analytical.Building.HVAC.Enums.md#DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType 'DiGi\.Analytical\.Building\.HVAC\.Enums\.ThermostatProfileType')

The specific type of thermostat profile to retrieve\.

#### Returns
[DiGi\.Analytical\.Building\.Interfaces\.IProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iprofile 'DiGi\.Analytical\.Building\.Interfaces\.IProfile')  
The matching [DiGi\.Analytical\.Building\.Interfaces\.IProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iprofile 'DiGi\.Analytical\.Building\.Interfaces\.IProfile') if found; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Analytical.Building.HVAC.Query.Profiles(thisDiGi.Analytical.Building.Interfaces.IInternalCondition)'></a>

## Query\.Profiles\(this IInternalCondition\) Method

Retrieves a list of all profiles associated with the specified internal condition\.

```csharp
public static System.Collections.Generic.List<DiGi.Analytical.Building.Interfaces.IProfile>? Profiles(this DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Query.Profiles(thisDiGi.Analytical.Building.Interfaces.IInternalCondition).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition to retrieve profiles from\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Building\.Interfaces\.IProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iprofile 'DiGi\.Analytical\.Building\.Interfaces\.IProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Analytical\.Building\.Interfaces\.IProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iprofile 'DiGi\.Analytical\.Building\.Interfaces\.IProfile') instances if the internal condition is not null; otherwise, null\.

<a name='DiGi.Analytical.Building.HVAC.Query.SystemProperties(thisDiGi.Analytical.Building.Interfaces.IInternalCondition)'></a>

## Query\.SystemProperties\(this IInternalCondition\) Method

Retrieves the system properties associated with the specified internal condition\.

```csharp
public static DiGi.Analytical.Building.HVAC.Classes.SystemProperties? SystemProperties(this DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Query.SystemProperties(thisDiGi.Analytical.Building.Interfaces.IInternalCondition).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition instance to query for system properties\.

#### Returns
[SystemProperties](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.SystemProperties 'DiGi\.Analytical\.Building\.HVAC\.Classes\.SystemProperties')  
The [SystemProperties\(this IInternalCondition\)](DiGi.Analytical.Building.HVAC.md#DiGi.Analytical.Building.HVAC.Query.SystemProperties(thisDiGi.Analytical.Building.Interfaces.IInternalCondition) 'DiGi\.Analytical\.Building\.HVAC\.Query\.SystemProperties\(this DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition\)') if found; otherwise, `null`\.

<a name='DiGi.Analytical.Building.HVAC.Query.Thermostat(thisDiGi.Analytical.Building.Interfaces.IInternalCondition)'></a>

## Query\.Thermostat\(this IInternalCondition\) Method

Retrieves the thermostat associated with the specified internal condition\.

```csharp
public static DiGi.Analytical.Building.HVAC.Classes.Thermostat? Thermostat(this DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Query.Thermostat(thisDiGi.Analytical.Building.Interfaces.IInternalCondition).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition to query for the thermostat parameter\.

#### Returns
[Thermostat](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Thermostat 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Thermostat')  
The [Thermostat\(this IInternalCondition\)](DiGi.Analytical.Building.HVAC.md#DiGi.Analytical.Building.HVAC.Query.Thermostat(thisDiGi.Analytical.Building.Interfaces.IInternalCondition) 'DiGi\.Analytical\.Building\.HVAC\.Query\.Thermostat\(this DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition\)') instance if it exists; otherwise, `null`\.