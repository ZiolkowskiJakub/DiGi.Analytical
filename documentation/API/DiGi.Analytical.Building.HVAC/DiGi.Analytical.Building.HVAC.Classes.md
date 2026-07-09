#### [DiGi\.Analytical\.Building\.HVAC](DiGi.Analytical.Building.HVAC.Overview.md 'DiGi\.Analytical\.Building\.HVAC\.Overview')

## DiGi\.Analytical\.Building\.HVAC\.Classes Namespace
### Classes

<a name='DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter'></a>

## CoolingEmitter Class

Represents a cooling emitter component within the HVAC system used to remove heat from a space\.

```csharp
public class CoolingEmitter : DiGi.Analytical.Building.HVAC.Classes.Emitter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [Emitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Emitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Emitter') → CoolingEmitter
### Constructors

<a name='DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter.CoolingEmitter()'></a>

## CoolingEmitter\(\) Constructor

Initializes a new instance of the [CoolingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.CoolingEmitter') class\.

```csharp
public CoolingEmitter();
```

<a name='DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter.CoolingEmitter(DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter)'></a>

## CoolingEmitter\(HeatingEmitter\) Constructor

Initializes a new instance of the [CoolingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.CoolingEmitter') class using the specified [HeatingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.HeatingEmitter')\.

```csharp
public CoolingEmitter(DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter? heatingEmitter);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter.CoolingEmitter(DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter).heatingEmitter'></a>

`heatingEmitter` [HeatingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.HeatingEmitter')

The [HeatingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.HeatingEmitter') instance used to initialize this object\.

<a name='DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter.CoolingEmitter(System.Text.Json.Nodes.JsonObject)'></a>

## CoolingEmitter\(JsonObject\) Constructor

Initializes a new instance of the [CoolingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.CoolingEmitter') class using the specified JSON object\.

```csharp
public CoolingEmitter(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter.CoolingEmitter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the cooling emitter\. This value can be null\.

<a name='DiGi.Analytical.Building.HVAC.Classes.Emitter'></a>

## Emitter Class

Represents an abstract base class for HVAC emitter components, defining core properties for thermal radiation and operational temperature thresholds\.

```csharp
public abstract class Emitter : DiGi.Core.Parameter.Classes.ParametrizedObject, DiGi.Analytical.Building.HVAC.Interfaces.IHVACNamedObject, DiGi.Analytical.Building.HVAC.Interfaces.IHVACObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → Emitter

Derived  
↳ [CoolingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.CoolingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.CoolingEmitter')  
↳ [HeatingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.HeatingEmitter')

Implements [DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.ihvacnamedobject 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACNamedObject'), [DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.ihvacobject 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject')
### Constructors

<a name='DiGi.Analytical.Building.HVAC.Classes.Emitter.Emitter()'></a>

## Emitter\(\) Constructor

Initializes a new instance of the [Emitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Emitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Emitter') class\.

```csharp
public Emitter();
```

<a name='DiGi.Analytical.Building.HVAC.Classes.Emitter.Emitter(DiGi.Analytical.Building.HVAC.Classes.Emitter)'></a>

## Emitter\(Emitter\) Constructor

Initializes a new instance of the [Emitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Emitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Emitter') class by copying the properties from another [Emitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Emitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Emitter') instance\.

```csharp
public Emitter(DiGi.Analytical.Building.HVAC.Classes.Emitter? emitter);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.Emitter.Emitter(DiGi.Analytical.Building.HVAC.Classes.Emitter).emitter'></a>

`emitter` [Emitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Emitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Emitter')

The source [Emitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Emitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Emitter') object to copy values from; if null, only base class initialization is performed\.

<a name='DiGi.Analytical.Building.HVAC.Classes.Emitter.Emitter(System.Text.Json.Nodes.JsonObject)'></a>

## Emitter\(JsonObject\) Constructor

Initializes a new instance of the [Emitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Emitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Emitter') class using the specified JSON object\.

```csharp
public Emitter(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.Emitter.Emitter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the properties of the emitter; may be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.
### Properties

<a name='DiGi.Analytical.Building.HVAC.Classes.Emitter.Description'></a>

## Emitter\.Description Property

Gets or sets the description of the emitter\.

```csharp
public string? Description { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.HVAC.Classes.Emitter.MaxOutsideTemperature'></a>

## Emitter\.MaxOutsideTemperature Property

Gets or sets the maximum outside temperature\.

```csharp
public double MaxOutsideTemperature { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Analytical.Building.HVAC.Classes.Emitter.Name'></a>

## Emitter\.Name Property

Gets or sets the name of the emitter\.

```csharp
public string? Name { get; set; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.HVAC.Classes.Emitter.OffOutsideTemperature'></a>

## Emitter\.OffOutsideTemperature Property

Gets or sets the outside temperature threshold at which the emitter is turned off\.

```csharp
public double OffOutsideTemperature { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Analytical.Building.HVAC.Classes.Emitter.RadiantProportion'></a>

## Emitter\.RadiantProportion Property

Gets or sets the radiant proportion of the emitter as a value between 0 and 1\.

```csharp
public DiGi.Core.Classes.Factor RadiantProportion { get; set; }
```

#### Property Value
[DiGi\.Core\.Classes\.Factor](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.factor 'DiGi\.Core\.Classes\.Factor')

<a name='DiGi.Analytical.Building.HVAC.Classes.Emitter.ViewCoefficient'></a>

## Emitter\.ViewCoefficient Property

Gets or sets the view coefficient of the emitter as a normalization factor between 0 and 1\.

```csharp
public DiGi.Core.Classes.Factor ViewCoefficient { get; set; }
```

#### Property Value
[DiGi\.Core\.Classes\.Factor](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.factor 'DiGi\.Core\.Classes\.Factor')

<a name='DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter'></a>

## HeatingEmitter Class

Represents a heating emitter component within the HVAC system used for thermal analysis\.

```csharp
public class HeatingEmitter : DiGi.Analytical.Building.HVAC.Classes.Emitter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [Emitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Emitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Emitter') → HeatingEmitter
### Constructors

<a name='DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter.HeatingEmitter()'></a>

## HeatingEmitter\(\) Constructor

Initializes a new instance of the [HeatingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.HeatingEmitter') class\.

```csharp
public HeatingEmitter();
```

<a name='DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter.HeatingEmitter(DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter)'></a>

## HeatingEmitter\(HeatingEmitter\) Constructor

Initializes a new instance of the [HeatingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.HeatingEmitter') class using an existing [HeatingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.HeatingEmitter') instance\.

```csharp
public HeatingEmitter(DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter? heatingEmitter);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter.HeatingEmitter(DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter).heatingEmitter'></a>

`heatingEmitter` [HeatingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.HeatingEmitter')

The source [HeatingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.HeatingEmitter') instance to copy from\.

<a name='DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter.HeatingEmitter(System.Text.Json.Nodes.JsonObject)'></a>

## HeatingEmitter\(JsonObject\) Constructor

Initializes a new instance of the [HeatingEmitter](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter 'DiGi\.Analytical\.Building\.HVAC\.Classes\.HeatingEmitter') class using the specified JSON object\.

```csharp
public HeatingEmitter(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.HeatingEmitter.HeatingEmitter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to populate the properties of the heating emitter; can be null\.

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain'></a>

## InternalGain Class

Represents the internal heat gain parameters for a building space, including radiant proportions and view coefficients for lighting, occupants, and equipment\.

```csharp
public class InternalGain : DiGi.Core.Parameter.Classes.ParametrizedObject, DiGi.Analytical.Building.HVAC.Interfaces.IHVACNamedObject, DiGi.Analytical.Building.HVAC.Interfaces.IHVACObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → InternalGain

Implements [DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.ihvacnamedobject 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACNamedObject'), [DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.ihvacobject 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject')
### Constructors

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain.InternalGain()'></a>

## InternalGain\(\) Constructor

Initializes a new instance of the [InternalGain](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.InternalGain 'DiGi\.Analytical\.Building\.HVAC\.Classes\.InternalGain') class\.

```csharp
public InternalGain();
```

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain.InternalGain(DiGi.Analytical.Building.HVAC.Classes.InternalGain)'></a>

## InternalGain\(InternalGain\) Constructor

Initializes a new instance of the [InternalGain](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.InternalGain 'DiGi\.Analytical\.Building\.HVAC\.Classes\.InternalGain') class by copying values from an existing [InternalGain](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.InternalGain 'DiGi\.Analytical\.Building\.HVAC\.Classes\.InternalGain') instance\.

```csharp
public InternalGain(DiGi.Analytical.Building.HVAC.Classes.InternalGain? internalGain);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain.InternalGain(DiGi.Analytical.Building.HVAC.Classes.InternalGain).internalGain'></a>

`internalGain` [InternalGain](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.InternalGain 'DiGi\.Analytical\.Building\.HVAC\.Classes\.InternalGain')

The source [InternalGain](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.InternalGain 'DiGi\.Analytical\.Building\.HVAC\.Classes\.InternalGain') instance to copy data from, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain.InternalGain(System.Text.Json.Nodes.JsonObject)'></a>

## InternalGain\(JsonObject\) Constructor

Initializes a new instance of the [InternalGain](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.InternalGain 'DiGi\.Analytical\.Building\.HVAC\.Classes\.InternalGain') class using the specified JSON object\.

```csharp
public InternalGain(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain.InternalGain(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the initialization data, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.
### Properties

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain.Description'></a>

## InternalGain\.Description Property

Gets or sets the description of the internal gain\.

```csharp
public string? Description { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain.EquipmentRadiantProportion'></a>

## InternalGain\.EquipmentRadiantProportion Property

Gets or sets the proportion of equipment internal heat gain that is radiant, expressed as a factor between 0 and 1\.

```csharp
public DiGi.Core.Classes.Factor EquipmentRadiantProportion { get; set; }
```

#### Property Value
[DiGi\.Core\.Classes\.Factor](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.factor 'DiGi\.Core\.Classes\.Factor')

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain.EquipmentViewCoefficient'></a>

## InternalGain\.EquipmentViewCoefficient Property

Gets or sets the view coefficient for equipment internal gains, represented as a factor between 0 and 1\.

```csharp
public DiGi.Core.Classes.Factor EquipmentViewCoefficient { get; set; }
```

#### Property Value
[DiGi\.Core\.Classes\.Factor](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.factor 'DiGi\.Core\.Classes\.Factor')

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain.LightingRadiantProportion'></a>

## InternalGain\.LightingRadiantProportion Property

Gets or sets the proportion of lighting heat gain that is radiant\.

```csharp
public DiGi.Core.Classes.Factor LightingRadiantProportion { get; set; }
```

#### Property Value
[DiGi\.Core\.Classes\.Factor](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.factor 'DiGi\.Core\.Classes\.Factor')

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain.LightingViewCoefficient'></a>

## InternalGain\.LightingViewCoefficient Property

Gets or sets the lighting view coefficient, represented as a factor between 0 and 1\.

```csharp
public DiGi.Core.Classes.Factor LightingViewCoefficient { get; set; }
```

#### Property Value
[DiGi\.Core\.Classes\.Factor](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.factor 'DiGi\.Core\.Classes\.Factor')

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain.Name'></a>

## InternalGain\.Name Property

Gets or sets the name of the internal gain\.

```csharp
public string? Name { get; set; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain.OccupantRadiantProportion'></a>

## InternalGain\.OccupantRadiantProportion Property

Gets or sets the proportion of occupant internal heat gain that is radiant, expressed as a factor between 0 and 1\.

```csharp
public DiGi.Core.Classes.Factor OccupantRadiantProportion { get; set; }
```

#### Property Value
[DiGi\.Core\.Classes\.Factor](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.factor 'DiGi\.Core\.Classes\.Factor')

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain.OccupantViewCoefficient'></a>

## InternalGain\.OccupantViewCoefficient Property

Gets or sets the view coefficient for occupant internal gains, representing a normalization factor between 0 and 1\.

```csharp
public DiGi.Core.Classes.Factor OccupantViewCoefficient { get; set; }
```

#### Property Value
[DiGi\.Core\.Classes\.Factor](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.factor 'DiGi\.Core\.Classes\.Factor')

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain.this[DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType]'></a>

## InternalGain\.this\[InternalGainProfileType\] Property

Gets or sets the profile associated with the specified internal gain profile type\.

```csharp
public DiGi.Analytical.Building.Interfaces.IProfile? this[DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType internalGainProfileType] { get; set; }
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.InternalGain.this[DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType].internalGainProfileType'></a>

`internalGainProfileType` [InternalGainProfileType](DiGi.Analytical.Building.HVAC.Enums.md#DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType 'DiGi\.Analytical\.Building\.HVAC\.Enums\.InternalGainProfileType')

The type of the internal gain profile to retrieve or set\.

#### Property Value
[DiGi\.Analytical\.Building\.Interfaces\.IProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iprofile 'DiGi\.Analytical\.Building\.Interfaces\.IProfile')

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_'></a>

## RegulatedHeatTransferCoefficients\<TEnum\> Class

Provides an abstract base implementation for regulated heat transfer coefficients, associating specific regulatory categories with their corresponding numerical values\.

```csharp
public abstract class RegulatedHeatTransferCoefficients<TEnum> : DiGi.Core.Classes.SerializableObject, DiGi.Analytical.Building.HVAC.Interfaces.IRegulatedHeatTransferCoefficients, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
    where TEnum : System.Enum
```
#### Type parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.TEnum'></a>

`TEnum`

The enumeration type used to define the keys for the heat transfer coefficient values\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → RegulatedHeatTransferCoefficients\<TEnum\>

Derived  
↳ [RegulatedHeatTransferCoefficients\_2002](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2002 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2002')  
↳ [RegulatedHeatTransferCoefficients\_2009](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2009 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2009')  
↳ [RegulatedHeatTransferCoefficients\_2014](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2014')

Implements [DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IRegulatedHeatTransferCoefficients](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.iregulatedheattransfercoefficients 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IRegulatedHeatTransferCoefficients'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.RegulatedHeatTransferCoefficients(DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_)'></a>

## RegulatedHeatTransferCoefficients\(RegulatedHeatTransferCoefficients\<TEnum\>\) Constructor

Initializes a new instance of the [RegulatedHeatTransferCoefficients&lt;TEnum&gt;](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_ 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>') class by copying the values from an existing instance\.

```csharp
public RegulatedHeatTransferCoefficients(DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients<TEnum> regulatedHeatTransferCoefficients);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.RegulatedHeatTransferCoefficients(DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_).regulatedHeatTransferCoefficients'></a>

`regulatedHeatTransferCoefficients` [DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients&lt;](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_ 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>')[TEnum](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.TEnum 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>\.TEnum')[&gt;](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_ 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>')

The source instance to copy heat transfer coefficients and regulation act from\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.RegulatedHeatTransferCoefficients(DiGi.Analytical.Building.HVAC.Classes.RegulationAct)'></a>

## RegulatedHeatTransferCoefficients\(RegulationAct\) Constructor

Initializes a new instance of the [RegulatedHeatTransferCoefficients&lt;TEnum&gt;](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_ 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>') class with the specified regulation act\.

```csharp
public RegulatedHeatTransferCoefficients(DiGi.Analytical.Building.HVAC.Classes.RegulationAct? regulationAct);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.RegulatedHeatTransferCoefficients(DiGi.Analytical.Building.HVAC.Classes.RegulationAct).regulationAct'></a>

`regulationAct` [RegulationAct](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulationAct 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulationAct')

The regulation act associated with the heat transfer coefficients, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if not specified\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.RegulatedHeatTransferCoefficients(System.Text.Json.Nodes.JsonObject)'></a>

## RegulatedHeatTransferCoefficients\(JsonObject\) Constructor

Initializes a new instance of the [RegulatedHeatTransferCoefficients&lt;TEnum&gt;](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_ 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>') class using the specified JSON object\.

```csharp
public RegulatedHeatTransferCoefficients(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.RegulatedHeatTransferCoefficients(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the serialized data for initialization\.
### Properties

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.RegulationAct'></a>

## RegulatedHeatTransferCoefficients\<TEnum\>\.RegulationAct Property

Gets the regulation act associated with the regulated heat transfer coefficients\.

```csharp
public DiGi.Analytical.Building.HVAC.Classes.RegulationAct? RegulationAct { get; }
```

Implements [RegulationAct](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.iregulatedheattransfercoefficients.regulationact 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IRegulatedHeatTransferCoefficients\.RegulationAct')

#### Property Value
[RegulationAct](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulationAct 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulationAct')

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.this[TEnum]'></a>

## RegulatedHeatTransferCoefficients\<TEnum\>\.this\[TEnum\] Property

Gets or sets the heat transfer coefficient associated with the specified enumeration member\.

```csharp
public double this[TEnum @enum] { get; set; }
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.this[TEnum].enum'></a>

`enum` [TEnum](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.TEnum 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>\.TEnum')

The enumeration member used to access the heat transfer coefficient\.

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.GetEnums()'></a>

## RegulatedHeatTransferCoefficients\<TEnum\>\.GetEnums\(\) Method

Retrieves the list of enumeration values used as keys for the heat transfer coefficients\.

```csharp
public System.Collections.Generic.List<TEnum> GetEnums();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TEnum](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.TEnum 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>\.TEnum')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing all the enumeration values currently defined in the coefficients collection\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.GetNames()'></a>

## RegulatedHeatTransferCoefficients\<TEnum\>\.GetNames\(\) Method

Retrieves a list of names or descriptions for the regulated heat transfer coefficients\.

```csharp
public System.Collections.Generic.List<string> GetNames();
```

Implements [GetNames\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.iregulatedheattransfercoefficients.getnames 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IRegulatedHeatTransferCoefficients\.GetNames')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of strings representing the names of the coefficients\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.SetValue(TEnum,double)'></a>

## RegulatedHeatTransferCoefficients\<TEnum\>\.SetValue\(TEnum, double\) Method

Sets the heat transfer coefficient value for the specified enumeration member\.

```csharp
public bool SetValue(TEnum @enum, double value);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.SetValue(TEnum,double).enum'></a>

`enum` [TEnum](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.TEnum 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>\.TEnum')

The enumeration member identifying the coefficient to set\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.SetValue(TEnum,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to assign to the coefficient\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully set; false if the provided value is [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.TryGetValue(string,double)'></a>

## RegulatedHeatTransferCoefficients\<TEnum\>\.TryGetValue\(string, double\) Method

Attempts to retrieve the heat transfer coefficient value associated with the specified name\.

```csharp
public bool TryGetValue(string name, out double value);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.TryGetValue(string,double).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the coefficient to retrieve, matching either the enum description or its string representation\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.TryGetValue(string,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the retrieved value if successful; otherwise, [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

Implements [TryGetValue\(string, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.iregulatedheattransfercoefficients.trygetvalue#digi-analytical-building-hvac-interfaces-iregulatedheattransfercoefficients-trygetvalue(system-string-system-double@) 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IRegulatedHeatTransferCoefficients\.TryGetValue\(System\.String,System\.Double@\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved; otherwise, false\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.TryGetValue(TEnum,double)'></a>

## RegulatedHeatTransferCoefficients\<TEnum\>\.TryGetValue\(TEnum, double\) Method

Attempts to retrieve the heat transfer coefficient value associated with the specified enumeration member\.

```csharp
public bool TryGetValue(TEnum @enum, out double value);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.TryGetValue(TEnum,double).enum'></a>

`enum` [TEnum](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.TEnum 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>\.TEnum')

The enumeration member used as the key for retrieval\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_.TryGetValue(TEnum,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the retrieved value if successful; otherwise, [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved; otherwise, false\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager'></a>

## RegulatedHeatTransferCoefficientsManager Class

Manages the collection and retrieval of regulated heat transfer coefficients associated with specific timestamps\.

```csharp
public class RegulatedHeatTransferCoefficientsManager : DiGi.Core.Classes.SerializableObject, DiGi.Analytical.Building.HVAC.Interfaces.IHVACObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → RegulatedHeatTransferCoefficientsManager

Implements [DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.ihvacobject 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager.RegulatedHeatTransferCoefficientsManager()'></a>

## RegulatedHeatTransferCoefficientsManager\(\) Constructor

Initializes a new instance of the [RegulatedHeatTransferCoefficientsManager](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficientsManager') class\.

```csharp
public RegulatedHeatTransferCoefficientsManager();
```

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager.RegulatedHeatTransferCoefficientsManager(DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager)'></a>

## RegulatedHeatTransferCoefficientsManager\(RegulatedHeatTransferCoefficientsManager\) Constructor

Initializes a new instance of the [RegulatedHeatTransferCoefficientsManager](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficientsManager') class by copying the specified instance\.

```csharp
public RegulatedHeatTransferCoefficientsManager(DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager regulatedHeatTransferCoefficientsManager);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager.RegulatedHeatTransferCoefficientsManager(DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager).regulatedHeatTransferCoefficientsManager'></a>

`regulatedHeatTransferCoefficientsManager` [RegulatedHeatTransferCoefficientsManager](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficientsManager')

The source [RegulatedHeatTransferCoefficientsManager](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficientsManager') instance to copy from\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager.RegulatedHeatTransferCoefficientsManager(System.Text.Json.Nodes.JsonObject)'></a>

## RegulatedHeatTransferCoefficientsManager\(JsonObject\) Constructor

Initializes a new instance of the [RegulatedHeatTransferCoefficientsManager](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficientsManager') class from the specified JSON object\.

```csharp
public RegulatedHeatTransferCoefficientsManager(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager.RegulatedHeatTransferCoefficientsManager(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to populate the properties of the manager\.
### Methods

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager.Add(DiGi.Analytical.Building.HVAC.Interfaces.IRegulatedHeatTransferCoefficients)'></a>

## RegulatedHeatTransferCoefficientsManager\.Add\(IRegulatedHeatTransferCoefficients\) Method

Adds a regulated heat transfer coefficient to the manager\.

```csharp
public bool Add(DiGi.Analytical.Building.HVAC.Interfaces.IRegulatedHeatTransferCoefficients? regulatedHeatTransferCoefficients);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager.Add(DiGi.Analytical.Building.HVAC.Interfaces.IRegulatedHeatTransferCoefficients).regulatedHeatTransferCoefficients'></a>

`regulatedHeatTransferCoefficients` [DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IRegulatedHeatTransferCoefficients](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.iregulatedheattransfercoefficients 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IRegulatedHeatTransferCoefficients')

The regulated heat transfer coefficients to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the regulated heat transfer coefficients were successfully added; otherwise, false\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager.GetRegulatedHeatTransferCoefficients(System.DateTime)'></a>

## RegulatedHeatTransferCoefficientsManager\.GetRegulatedHeatTransferCoefficients\(DateTime\) Method

Retrieves the regulated heat transfer coefficients applicable for the specified date and time\.

```csharp
public DiGi.Analytical.Building.HVAC.Interfaces.IRegulatedHeatTransferCoefficients? GetRegulatedHeatTransferCoefficients(System.DateTime dateTime);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager.GetRegulatedHeatTransferCoefficients(System.DateTime).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date and time used to determine the active regulated heat transfer coefficients\.

#### Returns
[DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IRegulatedHeatTransferCoefficients](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.iregulatedheattransfercoefficients 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IRegulatedHeatTransferCoefficients')  
The [DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IRegulatedHeatTransferCoefficients](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.iregulatedheattransfercoefficients 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IRegulatedHeatTransferCoefficients') corresponding to the provided date, or `null` if no applicable coefficients are found\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager.RegulatedHeatTransferCoefficients_TRegulatedHeatTransferCoefficients_()'></a>

## RegulatedHeatTransferCoefficientsManager\.RegulatedHeatTransferCoefficients\<TRegulatedHeatTransferCoefficients\>\(\) Method

Retrieves a list of regulated heat transfer coefficients filtered by the specified type\.

```csharp
public System.Collections.Generic.List<TRegulatedHeatTransferCoefficients> RegulatedHeatTransferCoefficients<TRegulatedHeatTransferCoefficients>()
    where TRegulatedHeatTransferCoefficients : DiGi.Analytical.Building.HVAC.Interfaces.IRegulatedHeatTransferCoefficients;
```
#### Type parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager.RegulatedHeatTransferCoefficients_TRegulatedHeatTransferCoefficients_().TRegulatedHeatTransferCoefficients'></a>

`TRegulatedHeatTransferCoefficients`

The specific type of regulated heat transfer coefficients to retrieve, which must implement [DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IRegulatedHeatTransferCoefficients](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.iregulatedheattransfercoefficients 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IRegulatedHeatTransferCoefficients')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TRegulatedHeatTransferCoefficients](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager.RegulatedHeatTransferCoefficients_TRegulatedHeatTransferCoefficients_().TRegulatedHeatTransferCoefficients 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficientsManager\.RegulatedHeatTransferCoefficients\<TRegulatedHeatTransferCoefficients\>\(\)\.TRegulatedHeatTransferCoefficients')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of all instances that match the specified type [TRegulatedHeatTransferCoefficients](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficientsManager.RegulatedHeatTransferCoefficients_TRegulatedHeatTransferCoefficients_().TRegulatedHeatTransferCoefficients 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficientsManager\.RegulatedHeatTransferCoefficients\<TRegulatedHeatTransferCoefficients\>\(\)\.TRegulatedHeatTransferCoefficients')\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2002'></a>

## RegulatedHeatTransferCoefficients\_2002 Class

Represents the regulated heat transfer coefficients according to the 2002 regulation standards for external partition types\.

```csharp
public class RegulatedHeatTransferCoefficients_2002 : DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients<DiGi.Analytical.Building.HVAC.Enums.ExternalPartitionType_2002>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients&lt;](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_ 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>')[ExternalPartitionType\_2002](DiGi.Analytical.Building.HVAC.Enums.md#DiGi.Analytical.Building.HVAC.Enums.ExternalPartitionType_2002 'DiGi\.Analytical\.Building\.HVAC\.Enums\.ExternalPartitionType\_2002')[&gt;](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_ 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>') → RegulatedHeatTransferCoefficients\_2002
### Constructors

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2002.RegulatedHeatTransferCoefficients_2002(DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2002)'></a>

## RegulatedHeatTransferCoefficients\_2002\(RegulatedHeatTransferCoefficients\_2002\) Constructor

Initializes a new instance of the [RegulatedHeatTransferCoefficients\_2002](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2002 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2002') class using another instance of the same type\.

```csharp
public RegulatedHeatTransferCoefficients_2002(DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2002 regulatedHeatTransferCoefficients_2002);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2002.RegulatedHeatTransferCoefficients_2002(DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2002).regulatedHeatTransferCoefficients_2002'></a>

`regulatedHeatTransferCoefficients_2002` [RegulatedHeatTransferCoefficients\_2002](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2002 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2002')

The source instance to copy from\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2002.RegulatedHeatTransferCoefficients_2002(DiGi.Analytical.Building.HVAC.Classes.RegulationAct)'></a>

## RegulatedHeatTransferCoefficients\_2002\(RegulationAct\) Constructor

Initializes a new instance of the [RegulatedHeatTransferCoefficients\_2002](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2002 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2002') class\.

```csharp
public RegulatedHeatTransferCoefficients_2002(DiGi.Analytical.Building.HVAC.Classes.RegulationAct? regulationAct);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2002.RegulatedHeatTransferCoefficients_2002(DiGi.Analytical.Building.HVAC.Classes.RegulationAct).regulationAct'></a>

`regulationAct` [RegulationAct](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulationAct 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulationAct')

The regulation act used to initialize the heat transfer coefficients\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2002.RegulatedHeatTransferCoefficients_2002(System.Text.Json.Nodes.JsonObject)'></a>

## RegulatedHeatTransferCoefficients\_2002\(JsonObject\) Constructor

Initializes a new instance of the [RegulatedHeatTransferCoefficients\_2002](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2002 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2002') class using the specified JSON object\.

```csharp
public RegulatedHeatTransferCoefficients_2002(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2002.RegulatedHeatTransferCoefficients_2002(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2009'></a>

## RegulatedHeatTransferCoefficients\_2009 Class

Provides the regulated heat transfer coefficients based on the 2009 regulations for external partition types\.

```csharp
public class RegulatedHeatTransferCoefficients_2009 : DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients<DiGi.Analytical.Building.HVAC.Enums.ExternalPartitionType_2009>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients&lt;](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_ 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>')[ExternalPartitionType\_2009](DiGi.Analytical.Building.HVAC.Enums.md#DiGi.Analytical.Building.HVAC.Enums.ExternalPartitionType_2009 'DiGi\.Analytical\.Building\.HVAC\.Enums\.ExternalPartitionType\_2009')[&gt;](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_ 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>') → RegulatedHeatTransferCoefficients\_2009
### Constructors

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2009.RegulatedHeatTransferCoefficients_2009(DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2009)'></a>

## RegulatedHeatTransferCoefficients\_2009\(RegulatedHeatTransferCoefficients\_2009\) Constructor

Initializes a new instance of the [RegulatedHeatTransferCoefficients\_2009](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2009 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2009') class using another instance of the same type\.

```csharp
public RegulatedHeatTransferCoefficients_2009(DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2009 regulatedHeatTransferCoefficients_2009);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2009.RegulatedHeatTransferCoefficients_2009(DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2009).regulatedHeatTransferCoefficients_2009'></a>

`regulatedHeatTransferCoefficients_2009` [RegulatedHeatTransferCoefficients\_2009](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2009 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2009')

The source instance to copy from\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2009.RegulatedHeatTransferCoefficients_2009(DiGi.Analytical.Building.HVAC.Classes.RegulationAct)'></a>

## RegulatedHeatTransferCoefficients\_2009\(RegulationAct\) Constructor

Initializes a new instance of the [RegulatedHeatTransferCoefficients\_2009](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2009 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2009') class\.

```csharp
public RegulatedHeatTransferCoefficients_2009(DiGi.Analytical.Building.HVAC.Classes.RegulationAct? regulationAct);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2009.RegulatedHeatTransferCoefficients_2009(DiGi.Analytical.Building.HVAC.Classes.RegulationAct).regulationAct'></a>

`regulationAct` [RegulationAct](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulationAct 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulationAct')

The regulation act used to determine the heat transfer coefficients\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2009.RegulatedHeatTransferCoefficients_2009(System.Text.Json.Nodes.JsonObject)'></a>

## RegulatedHeatTransferCoefficients\_2009\(JsonObject\) Constructor

Initializes a new instance of the [RegulatedHeatTransferCoefficients\_2009](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2009 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2009') class using the specified JSON object\.

```csharp
public RegulatedHeatTransferCoefficients_2009(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2009.RegulatedHeatTransferCoefficients_2009(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014'></a>

## RegulatedHeatTransferCoefficients\_2014 Class

Represents the regulated heat transfer coefficients according to the 2014 regulations for external partition types\.

```csharp
public class RegulatedHeatTransferCoefficients_2014 : DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients<DiGi.Analytical.Building.HVAC.Enums.ExternalPartitionType_2014>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients&lt;](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_ 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>')[ExternalPartitionType\_2014](DiGi.Analytical.Building.HVAC.Enums.md#DiGi.Analytical.Building.HVAC.Enums.ExternalPartitionType_2014 'DiGi\.Analytical\.Building\.HVAC\.Enums\.ExternalPartitionType\_2014')[&gt;](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_TEnum_ 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\<TEnum\>') → RegulatedHeatTransferCoefficients\_2014
### Constructors

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014.RegulatedHeatTransferCoefficients_2014(DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014)'></a>

## RegulatedHeatTransferCoefficients\_2014\(RegulatedHeatTransferCoefficients\_2014\) Constructor

Initializes a new instance of the [RegulatedHeatTransferCoefficients\_2014](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2014') class using an existing instance of the same type\.

```csharp
public RegulatedHeatTransferCoefficients_2014(DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014 regulatedHeatTransferCoefficients_2014);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014.RegulatedHeatTransferCoefficients_2014(DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014).regulatedHeatTransferCoefficients_2014'></a>

`regulatedHeatTransferCoefficients_2014` [RegulatedHeatTransferCoefficients\_2014](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2014')

The source [RegulatedHeatTransferCoefficients\_2014](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2014') instance to copy from\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014.RegulatedHeatTransferCoefficients_2014(DiGi.Analytical.Building.HVAC.Classes.RegulationAct)'></a>

## RegulatedHeatTransferCoefficients\_2014\(RegulationAct\) Constructor

Initializes a new instance of the [RegulatedHeatTransferCoefficients\_2014](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2014') class using the specified regulation act\.

```csharp
public RegulatedHeatTransferCoefficients_2014(DiGi.Analytical.Building.HVAC.Classes.RegulationAct? regulationAct);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014.RegulatedHeatTransferCoefficients_2014(DiGi.Analytical.Building.HVAC.Classes.RegulationAct).regulationAct'></a>

`regulationAct` [RegulationAct](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulationAct 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulationAct')

The regulation act used to determine the heat transfer coefficients\. This value can be null\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014.RegulatedHeatTransferCoefficients_2014(System.Text.Json.Nodes.JsonObject)'></a>

## RegulatedHeatTransferCoefficients\_2014\(JsonObject\) Constructor

Initializes a new instance of the [RegulatedHeatTransferCoefficients\_2014](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulatedHeatTransferCoefficients\_2014') class using the specified JSON object\.

```csharp
public RegulatedHeatTransferCoefficients_2014(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulatedHeatTransferCoefficients_2014.RegulatedHeatTransferCoefficients_2014(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct'></a>

## RegulationAct Class

Represents a regulatory act associated with HVAC systems, providing details such as publication date, effective date, reference, name, and description\.

```csharp
public class RegulationAct : DiGi.Core.Classes.SerializableObject, DiGi.Analytical.Building.HVAC.Interfaces.IHVACNamedObject, DiGi.Analytical.Building.HVAC.Interfaces.IHVACObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject, DiGi.Core.Interfaces.IDescribableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → RegulationAct

Implements [DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.ihvacnamedobject 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACNamedObject'), [DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.ihvacobject 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject')
### Constructors

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct.RegulationAct(DiGi.Analytical.Building.HVAC.Classes.RegulationAct)'></a>

## RegulationAct\(RegulationAct\) Constructor

Initializes a new instance of the [RegulationAct](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulationAct 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulationAct') class by copying the values from an existing [RegulationAct](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulationAct 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulationAct') instance\.

```csharp
public RegulationAct(DiGi.Analytical.Building.HVAC.Classes.RegulationAct regulationAct);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct.RegulationAct(DiGi.Analytical.Building.HVAC.Classes.RegulationAct).regulationAct'></a>

`regulationAct` [RegulationAct](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulationAct 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulationAct')

The source [RegulationAct](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulationAct 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulationAct') object to copy data from\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct.RegulationAct(System.DateTime,System.DateTime,string,string,string)'></a>

## RegulationAct\(DateTime, DateTime, string, string, string\) Constructor

Initializes a new instance of the [RegulationAct](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulationAct 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulationAct') class\.

```csharp
public RegulationAct(System.DateTime publicationDate, System.DateTime effectiveDate, string? reference, string? name, string? descriprion);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct.RegulationAct(System.DateTime,System.DateTime,string,string,string).publicationDate'></a>

`publicationDate` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date when the regulation act was published\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct.RegulationAct(System.DateTime,System.DateTime,string,string,string).effectiveDate'></a>

`effectiveDate` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date when the regulation act becomes effective\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct.RegulationAct(System.DateTime,System.DateTime,string,string,string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier for the regulation act\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct.RegulationAct(System.DateTime,System.DateTime,string,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the regulation act\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct.RegulationAct(System.DateTime,System.DateTime,string,string,string).descriprion'></a>

`descriprion` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the regulation act\.

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct.RegulationAct(System.Text.Json.Nodes.JsonObject)'></a>

## RegulationAct\(JsonObject\) Constructor

Initializes a new instance of the [RegulationAct](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.RegulationAct 'DiGi\.Analytical\.Building\.HVAC\.Classes\.RegulationAct') class using the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public RegulationAct(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct.RegulationAct(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to populate the properties of the regulation act\.
### Properties

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct.Description'></a>

## RegulationAct\.Description Property

Gets the description of the regulation act\.

```csharp
public string? Description { get; }
```

Implements [Description](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject.description 'DiGi\.Core\.Interfaces\.IDescribableObject\.Description')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct.EffectiveDate'></a>

## RegulationAct\.EffectiveDate Property

Gets the effective date of the regulation act\.

```csharp
public System.DateTime EffectiveDate { get; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct.Name'></a>

## RegulationAct\.Name Property

Gets the name of the regulation act\.

```csharp
public string? Name { get; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct.PublicationDate'></a>

## RegulationAct\.PublicationDate Property

Gets the publication date of the regulation act\.

```csharp
public System.DateTime PublicationDate { get; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.Analytical.Building.HVAC.Classes.RegulationAct.Reference'></a>

## RegulationAct\.Reference Property

Gets the reference identifier for the regulation act\.

```csharp
public string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.HVAC.Classes.SystemProperties'></a>

## SystemProperties Class

Represents the configuration properties for an HVAC system, encompassing parameters such as metabolic rate, domestic hot water usage, outside air requirements, and target illuminance\.

```csharp
public class SystemProperties : DiGi.Core.Parameter.Classes.ParametrizedObject, DiGi.Analytical.Building.HVAC.Interfaces.IHVACObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → SystemProperties

Implements [DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.ihvacobject 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Analytical.Building.HVAC.Classes.SystemProperties.SystemProperties()'></a>

## SystemProperties\(\) Constructor

Initializes a new instance of the [SystemProperties](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.SystemProperties 'DiGi\.Analytical\.Building\.HVAC\.Classes\.SystemProperties') class\.

```csharp
public SystemProperties();
```

<a name='DiGi.Analytical.Building.HVAC.Classes.SystemProperties.SystemProperties(DiGi.Analytical.Building.HVAC.Classes.SystemProperties)'></a>

## SystemProperties\(SystemProperties\) Constructor

Initializes a new instance of the [SystemProperties](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.SystemProperties 'DiGi\.Analytical\.Building\.HVAC\.Classes\.SystemProperties') class using the properties of another [SystemProperties](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.SystemProperties 'DiGi\.Analytical\.Building\.HVAC\.Classes\.SystemProperties') instance\.

```csharp
public SystemProperties(DiGi.Analytical.Building.HVAC.Classes.SystemProperties? systemProperties);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.SystemProperties.SystemProperties(DiGi.Analytical.Building.HVAC.Classes.SystemProperties).systemProperties'></a>

`systemProperties` [SystemProperties](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.SystemProperties 'DiGi\.Analytical\.Building\.HVAC\.Classes\.SystemProperties')

The source [SystemProperties](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.SystemProperties 'DiGi\.Analytical\.Building\.HVAC\.Classes\.SystemProperties') instance to copy values from\. If null, the object is initialized with default values\.

<a name='DiGi.Analytical.Building.HVAC.Classes.SystemProperties.SystemProperties(System.Text.Json.Nodes.JsonObject)'></a>

## SystemProperties\(JsonObject\) Constructor

Initializes a new instance of the [SystemProperties](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.SystemProperties 'DiGi\.Analytical\.Building\.HVAC\.Classes\.SystemProperties') class using the specified JSON object\.

```csharp
public SystemProperties(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.SystemProperties.SystemProperties(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the system properties data, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.
### Properties

<a name='DiGi.Analytical.Building.HVAC.Classes.SystemProperties.DomesticHotWater'></a>

## SystemProperties\.DomesticHotWater Property

Gets or sets the domestic hot water usage in liters per day per square meter \[l/d/m2\]\.

```csharp
public double DomesticHotWater { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Analytical.Building.HVAC.Classes.SystemProperties.MetabolicRate'></a>

## SystemProperties\.MetabolicRate Property

Gets or sets the metabolic rate \[W/p\]\.

```csharp
public double MetabolicRate { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Analytical.Building.HVAC.Classes.SystemProperties.OutsideAir'></a>

## SystemProperties\.OutsideAir Property

Gets or sets the outside air flow rate in liters per second per person \[l/s/p\]\.

```csharp
public double OutsideAir { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Analytical.Building.HVAC.Classes.SystemProperties.TargetIlluminance'></a>

## SystemProperties\.TargetIlluminance Property

Gets or sets the target illuminance \[lx\]\.

```csharp
public double TargetIlluminance { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Analytical.Building.HVAC.Classes.Thermostat'></a>

## Thermostat Class

Represents a thermostat device used for controlling heating, ventilation, and air conditioning \(HVAC\) systems within a building analytical model\.

```csharp
public class Thermostat : DiGi.Core.Parameter.Classes.ParametrizedObject, DiGi.Analytical.Building.HVAC.Interfaces.IHVACNamedObject, DiGi.Analytical.Building.HVAC.Interfaces.IHVACObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → Thermostat

Implements [DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.ihvacnamedobject 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACNamedObject'), [DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.interfaces.ihvacobject 'DiGi\.Analytical\.Building\.HVAC\.Interfaces\.IHVACObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject')
### Constructors

<a name='DiGi.Analytical.Building.HVAC.Classes.Thermostat.Thermostat()'></a>

## Thermostat\(\) Constructor

Initializes a new instance of the [Thermostat](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Thermostat 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Thermostat') class\.

```csharp
public Thermostat();
```

<a name='DiGi.Analytical.Building.HVAC.Classes.Thermostat.Thermostat(DiGi.Analytical.Building.HVAC.Classes.Thermostat)'></a>

## Thermostat\(Thermostat\) Constructor

Initializes a new instance of the [Thermostat](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Thermostat 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Thermostat') class by copying the properties and profiles from an existing thermostat instance\.

```csharp
public Thermostat(DiGi.Analytical.Building.HVAC.Classes.Thermostat? thermostat);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.Thermostat.Thermostat(DiGi.Analytical.Building.HVAC.Classes.Thermostat).thermostat'></a>

`thermostat` [Thermostat](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Thermostat 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Thermostat')

The source [Thermostat](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Thermostat 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Thermostat') instance to copy data from, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Analytical.Building.HVAC.Classes.Thermostat.Thermostat(System.Text.Json.Nodes.JsonObject)'></a>

## Thermostat\(JsonObject\) Constructor

Initializes a new instance of the [Thermostat](DiGi.Analytical.Building.HVAC.Classes.md#DiGi.Analytical.Building.HVAC.Classes.Thermostat 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Thermostat') class using the specified JSON object\.

```csharp
public Thermostat(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.Thermostat.Thermostat(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the thermostat instance\.
### Properties

<a name='DiGi.Analytical.Building.HVAC.Classes.Thermostat.Description'></a>

## Thermostat\.Description Property

Gets or sets the description of the thermostat\.

```csharp
public string? Description { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.HVAC.Classes.Thermostat.Name'></a>

## Thermostat\.Name Property

Gets or sets the name of the thermostat\.

```csharp
public string? Name { get; set; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.HVAC.Classes.Thermostat.this[DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType]'></a>

## Thermostat\.this\[ThermostatProfileType\] Property

Gets or sets the profile associated with the specified thermostat profile type\.

```csharp
public DiGi.Analytical.Building.Interfaces.IProfile? this[DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType thermostatProfileType] { get; set; }
```
#### Parameters

<a name='DiGi.Analytical.Building.HVAC.Classes.Thermostat.this[DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType].thermostatProfileType'></a>

`thermostatProfileType` [ThermostatProfileType](DiGi.Analytical.Building.HVAC.Enums.md#DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType 'DiGi\.Analytical\.Building\.HVAC\.Enums\.ThermostatProfileType')

The type of the thermostat profile to retrieve or assign\.

#### Property Value
[DiGi\.Analytical\.Building\.Interfaces\.IProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iprofile 'DiGi\.Analytical\.Building\.Interfaces\.IProfile')