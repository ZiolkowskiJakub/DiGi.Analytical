#### [DiGi\.Analytical](index.md 'index')

## DiGi\.Analytical\.Classes Namespace
### Classes

<a name='DiGi.Analytical.Classes.BoundingBox'></a>

## BoundingBox Class

Represents a three\-dimensional bounding box used in analytical geometry, extending basic spatial boundaries with unique identification properties\.

```csharp
public class BoundingBox : DiGi.Geometry.Spatial.Classes.BoundingBox3D, DiGi.Analytical.Interfaces.IAnalyticalGeometry, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IGuidObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Geometry\.Spatial\.Classes\.Geometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.geometry3d 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') → BoundingBox

Implements [DiGi\.Analytical\.Interfaces\.IAnalyticalGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalgeometry 'DiGi\.Analytical\.Interfaces\.IAnalyticalGeometry'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')
### Constructors

<a name='DiGi.Analytical.Classes.BoundingBox.BoundingBox(DiGi.Analytical.Classes.BoundingBox)'></a>

## BoundingBox\(BoundingBox\) Constructor

Initializes a new instance of the [BoundingBox](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.BoundingBox 'DiGi\.Analytical\.Classes\.BoundingBox') class by copying the values from an existing [BoundingBox](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.BoundingBox 'DiGi\.Analytical\.Classes\.BoundingBox') instance\.

```csharp
public BoundingBox(DiGi.Analytical.Classes.BoundingBox? boundingBox);
```
#### Parameters

<a name='DiGi.Analytical.Classes.BoundingBox.BoundingBox(DiGi.Analytical.Classes.BoundingBox).boundingBox'></a>

`boundingBox` [BoundingBox](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.BoundingBox 'DiGi\.Analytical\.Classes\.BoundingBox')

The source [BoundingBox](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.BoundingBox 'DiGi\.Analytical\.Classes\.BoundingBox') instance to copy data from\. This value can be null\.

<a name='DiGi.Analytical.Classes.BoundingBox.BoundingBox(DiGi.Core.Interfaces.IUniqueReference,DiGi.Geometry.Spatial.Classes.BoundingBox3D)'></a>

## BoundingBox\(IUniqueReference, BoundingBox3D\) Constructor

Initializes a new instance of the [BoundingBox](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.BoundingBox 'DiGi\.Analytical\.Classes\.BoundingBox') class using the specified unique reference and 3D bounding box\.

```csharp
public BoundingBox(DiGi.Core.Interfaces.IUniqueReference? uniqueReference, DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D);
```
#### Parameters

<a name='DiGi.Analytical.Classes.BoundingBox.BoundingBox(DiGi.Core.Interfaces.IUniqueReference,DiGi.Geometry.Spatial.Classes.BoundingBox3D).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference') that uniquely identifies this bounding box\.

<a name='DiGi.Analytical.Classes.BoundingBox.BoundingBox(DiGi.Core.Interfaces.IUniqueReference,DiGi.Geometry.Spatial.Classes.BoundingBox3D).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') used to initialize the spatial boundaries of the bounding box\.

<a name='DiGi.Analytical.Classes.BoundingBox.BoundingBox(DiGi.Geometry.Spatial.Classes.BoundingBox3D)'></a>

## BoundingBox\(BoundingBox3D\) Constructor

Initializes a new instance of the [BoundingBox](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.BoundingBox 'DiGi\.Analytical\.Classes\.BoundingBox') class using the specified [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')\.

```csharp
public BoundingBox(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D);
```
#### Parameters

<a name='DiGi.Analytical.Classes.BoundingBox.BoundingBox(DiGi.Geometry.Spatial.Classes.BoundingBox3D).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The optional [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') used to initialize the bounding box\.

<a name='DiGi.Analytical.Classes.BoundingBox.BoundingBox(System.Guid,DiGi.Analytical.Classes.BoundingBox)'></a>

## BoundingBox\(Guid, BoundingBox\) Constructor

Initializes a new instance of the [BoundingBox](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.BoundingBox 'DiGi\.Analytical\.Classes\.BoundingBox') class with a specified unique identifier and an optional existing bounding box\.

```csharp
public BoundingBox(System.Guid guid, DiGi.Analytical.Classes.BoundingBox? boundingBox);
```
#### Parameters

<a name='DiGi.Analytical.Classes.BoundingBox.BoundingBox(System.Guid,DiGi.Analytical.Classes.BoundingBox).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier to assign to this object\.

<a name='DiGi.Analytical.Classes.BoundingBox.BoundingBox(System.Guid,DiGi.Analytical.Classes.BoundingBox).boundingBox'></a>

`boundingBox` [BoundingBox](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.BoundingBox 'DiGi\.Analytical\.Classes\.BoundingBox')

An optional [BoundingBox](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.BoundingBox 'DiGi\.Analytical\.Classes\.BoundingBox') instance used to initialize base spatial properties and clone the unique reference\.

<a name='DiGi.Analytical.Classes.BoundingBox.BoundingBox(System.Text.Json.Nodes.JsonObject)'></a>

## BoundingBox\(JsonObject\) Constructor

Initializes a new instance of the [BoundingBox](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.BoundingBox 'DiGi\.Analytical\.Classes\.BoundingBox') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public BoundingBox(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Classes.BoundingBox.BoundingBox(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the bounding box\. This value can be null\.
### Properties

<a name='DiGi.Analytical.Classes.BoundingBox.Guid'></a>

## BoundingBox\.Guid Property

Gets the unique global identifier of the bounding box\.

```csharp
public System.Guid Guid { get; }
```

Implements [Guid](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject.guid 'DiGi\.Core\.Interfaces\.IGuidObject\.Guid')

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Analytical.Classes.BoundingBox.UniqueId'></a>

## BoundingBox\.UniqueId Property

Gets the unique identifier of the bounding box\.

```csharp
public string? UniqueId { get; }
```

Implements [UniqueId](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject.uniqueid 'DiGi\.Core\.Interfaces\.IUniqueObject\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Classes.BoundingBox.UniqueReference'></a>

## BoundingBox\.UniqueReference Property

Gets the unique reference for the bounding box\.

```csharp
public DiGi.Core.Interfaces.IUniqueReference? UniqueReference { get; }
```

#### Property Value
[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')
### Methods

<a name='DiGi.Analytical.Classes.BoundingBox.Duplicate(System.Nullable_System.Guid_)'></a>

## BoundingBox\.Duplicate\(Nullable\<Guid\>\) Method

Creates a duplicate of the current bounding box, optionally with a new GUID\.

```csharp
public DiGi.Core.Interfaces.IGuidObject? Duplicate(System.Nullable<System.Guid> guid=null);
```
#### Parameters

<a name='DiGi.Analytical.Classes.BoundingBox.Duplicate(System.Nullable_System.Guid_).guid'></a>

`guid` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional GUID to assign to the duplicated object\.

Implements [Duplicate\(Nullable&lt;Guid&gt;\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject.duplicate#digi-core-interfaces-iguidobject-duplicate(system-nullable{system-guid}) 'DiGi\.Core\.Interfaces\.IGuidObject\.Duplicate\(System\.Nullable\{System\.Guid\}\)')

#### Returns
[DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')  
A duplicate of the current object as an [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), or null if duplication fails\.

<a name='DiGi.Analytical.Classes.CoplanarFaceSplitEventArgs'></a>

## CoplanarFaceSplitEventArgs Class

Provides data for events related to splitting coplanar faces\.

```csharp
public class CoplanarFaceSplitEventArgs : DiGi.Analytical.Classes.FaceSplitEventArgs
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.EventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.eventargs 'System\.EventArgs') → [FaceSplitEventArgs](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FaceSplitEventArgs 'DiGi\.Analytical\.Classes\.FaceSplitEventArgs') → CoplanarFaceSplitEventArgs
### Constructors

<a name='DiGi.Analytical.Classes.CoplanarFaceSplitEventArgs.CoplanarFaceSplitEventArgs(DiGi.Analytical.Classes.Face,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Face_,DiGi.Geometry.Spatial.Classes.PolygonalFace3D)'></a>

## CoplanarFaceSplitEventArgs\(Face, IEnumerable\<Face\>, PolygonalFace3D\) Constructor

Initializes a new instance of the [CoplanarFaceSplitEventArgs](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.CoplanarFaceSplitEventArgs 'DiGi\.Analytical\.Classes\.CoplanarFaceSplitEventArgs') class\.

```csharp
public CoplanarFaceSplitEventArgs(DiGi.Analytical.Classes.Face? input, System.Collections.Generic.IEnumerable<DiGi.Analytical.Classes.Face>? outputs, DiGi.Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D);
```
#### Parameters

<a name='DiGi.Analytical.Classes.CoplanarFaceSplitEventArgs.CoplanarFaceSplitEventArgs(DiGi.Analytical.Classes.Face,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Face_,DiGi.Geometry.Spatial.Classes.PolygonalFace3D).input'></a>

`input` [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')

The input [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') that was split\. This value can be null\.

<a name='DiGi.Analytical.Classes.CoplanarFaceSplitEventArgs.CoplanarFaceSplitEventArgs(DiGi.Analytical.Classes.Face,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Face_,DiGi.Geometry.Spatial.Classes.PolygonalFace3D).outputs'></a>

`outputs` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') objects resulting from the coplanar face split\. This value can be null\.

<a name='DiGi.Analytical.Classes.CoplanarFaceSplitEventArgs.CoplanarFaceSplitEventArgs(DiGi.Analytical.Classes.Face,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Face_,DiGi.Geometry.Spatial.Classes.PolygonalFace3D).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') representing the planar polygonal face associated with the split\. This value can be null\.
### Properties

<a name='DiGi.Analytical.Classes.CoplanarFaceSplitEventArgs.Outputs'></a>

## CoplanarFaceSplitEventArgs\.Outputs Property

Gets the list of resulting [DiGi\.Geometry\.Spatial\.Classes\.Face](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.face 'DiGi\.Geometry\.Spatial\.Classes\.Face') objects produced by the coplanar face split operation\.

```csharp
public System.Collections.Generic.List<DiGi.Analytical.Classes.Face>? Outputs { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Analytical.Classes.Face'></a>

## Face Class

Represents a polygonal face within the analytical geometry system, providing spatial properties and unique identification\.

```csharp
public class Face : DiGi.Geometry.Spatial.Classes.PolygonalFace3D, DiGi.Analytical.Interfaces.IAnalyticalGeometry, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IGuidObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Geometry\.Spatial\.Classes\.Geometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.geometry3d 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → [DiGi\.Geometry\.Spatial\.Classes\.Planar&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.planar-1 'DiGi\.Geometry\.Spatial\.Classes\.Planar\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonalface2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.planar-1 'DiGi\.Geometry\.Spatial\.Classes\.Planar\`1') → [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') → Face

Implements [DiGi\.Analytical\.Interfaces\.IAnalyticalGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalgeometry 'DiGi\.Analytical\.Interfaces\.IAnalyticalGeometry'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')
### Constructors

<a name='DiGi.Analytical.Classes.Face.Face(DiGi.Analytical.Classes.Face)'></a>

## Face\(Face\) Constructor

Initializes a new instance of the [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') class by copying the properties from an existing [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') instance\.

```csharp
public Face(DiGi.Analytical.Classes.Face? face);
```
#### Parameters

<a name='DiGi.Analytical.Classes.Face.Face(DiGi.Analytical.Classes.Face).face'></a>

`face` [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')

The source [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') instance to copy from\. If null, a default instance is initialized\.

<a name='DiGi.Analytical.Classes.Face.Face(DiGi.Core.Interfaces.IUniqueReference,DiGi.Geometry.Spatial.Classes.PolygonalFace3D)'></a>

## Face\(IUniqueReference, PolygonalFace3D\) Constructor

Initializes a new instance of the [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') class using the specified unique reference and polygonal face data\.

```csharp
public Face(DiGi.Core.Interfaces.IUniqueReference? uniqueReference, DiGi.Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D);
```
#### Parameters

<a name='DiGi.Analytical.Classes.Face.Face(DiGi.Core.Interfaces.IUniqueReference,DiGi.Geometry.Spatial.Classes.PolygonalFace3D).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference') used to uniquely identify the face\. This value can be null\.

<a name='DiGi.Analytical.Classes.Face.Face(DiGi.Core.Interfaces.IUniqueReference,DiGi.Geometry.Spatial.Classes.PolygonalFace3D).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') instance providing the geometric data for the face\. This value can be null\.

<a name='DiGi.Analytical.Classes.Face.Face(DiGi.Geometry.Spatial.Classes.PolygonalFace3D)'></a>

## Face\(PolygonalFace3D\) Constructor

Initializes a new instance of the [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') class using the specified [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') instance\.

```csharp
public Face(DiGi.Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D);
```
#### Parameters

<a name='DiGi.Analytical.Classes.Face.Face(DiGi.Geometry.Spatial.Classes.PolygonalFace3D).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') instance to copy from\. This value can be null\.

<a name='DiGi.Analytical.Classes.Face.Face(System.Guid,DiGi.Analytical.Classes.Face)'></a>

## Face\(Guid, Face\) Constructor

Initializes a new instance of the [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') class with a specified unique identifier and an optional existing face to clone references from\.

```csharp
public Face(System.Guid guid, DiGi.Analytical.Classes.Face? face);
```
#### Parameters

<a name='DiGi.Analytical.Classes.Face.Face(System.Guid,DiGi.Analytical.Classes.Face).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the new face\.

<a name='DiGi.Analytical.Classes.Face.Face(System.Guid,DiGi.Analytical.Classes.Face).face'></a>

`face` [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')

An optional existing [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') instance used as a source for cloning properties\.

<a name='DiGi.Analytical.Classes.Face.Face(System.Text.Json.Nodes.JsonObject)'></a>

## Face\(JsonObject\) Constructor

Initializes a new instance of the [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Face(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Classes.Face.Face(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the face\. This value can be null\.
### Properties

<a name='DiGi.Analytical.Classes.Face.Guid'></a>

## Face\.Guid Property

Gets the unique identifier for the face\.

```csharp
public System.Guid Guid { get; }
```

Implements [Guid](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject.guid 'DiGi\.Core\.Interfaces\.IGuidObject\.Guid')

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Analytical.Classes.Face.UniqueId'></a>

## Face\.UniqueId Property

Gets the unique identifier of the face\.

```csharp
public string? UniqueId { get; }
```

Implements [UniqueId](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject.uniqueid 'DiGi\.Core\.Interfaces\.IUniqueObject\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Classes.Face.UniqueReference'></a>

## Face\.UniqueReference Property

Gets the unique reference associated with this face\.

```csharp
public DiGi.Core.Interfaces.IUniqueReference? UniqueReference { get; }
```

#### Property Value
[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')
### Methods

<a name='DiGi.Analytical.Classes.Face.Duplicate(System.Nullable_System.Guid_)'></a>

## Face\.Duplicate\(Nullable\<Guid\>\) Method

Creates a duplicate of the current face, optionally with a specified GUID\.

```csharp
public DiGi.Core.Interfaces.IGuidObject? Duplicate(System.Nullable<System.Guid> guid=null);
```
#### Parameters

<a name='DiGi.Analytical.Classes.Face.Duplicate(System.Nullable_System.Guid_).guid'></a>

`guid` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional GUID to assign to the duplicated object\.

Implements [Duplicate\(Nullable&lt;Guid&gt;\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject.duplicate#digi-core-interfaces-iguidobject-duplicate(system-nullable{system-guid}) 'DiGi\.Core\.Interfaces\.IGuidObject\.Duplicate\(System\.Nullable\{System\.Guid\}\)')

#### Returns
[DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')  
A duplicate of the current object as an [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), or null if duplication fails\.

<a name='DiGi.Analytical.Classes.FaceByFacesSplitSolver'></a>

## FaceByFacesSplitSolver Class

Provides functionality to split faces based on a collection of other faces\.

```csharp
public class FaceByFacesSplitSolver : DiGi.Analytical.Classes.FaceSplitSolver
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Analytical\.Classes\.SplitSolver&lt;](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_ 'DiGi\.Analytical\.Classes\.SplitSolver\<TAnalyticalGeometry\>')[Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')[&gt;](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_ 'DiGi\.Analytical\.Classes\.SplitSolver\<TAnalyticalGeometry\>') → [FaceSplitSolver](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FaceSplitSolver 'DiGi\.Analytical\.Classes\.FaceSplitSolver') → FaceByFacesSplitSolver
### Constructors

<a name='DiGi.Analytical.Classes.FaceByFacesSplitSolver.FaceByFacesSplitSolver(double)'></a>

## FaceByFacesSplitSolver\(double\) Constructor

Initializes a new instance of the [FaceByFacesSplitSolver](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FaceByFacesSplitSolver 'DiGi\.Analytical\.Classes\.FaceByFacesSplitSolver') class\.

```csharp
public FaceByFacesSplitSolver(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Classes.FaceByFacesSplitSolver.FaceByFacesSplitSolver(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for geometric operations, defaulting to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.
### Properties

<a name='DiGi.Analytical.Classes.FaceByFacesSplitSolver.Faces'></a>

## FaceByFacesSplitSolver\.Faces Property

Gets or sets the list of [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') objects used for the split solving process\.

```csharp
public System.Collections.Generic.List<DiGi.Analytical.Classes.Face>? Faces { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Analytical.Classes.FaceByFacesSplitSolver.Solve()'></a>

## FaceByFacesSplitSolver\.Solve\(\) Method

Executes the face splitting operation based on the provided faces and input criteria\.

```csharp
public override bool Solve();
```

Implements [Solve\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver.solve 'DiGi\.Core\.Interfaces\.ISolver\.Solve')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the split operation was successfully completed; returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the faces list is null or the input data is invalid\.

<a name='DiGi.Analytical.Classes.FaceByPlaneSplitSolver'></a>

## FaceByPlaneSplitSolver Class

Provides functionality to solve the splitting of a face using a specified plane\.

```csharp
public class FaceByPlaneSplitSolver : DiGi.Analytical.Classes.FaceSplitSolver
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Analytical\.Classes\.SplitSolver&lt;](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_ 'DiGi\.Analytical\.Classes\.SplitSolver\<TAnalyticalGeometry\>')[Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')[&gt;](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_ 'DiGi\.Analytical\.Classes\.SplitSolver\<TAnalyticalGeometry\>') → [FaceSplitSolver](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FaceSplitSolver 'DiGi\.Analytical\.Classes\.FaceSplitSolver') → FaceByPlaneSplitSolver
### Constructors

<a name='DiGi.Analytical.Classes.FaceByPlaneSplitSolver.FaceByPlaneSplitSolver(double)'></a>

## FaceByPlaneSplitSolver\(double\) Constructor

Initializes a new instance of the [FaceByPlaneSplitSolver](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FaceByPlaneSplitSolver 'DiGi\.Analytical\.Classes\.FaceByPlaneSplitSolver') class\.

```csharp
public FaceByPlaneSplitSolver(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Classes.FaceByPlaneSplitSolver.FaceByPlaneSplitSolver(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for geometric operations during the split process\.
### Properties

<a name='DiGi.Analytical.Classes.FaceByPlaneSplitSolver.Plane'></a>

## FaceByPlaneSplitSolver\.Plane Property

Gets or sets the [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used to split the face\.

```csharp
public DiGi.Geometry.Spatial.Classes.Plane? Plane { get; set; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
The [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') instance used for splitting, or `null` if no plane is defined\.
### Methods

<a name='DiGi.Analytical.Classes.FaceByPlaneSplitSolver.Solve()'></a>

## FaceByPlaneSplitSolver\.Solve\(\) Method

Attempts to solve the face splitting operation using a specified plane\.

```csharp
public override bool Solve();
```

Implements [Solve\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver.solve 'DiGi\.Core\.Interfaces\.ISolver\.Solve')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the face was successfully split; returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the plane is not defined\.

<a name='DiGi.Analytical.Classes.FaceSplitEventArgs'></a>

## FaceSplitEventArgs Class

Provides data for events that occur when a face is split\.

```csharp
public class FaceSplitEventArgs : System.EventArgs
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.EventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.eventargs 'System\.EventArgs') → FaceSplitEventArgs

Derived  
↳ [CoplanarFaceSplitEventArgs](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.CoplanarFaceSplitEventArgs 'DiGi\.Analytical\.Classes\.CoplanarFaceSplitEventArgs')  
↳ [NonCoplanarFaceSplitEventArgs](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.NonCoplanarFaceSplitEventArgs 'DiGi\.Analytical\.Classes\.NonCoplanarFaceSplitEventArgs')
### Constructors

<a name='DiGi.Analytical.Classes.FaceSplitEventArgs.FaceSplitEventArgs(DiGi.Analytical.Classes.Face,DiGi.Geometry.Spatial.Classes.PolygonalFace3D)'></a>

## FaceSplitEventArgs\(Face, PolygonalFace3D\) Constructor

Initializes a new instance of the [FaceSplitEventArgs](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FaceSplitEventArgs 'DiGi\.Analytical\.Classes\.FaceSplitEventArgs') class\.

```csharp
public FaceSplitEventArgs(DiGi.Analytical.Classes.Face? input, DiGi.Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D);
```
#### Parameters

<a name='DiGi.Analytical.Classes.FaceSplitEventArgs.FaceSplitEventArgs(DiGi.Analytical.Classes.Face,DiGi.Geometry.Spatial.Classes.PolygonalFace3D).input'></a>

`input` [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')

The [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') input face\. This value can be null\.

<a name='DiGi.Analytical.Classes.FaceSplitEventArgs.FaceSplitEventArgs(DiGi.Analytical.Classes.Face,DiGi.Geometry.Spatial.Classes.PolygonalFace3D).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')

The [PolygonalFace3D](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FaceSplitEventArgs.PolygonalFace3D 'DiGi\.Analytical\.Classes\.FaceSplitEventArgs\.PolygonalFace3D') representing the polygonal face in 3D space\. This value can be null\.
### Properties

<a name='DiGi.Analytical.Classes.FaceSplitEventArgs.Handled'></a>

## FaceSplitEventArgs\.Handled Property

Gets or sets a value indicating whether the face split event has been handled\.

```csharp
public bool Handled { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Analytical.Classes.FaceSplitEventArgs.Input'></a>

## FaceSplitEventArgs\.Input Property

Gets the input face used in the split operation\.

```csharp
public DiGi.Analytical.Classes.Face? Input { get; }
```

#### Property Value
[Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')

<a name='DiGi.Analytical.Classes.FaceSplitEventArgs.PolygonalFace3D'></a>

## FaceSplitEventArgs\.PolygonalFace3D Property

Gets the [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') representing a planar polygonal face in 3D space associated with the face split event\.

```csharp
public DiGi.Geometry.Spatial.Classes.PolygonalFace3D? PolygonalFace3D { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')

<a name='DiGi.Analytical.Classes.FaceSplitEventArgs.UniqueReference'></a>

## FaceSplitEventArgs\.UniqueReference Property

Gets or sets the unique reference associated with the face split event\.

```csharp
public DiGi.Core.Interfaces.IUniqueReference? UniqueReference { get; set; }
```

#### Property Value
[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

<a name='DiGi.Analytical.Classes.FaceSplitSolver'></a>

## FaceSplitSolver Class

Provides an abstract base implementation for solvers designed to split face elements\.

```csharp
public abstract class FaceSplitSolver : DiGi.Analytical.Classes.SplitSolver<DiGi.Analytical.Classes.Face>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Analytical\.Classes\.SplitSolver&lt;](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_ 'DiGi\.Analytical\.Classes\.SplitSolver\<TAnalyticalGeometry\>')[Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')[&gt;](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_ 'DiGi\.Analytical\.Classes\.SplitSolver\<TAnalyticalGeometry\>') → FaceSplitSolver

Derived  
↳ [FaceByFacesSplitSolver](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FaceByFacesSplitSolver 'DiGi\.Analytical\.Classes\.FaceByFacesSplitSolver')  
↳ [FaceByPlaneSplitSolver](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FaceByPlaneSplitSolver 'DiGi\.Analytical\.Classes\.FaceByPlaneSplitSolver')
### Constructors

<a name='DiGi.Analytical.Classes.FaceSplitSolver.FaceSplitSolver(double)'></a>

## FaceSplitSolver\(double\) Constructor

Initializes a new instance of the [FaceSplitSolver](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FaceSplitSolver 'DiGi\.Analytical\.Classes\.FaceSplitSolver') class\.

```csharp
public FaceSplitSolver(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Classes.FaceSplitSolver.FaceSplitSolver(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for geometric calculations during face splitting\.

<a name='DiGi.Analytical.Classes.FluidMaterial'></a>

## FluidMaterial Class

Represents a material with fluid\-specific properties, extending the functionality of the base [Material](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Material 'DiGi\.Analytical\.Classes\.Material') class\.

```csharp
public class FluidMaterial : DiGi.Analytical.Classes.Material
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Material](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Material 'DiGi\.Analytical\.Classes\.Material') → FluidMaterial
### Constructors

<a name='DiGi.Analytical.Classes.FluidMaterial.FluidMaterial(DiGi.Analytical.Classes.FluidMaterial)'></a>

## FluidMaterial\(FluidMaterial\) Constructor

Initializes a new instance of the [FluidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FluidMaterial 'DiGi\.Analytical\.Classes\.FluidMaterial') class using another [FluidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FluidMaterial 'DiGi\.Analytical\.Classes\.FluidMaterial') instance\.

```csharp
public FluidMaterial(DiGi.Analytical.Classes.FluidMaterial? fluidMaterial);
```
#### Parameters

<a name='DiGi.Analytical.Classes.FluidMaterial.FluidMaterial(DiGi.Analytical.Classes.FluidMaterial).fluidMaterial'></a>

`fluidMaterial` [FluidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FluidMaterial 'DiGi\.Analytical\.Classes\.FluidMaterial')

The source [FluidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FluidMaterial 'DiGi\.Analytical\.Classes\.FluidMaterial') object to copy from\.

<a name='DiGi.Analytical.Classes.FluidMaterial.FluidMaterial(string)'></a>

## FluidMaterial\(string\) Constructor

Initializes a new instance of the [FluidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FluidMaterial 'DiGi\.Analytical\.Classes\.FluidMaterial') class with the specified name\.

```csharp
public FluidMaterial(string? name);
```
#### Parameters

<a name='DiGi.Analytical.Classes.FluidMaterial.FluidMaterial(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the fluid material\. This value can be null\.

<a name='DiGi.Analytical.Classes.FluidMaterial.FluidMaterial(System.Text.Json.Nodes.JsonObject)'></a>

## FluidMaterial\(JsonObject\) Constructor

Initializes a new instance of the [FluidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FluidMaterial 'DiGi\.Analytical\.Classes\.FluidMaterial') class using the specified JSON object\.

```csharp
public FluidMaterial(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Classes.FluidMaterial.FluidMaterial(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the material properties to initialize the instance\.

<a name='DiGi.Analytical.Classes.HourRange'></a>

## HourRange Class

Represents a range of hours defined by integer values\.

```csharp
public class HourRange : DiGi.Core.Classes.Range<int>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') → HourRange
### Constructors

<a name='DiGi.Analytical.Classes.HourRange.HourRange(DiGi.Analytical.Classes.HourRange)'></a>

## HourRange\(HourRange\) Constructor

Initializes a new instance of the [HourRange](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.HourRange 'DiGi\.Analytical\.Classes\.HourRange') class using the values from an existing [HourRange](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.HourRange 'DiGi\.Analytical\.Classes\.HourRange') instance\.

```csharp
public HourRange(DiGi.Analytical.Classes.HourRange? hourRange);
```
#### Parameters

<a name='DiGi.Analytical.Classes.HourRange.HourRange(DiGi.Analytical.Classes.HourRange).hourRange'></a>

`hourRange` [HourRange](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.HourRange 'DiGi\.Analytical\.Classes\.HourRange')

The source [HourRange](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.HourRange 'DiGi\.Analytical\.Classes\.HourRange') instance to copy values from\.

<a name='DiGi.Analytical.Classes.HourRange.HourRange(DiGi.Core.Classes.Range_int_)'></a>

## HourRange\(Range\<int\>\) Constructor

Initializes a new instance of the [HourRange](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.HourRange 'DiGi\.Analytical\.Classes\.HourRange') class using the specified range\.

```csharp
public HourRange(DiGi.Core.Classes.Range<int>? range);
```
#### Parameters

<a name='DiGi.Analytical.Classes.HourRange.HourRange(DiGi.Core.Classes.Range_int_).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') used to initialize this instance\.

<a name='DiGi.Analytical.Classes.HourRange.HourRange(int,int)'></a>

## HourRange\(int, int\) Constructor

Initializes a new instance of the [HourRange](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.HourRange 'DiGi\.Analytical\.Classes\.HourRange') class with specified start and end values\.

```csharp
public HourRange(int value_1, int value_2);
```
#### Parameters

<a name='DiGi.Analytical.Classes.HourRange.HourRange(int,int).value_1'></a>

`value_1` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The starting hour value\.

<a name='DiGi.Analytical.Classes.HourRange.HourRange(int,int).value_2'></a>

`value_2` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The ending hour value\.

<a name='DiGi.Analytical.Classes.HourRange.HourRange(System.Text.Json.Nodes.JsonObject)'></a>

## HourRange\(JsonObject\) Constructor

Initializes a new instance of the [HourRange](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.HourRange 'DiGi\.Analytical\.Classes\.HourRange') class using the specified JSON object\.

```csharp
public HourRange(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Classes.HourRange.HourRange(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the hour range\.

<a name='DiGi.Analytical.Classes.Material'></a>

## Material Class

Represents a base abstraction for materials within the analytical system, providing common functionality and properties shared by all material types\.

```csharp
public abstract class Material : DiGi.Core.Classes.GuidObject, DiGi.Analytical.Interfaces.IMaterial, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.INamedObject, DiGi.Core.Interfaces.IDescribableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → Material

Derived  
↳ [FluidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FluidMaterial 'DiGi\.Analytical\.Classes\.FluidMaterial')  
↳ [SolidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SolidMaterial 'DiGi\.Analytical\.Classes\.SolidMaterial')

Implements [DiGi\.Analytical\.Interfaces\.IMaterial](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.imaterial 'DiGi\.Analytical\.Interfaces\.IMaterial'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject')
### Constructors

<a name='DiGi.Analytical.Classes.Material.Material(DiGi.Analytical.Classes.Material)'></a>

## Material\(Material\) Constructor

Initializes a new instance of the [Material](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Material 'DiGi\.Analytical\.Classes\.Material') class using another [Material](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Material 'DiGi\.Analytical\.Classes\.Material') instance\.

```csharp
public Material(DiGi.Analytical.Classes.Material? material);
```
#### Parameters

<a name='DiGi.Analytical.Classes.Material.Material(DiGi.Analytical.Classes.Material).material'></a>

`material` [Material](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Material 'DiGi\.Analytical\.Classes\.Material')

The source material instance from which to copy values\. This value can be null\.

<a name='DiGi.Analytical.Classes.Material.Material(string)'></a>

## Material\(string\) Constructor

Initializes a new instance of the [Material](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Material 'DiGi\.Analytical\.Classes\.Material') class with the specified name\.

```csharp
public Material(string? name);
```
#### Parameters

<a name='DiGi.Analytical.Classes.Material.Material(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the material\.

<a name='DiGi.Analytical.Classes.Material.Material(System.Text.Json.Nodes.JsonObject)'></a>

## Material\(JsonObject\) Constructor

Initializes a new instance of the [Material](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Material 'DiGi\.Analytical\.Classes\.Material') class using the specified JSON object\.

```csharp
public Material(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Classes.Material.Material(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to populate the properties of the material instance\.
### Properties

<a name='DiGi.Analytical.Classes.Material.Description'></a>

## Material\.Description Property

Gets or sets the description of the material\.

```csharp
public string? Description { get; set; }
```

Implements [Description](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject.description 'DiGi\.Core\.Interfaces\.IDescribableObject\.Description')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Classes.Material.Name'></a>

## Material\.Name Property

Gets or sets the name of the material\.

```csharp
public string? Name { get; set; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Classes.MaterialsFile'></a>

## MaterialsFile Class

Represents a storage file specifically designed for managing and persisting [DiGi\.Analytical\.Interfaces\.IMaterial](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.imaterial 'DiGi\.Analytical\.Interfaces\.IMaterial') instances\.

```csharp
public class MaterialsFile : DiGi.Core.IO.File.Classes.StorageFile<DiGi.Analytical.Interfaces.IMaterial>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.IO\.File\.Classes\.File](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.file 'DiGi\.Core\.IO\.File\.Classes\.File') → [DiGi\.Core\.IO\.File\.Classes\.StorageFile&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1')[DiGi\.Analytical\.Interfaces\.IMaterial](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.imaterial 'DiGi\.Analytical\.Interfaces\.IMaterial')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1') → MaterialsFile
### Constructors

<a name='DiGi.Analytical.Classes.MaterialsFile.MaterialsFile(DiGi.Analytical.Classes.MaterialsFile)'></a>

## MaterialsFile\(MaterialsFile\) Constructor

Initializes a new instance of the [MaterialsFile](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.MaterialsFile 'DiGi\.Analytical\.Classes\.MaterialsFile') class using an existing [MaterialsFile](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.MaterialsFile 'DiGi\.Analytical\.Classes\.MaterialsFile') instance\.

```csharp
public MaterialsFile(DiGi.Analytical.Classes.MaterialsFile? materialsFile);
```
#### Parameters

<a name='DiGi.Analytical.Classes.MaterialsFile.MaterialsFile(DiGi.Analytical.Classes.MaterialsFile).materialsFile'></a>

`materialsFile` [MaterialsFile](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.MaterialsFile 'DiGi\.Analytical\.Classes\.MaterialsFile')

The source [MaterialsFile](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.MaterialsFile 'DiGi\.Analytical\.Classes\.MaterialsFile') instance to copy from\.

<a name='DiGi.Analytical.Classes.MaterialsFile.MaterialsFile(string)'></a>

## MaterialsFile\(string\) Constructor

Initializes a new instance of the [MaterialsFile](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.MaterialsFile 'DiGi\.Analytical\.Classes\.MaterialsFile') class using the specified file path\.

```csharp
public MaterialsFile(string? path);
```
#### Parameters

<a name='DiGi.Analytical.Classes.MaterialsFile.MaterialsFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path to the materials file\. This value can be null\.

<a name='DiGi.Analytical.Classes.MaterialsFile.MaterialsFile(System.Text.Json.Nodes.JsonObject)'></a>

## MaterialsFile\(JsonObject\) Constructor

Initializes a new instance of the [MaterialsFile](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.MaterialsFile 'DiGi\.Analytical\.Classes\.MaterialsFile') class using the specified JSON object\.

```csharp
public MaterialsFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Classes.MaterialsFile.MaterialsFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the materials file\.
### Methods

<a name='DiGi.Analytical.Classes.MaterialsFile.GetUniqueReference(DiGi.Analytical.Interfaces.IMaterial)'></a>

## MaterialsFile\.GetUniqueReference\(IMaterial\) Method

Retrieves the unique reference for the specified material\.

```csharp
public override DiGi.Core.Classes.UniqueReference? GetUniqueReference(DiGi.Analytical.Interfaces.IMaterial? material);
```
#### Parameters

<a name='DiGi.Analytical.Classes.MaterialsFile.GetUniqueReference(DiGi.Analytical.Interfaces.IMaterial).material'></a>

`material` [DiGi\.Analytical\.Interfaces\.IMaterial](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.imaterial 'DiGi\.Analytical\.Interfaces\.IMaterial')

The material to retrieve the reference for\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
The unique reference associated with the specified material, or null\.

<a name='DiGi.Analytical.Classes.NonCoplanarFaceSplitEventArgs'></a>

## NonCoplanarFaceSplitEventArgs Class

Provides the event data for a non\-coplanar face split operation\.

```csharp
public class NonCoplanarFaceSplitEventArgs : DiGi.Analytical.Classes.FaceSplitEventArgs
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.EventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.eventargs 'System\.EventArgs') → [FaceSplitEventArgs](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FaceSplitEventArgs 'DiGi\.Analytical\.Classes\.FaceSplitEventArgs') → NonCoplanarFaceSplitEventArgs
### Constructors

<a name='DiGi.Analytical.Classes.NonCoplanarFaceSplitEventArgs.NonCoplanarFaceSplitEventArgs(DiGi.Analytical.Classes.Face,DiGi.Geometry.Spatial.Classes.PolygonalFace3D)'></a>

## NonCoplanarFaceSplitEventArgs\(Face, PolygonalFace3D\) Constructor

Initializes a new instance of the [NonCoplanarFaceSplitEventArgs](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.NonCoplanarFaceSplitEventArgs 'DiGi\.Analytical\.Classes\.NonCoplanarFaceSplitEventArgs') class\.

```csharp
public NonCoplanarFaceSplitEventArgs(DiGi.Analytical.Classes.Face? input, DiGi.Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D);
```
#### Parameters

<a name='DiGi.Analytical.Classes.NonCoplanarFaceSplitEventArgs.NonCoplanarFaceSplitEventArgs(DiGi.Analytical.Classes.Face,DiGi.Geometry.Spatial.Classes.PolygonalFace3D).input'></a>

`input` [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')

The [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') that is being split; this value can be null\.

<a name='DiGi.Analytical.Classes.NonCoplanarFaceSplitEventArgs.NonCoplanarFaceSplitEventArgs(DiGi.Analytical.Classes.Face,DiGi.Geometry.Spatial.Classes.PolygonalFace3D).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') involved in the non\-coplanar face split operation; this value can be null\.

<a name='DiGi.Analytical.Classes.OpaqueMaterial'></a>

## OpaqueMaterial Class

Represents a material that is opaque, containing physical and thermal properties such as conductivity, density, and reflectance\.

```csharp
public class OpaqueMaterial : DiGi.Analytical.Classes.SolidMaterial
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Material](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Material 'DiGi\.Analytical\.Classes\.Material') → [SolidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SolidMaterial 'DiGi\.Analytical\.Classes\.SolidMaterial') → OpaqueMaterial
### Constructors

<a name='DiGi.Analytical.Classes.OpaqueMaterial.OpaqueMaterial(DiGi.Analytical.Classes.OpaqueMaterial)'></a>

## OpaqueMaterial\(OpaqueMaterial\) Constructor

Initializes a new instance of the [OpaqueMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.OpaqueMaterial 'DiGi\.Analytical\.Classes\.OpaqueMaterial') class by copying the properties from an existing [OpaqueMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.OpaqueMaterial 'DiGi\.Analytical\.Classes\.OpaqueMaterial') instance\.

```csharp
public OpaqueMaterial(DiGi.Analytical.Classes.OpaqueMaterial? opaqueMaterial);
```
#### Parameters

<a name='DiGi.Analytical.Classes.OpaqueMaterial.OpaqueMaterial(DiGi.Analytical.Classes.OpaqueMaterial).opaqueMaterial'></a>

`opaqueMaterial` [OpaqueMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.OpaqueMaterial 'DiGi\.Analytical\.Classes\.OpaqueMaterial')

The source [OpaqueMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.OpaqueMaterial 'DiGi\.Analytical\.Classes\.OpaqueMaterial') instance to copy data from\. This value can be null\.

<a name='DiGi.Analytical.Classes.OpaqueMaterial.OpaqueMaterial(string)'></a>

## OpaqueMaterial\(string\) Constructor

Initializes a new instance of the [OpaqueMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.OpaqueMaterial 'DiGi\.Analytical\.Classes\.OpaqueMaterial') class with the specified name\.

```csharp
public OpaqueMaterial(string? name);
```
#### Parameters

<a name='DiGi.Analytical.Classes.OpaqueMaterial.OpaqueMaterial(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the opaque material\.

<a name='DiGi.Analytical.Classes.OpaqueMaterial.OpaqueMaterial(System.Text.Json.Nodes.JsonObject)'></a>

## OpaqueMaterial\(JsonObject\) Constructor

Initializes a new instance of the [OpaqueMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.OpaqueMaterial 'DiGi\.Analytical\.Classes\.OpaqueMaterial') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public OpaqueMaterial(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Classes.OpaqueMaterial.OpaqueMaterial(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the material properties\.
### Properties

<a name='DiGi.Analytical.Classes.OpaqueMaterial.Conductivity'></a>

## OpaqueMaterial\.Conductivity Property

Gets or sets the thermal conductivity of the opaque material\.

```csharp
public double Conductivity { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Analytical.Classes.OpaqueMaterial.Density'></a>

## OpaqueMaterial\.Density Property

Gets or sets the density of the opaque material\.

```csharp
public double Density { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Analytical.Classes.OpaqueMaterial.Emissivity'></a>

## OpaqueMaterial\.Emissivity Property

Gets or sets the emissivity of the opaque material\.

```csharp
public DiGi.Analytical.Classes.SurfaceValue? Emissivity { get; set; }
```

#### Property Value
[SurfaceValue](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SurfaceValue 'DiGi\.Analytical\.Classes\.SurfaceValue')

<a name='DiGi.Analytical.Classes.OpaqueMaterial.SpecificHeat'></a>

## OpaqueMaterial\.SpecificHeat Property

Gets or sets the specific heat capacity of the opaque material\.

```csharp
public double SpecificHeat { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Analytical.Classes.OpaqueMaterial.VapourDiffusionFactor'></a>

## OpaqueMaterial\.VapourDiffusionFactor Property

Gets or sets the vapour diffusion factor of the opaque material\.

```csharp
public double VapourDiffusionFactor { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Analytical.Classes.Shell'></a>

## Shell Class

Represents a geometric shell consisting of a collection of faces, providing functionality for spatial analysis and analytical geometry operations\.

```csharp
public class Shell : DiGi.Geometry.Spatial.Classes.Polyhedron<DiGi.Analytical.Classes.Face>, DiGi.Analytical.Interfaces.IAnalyticalGeometry, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IGuidObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Geometry\.Spatial\.Classes\.Geometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.geometry3d 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron-1 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\`1')[Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron-1 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\`1') → Shell

Implements [DiGi\.Analytical\.Interfaces\.IAnalyticalGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalgeometry 'DiGi\.Analytical\.Interfaces\.IAnalyticalGeometry'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')
### Constructors

<a name='DiGi.Analytical.Classes.Shell.Shell(DiGi.Analytical.Classes.Shell)'></a>

## Shell\(Shell\) Constructor

Initializes a new instance of the [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell') class by copying an existing shell instance\.

```csharp
public Shell(DiGi.Analytical.Classes.Shell shell);
```
#### Parameters

<a name='DiGi.Analytical.Classes.Shell.Shell(DiGi.Analytical.Classes.Shell).shell'></a>

`shell` [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')

The source [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell') instance to copy from\.

<a name='DiGi.Analytical.Classes.Shell.Shell(DiGi.Core.Interfaces.IUniqueReference,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Face_)'></a>

## Shell\(IUniqueReference, IEnumerable\<Face\>\) Constructor

Initializes a new instance of the [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell') class using the specified unique reference and collection of faces\.

```csharp
public Shell(DiGi.Core.Interfaces.IUniqueReference? uniqueReference, System.Collections.Generic.IEnumerable<DiGi.Analytical.Classes.Face> faces);
```
#### Parameters

<a name='DiGi.Analytical.Classes.Shell.Shell(DiGi.Core.Interfaces.IUniqueReference,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Face_).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to assign to this shell\.

<a name='DiGi.Analytical.Classes.Shell.Shell(DiGi.Core.Interfaces.IUniqueReference,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Face_).faces'></a>

`faces` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') objects that compose the shell\.

<a name='DiGi.Analytical.Classes.Shell.Shell(System.Guid,DiGi.Analytical.Classes.Shell)'></a>

## Shell\(Guid, Shell\) Constructor

Initializes a new instance of the [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell') class with a specified unique identifier and an optional source shell to clone properties from\.

```csharp
public Shell(System.Guid guid, DiGi.Analytical.Classes.Shell? shell);
```
#### Parameters

<a name='DiGi.Analytical.Classes.Shell.Shell(System.Guid,DiGi.Analytical.Classes.Shell).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the shell\.

<a name='DiGi.Analytical.Classes.Shell.Shell(System.Guid,DiGi.Analytical.Classes.Shell).shell'></a>

`shell` [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')

An optional existing shell object used to initialize the reference data\.

<a name='DiGi.Analytical.Classes.Shell.Shell(System.Text.Json.Nodes.JsonObject)'></a>

## Shell\(JsonObject\) Constructor

Initializes a new instance of the [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell') class using the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Shell(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Classes.Shell.Shell(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the shell; can be null\.
### Properties

<a name='DiGi.Analytical.Classes.Shell.Guid'></a>

## Shell\.Guid Property

Gets the unique global identifier of the shell\.

```csharp
public System.Guid Guid { get; }
```

Implements [Guid](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject.guid 'DiGi\.Core\.Interfaces\.IGuidObject\.Guid')

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Analytical.Classes.Shell.UniqueId'></a>

## Shell\.UniqueId Property

Gets the unique identifier of the shell\.

```csharp
public string? UniqueId { get; }
```

Implements [UniqueId](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject.uniqueid 'DiGi\.Core\.Interfaces\.IUniqueObject\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Classes.Shell.UniqueReference'></a>

## Shell\.UniqueReference Property

Gets the unique reference associated with this shell\.

```csharp
public DiGi.Core.Interfaces.IUniqueReference? UniqueReference { get; }
```

#### Property Value
[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')
### Methods

<a name='DiGi.Analytical.Classes.Shell.Duplicate(System.Nullable_System.Guid_)'></a>

## Shell\.Duplicate\(Nullable\<Guid\>\) Method

Creates a duplicate of the current object, optionally with a new GUID\.

```csharp
public DiGi.Core.Interfaces.IGuidObject? Duplicate(System.Nullable<System.Guid> guid=null);
```
#### Parameters

<a name='DiGi.Analytical.Classes.Shell.Duplicate(System.Nullable_System.Guid_).guid'></a>

`guid` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional GUID to assign to the duplicated object\.

Implements [Duplicate\(Nullable&lt;Guid&gt;\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject.duplicate#digi-core-interfaces-iguidobject-duplicate(system-nullable{system-guid}) 'DiGi\.Core\.Interfaces\.IGuidObject\.Duplicate\(System\.Nullable\{System\.Guid\}\)')

#### Returns
[DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')  
A duplicate of the current object as an [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), or null if duplication fails\.

<a name='DiGi.Analytical.Classes.ShellByPlaneSplitSolver'></a>

## ShellByPlaneSplitSolver Class

Provides functionality to split a shell using a specified plane as the cutting surface\.

```csharp
public class ShellByPlaneSplitSolver : DiGi.Analytical.Classes.ShellSplitSolver
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Analytical\.Classes\.SplitSolver&lt;](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_ 'DiGi\.Analytical\.Classes\.SplitSolver\<TAnalyticalGeometry\>')[Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')[&gt;](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_ 'DiGi\.Analytical\.Classes\.SplitSolver\<TAnalyticalGeometry\>') → [ShellSplitSolver](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.ShellSplitSolver 'DiGi\.Analytical\.Classes\.ShellSplitSolver') → ShellByPlaneSplitSolver
### Constructors

<a name='DiGi.Analytical.Classes.ShellByPlaneSplitSolver.ShellByPlaneSplitSolver(double)'></a>

## ShellByPlaneSplitSolver\(double\) Constructor

Initializes a new instance of the [ShellByPlaneSplitSolver](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.ShellByPlaneSplitSolver 'DiGi\.Analytical\.Classes\.ShellByPlaneSplitSolver') class\.

```csharp
public ShellByPlaneSplitSolver(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Classes.ShellByPlaneSplitSolver.ShellByPlaneSplitSolver(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for geometric operations during the splitting process\.
### Properties

<a name='DiGi.Analytical.Classes.ShellByPlaneSplitSolver.Plane'></a>

## ShellByPlaneSplitSolver\.Plane Property

Gets or sets the [Plane](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.ShellByPlaneSplitSolver.Plane 'DiGi\.Analytical\.Classes\.ShellByPlaneSplitSolver\.Plane') used to split the shell\.

```csharp
public DiGi.Geometry.Spatial.Classes.Plane? Plane { get; set; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
The [Plane](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.ShellByPlaneSplitSolver.Plane 'DiGi\.Analytical\.Classes\.ShellByPlaneSplitSolver\.Plane') instance, or `null` if no plane is defined\.
### Methods

<a name='DiGi.Analytical.Classes.ShellByPlaneSplitSolver.Solve()'></a>

## ShellByPlaneSplitSolver\.Solve\(\) Method

Splits the shell using the specified plane\.

```csharp
public override bool Solve();
```

Implements [Solve\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver.solve 'DiGi\.Core\.Interfaces\.ISolver\.Solve')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the splitting operation was successful\.

<a name='DiGi.Analytical.Classes.ShellSplitEventArgs'></a>

## ShellSplitEventArgs Class

Provides the event data for shell splitting operations\.

```csharp
public class ShellSplitEventArgs : System.EventArgs
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.EventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.eventargs 'System\.EventArgs') → ShellSplitEventArgs
### Constructors

<a name='DiGi.Analytical.Classes.ShellSplitEventArgs.ShellSplitEventArgs(DiGi.Analytical.Classes.Shell,DiGi.Geometry.Spatial.Classes.Polyhedron)'></a>

## ShellSplitEventArgs\(Shell, Polyhedron\) Constructor

Initializes a new instance of the [ShellSplitEventArgs](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.ShellSplitEventArgs 'DiGi\.Analytical\.Classes\.ShellSplitEventArgs') class\.

```csharp
public ShellSplitEventArgs(DiGi.Analytical.Classes.Shell? input, DiGi.Geometry.Spatial.Classes.Polyhedron? polyhedron);
```
#### Parameters

<a name='DiGi.Analytical.Classes.ShellSplitEventArgs.ShellSplitEventArgs(DiGi.Analytical.Classes.Shell,DiGi.Geometry.Spatial.Classes.Polyhedron).input'></a>

`input` [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')

The [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell') that is being split\.

<a name='DiGi.Analytical.Classes.ShellSplitEventArgs.ShellSplitEventArgs(DiGi.Analytical.Classes.Shell,DiGi.Geometry.Spatial.Classes.Polyhedron).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')

The [Polyhedron](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.ShellSplitEventArgs.Polyhedron 'DiGi\.Analytical\.Classes\.ShellSplitEventArgs\.Polyhedron') used to perform the split operation\.
### Properties

<a name='DiGi.Analytical.Classes.ShellSplitEventArgs.Handled'></a>

## ShellSplitEventArgs\.Handled Property

Gets or sets a value indicating whether the shell split event has been handled\.

```csharp
public bool Handled { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Analytical.Classes.ShellSplitEventArgs.Input'></a>

## ShellSplitEventArgs\.Input Property

Gets the [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell') used as the input for the split operation\.

```csharp
public DiGi.Analytical.Classes.Shell? Input { get; }
```

#### Property Value
[Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')

<a name='DiGi.Analytical.Classes.ShellSplitEventArgs.Polyhedron'></a>

## ShellSplitEventArgs\.Polyhedron Property

Gets the [Polyhedron](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.ShellSplitEventArgs.Polyhedron 'DiGi\.Analytical\.Classes\.ShellSplitEventArgs\.Polyhedron') involved in the shell splitting operation\.

```csharp
public DiGi.Geometry.Spatial.Classes.Polyhedron? Polyhedron { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')

<a name='DiGi.Analytical.Classes.ShellSplitEventArgs.UniqueReference'></a>

## ShellSplitEventArgs\.UniqueReference Property

Gets or sets the unique reference associated with the shell split event\.

```csharp
public DiGi.Core.Interfaces.IUniqueReference? UniqueReference { get; set; }
```

#### Property Value
[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

<a name='DiGi.Analytical.Classes.ShellSplitSolver'></a>

## ShellSplitSolver Class

Provides an abstract base implementation for solvers specialized in splitting shell elements\.

```csharp
public abstract class ShellSplitSolver : DiGi.Analytical.Classes.SplitSolver<DiGi.Analytical.Classes.Shell>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Analytical\.Classes\.SplitSolver&lt;](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_ 'DiGi\.Analytical\.Classes\.SplitSolver\<TAnalyticalGeometry\>')[Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')[&gt;](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_ 'DiGi\.Analytical\.Classes\.SplitSolver\<TAnalyticalGeometry\>') → ShellSplitSolver

Derived  
↳ [ShellByPlaneSplitSolver](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.ShellByPlaneSplitSolver 'DiGi\.Analytical\.Classes\.ShellByPlaneSplitSolver')
### Constructors

<a name='DiGi.Analytical.Classes.ShellSplitSolver.ShellSplitSolver(double)'></a>

## ShellSplitSolver\(double\) Constructor

Initializes a new instance of the [ShellSplitSolver](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.ShellSplitSolver 'DiGi\.Analytical\.Classes\.ShellSplitSolver') class\.

```csharp
public ShellSplitSolver(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Classes.ShellSplitSolver.ShellSplitSolver(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for splitting operations\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

<a name='DiGi.Analytical.Classes.SolidMaterial'></a>

## SolidMaterial Class

Represents a material specifically characterized as being in a solid state\.

```csharp
public class SolidMaterial : DiGi.Analytical.Classes.Material
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Material](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Material 'DiGi\.Analytical\.Classes\.Material') → SolidMaterial

Derived  
↳ [OpaqueMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.OpaqueMaterial 'DiGi\.Analytical\.Classes\.OpaqueMaterial')  
↳ [TransparentMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.TransparentMaterial 'DiGi\.Analytical\.Classes\.TransparentMaterial')
### Constructors

<a name='DiGi.Analytical.Classes.SolidMaterial.SolidMaterial(DiGi.Analytical.Classes.SolidMaterial)'></a>

## SolidMaterial\(SolidMaterial\) Constructor

Initializes a new instance of the [SolidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SolidMaterial 'DiGi\.Analytical\.Classes\.SolidMaterial') class using an existing [SolidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SolidMaterial 'DiGi\.Analytical\.Classes\.SolidMaterial') object\.

```csharp
public SolidMaterial(DiGi.Analytical.Classes.SolidMaterial? solidMaterial);
```
#### Parameters

<a name='DiGi.Analytical.Classes.SolidMaterial.SolidMaterial(DiGi.Analytical.Classes.SolidMaterial).solidMaterial'></a>

`solidMaterial` [SolidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SolidMaterial 'DiGi\.Analytical\.Classes\.SolidMaterial')

The source [SolidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SolidMaterial 'DiGi\.Analytical\.Classes\.SolidMaterial') instance to copy from\.

<a name='DiGi.Analytical.Classes.SolidMaterial.SolidMaterial(string)'></a>

## SolidMaterial\(string\) Constructor

Initializes a new instance of the [SolidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SolidMaterial 'DiGi\.Analytical\.Classes\.SolidMaterial') class with the specified name\.

```csharp
public SolidMaterial(string? name);
```
#### Parameters

<a name='DiGi.Analytical.Classes.SolidMaterial.SolidMaterial(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the solid material\.

<a name='DiGi.Analytical.Classes.SolidMaterial.SolidMaterial(System.Text.Json.Nodes.JsonObject)'></a>

## SolidMaterial\(JsonObject\) Constructor

Initializes a new instance of the [SolidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SolidMaterial 'DiGi\.Analytical\.Classes\.SolidMaterial') class using the specified JSON object\.

```csharp
public SolidMaterial(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Classes.SolidMaterial.SolidMaterial(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the material\.

<a name='DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_'></a>

## SplitSolver\<TAnalyticalGeometry\> Class

Provides a base abstract implementation for solvers that split a single analytical geometry entity into one or more resulting entities\.

```csharp
public abstract class SplitSolver<TAnalyticalGeometry> : DiGi.Core.Interfaces.IOneToManySolver<TAnalyticalGeometry, TAnalyticalGeometry>, DiGi.Core.Interfaces.ISolver, DiGi.Core.Interfaces.IEvaluator
    where TAnalyticalGeometry : DiGi.Analytical.Interfaces.IAnalyticalGeometry
```
#### Type parameters

<a name='DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_.TAnalyticalGeometry'></a>

`TAnalyticalGeometry`

The type of the analytical geometry being processed, which must implement [DiGi\.Analytical\.Interfaces\.IAnalyticalGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalgeometry 'DiGi\.Analytical\.Interfaces\.IAnalyticalGeometry')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → SplitSolver\<TAnalyticalGeometry\>

Derived  
↳ [FaceSplitSolver](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.FaceSplitSolver 'DiGi\.Analytical\.Classes\.FaceSplitSolver')  
↳ [ShellSplitSolver](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.ShellSplitSolver 'DiGi\.Analytical\.Classes\.ShellSplitSolver')

Implements [DiGi\.Core\.Interfaces\.IOneToManySolver&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2')[TAnalyticalGeometry](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_.TAnalyticalGeometry 'DiGi\.Analytical\.Classes\.SplitSolver\<TAnalyticalGeometry\>\.TAnalyticalGeometry')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2')[TAnalyticalGeometry](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_.TAnalyticalGeometry 'DiGi\.Analytical\.Classes\.SplitSolver\<TAnalyticalGeometry\>\.TAnalyticalGeometry')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2'), [DiGi\.Core\.Interfaces\.ISolver](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver 'DiGi\.Core\.Interfaces\.ISolver'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator')
### Constructors

<a name='DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_.SplitSolver(double)'></a>

## SplitSolver\(double\) Constructor

Initializes a new instance of the [SplitSolver&lt;TAnalyticalGeometry&gt;](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_ 'DiGi\.Analytical\.Classes\.SplitSolver\<TAnalyticalGeometry\>') class\.

```csharp
public SplitSolver(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_.SplitSolver(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance to be used for geometric operations\.
### Properties

<a name='DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_.Input'></a>

## SplitSolver\<TAnalyticalGeometry\>\.Input Property

```csharp
public TAnalyticalGeometry? Input { get; set; }
```

Implements [Input](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2.input 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2\.Input')

#### Property Value
[TAnalyticalGeometry](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_.TAnalyticalGeometry 'DiGi\.Analytical\.Classes\.SplitSolver\<TAnalyticalGeometry\>\.TAnalyticalGeometry')

<a name='DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_.Outputs'></a>

## SplitSolver\<TAnalyticalGeometry\>\.Outputs Property

Gets the resulting list of output analytical geometry objects from the solver, filtered to remove any null values\.

```csharp
public System.Collections.Generic.List<TAnalyticalGeometry>? Outputs { get; }
```

Implements [Outputs](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2.outputs 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2\.Outputs')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TAnalyticalGeometry](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_.TAnalyticalGeometry 'DiGi\.Analytical\.Classes\.SplitSolver\<TAnalyticalGeometry\>\.TAnalyticalGeometry')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_.Tolerance'></a>

## SplitSolver\<TAnalyticalGeometry\>\.Tolerance Property

Gets the tolerance value used by the solver for geometric calculations and comparisons\.

```csharp
public double Tolerance { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Analytical.Classes.SplitSolver_TAnalyticalGeometry_.Solve()'></a>

## SplitSolver\<TAnalyticalGeometry\>\.Solve\(\) Method

Executes the splitting operation for the analytical geometry\.

```csharp
public abstract bool Solve();
```

Implements [Solve\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver.solve 'DiGi\.Core\.Interfaces\.ISolver\.Solve')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the solution was successfully found\.

<a name='DiGi.Analytical.Classes.SurfaceValue'></a>

## SurfaceValue Class

Represents a value associated with a surface, containing both internal and external numeric measurements\.

```csharp
public class SurfaceValue : DiGi.Core.Classes.SerializableObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → SurfaceValue

Implements [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Analytical.Classes.SurfaceValue.SurfaceValue(DiGi.Analytical.Classes.SurfaceValue)'></a>

## SurfaceValue\(SurfaceValue\) Constructor

Initializes a new instance of the [SurfaceValue](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SurfaceValue 'DiGi\.Analytical\.Classes\.SurfaceValue') class by copying values from an existing [SurfaceValue](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SurfaceValue 'DiGi\.Analytical\.Classes\.SurfaceValue') instance\.

```csharp
public SurfaceValue(DiGi.Analytical.Classes.SurfaceValue? surfaceValue);
```
#### Parameters

<a name='DiGi.Analytical.Classes.SurfaceValue.SurfaceValue(DiGi.Analytical.Classes.SurfaceValue).surfaceValue'></a>

`surfaceValue` [SurfaceValue](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SurfaceValue 'DiGi\.Analytical\.Classes\.SurfaceValue')

The source [SurfaceValue](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SurfaceValue 'DiGi\.Analytical\.Classes\.SurfaceValue') instance to copy data from, or null\.

<a name='DiGi.Analytical.Classes.SurfaceValue.SurfaceValue(double,double)'></a>

## SurfaceValue\(double, double\) Constructor

Initializes a new instance of the [SurfaceValue](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SurfaceValue 'DiGi\.Analytical\.Classes\.SurfaceValue') class with specified internal and external values\.

```csharp
public SurfaceValue(double @internal, double external);
```
#### Parameters

<a name='DiGi.Analytical.Classes.SurfaceValue.SurfaceValue(double,double).internal'></a>

`internal` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The internal value to assign\.

<a name='DiGi.Analytical.Classes.SurfaceValue.SurfaceValue(double,double).external'></a>

`external` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The external value to assign\.

<a name='DiGi.Analytical.Classes.SurfaceValue.SurfaceValue(System.Text.Json.Nodes.JsonObject)'></a>

## SurfaceValue\(JsonObject\) Constructor

Initializes a new instance of the [SurfaceValue](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SurfaceValue 'DiGi\.Analytical\.Classes\.SurfaceValue') class using the specified JSON object\.

```csharp
public SurfaceValue(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Classes.SurfaceValue.SurfaceValue(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to populate the properties of the instance; can be null\.
### Properties

<a name='DiGi.Analytical.Classes.SurfaceValue.External'></a>

## SurfaceValue\.External Property

Gets or sets the value associated with the external side of the surface\.

```csharp
public double External { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Analytical.Classes.SurfaceValue.Internal'></a>

## SurfaceValue\.Internal Property

Gets or sets the value for the internal side of the surface\.

```csharp
public double Internal { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Analytical.Classes.TransparentMaterial'></a>

## TransparentMaterial Class

Represents a material that possesses transparency characteristics, extending the base functionality of a solid material\.

```csharp
public class TransparentMaterial : DiGi.Analytical.Classes.SolidMaterial
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Material](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Material 'DiGi\.Analytical\.Classes\.Material') → [SolidMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SolidMaterial 'DiGi\.Analytical\.Classes\.SolidMaterial') → TransparentMaterial
### Constructors

<a name='DiGi.Analytical.Classes.TransparentMaterial.TransparentMaterial(DiGi.Analytical.Classes.TransparentMaterial)'></a>

## TransparentMaterial\(TransparentMaterial\) Constructor

Initializes a new instance of the [TransparentMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.TransparentMaterial 'DiGi\.Analytical\.Classes\.TransparentMaterial') class using an existing [TransparentMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.TransparentMaterial 'DiGi\.Analytical\.Classes\.TransparentMaterial') instance\.

```csharp
public TransparentMaterial(DiGi.Analytical.Classes.TransparentMaterial? transparentMaterial);
```
#### Parameters

<a name='DiGi.Analytical.Classes.TransparentMaterial.TransparentMaterial(DiGi.Analytical.Classes.TransparentMaterial).transparentMaterial'></a>

`transparentMaterial` [TransparentMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.TransparentMaterial 'DiGi\.Analytical\.Classes\.TransparentMaterial')

The source [TransparentMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.TransparentMaterial 'DiGi\.Analytical\.Classes\.TransparentMaterial') instance to copy from\.

<a name='DiGi.Analytical.Classes.TransparentMaterial.TransparentMaterial(string)'></a>

## TransparentMaterial\(string\) Constructor

Initializes a new instance of the [TransparentMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.TransparentMaterial 'DiGi\.Analytical\.Classes\.TransparentMaterial') class with the specified name\.

```csharp
public TransparentMaterial(string? name);
```
#### Parameters

<a name='DiGi.Analytical.Classes.TransparentMaterial.TransparentMaterial(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the transparent material\.

<a name='DiGi.Analytical.Classes.TransparentMaterial.TransparentMaterial(System.Text.Json.Nodes.JsonObject)'></a>

## TransparentMaterial\(JsonObject\) Constructor

Initializes a new instance of the [TransparentMaterial](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.TransparentMaterial 'DiGi\.Analytical\.Classes\.TransparentMaterial') class using the specified JSON object\.

```csharp
public TransparentMaterial(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Classes.TransparentMaterial.TransparentMaterial(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the material properties\. This value can be null\.