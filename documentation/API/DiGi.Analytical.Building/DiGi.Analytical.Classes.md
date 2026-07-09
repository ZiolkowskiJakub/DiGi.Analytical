#### [DiGi\.Analytical\.Building](DiGi.Analytical.Building.Overview.md 'DiGi\.Analytical\.Building\.Overview')

## DiGi\.Analytical\.Classes Namespace
### Classes

<a name='DiGi.Analytical.Classes.StructureLayer'></a>

## StructureLayer Class

Represents a structural layer within a building component, defining its sequence index and physical thickness\.

```csharp
public class StructureLayer : DiGi.Core.Classes.GuidObject, DiGi.Analytical.Building.Interfaces.IStructureLayer, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → StructureLayer

Implements [DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')
### Constructors

<a name='DiGi.Analytical.Classes.StructureLayer.StructureLayer(DiGi.Analytical.Classes.StructureLayer)'></a>

## StructureLayer\(StructureLayer\) Constructor

Initializes a new instance of the [StructureLayer](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.StructureLayer 'DiGi\.Analytical\.Classes\.StructureLayer') class using an existing [StructureLayer](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.StructureLayer 'DiGi\.Analytical\.Classes\.StructureLayer') object\.

```csharp
public StructureLayer(DiGi.Analytical.Classes.StructureLayer? structureLayer);
```
#### Parameters

<a name='DiGi.Analytical.Classes.StructureLayer.StructureLayer(DiGi.Analytical.Classes.StructureLayer).structureLayer'></a>

`structureLayer` [StructureLayer](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.StructureLayer 'DiGi\.Analytical\.Classes\.StructureLayer')

The source [StructureLayer](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.StructureLayer 'DiGi\.Analytical\.Classes\.StructureLayer') object to copy from\.

<a name='DiGi.Analytical.Classes.StructureLayer.StructureLayer(int,double)'></a>

## StructureLayer\(int, double\) Constructor

Initializes a new instance of the [StructureLayer](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.StructureLayer 'DiGi\.Analytical\.Classes\.StructureLayer') class with the specified index and thickness\.

```csharp
public StructureLayer(int index, double thickness);
```
#### Parameters

<a name='DiGi.Analytical.Classes.StructureLayer.StructureLayer(int,double).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the structure layer\.

<a name='DiGi.Analytical.Classes.StructureLayer.StructureLayer(int,double).thickness'></a>

`thickness` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The thickness of the structure layer\.

<a name='DiGi.Analytical.Classes.StructureLayer.StructureLayer(System.Text.Json.Nodes.JsonObject)'></a>

## StructureLayer\(JsonObject\) Constructor

Initializes a new instance of the [StructureLayer](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.StructureLayer 'DiGi\.Analytical\.Classes\.StructureLayer') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public StructureLayer(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Classes.StructureLayer.StructureLayer(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.
### Properties

<a name='DiGi.Analytical.Classes.StructureLayer.Index'></a>

## StructureLayer\.Index Property

Gets or sets the index of the structure layer\.

```csharp
public int Index { get; set; }
```

Implements [Index](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer.index 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer\.Index')

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Analytical.Classes.StructureLayer.Thickness'></a>

## StructureLayer\.Thickness Property

Gets or sets the thickness of the structure layer\.

```csharp
public double Thickness { get; set; }
```

Implements [Thickness](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer.thickness 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer\.Thickness')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')