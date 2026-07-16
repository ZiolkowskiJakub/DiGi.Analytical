#### [DiGi\.Analytical\.Building\.HVAC](DiGi.Analytical.Building.HVAC.Overview.md 'DiGi\.Analytical\.Building\.HVAC\.Overview')

## DiGi\.Analytical\.Building\.HVAC\.Interfaces Namespace
### Interfaces

<a name='DiGi.Analytical.Building.HVAC.Interfaces.IHVACNamedObject'></a>

## IHVACNamedObject Interface

Interface for HVAC objects that have a name\.

```csharp
public interface IHVACNamedObject : DiGi.Analytical.Building.HVAC.Interfaces.IHVACObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject
```

Derived  
↳ [Emitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Emitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Emitter')  
↳ [InternalGain](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.InternalGain 'DiGi\.Analytical\.Building\.HVAC\.Classes\.InternalGain')  
↳ [RegulationAct](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulationAct 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulationAct')  
↳ [Thermostat](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Thermostat 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Thermostat')

Implements [IHVACObject](DiGi.Analytical.Building.HVAC.Interfaces.md#DiGi.Analytical.Building.HVAC.Interfaces.IHVACObject 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject')

<a name='DiGi.Analytical.Building.HVAC.Interfaces.IHVACObject'></a>

## IHVACObject Interface

Base interface for all HVAC\-related objects in the building analytical framework\.

```csharp
public interface IHVACObject : DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Emitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Emitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Emitter')  
↳ [InternalGain](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.InternalGain 'DiGi\.Analytical\.Building\.HVAC\.Classes\.InternalGain')  
↳ [RegulatedHeatTransferCoefficientsManager](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficientsManager')  
↳ [RegulationAct](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulationAct 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulationAct')  
↳ [SystemProperties](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.SystemProperties 'DiGi\.Analytical\.Building\.HVAC\.Classes\.SystemProperties')  
↳ [Thermostat](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Thermostat 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Thermostat')  
↳ [IHVACNamedObject](DiGi.Analytical.Building.HVAC.Interfaces.md#DiGi.Analytical.Building.HVAC.Interfaces.IHVACNamedObject 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACNamedObject')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Analytical.Building.HVAC.Interfaces.IRegulatedHeatTransferCoefficients'></a>

## IRegulatedHeatTransferCoefficients Interface

Interface for regulated heat transfer coefficients defined by building regulations\.

```csharp
public interface IRegulatedHeatTransferCoefficients : DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [RegulatedHeatTransferCoefficients&lt;TEnum&gt;](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_ 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Properties

<a name='DiGi.Analytical.Building.HVAC.Interfaces.IRegulatedHeatTransferCoefficients.RegulationAct'></a>

## IRegulatedHeatTransferCoefficients\.RegulationAct Property

Gets the regulation act that defines these heat transfer coefficients\.

```csharp
DiGi.Analytical.Building.HVAC.Classes.RegulationAct? RegulationAct { get; }
```

#### Property Value
[RegulationAct](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulationAct 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulationAct')
### Methods

<a name='DiGi.Analytical.Building.HVAC.Interfaces.IRegulatedHeatTransferCoefficients.GetNames()'></a>

## IRegulatedHeatTransferCoefficients\.GetNames\(\) Method

Gets the list of all coefficient names defined in this regulation\.

```csharp
System.Collections.Generic.List<string> GetNames();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of coefficient names\.

<a name='DiGi.Analytical.Building.HVAC.Interfaces.IRegulatedHeatTransferCoefficients.TryGetValue(string,double)'></a>

## IRegulatedHeatTransferCoefficients\.TryGetValue\(string, double\) Method

Attempts to retrieve the heat transfer coefficient value for the specified name\.

```csharp
bool TryGetValue(string name, out double value);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Interfaces.IRegulatedHeatTransferCoefficients.TryGetValue(string,double).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the coefficient to retrieve\.

<a name='DiGi.Analytical.Building.HVAC.Interfaces.IRegulatedHeatTransferCoefficients.TryGetValue(string,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the coefficient value if found; otherwise, zero\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the coefficient was found; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.