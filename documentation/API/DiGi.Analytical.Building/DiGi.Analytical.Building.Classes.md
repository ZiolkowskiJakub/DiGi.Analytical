#### [DiGi\.Analytical\.Building](DiGi.Analytical.Building.Overview.md 'DiGi\.Analytical\.Building\.Overview')

## DiGi\.Analytical\.Building\.Classes Namespace
### Classes

<a name='DiGi.Analytical.Building.Classes.AbstractComponent'></a>

## AbstractComponent Class

Represents an abstract base class for all analytical building components, providing core functionality and implementing the [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent') interface\.

```csharp
public abstract class AbstractComponent : DiGi.Analytical.Building.Classes.Component, DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IBuildingBoundable3D, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IConstructable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') → AbstractComponent

Derived  
↳ [AbstractComponent&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstructable](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstructable 'DiGi\.Analytical\.Building\.Interfaces\.IConstructable')
### Constructors

<a name='DiGi.Analytical.Building.Classes.AbstractComponent.AbstractComponent()'></a>

## AbstractComponent\(\) Constructor

Initializes a new instance of the [AbstractComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent') class\.

```csharp
public AbstractComponent();
```

<a name='DiGi.Analytical.Building.Classes.AbstractComponent.AbstractComponent(DiGi.Analytical.Building.Classes.AbstractComponent)'></a>

## AbstractComponent\(AbstractComponent\) Constructor

Initializes a new instance of the [AbstractComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent') class using an existing [AbstractComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent') instance\.

```csharp
public AbstractComponent(DiGi.Analytical.Building.Classes.AbstractComponent? abstractComponent);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.AbstractComponent.AbstractComponent(DiGi.Analytical.Building.Classes.AbstractComponent).abstractComponent'></a>

`abstractComponent` [AbstractComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent')

The source component to copy data from\.

<a name='DiGi.Analytical.Building.Classes.AbstractComponent.AbstractComponent(System.Guid)'></a>

## AbstractComponent\(Guid\) Constructor

Initializes a new instance of the [AbstractComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent') class using the specified unique identifier\.

```csharp
public AbstractComponent(System.Guid guid);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.AbstractComponent.AbstractComponent(System.Guid).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the component\.

<a name='DiGi.Analytical.Building.Classes.AbstractComponent.AbstractComponent(System.Guid,DiGi.Analytical.Building.Classes.AbstractComponent)'></a>

## AbstractComponent\(Guid, AbstractComponent\) Constructor

Initializes a new instance of the [AbstractComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent') class using a specified unique identifier and an optional existing component\.

```csharp
public AbstractComponent(System.Guid guid, DiGi.Analytical.Building.Classes.AbstractComponent? abstractComponent);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.AbstractComponent.AbstractComponent(System.Guid,DiGi.Analytical.Building.Classes.AbstractComponent).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the component\.

<a name='DiGi.Analytical.Building.Classes.AbstractComponent.AbstractComponent(System.Guid,DiGi.Analytical.Building.Classes.AbstractComponent).abstractComponent'></a>

`abstractComponent` [AbstractComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent')

An optional [AbstractComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent') to initialize from\.

<a name='DiGi.Analytical.Building.Classes.AbstractComponent.AbstractComponent(System.Text.Json.Nodes.JsonObject)'></a>

## AbstractComponent\(JsonObject\) Constructor

Initializes a new instance of the [AbstractComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent') class using the specified JSON object\.

```csharp
public AbstractComponent(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.AbstractComponent.AbstractComponent(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the component\.
### Properties

<a name='DiGi.Analytical.Building.Classes.AbstractComponent.StructurePosition'></a>

## AbstractComponent\.StructurePosition Property

Gets or sets the structure position of the component\.

```csharp
public DiGi.Analytical.Building.Enums.StructurePosition StructurePosition { get; set; }
```

#### Property Value
[StructurePosition](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.StructurePosition 'DiGi\.Analytical\.Building\.Enums\.StructurePosition')

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_'></a>

## AbstractComponent\<T\> Class

Provides a base implementation for components that incorporate 3D geometry\.

```csharp
public abstract class AbstractComponent<T> : DiGi.Analytical.Building.Classes.AbstractComponent, DiGi.Analytical.Building.Interfaces.IAbstractComponent<T>, DiGi.Analytical.Building.Interfaces.IAbstractComponent, DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IBuildingBoundable3D, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IConstructable, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject<T>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<T>
    where T : DiGi.Geometry.Spatial.Interfaces.IGeometry3D
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.T'></a>

`T`

The type of the 3D geometry, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') → [AbstractComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent') → AbstractComponent\<T\>

Derived  
↳ [Air&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_ 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IAbstractComponent&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iabstractcomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IAbstractComponent\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iabstractcomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IAbstractComponent\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IAbstractComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iabstractcomponent 'DiGi\.Analytical\.Building\.Interfaces\.IAbstractComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstructable](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstructable 'DiGi\.Analytical\.Building\.Interfaces\.IConstructable'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.AbstractComponent(DiGi.Analytical.Building.Classes.AbstractComponent,T)'></a>

## AbstractComponent\(AbstractComponent, T\) Constructor

Initializes a new instance of the [AbstractComponent&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>') class using an existing abstract component and a specific geometry\.

```csharp
public AbstractComponent(DiGi.Analytical.Building.Classes.AbstractComponent? abstractComponent, T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.AbstractComponent(DiGi.Analytical.Building.Classes.AbstractComponent,T).abstractComponent'></a>

`abstractComponent` [AbstractComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent')

The source abstract component from which to copy base properties\.

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.AbstractComponent(DiGi.Analytical.Building.Classes.AbstractComponent,T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>\.T')

The geometry object to be assigned to this component\.

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.AbstractComponent(DiGi.Analytical.Building.Classes.AbstractComponent_T_)'></a>

## AbstractComponent\(AbstractComponent\<T\>\) Constructor

Initializes a new instance of the [AbstractComponent&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>') class using an existing component as a source for cloning\.

```csharp
public AbstractComponent(DiGi.Analytical.Building.Classes.AbstractComponent<T>? abstractComponent);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.AbstractComponent(DiGi.Analytical.Building.Classes.AbstractComponent_T_).abstractComponent'></a>

`abstractComponent` [DiGi\.Analytical\.Building\.Classes\.AbstractComponent&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>')

The source [AbstractComponent&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>') instance to copy data from\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.AbstractComponent(System.Guid,DiGi.Analytical.Building.Classes.AbstractComponent_T_)'></a>

## AbstractComponent\(Guid, AbstractComponent\<T\>\) Constructor

Initializes a new instance of the [AbstractComponent&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>') class using the specified unique identifier and an optional source component\.

```csharp
public AbstractComponent(System.Guid guid, DiGi.Analytical.Building.Classes.AbstractComponent<T>? abstractComponent);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.AbstractComponent(System.Guid,DiGi.Analytical.Building.Classes.AbstractComponent_T_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The globally unique identifier for the component\.

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.AbstractComponent(System.Guid,DiGi.Analytical.Building.Classes.AbstractComponent_T_).abstractComponent'></a>

`abstractComponent` [DiGi\.Analytical\.Building\.Classes\.AbstractComponent&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>')

An optional source [AbstractComponent&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>') instance to copy properties from\.

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.AbstractComponent(System.Guid,T)'></a>

## AbstractComponent\(Guid, T\) Constructor

Initializes a new instance of the [AbstractComponent&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>') class with the specified unique identifier and geometry\.

```csharp
public AbstractComponent(System.Guid guid, T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.AbstractComponent(System.Guid,T).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the component\.

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.AbstractComponent(System.Guid,T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>\.T')

The geometry associated with the component\.

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.AbstractComponent(System.Text.Json.Nodes.JsonObject)'></a>

## AbstractComponent\(JsonObject\) Constructor

Initializes a new instance of the [AbstractComponent&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>') class using the specified JSON object\.

```csharp
public AbstractComponent(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.AbstractComponent(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the component\.

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.AbstractComponent(T)'></a>

## AbstractComponent\(T\) Constructor

Initializes a new instance of the [AbstractComponent&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>') class with the specified geometry\.

```csharp
public AbstractComponent(T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.AbstractComponent(T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>\.T')

The geometry object to associate with this component\. This value can be null\.
### Properties

<a name='DiGi.Analytical.Building.Classes.AbstractComponent_T_.Geometry'></a>

## AbstractComponent\<T\>\.Geometry Property

```csharp
public T? Geometry { get; }
```

Implements [Geometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1.geometry 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1\.Geometry')

#### Property Value
[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>\.T')

<a name='DiGi.Analytical.Building.Classes.Air_T_'></a>

## Air\<T\> Class

Represents an abstract base class for air components within a building analytical model\.

```csharp
public abstract class Air<T> : DiGi.Analytical.Building.Classes.AbstractComponent<T>, DiGi.Analytical.Building.Interfaces.IAir<T>, DiGi.Analytical.Building.Interfaces.IAbstractComponent<T>, DiGi.Analytical.Building.Interfaces.IAbstractComponent, DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IBuildingBoundable3D, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IConstructable, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject<T>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<T>
    where T : DiGi.Geometry.Spatial.Interfaces.IGeometry3D
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.Air_T_.T'></a>

`T`

The type of 3D geometry associated with the air component, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') → [AbstractComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent') → [DiGi\.Analytical\.Building\.Classes\.AbstractComponent&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_.T 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>') → Air\<T\>

Derived  
↳ [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IAir&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iair-1 'DiGi\.Analytical\.Building\.Interfaces\.IAir\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_.T 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iair-1 'DiGi\.Analytical\.Building\.Interfaces\.IAir\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IAbstractComponent&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iabstractcomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IAbstractComponent\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_.T 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iabstractcomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IAbstractComponent\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IAbstractComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iabstractcomponent 'DiGi\.Analytical\.Building\.Interfaces\.IAbstractComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstructable](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstructable 'DiGi\.Analytical\.Building\.Interfaces\.IConstructable'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_.T 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_.T 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.Air_T_.Air(DiGi.Analytical.Building.Classes.Air_T_)'></a>

## Air\(Air\<T\>\) Constructor

Initializes a new instance of the [Air&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_ 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>') class using an existing air component\.

```csharp
public Air(DiGi.Analytical.Building.Classes.Air<T>? air);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Air_T_.Air(DiGi.Analytical.Building.Classes.Air_T_).air'></a>

`air` [DiGi\.Analytical\.Building\.Classes\.Air&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_ 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_.T 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_ 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>')

The source [Air&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_ 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.Air_T_.Air(DiGi.Analytical.Building.Interfaces.IAir,T)'></a>

## Air\(IAir, T\) Constructor

Initializes a new instance of the [Air&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_ 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>') class using an existing air component and a specified geometry\.

```csharp
public Air(DiGi.Analytical.Building.Interfaces.IAir? air, T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Air_T_.Air(DiGi.Analytical.Building.Interfaces.IAir,T).air'></a>

`air` [DiGi\.Analytical\.Building\.Interfaces\.IAir](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iair 'DiGi\.Analytical\.Building\.Interfaces\.IAir')

The source air component from which properties are copied\.

<a name='DiGi.Analytical.Building.Classes.Air_T_.Air(DiGi.Analytical.Building.Interfaces.IAir,T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_.T 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>\.T')

The geometry associated with this air component\.

<a name='DiGi.Analytical.Building.Classes.Air_T_.Air(System.Guid,DiGi.Analytical.Building.Classes.Air_T_)'></a>

## Air\(Guid, Air\<T\>\) Constructor

Initializes a new instance of the [Air&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_ 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>') class using a specified unique identifier and an existing air object\.

```csharp
public Air(System.Guid guid, DiGi.Analytical.Building.Classes.Air<T>? air);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Air_T_.Air(System.Guid,DiGi.Analytical.Building.Classes.Air_T_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the air component\.

<a name='DiGi.Analytical.Building.Classes.Air_T_.Air(System.Guid,DiGi.Analytical.Building.Classes.Air_T_).air'></a>

`air` [DiGi\.Analytical\.Building\.Classes\.Air&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_ 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_.T 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_ 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>')

An optional existing air object to initialize from\.

<a name='DiGi.Analytical.Building.Classes.Air_T_.Air(System.Guid,T)'></a>

## Air\(Guid, T\) Constructor

Initializes a new instance of the [Air&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_ 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>') class using the specified unique identifier and geometry\.

```csharp
public Air(System.Guid guid, T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Air_T_.Air(System.Guid,T).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the object\.

<a name='DiGi.Analytical.Building.Classes.Air_T_.Air(System.Guid,T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_.T 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>\.T')

The 3D geometry associated with the air component\.

<a name='DiGi.Analytical.Building.Classes.Air_T_.Air(System.Text.Json.Nodes.JsonObject)'></a>

## Air\(JsonObject\) Constructor

Initializes a new instance of the [Air&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_ 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>') class using the specified JSON object\.

```csharp
public Air(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Air_T_.Air(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the instance\.

<a name='DiGi.Analytical.Building.Classes.Air_T_.Air(T)'></a>

## Air\(T\) Constructor

Initializes a new instance of the [Air&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_ 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>') class using the specified geometry\.

```csharp
public Air(T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Air_T_.Air(T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_.T 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>\.T')

The geometry to be associated with this air component\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject'></a>

## BuildingGeometry2DObject Class

Represents an abstract base class for two\-dimensional geometric objects within a building's analytical model\.

```csharp
public abstract class BuildingGeometry2DObject : DiGi.Analytical.Building.Classes.BuildingObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometry2DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → BuildingGeometry2DObject

Derived  
↳ [BuildingGeometry2DObject&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry2dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry2DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject.BuildingGeometry2DObject()'></a>

## BuildingGeometry2DObject\(\) Constructor

Initializes a new instance of the [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject') class\.

```csharp
public BuildingGeometry2DObject();
```

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject.BuildingGeometry2DObject(DiGi.Analytical.Building.Classes.BuildingGeometry2DObject)'></a>

## BuildingGeometry2DObject\(BuildingGeometry2DObject\) Constructor

Initializes a new instance of the [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject') class based on an existing [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject') object\.

```csharp
public BuildingGeometry2DObject(DiGi.Analytical.Building.Classes.BuildingGeometry2DObject? buildingGeometry2DObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject.BuildingGeometry2DObject(DiGi.Analytical.Building.Classes.BuildingGeometry2DObject).buildingGeometry2DObject'></a>

`buildingGeometry2DObject` [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject')

The [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject') object to copy from\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject.BuildingGeometry2DObject(System.Guid)'></a>

## BuildingGeometry2DObject\(Guid\) Constructor

Initializes a new instance of the [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject') class using the specified unique identifier\.

```csharp
public BuildingGeometry2DObject(System.Guid guid);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject.BuildingGeometry2DObject(System.Guid).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the object\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject.BuildingGeometry2DObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingGeometry2DObject)'></a>

## BuildingGeometry2DObject\(Guid, BuildingGeometry2DObject\) Constructor

Initializes a new instance of the [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject') class with a specified unique identifier and an optional source object\.

```csharp
public BuildingGeometry2DObject(System.Guid guid, DiGi.Analytical.Building.Classes.BuildingGeometry2DObject? buildingGeometry2DObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject.BuildingGeometry2DObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingGeometry2DObject).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the building geometry 2D object\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject.BuildingGeometry2DObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingGeometry2DObject).buildingGeometry2DObject'></a>

`buildingGeometry2DObject` [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject')

An optional existing [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject') instance used to initialize the current instance\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject.BuildingGeometry2DObject(System.Text.Json.Nodes.JsonObject)'></a>

## BuildingGeometry2DObject\(JsonObject\) Constructor

Initializes a new instance of the [BuildingGeometry2DObject&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>') class from the specified JSON object\.

```csharp
public BuildingGeometry2DObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject.BuildingGeometry2DObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the building geometry 2D object\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_'></a>

## BuildingGeometry2DObject\<T\> Class

Represents an abstract base class for objects that possess two\-dimensional building geometry\.

```csharp
public abstract class BuildingGeometry2DObject<T> : DiGi.Analytical.Building.Classes.BuildingGeometry2DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometry2DObject<T>, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject<T>, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<T>, DiGi.Analytical.Building.Interfaces.IBuildingGeometry2DObject, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject<T>
    where T : DiGi.Geometry.Planar.Interfaces.IGeometry2D
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.T'></a>

`T`

The type of the 2D geometry\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject') → BuildingGeometry2DObject\<T\>

Derived  
↳ [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry2DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry2dobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry2DObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry2dobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry2DObject\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry2dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry2DObject'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.BuildingGeometry2DObject(DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_)'></a>

## BuildingGeometry2DObject\(BuildingGeometry2DObject\<T\>\) Constructor

Initializes a new instance of the [BuildingGeometry2DObject&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>') class by copying an existing building geometry 2D object\.

```csharp
public BuildingGeometry2DObject(DiGi.Analytical.Building.Classes.BuildingGeometry2DObject<T>? buildingGeometry2DObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.BuildingGeometry2DObject(DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_).buildingGeometry2DObject'></a>

`buildingGeometry2DObject` [DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>')

The source [BuildingGeometry2DObject&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>') object to copy from\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.BuildingGeometry2DObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_)'></a>

## BuildingGeometry2DObject\(Guid, BuildingGeometry2DObject\<T\>\) Constructor

Initializes a new instance of the [BuildingGeometry2DObject&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>') class using the specified unique identifier and an existing building geometry object\.

```csharp
public BuildingGeometry2DObject(System.Guid guid, DiGi.Analytical.Building.Classes.BuildingGeometry2DObject<T>? buildingGeometry2DObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.BuildingGeometry2DObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the object\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.BuildingGeometry2DObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_).buildingGeometry2DObject'></a>

`buildingGeometry2DObject` [DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>')

The source building geometry object from which to clone properties and geometry\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.BuildingGeometry2DObject(System.Text.Json.Nodes.JsonObject)'></a>

## BuildingGeometry2DObject\(JsonObject\) Constructor

Initializes a new instance of the [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject') class using the specified JSON object\.

```csharp
public BuildingGeometry2DObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.BuildingGeometry2DObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the building geometry 2D object\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.BuildingGeometry2DObject(T)'></a>

## BuildingGeometry2DObject\(T\) Constructor

Initializes a new instance of the [BuildingGeometry2DObject&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>') class with the specified geometry\.

```csharp
public BuildingGeometry2DObject(T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.BuildingGeometry2DObject(T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>\.T')

The geometry to assign to the object; can be null\.
### Properties

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.Geometry'></a>

## BuildingGeometry2DObject\<T\>\.Geometry Property

Gets the two\-dimensional geometry of the building object\.

```csharp
public T? Geometry { get; }
```

Implements [Geometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1.geometry 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1\.Geometry')

#### Property Value
[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>\.T')

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject'></a>

## BuildingGeometry3DObject Class

Represents an abstract base class for all three\-dimensional geometric objects within a building's analytical model\.

```csharp
public abstract class BuildingGeometry3DObject : DiGi.Analytical.Building.Classes.BuildingObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → BuildingGeometry3DObject

Derived  
↳ [BuildingGeometry3DObject&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>')  
↳ [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject.BuildingGeometry3DObject()'></a>

## BuildingGeometry3DObject\(\) Constructor

Initializes a new instance of the [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') class\.

```csharp
public BuildingGeometry3DObject();
```

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject.BuildingGeometry3DObject(DiGi.Analytical.Building.Classes.BuildingGeometry3DObject)'></a>

## BuildingGeometry3DObject\(BuildingGeometry3DObject\) Constructor

Initializes a new instance of the [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') class using the specified object\.

```csharp
public BuildingGeometry3DObject(DiGi.Analytical.Building.Classes.BuildingGeometry3DObject? buildingGeometry3DObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject.BuildingGeometry3DObject(DiGi.Analytical.Building.Classes.BuildingGeometry3DObject).buildingGeometry3DObject'></a>

`buildingGeometry3DObject` [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject')

The [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') object to copy from or use for initialization\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject.BuildingGeometry3DObject(System.Guid)'></a>

## BuildingGeometry3DObject\(Guid\) Constructor

Initializes a new instance of the [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') class with the specified unique identifier\.

```csharp
public BuildingGeometry3DObject(System.Guid guid);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject.BuildingGeometry3DObject(System.Guid).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the building geometry 3D object\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject.BuildingGeometry3DObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingGeometry3DObject)'></a>

## BuildingGeometry3DObject\(Guid, BuildingGeometry3DObject\) Constructor

Initializes a new instance of the [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') class with a specified unique identifier and an optional existing object\.

```csharp
public BuildingGeometry3DObject(System.Guid guid, DiGi.Analytical.Building.Classes.BuildingGeometry3DObject? buildingGeometry3DObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject.BuildingGeometry3DObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingGeometry3DObject).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the building geometry 3D object\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject.BuildingGeometry3DObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingGeometry3DObject).buildingGeometry3DObject'></a>

`buildingGeometry3DObject` [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject')

An optional [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') instance to initialize from\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject.BuildingGeometry3DObject(System.Text.Json.Nodes.JsonObject)'></a>

## BuildingGeometry3DObject\(JsonObject\) Constructor

Initializes a new instance of the [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') class using the specified JSON object\.

```csharp
public BuildingGeometry3DObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject.BuildingGeometry3DObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the building geometry 3D object\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_'></a>

## BuildingGeometry3DObject\<T\> Class

Represents an abstract base class for 3D building geometry objects that encapsulate a specific type of 3D geometry\.

```csharp
public abstract class BuildingGeometry3DObject<T> : DiGi.Analytical.Building.Classes.BuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject<T>, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject<T>, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<T>, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject<T>
    where T : DiGi.Geometry.Spatial.Interfaces.IGeometry3D
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.T'></a>

`T`

The type of the 3D geometry, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → BuildingGeometry3DObject\<T\>

Derived  
↳ [Shade&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_ 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>')  
↳ [Space](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Space 'DiGi\.Analytical\.Building\.Classes\.Space')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject-1 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject-1 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.BuildingGeometry3DObject(DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_)'></a>

## BuildingGeometry3DObject\(BuildingGeometry3DObject\<T\>\) Constructor

Initializes a new instance of the [BuildingGeometry3DObject&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>') class using an existing building geometry 3D object\.

```csharp
public BuildingGeometry3DObject(DiGi.Analytical.Building.Classes.BuildingGeometry3DObject<T>? buildingGeometry3DObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.BuildingGeometry3DObject(DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_).buildingGeometry3DObject'></a>

`buildingGeometry3DObject` [DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>')

The source building geometry 3D object to copy from\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.BuildingGeometry3DObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_)'></a>

## BuildingGeometry3DObject\(Guid, BuildingGeometry3DObject\<T\>\) Constructor

Initializes a new instance of the [BuildingGeometry3DObject&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>') class with the specified unique identifier and an optional source building geometry 3D object\.

```csharp
public BuildingGeometry3DObject(System.Guid guid, DiGi.Analytical.Building.Classes.BuildingGeometry3DObject<T>? buildingGeometry3DObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.BuildingGeometry3DObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the object\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.BuildingGeometry3DObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_).buildingGeometry3DObject'></a>

`buildingGeometry3DObject` [DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>')

An optional existing building geometry 3D object to copy data from\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.BuildingGeometry3DObject(System.Text.Json.Nodes.JsonObject)'></a>

## BuildingGeometry3DObject\(JsonObject\) Constructor

Initializes a new instance of the [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') class using the specified JSON object\.

```csharp
public BuildingGeometry3DObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.BuildingGeometry3DObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the object\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.BuildingGeometry3DObject(T)'></a>

## BuildingGeometry3DObject\(T\) Constructor

Initializes a new instance of the [BuildingGeometry3DObject&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>') class with the specified 3D geometry\.

```csharp
public BuildingGeometry3DObject(T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.BuildingGeometry3DObject(T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>\.T')

The 3D geometry to assign to this object\. The provided geometry is cloned if it is not null\.
### Properties

<a name='DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.Geometry'></a>

## BuildingGeometry3DObject\<T\>\.Geometry Property

```csharp
public T? Geometry { get; }
```

Implements [Geometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1.geometry 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1\.Geometry')

#### Property Value
[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_.T 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>\.T')

<a name='DiGi.Analytical.Building.Classes.BuildingInformation'></a>

## BuildingInformation Class

Represents detailed information regarding a building, providing properties for its address, geographical coordinates, and UTC offset\.

```csharp
public class BuildingInformation : DiGi.Core.Classes.SerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → BuildingInformation

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.BuildingInformation.BuildingInformation()'></a>

## BuildingInformation\(\) Constructor

Initializes a new instance of the [BuildingInformation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingInformation 'DiGi\.Analytical\.Building\.Classes\.BuildingInformation') class\.

```csharp
public BuildingInformation();
```

<a name='DiGi.Analytical.Building.Classes.BuildingInformation.BuildingInformation(DiGi.Analytical.Building.Classes.BuildingInformation)'></a>

## BuildingInformation\(BuildingInformation\) Constructor

Initializes a new instance of the [BuildingInformation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingInformation 'DiGi\.Analytical\.Building\.Classes\.BuildingInformation') class by copying the values from an existing [BuildingInformation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingInformation 'DiGi\.Analytical\.Building\.Classes\.BuildingInformation') instance\.

```csharp
public BuildingInformation(DiGi.Analytical.Building.Classes.BuildingInformation? buildingInformation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingInformation.BuildingInformation(DiGi.Analytical.Building.Classes.BuildingInformation).buildingInformation'></a>

`buildingInformation` [BuildingInformation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingInformation 'DiGi\.Analytical\.Building\.Classes\.BuildingInformation')

The source [BuildingInformation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingInformation 'DiGi\.Analytical\.Building\.Classes\.BuildingInformation') object to copy data from; can be null\.

<a name='DiGi.Analytical.Building.Classes.BuildingInformation.BuildingInformation(System.Text.Json.Nodes.JsonObject)'></a>

## BuildingInformation\(JsonObject\) Constructor

Initializes a new instance of the [BuildingInformation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingInformation 'DiGi\.Analytical\.Building\.Classes\.BuildingInformation') class using the specified JSON object\.

```csharp
public BuildingInformation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingInformation.BuildingInformation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the building information data\.
### Properties

<a name='DiGi.Analytical.Building.Classes.BuildingInformation.Address'></a>

## BuildingInformation\.Address Property

Gets or sets the physical mailing address of the building\.

```csharp
public DiGi.Core.Classes.Address? Address { get; set; }
```

#### Property Value
[DiGi\.Core\.Classes\.Address](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.address 'DiGi\.Core\.Classes\.Address')

<a name='DiGi.Analytical.Building.Classes.BuildingInformation.Coordinates'></a>

## BuildingInformation\.Coordinates Property

Gets or sets the geographic coordinates of the building\.

```csharp
public DiGi.Core.Classes.Coordinates? Coordinates { get; set; }
```

#### Property Value
[DiGi\.Core\.Classes\.Coordinates](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.coordinates 'DiGi\.Core\.Classes\.Coordinates')

<a name='DiGi.Analytical.Building.Classes.BuildingInformation.UTC'></a>

## BuildingInformation\.UTC Property

Gets or sets the Coordinated Universal Time \(UTC\) time zone associated with the building information\.

```csharp
public DiGi.Core.Enums.UTC UTC { get; set; }
```

#### Property Value
[DiGi\.Core\.Enums\.UTC](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.utc 'DiGi\.Core\.Enums\.UTC')

<a name='DiGi.Analytical.Building.Classes.BuildingModel'></a>

## BuildingModel Class

Represents an analytical building model that manages structural relations, building information, and spatial bounding properties\.

```csharp
public class BuildingModel : DiGi.Core.Parameter.Classes.ParametrizedGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IGuidModel, DiGi.Core.Interfaces.ISerializableModel, DiGi.Core.Interfaces.IModel, DiGi.Analytical.Building.Interfaces.IBuildingBoundable3D, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → BuildingModel

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IGuidModel](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidmodel 'DiGi\.Core\.Interfaces\.IGuidModel'), [DiGi\.Core\.Interfaces\.ISerializableModel](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializablemodel 'DiGi\.Core\.Interfaces\.ISerializableModel'), [DiGi\.Core\.Interfaces\.IModel](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.imodel 'DiGi\.Core\.Interfaces\.IModel'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.BuildingModel.BuildingModel()'></a>

## BuildingModel\(\) Constructor

Initializes a new instance of the [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') class\.

```csharp
public BuildingModel();
```

<a name='DiGi.Analytical.Building.Classes.BuildingModel.BuildingModel(DiGi.Analytical.Building.Classes.BuildingModel)'></a>

## BuildingModel\(BuildingModel\) Constructor

Initializes a new instance of the [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') class by cloning an existing building model\.

```csharp
public BuildingModel(DiGi.Analytical.Building.Classes.BuildingModel? buildingModel);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.BuildingModel(DiGi.Analytical.Building.Classes.BuildingModel).buildingModel'></a>

`buildingModel` [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The source [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') instance to copy data from\. If null, a default instance is initialized\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.BuildingModel(System.Text.Json.Nodes.JsonObject)'></a>

## BuildingModel\(JsonObject\) Constructor

Initializes a new instance of the [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') class using the specified JSON object\.

```csharp
public BuildingModel(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.BuildingModel(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the building model data, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no data is provided\.
### Properties

<a name='DiGi.Analytical.Building.Classes.BuildingModel.BuildingInformation'></a>

## BuildingModel\.BuildingInformation Property

Gets or sets the building information associated with this building model\.

```csharp
public DiGi.Analytical.Building.Classes.BuildingInformation BuildingInformation { get; set; }
```

#### Property Value
[BuildingInformation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingInformation 'DiGi\.Analytical\.Building\.Classes\.BuildingInformation')
### Methods

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace)'></a>

## BuildingModel\.Assign\(IComponent, ISpace, ISpace\) Method

Assigns a component to one or two spaces and establishes the corresponding relationship within the building model\.

```csharp
public bool Assign(DiGi.Analytical.Building.Interfaces.IComponent? component, DiGi.Analytical.Building.Interfaces.ISpace? space_1, DiGi.Analytical.Building.Interfaces.ISpace? space_2=null);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The component to be assigned\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace).space_1'></a>

`space_1` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The primary space associated with the component\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace).space_2'></a>

`space_2` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

An optional secondary space associated with the component\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the component and spaces were successfully updated and the relationship was created; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IDoor,DiGi.Analytical.Building.Interfaces.IDoorConstruction)'></a>

## BuildingModel\.Assign\(IDoor, IDoorConstruction\) Method

Assigns a relationship between the specified door and its corresponding door construction within the building model\.

```csharp
public bool Assign(DiGi.Analytical.Building.Interfaces.IDoor? door, DiGi.Analytical.Building.Interfaces.IDoorConstruction? doorConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IDoor,DiGi.Analytical.Building.Interfaces.IDoorConstruction).door'></a>

`door` [DiGi\.Analytical\.Building\.Interfaces\.IDoor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.idoor 'DiGi\.Analytical\.Building\.Interfaces\.IDoor')

The door object to be assigned\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IDoor,DiGi.Analytical.Building.Interfaces.IDoorConstruction).doorConstruction'></a>

`doorConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IDoorConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.idoorconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IDoorConstruction')

The door construction object to be assigned\. This value can be null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the relationship was successfully established; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IFloor,DiGi.Analytical.Building.Interfaces.IFloorConstruction)'></a>

## BuildingModel\.Assign\(IFloor, IFloorConstruction\) Method

Assigns a floor construction to a specific floor within the building model\.

```csharp
public bool Assign(DiGi.Analytical.Building.Interfaces.IFloor? floor, DiGi.Analytical.Building.Interfaces.IFloorConstruction? floorConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IFloor,DiGi.Analytical.Building.Interfaces.IFloorConstruction).floor'></a>

`floor` [DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor')

The floor object to be assigned\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IFloor,DiGi.Analytical.Building.Interfaces.IFloorConstruction).floorConstruction'></a>

`floorConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloorconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction')

The floor construction object to be assigned\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the assignment was successful; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IRoof,DiGi.Analytical.Building.Interfaces.IRoofConstruction)'></a>

## BuildingModel\.Assign\(IRoof, IRoofConstruction\) Method

Assigns a relationship between the specified roof and its corresponding roof construction within the building model\.

```csharp
public bool Assign(DiGi.Analytical.Building.Interfaces.IRoof? roof, DiGi.Analytical.Building.Interfaces.IRoofConstruction? roofConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IRoof,DiGi.Analytical.Building.Interfaces.IRoofConstruction).roof'></a>

`roof` [DiGi\.Analytical\.Building\.Interfaces\.IRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof')

The roof object to be assigned\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IRoof,DiGi.Analytical.Building.Interfaces.IRoofConstruction).roofConstruction'></a>

`roofConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IRoofConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroofconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IRoofConstruction')

The roof construction object to be assigned\. This value can be null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the assignment was successful and the relation was created; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string)'></a>

## BuildingModel\.Assign\(ISpace, IInternalCondition, HourRange, string\) Method

Assigns an internal condition to a specific space within the building model\.

```csharp
public bool Assign(DiGi.Analytical.Building.Interfaces.ISpace? space, DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition, DiGi.Analytical.Classes.HourRange? hourRange, string? id=null);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space object to which the internal condition is assigned\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition object to be assigned to the space\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).hourRange'></a>

`hourRange` [DiGi\.Analytical\.Classes\.HourRange](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.hourrange 'DiGi\.Analytical\.Classes\.HourRange')

An optional hour range specifying when the internal condition applies\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional unique identifier for the assignment relation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the internal condition was successfully assigned to the space; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Analytical.Building.Interfaces.IWallConstruction)'></a>

## BuildingModel\.Assign\(IWall, IWallConstruction\) Method

Assigns a wall to its corresponding wall construction within the building model\.

```csharp
public bool Assign(DiGi.Analytical.Building.Interfaces.IWall? wall, DiGi.Analytical.Building.Interfaces.IWallConstruction? wallConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Analytical.Building.Interfaces.IWallConstruction).wall'></a>

`wall` [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')

The wall object to be assigned\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Analytical.Building.Interfaces.IWallConstruction).wallConstruction'></a>

`wallConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IWallConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwallconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IWallConstruction')

The wall construction object to be associated with the wall\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the assignment was successful; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IWindow,DiGi.Analytical.Building.Interfaces.IWindowConstruction)'></a>

## BuildingModel\.Assign\(IWindow, IWindowConstruction\) Method

Assigns a window construction to the specified window within the building model\.

```csharp
public bool Assign(DiGi.Analytical.Building.Interfaces.IWindow? window, DiGi.Analytical.Building.Interfaces.IWindowConstruction? windowConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IWindow,DiGi.Analytical.Building.Interfaces.IWindowConstruction).window'></a>

`window` [DiGi\.Analytical\.Building\.Interfaces\.IWindow](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwindow 'DiGi\.Analytical\.Building\.Interfaces\.IWindow')

The window instance to which the construction is assigned\. May be null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IWindow,DiGi.Analytical.Building.Interfaces.IWindowConstruction).windowConstruction'></a>

`windowConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IWindowConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwindowconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IWindowConstruction')

The window construction instance to assign\. May be null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the assignment was successfully created; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IZone,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_)'></a>

## BuildingModel\.Assign\(IZone, IEnumerable\<ISpace\>\) Method

Assigns a collection of spaces to a specified zone within the building model\.

```csharp
public bool Assign(DiGi.Analytical.Building.Interfaces.IZone? zone, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Interfaces.ISpace>? spaces);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IZone,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_).zone'></a>

`zone` [DiGi\.Analytical\.Building\.Interfaces\.IZone](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.izone 'DiGi\.Analytical\.Building\.Interfaces\.IZone')

The zone to which the spaces should be assigned\. May be null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign(DiGi.Analytical.Building.Interfaces.IZone,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_).spaces'></a>

`spaces` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of spaces to associate with the zone\. May be null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the assignment was successful and the relation was created; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign_TSpace_(System.Collections.Generic.IEnumerable_TSpace_,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string)'></a>

## BuildingModel\.Assign\<TSpace\>\(IEnumerable\<TSpace\>, IInternalCondition, HourRange, string\) Method

Assigns a collection of spaces to an internal condition with an optional time range and identifier\.

```csharp
public bool Assign<TSpace>(System.Collections.Generic.IEnumerable<TSpace>? spaces, DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition, DiGi.Analytical.Classes.HourRange? hourRange, string? id=null)
    where TSpace : DiGi.Analytical.Building.Interfaces.ISpace;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign_TSpace_(System.Collections.Generic.IEnumerable_TSpace_,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).TSpace'></a>

`TSpace`

The type of the space objects, which must implement [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign_TSpace_(System.Collections.Generic.IEnumerable_TSpace_,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).spaces'></a>

`spaces` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TSpace](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.Assign_TSpace_(System.Collections.Generic.IEnumerable_TSpace_,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).TSpace 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.Assign\<TSpace\>\(System\.Collections\.Generic\.IEnumerable\<TSpace\>, DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition, DiGi\.Analytical\.Classes\.HourRange, string\)\.TSpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of spaces to be assigned\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign_TSpace_(System.Collections.Generic.IEnumerable_TSpace_,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition to associate with the spaces\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign_TSpace_(System.Collections.Generic.IEnumerable_TSpace_,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).hourRange'></a>

`hourRange` [DiGi\.Analytical\.Classes\.HourRange](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.hourrange 'DiGi\.Analytical\.Classes\.HourRange')

An optional time range during which the assignment is valid\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Assign_TSpace_(System.Collections.Generic.IEnumerable_TSpace_,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional unique identifier for the relation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if at least one space was successfully assigned; otherwise, `false`\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetBoundingBox()'></a>

## BuildingModel\.GetBoundingBox\(\) Method

Gets the axis\-aligned bounding box of the building model\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d.getboundingbox 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D\.GetBoundingBox')

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
The bounding box encompassing all components in the building model, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if it cannot be created\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetComponent_TComponent_(DiGi.Analytical.Building.Interfaces.IOpening)'></a>

## BuildingModel\.GetComponent\<TComponent\>\(IOpening\) Method

Retrieves a component of the specified type associated with the given opening\.

```csharp
public TComponent? GetComponent<TComponent>(DiGi.Analytical.Building.Interfaces.IOpening? opening)
    where TComponent : DiGi.Analytical.Building.Interfaces.IComponent;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetComponent_TComponent_(DiGi.Analytical.Building.Interfaces.IOpening).TComponent'></a>

`TComponent`

The type of the component to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetComponent_TComponent_(DiGi.Analytical.Building.Interfaces.IOpening).opening'></a>

`opening` [DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')

The opening for which the associated component is being retrieved\. May be `null`\.

#### Returns
[TComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetComponent_TComponent_(DiGi.Analytical.Building.Interfaces.IOpening).TComponent 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetComponent\<TComponent\>\(DiGi\.Analytical\.Building\.Interfaces\.IOpening\)\.TComponent')  
A cloned instance of the requested component type if found and compatible; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_()'></a>

## BuildingModel\.GetComponents\<TComponent\>\(\) Method

Retrieves all components of the specified type from the building relation cluster\.

```csharp
public System.Collections.Generic.List<TComponent>? GetComponents<TComponent>()
    where TComponent : DiGi.Analytical.Building.Interfaces.IComponent;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_().TComponent'></a>

`TComponent`

The type of component to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_().TComponent 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetComponents\<TComponent\>\(\)\.TComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of components of type [TComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_().TComponent 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetComponents\<TComponent\>\(\)\.TComponent'), or null if no such components are found\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction)'></a>

## BuildingModel\.GetComponents\<TComponent\>\(IPhysicalComponentConstruction\) Method

Retrieves a list of components of the specified type associated with the given physical component construction\.

```csharp
public System.Collections.Generic.List<TComponent>? GetComponents<TComponent>(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction? physicalComponentConstruction)
    where TComponent : DiGi.Analytical.Building.Interfaces.IComponent;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction).TComponent'></a>

`TComponent`

The type of components to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction).physicalComponentConstruction'></a>

`physicalComponentConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')

The physical component construction used to identify related components\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction).TComponent 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetComponents\<TComponent\>\(DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction\)\.TComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of components of type [TComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction).TComponent 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetComponents\<TComponent\>\(DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction\)\.TComponent') if found; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.ISpace)'></a>

## BuildingModel\.GetComponents\<TComponent\>\(ISpace\) Method

Retrieves a list of components of the specified type associated with the given space\.

```csharp
public System.Collections.Generic.List<TComponent>? GetComponents<TComponent>(DiGi.Analytical.Building.Interfaces.ISpace? space)
    where TComponent : DiGi.Analytical.Building.Interfaces.IComponent;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.ISpace).TComponent'></a>

`TComponent`

The type of component to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.ISpace).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space for which to retrieve the associated components\. May be null\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.ISpace).TComponent 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetComponents\<TComponent\>\(DiGi\.Analytical\.Building\.Interfaces\.ISpace\)\.TComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of components of type [TComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.ISpace).TComponent 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetComponents\<TComponent\>\(DiGi\.Analytical\.Building\.Interfaces\.ISpace\)\.TComponent') if successful; otherwise, null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace)'></a>

## BuildingModel\.GetComponents\<TComponent\>\(ISpace, ISpace\) Method

Retrieves a list of components of the specified type that define the relationship between two spaces\.

```csharp
public System.Collections.Generic.List<TComponent>? GetComponents<TComponent>(DiGi.Analytical.Building.Interfaces.ISpace? space_1, DiGi.Analytical.Building.Interfaces.ISpace? space_2)
    where TComponent : DiGi.Analytical.Building.Interfaces.IComponent;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace).TComponent'></a>

`TComponent`

The type of component to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace).space_1'></a>

`space_1` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The first space involved in the relation\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace).space_2'></a>

`space_2` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The second space involved in the relation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace).TComponent 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetComponents\<TComponent\>\(DiGi\.Analytical\.Building\.Interfaces\.ISpace, DiGi\.Analytical\.Building\.Interfaces\.ISpace\)\.TComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of components of type [TComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetComponents_TComponent_(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace).TComponent 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetComponents\<TComponent\>\(DiGi\.Analytical\.Building\.Interfaces\.ISpace, DiGi\.Analytical\.Building\.Interfaces\.ISpace\)\.TComponent') if successful; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetDoorConstruction(DiGi.Analytical.Building.Interfaces.IDoor)'></a>

## BuildingModel\.GetDoorConstruction\(IDoor\) Method

Retrieves the door construction associated with the specified door\.

```csharp
public DiGi.Analytical.Building.Interfaces.IDoorConstruction? GetDoorConstruction(DiGi.Analytical.Building.Interfaces.IDoor? door);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetDoorConstruction(DiGi.Analytical.Building.Interfaces.IDoor).door'></a>

`door` [DiGi\.Analytical\.Building\.Interfaces\.IDoor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.idoor 'DiGi\.Analytical\.Building\.Interfaces\.IDoor')

The door for which to retrieve the construction\.

#### Returns
[DiGi\.Analytical\.Building\.Interfaces\.IDoorConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.idoorconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IDoorConstruction')  
The [DiGi\.Analytical\.Building\.Interfaces\.IDoorConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.idoorconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IDoorConstruction') associated with the provided door, or `null` if no such construction is found or if the door is null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetFloorConstruction(DiGi.Analytical.Building.Interfaces.IFloor)'></a>

## BuildingModel\.GetFloorConstruction\(IFloor\) Method

Retrieves the floor construction associated with the specified floor\.

```csharp
public DiGi.Analytical.Building.Interfaces.IFloorConstruction? GetFloorConstruction(DiGi.Analytical.Building.Interfaces.IFloor? floor);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetFloorConstruction(DiGi.Analytical.Building.Interfaces.IFloor).floor'></a>

`floor` [DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor')

The floor for which to retrieve the construction\.

#### Returns
[DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloorconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction')  
The [DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloorconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction') associated with the provided floor, or `null` if no such construction exists or the floor is null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetInternalConditions_TInternalCondition_(DiGi.Analytical.Building.Interfaces.ISpace)'></a>

## BuildingModel\.GetInternalConditions\<TInternalCondition\>\(ISpace\) Method

Retrieves the internal conditions associated with the specified space\.

```csharp
public System.Collections.Generic.List<TInternalCondition>? GetInternalConditions<TInternalCondition>(DiGi.Analytical.Building.Interfaces.ISpace? space)
    where TInternalCondition : DiGi.Analytical.Building.Interfaces.IInternalCondition;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetInternalConditions_TInternalCondition_(DiGi.Analytical.Building.Interfaces.ISpace).TInternalCondition'></a>

`TInternalCondition`

The type of internal condition to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetInternalConditions_TInternalCondition_(DiGi.Analytical.Building.Interfaces.ISpace).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space for which to retrieve the internal conditions\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TInternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetInternalConditions_TInternalCondition_(DiGi.Analytical.Building.Interfaces.ISpace).TInternalCondition 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetInternalConditions\<TInternalCondition\>\(DiGi\.Analytical\.Building\.Interfaces\.ISpace\)\.TInternalCondition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of internal conditions of type [TInternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetInternalConditions_TInternalCondition_(DiGi.Analytical.Building.Interfaces.ISpace).TInternalCondition 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetInternalConditions\<TInternalCondition\>\(DiGi\.Analytical\.Building\.Interfaces\.ISpace\)\.TInternalCondition') associated with the specified space, or null if no such conditions are found or if the input is null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetObject_TBuildingGuidObject_(DiGi.Analytical.Building.Interfaces.IBuildingRelation)'></a>

## BuildingModel\.GetObject\<TBuildingGuidObject\>\(IBuildingRelation\) Method

Retrieves a building object associated with the specified building relation\.

```csharp
public TBuildingGuidObject? GetObject<TBuildingGuidObject>(DiGi.Analytical.Building.Interfaces.IBuildingRelation? buildingRelation)
    where TBuildingGuidObject : DiGi.Analytical.Building.Interfaces.IBuildingGuidObject;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetObject_TBuildingGuidObject_(DiGi.Analytical.Building.Interfaces.IBuildingRelation).TBuildingGuidObject'></a>

`TBuildingGuidObject`

The type of the building GUID object to retrieve\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetObject_TBuildingGuidObject_(DiGi.Analytical.Building.Interfaces.IBuildingRelation).buildingRelation'></a>

`buildingRelation` [DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingrelation 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation')

The building relation used to identify the target object\.

#### Returns
[TBuildingGuidObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetObject_TBuildingGuidObject_(DiGi.Analytical.Building.Interfaces.IBuildingRelation).TBuildingGuidObject 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetObject\<TBuildingGuidObject\>\(DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation\)\.TBuildingGuidObject')  
The retrieved and cloned building object if found; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetObject_TBuildingGuidObject_(DiGi.Core.Classes.GuidReference)'></a>

## BuildingModel\.GetObject\<TBuildingGuidObject\>\(GuidReference\) Method

Retrieves an object of type [TBuildingGuidObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetObject_TBuildingGuidObject_(DiGi.Core.Classes.GuidReference).TBuildingGuidObject 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetObject\<TBuildingGuidObject\>\(DiGi\.Core\.Classes\.GuidReference\)\.TBuildingGuidObject') using the specified GUID reference\.

```csharp
public TBuildingGuidObject? GetObject<TBuildingGuidObject>(DiGi.Core.Classes.GuidReference? guidReference)
    where TBuildingGuidObject : DiGi.Analytical.Building.Interfaces.IBuildingGuidObject;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetObject_TBuildingGuidObject_(DiGi.Core.Classes.GuidReference).TBuildingGuidObject'></a>

`TBuildingGuidObject`

The type of the building GUID object to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject')\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetObject_TBuildingGuidObject_(DiGi.Core.Classes.GuidReference).guidReference'></a>

`guidReference` [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')

The GUID reference of the object to retrieve\.

#### Returns
[TBuildingGuidObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetObject_TBuildingGuidObject_(DiGi.Core.Classes.GuidReference).TBuildingGuidObject 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetObject\<TBuildingGuidObject\>\(DiGi\.Core\.Classes\.GuidReference\)\.TBuildingGuidObject')  
The retrieved object of type [TBuildingGuidObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetObject_TBuildingGuidObject_(DiGi.Core.Classes.GuidReference).TBuildingGuidObject 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetObject\<TBuildingGuidObject\>\(DiGi\.Core\.Classes\.GuidReference\)\.TBuildingGuidObject') if found; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetObjects_TBuildingGuidObject_(DiGi.Analytical.Building.Interfaces.IBuildingRelation)'></a>

## BuildingModel\.GetObjects\<TBuildingGuidObject\>\(IBuildingRelation\) Method

Retrieves a list of building objects associated with the specified building relation\.

```csharp
public System.Collections.Generic.List<TBuildingGuidObject>? GetObjects<TBuildingGuidObject>(DiGi.Analytical.Building.Interfaces.IBuildingRelation? buildingRelation)
    where TBuildingGuidObject : DiGi.Analytical.Building.Interfaces.IBuildingGuidObject;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetObjects_TBuildingGuidObject_(DiGi.Analytical.Building.Interfaces.IBuildingRelation).TBuildingGuidObject'></a>

`TBuildingGuidObject`

The type of building GUID object to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject')\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetObjects_TBuildingGuidObject_(DiGi.Analytical.Building.Interfaces.IBuildingRelation).buildingRelation'></a>

`buildingRelation` [DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingrelation 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation')

The building relation used to identify the associated objects\. Can be null\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TBuildingGuidObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetObjects_TBuildingGuidObject_(DiGi.Analytical.Building.Interfaces.IBuildingRelation).TBuildingGuidObject 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetObjects\<TBuildingGuidObject\>\(DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation\)\.TBuildingGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of objects of type [TBuildingGuidObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetObjects_TBuildingGuidObject_(DiGi.Analytical.Building.Interfaces.IBuildingRelation).TBuildingGuidObject 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetObjects\<TBuildingGuidObject\>\(DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation\)\.TBuildingGuidObject') if found; otherwise, null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetOpenings_TOpening_(DiGi.Analytical.Building.Interfaces.IComponent)'></a>

## BuildingModel\.GetOpenings\<TOpening\>\(IComponent\) Method

Retrieves a list of opening objects associated with the specified component\.

```csharp
public System.Collections.Generic.List<TOpening>? GetOpenings<TOpening>(DiGi.Analytical.Building.Interfaces.IComponent? component)
    where TOpening : DiGi.Analytical.Building.Interfaces.IOpening;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetOpenings_TOpening_(DiGi.Analytical.Building.Interfaces.IComponent).TOpening'></a>

`TOpening`

The type of opening object to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetOpenings_TOpening_(DiGi.Analytical.Building.Interfaces.IComponent).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The component for which associated openings are retrieved\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TOpening](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetOpenings_TOpening_(DiGi.Analytical.Building.Interfaces.IComponent).TOpening 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetOpenings\<TOpening\>\(DiGi\.Analytical\.Building\.Interfaces\.IComponent\)\.TOpening')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of objects of type \<typeparam ref="TOpening" /\> if associations are found; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetOpenings_TOpening_(DiGi.Analytical.Building.Interfaces.IOpeningConstruction)'></a>

## BuildingModel\.GetOpenings\<TOpening\>\(IOpeningConstruction\) Method

Retrieves a list of openings associated with the specified opening construction\.

```csharp
public System.Collections.Generic.List<TOpening>? GetOpenings<TOpening>(DiGi.Analytical.Building.Interfaces.IOpeningConstruction? openingConstruction)
    where TOpening : DiGi.Analytical.Building.Interfaces.IOpening;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetOpenings_TOpening_(DiGi.Analytical.Building.Interfaces.IOpeningConstruction).TOpening'></a>

`TOpening`

The type of opening to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetOpenings_TOpening_(DiGi.Analytical.Building.Interfaces.IOpeningConstruction).openingConstruction'></a>

`openingConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')

The opening construction object used to find related openings\. Can be null\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TOpening](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetOpenings_TOpening_(DiGi.Analytical.Building.Interfaces.IOpeningConstruction).TOpening 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetOpenings\<TOpening\>\(DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction\)\.TOpening')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of openings of type \<typeparam ref="TOpening" /\> associated with the provided construction, or null if no such openings are found or if inputs are null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetOpenings_TOpening_(System.Func_TOpening,bool_)'></a>

## BuildingModel\.GetOpenings\<TOpening\>\(Func\<TOpening,bool\>\) Method

Retrieves a list of openings that match the specified criteria\.

```csharp
public System.Collections.Generic.List<TOpening>? GetOpenings<TOpening>(System.Func<TOpening?,bool>? func=null)
    where TOpening : DiGi.Analytical.Building.Interfaces.IOpening;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetOpenings_TOpening_(System.Func_TOpening,bool_).TOpening'></a>

`TOpening`

The type of opening to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetOpenings_TOpening_(System.Func_TOpening,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TOpening](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetOpenings_TOpening_(System.Func_TOpening,bool_).TOpening 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetOpenings\<TOpening\>\(System\.Func\<TOpening,bool\>\)\.TOpening')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate used to filter the retrieved openings\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TOpening](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetOpenings_TOpening_(System.Func_TOpening,bool_).TOpening 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetOpenings\<TOpening\>\(System\.Func\<TOpening,bool\>\)\.TOpening')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of openings matching the criteria, or null if the building relation cluster is not available\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetRelation_TBuildingRelation_(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject,System.Func_TBuildingRelation,bool_)'></a>

## BuildingModel\.GetRelation\<TBuildingRelation\>\(IBuildingGuidObject, Func\<TBuildingRelation,bool\>\) Method

Retrieves a specific building relation associated with the provided unique object\.

```csharp
public TBuildingRelation? GetRelation<TBuildingRelation>(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject? buildingUniqueObject, System.Func<TBuildingRelation?,bool>? func=null)
    where TBuildingRelation : DiGi.Analytical.Building.Interfaces.IBuildingRelation;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetRelation_TBuildingRelation_(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject,System.Func_TBuildingRelation,bool_).TBuildingRelation'></a>

`TBuildingRelation`

The type of the building relation to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingrelation 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation')\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetRelation_TBuildingRelation_(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject,System.Func_TBuildingRelation,bool_).buildingUniqueObject'></a>

`buildingUniqueObject` [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject')

The building unique object for which the relation is retrieved\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetRelation_TBuildingRelation_(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject,System.Func_TBuildingRelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TBuildingRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetRelation_TBuildingRelation_(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject,System.Func_TBuildingRelation,bool_).TBuildingRelation 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetRelation\<TBuildingRelation\>\(DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject, System\.Func\<TBuildingRelation,bool\>\)\.TBuildingRelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate used to filter the relation based on a specific condition\.

#### Returns
[TBuildingRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetRelation_TBuildingRelation_(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject,System.Func_TBuildingRelation,bool_).TBuildingRelation 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetRelation\<TBuildingRelation\>\(DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject, System\.Func\<TBuildingRelation,bool\>\)\.TBuildingRelation')  
A cloned instance of [TBuildingRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetRelation_TBuildingRelation_(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject,System.Func_TBuildingRelation,bool_).TBuildingRelation 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetRelation\<TBuildingRelation\>\(DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject, System\.Func\<TBuildingRelation,bool\>\)\.TBuildingRelation') if a matching relation is found; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetRelations_TBuildingRelation_(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject,System.Func_TBuildingRelation,bool_)'></a>

## BuildingModel\.GetRelations\<TBuildingRelation\>\(IBuildingGuidObject, Func\<TBuildingRelation,bool\>\) Method

Retrieves a list of building relations associated with the specified unique object, optionally filtered by a predicate\.

```csharp
public System.Collections.Generic.List<TBuildingRelation>? GetRelations<TBuildingRelation>(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject? buildingUniqueObject, System.Func<TBuildingRelation?,bool>? func=null)
    where TBuildingRelation : DiGi.Analytical.Building.Interfaces.IBuildingRelation;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetRelations_TBuildingRelation_(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject,System.Func_TBuildingRelation,bool_).TBuildingRelation'></a>

`TBuildingRelation`

The type of building relation to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingrelation 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation')\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetRelations_TBuildingRelation_(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject,System.Func_TBuildingRelation,bool_).buildingUniqueObject'></a>

`buildingUniqueObject` [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject')

The unique building object for which relations are retrieved\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetRelations_TBuildingRelation_(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject,System.Func_TBuildingRelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TBuildingRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetRelations_TBuildingRelation_(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject,System.Func_TBuildingRelation,bool_).TBuildingRelation 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetRelations\<TBuildingRelation\>\(DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject, System\.Func\<TBuildingRelation,bool\>\)\.TBuildingRelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate function used to filter the returned relations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TBuildingRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetRelations_TBuildingRelation_(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject,System.Func_TBuildingRelation,bool_).TBuildingRelation 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetRelations\<TBuildingRelation\>\(DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject, System\.Func\<TBuildingRelation,bool\>\)\.TBuildingRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of matching [TBuildingRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetRelations_TBuildingRelation_(DiGi.Analytical.Building.Interfaces.IBuildingGuidObject,System.Func_TBuildingRelation,bool_).TBuildingRelation 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetRelations\<TBuildingRelation\>\(DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject, System\.Func\<TBuildingRelation,bool\>\)\.TBuildingRelation') instances, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no relations exist or the input object is null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetRoofConstruction(DiGi.Analytical.Building.Interfaces.IRoof)'></a>

## BuildingModel\.GetRoofConstruction\(IRoof\) Method

Gets the construction associated with the specified roof\.

```csharp
public DiGi.Analytical.Building.Interfaces.IRoofConstruction? GetRoofConstruction(DiGi.Analytical.Building.Interfaces.IRoof? roof);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetRoofConstruction(DiGi.Analytical.Building.Interfaces.IRoof).roof'></a>

`roof` [DiGi\.Analytical\.Building\.Interfaces\.IRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof')

The roof for which to retrieve the construction\.

#### Returns
[DiGi\.Analytical\.Building\.Interfaces\.IRoofConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroofconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IRoofConstruction')  
The [DiGi\.Analytical\.Building\.Interfaces\.IRoofConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroofconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IRoofConstruction') associated with the roof, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no such construction exists or the [roof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetRoofConstruction(DiGi.Analytical.Building.Interfaces.IRoof).roof 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetRoofConstruction\(DiGi\.Analytical\.Building\.Interfaces\.IRoof\)\.roof') is null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShell(DiGi.Analytical.Building.Interfaces.ISpace,System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double)'></a>

## BuildingModel\.GetShell\(ISpace, Nullable\<Side\>, Nullable\<Orientation\>, Nullable\<Orientation\>, double\) Method

Retrieves a shell associated with the specified space based on the provided criteria\.

```csharp
public DiGi.Analytical.Classes.Shell? GetShell(DiGi.Analytical.Building.Interfaces.ISpace? space, System.Nullable<DiGi.Geometry.Core.Enums.Side> normalSide=null, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> externalEdgeOrientation=null, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> internalEdgeOrientation=null, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShell(DiGi.Analytical.Building.Interfaces.ISpace,System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space from which to retrieve the shell\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShell(DiGi.Analytical.Building.Interfaces.ISpace,System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).normalSide'></a>

`normalSide` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.Geometry\.Core\.Enums\.Side](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.enums.side 'DiGi\.Geometry\.Core\.Enums\.Side')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional side or orientation of the boundary\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShell(DiGi.Analytical.Building.Interfaces.ISpace,System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).externalEdgeOrientation'></a>

`externalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.Geometry\.Core\.Enums\.Orientation](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.enums.orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional orientation of external edges\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShell(DiGi.Analytical.Building.Interfaces.ISpace,System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).internalEdgeOrientation'></a>

`internalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.Geometry\.Core\.Enums\.Orientation](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.enums.orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional orientation of internal edges\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShell(DiGi.Analytical.Building.Interfaces.ISpace,System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for geometric operations\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[DiGi\.Analytical\.Classes\.Shell](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.shell 'DiGi\.Analytical\.Classes\.Shell')  
The [DiGi\.Analytical\.Classes\.Shell](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.shell 'DiGi\.Analytical\.Classes\.Shell') associated with the space if found; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShells_TSpace_(System.Collections.Generic.IEnumerable_TSpace_,System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double)'></a>

## BuildingModel\.GetShells\<TSpace\>\(IEnumerable\<TSpace\>, Nullable\<Side\>, Nullable\<Orientation\>, Nullable\<Orientation\>, double\) Method

Retrieves a list of shells associated with the specified spaces, applying optional filters for side orientation, edge orientations, and geometric tolerance\.

```csharp
public System.Collections.Generic.List<DiGi.Analytical.Classes.Shell>? GetShells<TSpace>(System.Collections.Generic.IEnumerable<TSpace> spaces, System.Nullable<DiGi.Geometry.Core.Enums.Side> normalSide=null, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> externalEdgeOrientation=null, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> internalEdgeOrientation=null, double tolerance=1E-06)
    where TSpace : DiGi.Analytical.Building.Interfaces.ISpace;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShells_TSpace_(System.Collections.Generic.IEnumerable_TSpace_,System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).TSpace'></a>

`TSpace`

The type of space objects, which must implement [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShells_TSpace_(System.Collections.Generic.IEnumerable_TSpace_,System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).spaces'></a>

`spaces` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TSpace](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetShells_TSpace_(System.Collections.Generic.IEnumerable_TSpace_,System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).TSpace 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetShells\<TSpace\>\(System\.Collections\.Generic\.IEnumerable\<TSpace\>, System\.Nullable\<DiGi\.Geometry\.Core\.Enums\.Side\>, System\.Nullable\<DiGi\.Geometry\.Core\.Enums\.Orientation\>, System\.Nullable\<DiGi\.Geometry\.Core\.Enums\.Orientation\>, double\)\.TSpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of spaces to process\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShells_TSpace_(System.Collections.Generic.IEnumerable_TSpace_,System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).normalSide'></a>

`normalSide` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.Geometry\.Core\.Enums\.Side](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.enums.side 'DiGi\.Geometry\.Core\.Enums\.Side')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Optional specification for the side or orientation of a boundary\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShells_TSpace_(System.Collections.Generic.IEnumerable_TSpace_,System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).externalEdgeOrientation'></a>

`externalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.Geometry\.Core\.Enums\.Orientation](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.enums.orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Optional specification for the orientation of external edges\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShells_TSpace_(System.Collections.Generic.IEnumerable_TSpace_,System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).internalEdgeOrientation'></a>

`internalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.Geometry\.Core\.Enums\.Orientation](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.enums.orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Optional specification for the orientation of internal edges\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShells_TSpace_(System.Collections.Generic.IEnumerable_TSpace_,System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for geometric operations\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Classes\.Shell](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.shell 'DiGi\.Analytical\.Classes\.Shell')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Analytical\.Classes\.Shell](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.shell 'DiGi\.Analytical\.Classes\.Shell') objects if successful; otherwise, null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShells_TSpace_(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double)'></a>

## BuildingModel\.GetShells\<TSpace\>\(Nullable\<Side\>, Nullable\<Orientation\>, Nullable\<Orientation\>, double\) Method

Retrieves the shells for all spaces of type [TSpace](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetShells_TSpace_(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).TSpace 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetShells\<TSpace\>\(System\.Nullable\<DiGi\.Geometry\.Core\.Enums\.Side\>, System\.Nullable\<DiGi\.Geometry\.Core\.Enums\.Orientation\>, System\.Nullable\<DiGi\.Geometry\.Core\.Enums\.Orientation\>, double\)\.TSpace') within the building model\.

```csharp
public System.Collections.Generic.List<DiGi.Analytical.Classes.Shell>? GetShells<TSpace>(System.Nullable<DiGi.Geometry.Core.Enums.Side> normalSide=null, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> externalEdgeOrientation=null, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> internalEdgeOrientation=null, double tolerance=1E-06)
    where TSpace : DiGi.Analytical.Building.Interfaces.ISpace;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShells_TSpace_(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).TSpace'></a>

`TSpace`

The type of space that implements the [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace') interface\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShells_TSpace_(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).normalSide'></a>

`normalSide` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.Geometry\.Core\.Enums\.Side](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.enums.side 'DiGi\.Geometry\.Core\.Enums\.Side')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Optional specification for the side or orientation of boundary normals\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShells_TSpace_(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).externalEdgeOrientation'></a>

`externalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.Geometry\.Core\.Enums\.Orientation](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.enums.orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Optional specification for the orientation of external edges\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShells_TSpace_(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).internalEdgeOrientation'></a>

`internalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.Geometry\.Core\.Enums\.Orientation](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.enums.orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Optional specification for the orientation of internal edges\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetShells_TSpace_(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for geometric operations\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Classes\.Shell](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.shell 'DiGi\.Analytical\.Classes\.Shell')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Analytical\.Classes\.Shell](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.shell 'DiGi\.Analytical\.Classes\.Shell') objects if spaces are found; otherwise, null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetSpaceInternalConditions(DiGi.Analytical.Building.Interfaces.ISpace)'></a>

## BuildingModel\.GetSpaceInternalConditions\(ISpace\) Method

Retrieves the internal conditions associated with the specified space\.

```csharp
public System.Collections.Generic.List<DiGi.Analytical.Building.Classes.SpaceInternalCondition>? GetSpaceInternalConditions(DiGi.Analytical.Building.Interfaces.ISpace? space);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetSpaceInternalConditions(DiGi.Analytical.Building.Interfaces.ISpace).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space for which to retrieve internal conditions\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[SpaceInternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalCondition 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalCondition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [SpaceInternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalCondition 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalCondition') objects if found; otherwise, null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetSpaces(DiGi.Analytical.Building.Interfaces.IComponent)'></a>

## BuildingModel\.GetSpaces\(IComponent\) Method

Retrieves the list of spaces associated with the specified component\.

```csharp
public System.Collections.Generic.List<DiGi.Analytical.Building.Interfaces.ISpace>? GetSpaces(DiGi.Analytical.Building.Interfaces.IComponent? component);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetSpaces(DiGi.Analytical.Building.Interfaces.IComponent).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The component for which to retrieve the associated spaces\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace') objects if found; otherwise, null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetSpaces(DiGi.Analytical.Building.Interfaces.IOpening)'></a>

## BuildingModel\.GetSpaces\(IOpening\) Method

Retrieves a list of spaces associated with the specified opening\.

```csharp
public System.Collections.Generic.List<DiGi.Analytical.Building.Interfaces.ISpace>? GetSpaces(DiGi.Analytical.Building.Interfaces.IOpening? opening);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetSpaces(DiGi.Analytical.Building.Interfaces.IOpening).opening'></a>

`opening` [DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')

The opening for which to retrieve the associated spaces\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace') objects if found; otherwise, null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetSpaces(DiGi.Analytical.Building.Interfaces.IZone)'></a>

## BuildingModel\.GetSpaces\(IZone\) Method

Retrieves a list of spaces associated with the specified zone\.

```csharp
public System.Collections.Generic.List<DiGi.Analytical.Building.Interfaces.ISpace>? GetSpaces(DiGi.Analytical.Building.Interfaces.IZone? zone);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetSpaces(DiGi.Analytical.Building.Interfaces.IZone).zone'></a>

`zone` [DiGi\.Analytical\.Building\.Interfaces\.IZone](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.izone 'DiGi\.Analytical\.Building\.Interfaces\.IZone')

The zone for which to retrieve the associated spaces\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace') objects if the zone is valid and has associated spaces; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetSpaces_TSpace_()'></a>

## BuildingModel\.GetSpaces\<TSpace\>\(\) Method

Retrieves all spaces of the specified type from the building model\.

```csharp
public System.Collections.Generic.List<TSpace>? GetSpaces<TSpace>()
    where TSpace : DiGi.Analytical.Building.Interfaces.ISpace;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetSpaces_TSpace_().TSpace'></a>

`TSpace`

The type of space to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TSpace](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetSpaces_TSpace_().TSpace 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetSpaces\<TSpace\>\(\)\.TSpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the retrieved spaces of type [TSpace](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetSpaces_TSpace_().TSpace 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetSpaces\<TSpace\>\(\)\.TSpace'), or null if no such spaces are found\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetSpaces_TSpace_(DiGi.Analytical.Building.Interfaces.IInternalCondition)'></a>

## BuildingModel\.GetSpaces\<TSpace\>\(IInternalCondition\) Method

Retrieves the spaces associated with the specified internal condition\.

```csharp
public System.Collections.Generic.List<TSpace>? GetSpaces<TSpace>(DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition)
    where TSpace : DiGi.Analytical.Building.Interfaces.ISpace;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetSpaces_TSpace_(DiGi.Analytical.Building.Interfaces.IInternalCondition).TSpace'></a>

`TSpace`

The type of space to retrieve\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetSpaces_TSpace_(DiGi.Analytical.Building.Interfaces.IInternalCondition).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition for which to retrieve associated spaces\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TSpace](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetSpaces_TSpace_(DiGi.Analytical.Building.Interfaces.IInternalCondition).TSpace 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetSpaces\<TSpace\>\(DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition\)\.TSpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of spaces of type [TSpace](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.GetSpaces_TSpace_(DiGi.Analytical.Building.Interfaces.IInternalCondition).TSpace 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.GetSpaces\<TSpace\>\(DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition\)\.TSpace'), or null if no relations are found\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetWallConstruction(DiGi.Analytical.Building.Interfaces.IWall)'></a>

## BuildingModel\.GetWallConstruction\(IWall\) Method

Gets the wall construction for the specified wall\.

```csharp
public DiGi.Analytical.Building.Interfaces.IWallConstruction? GetWallConstruction(DiGi.Analytical.Building.Interfaces.IWall? wall);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetWallConstruction(DiGi.Analytical.Building.Interfaces.IWall).wall'></a>

`wall` [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')

The wall for which to retrieve the construction\.

#### Returns
[DiGi\.Analytical\.Building\.Interfaces\.IWallConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwallconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IWallConstruction')  
The [DiGi\.Analytical\.Building\.Interfaces\.IWallConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwallconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IWallConstruction') associated with the wall, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no construction is found or the wall is null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetWindowConstruction(DiGi.Analytical.Building.Interfaces.IWindow)'></a>

## BuildingModel\.GetWindowConstruction\(IWindow\) Method

Gets the window construction for the specified window\.

```csharp
public DiGi.Analytical.Building.Interfaces.IWindowConstruction? GetWindowConstruction(DiGi.Analytical.Building.Interfaces.IWindow? window);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.GetWindowConstruction(DiGi.Analytical.Building.Interfaces.IWindow).window'></a>

`window` [DiGi\.Analytical\.Building\.Interfaces\.IWindow](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwindow 'DiGi\.Analytical\.Building\.Interfaces\.IWindow')

The window for which to retrieve the construction\.

#### Returns
[DiGi\.Analytical\.Building\.Interfaces\.IWindowConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwindowconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IWindowConstruction')  
The [DiGi\.Analytical\.Building\.Interfaces\.IWindowConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwindowconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IWindowConstruction') associated with the window, or `null` if no construction is found or the provided window is null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Inside(DiGi.Geometry.Spatial.Classes.Sphere,double)'></a>

## BuildingModel\.Inside\(Sphere, double\) Method

Determines whether the building model is contained within the specified sphere\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Classes.Sphere? sphere, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Inside(DiGi.Geometry.Spatial.Classes.Sphere,double).sphere'></a>

`sphere` [DiGi\.Geometry\.Spatial\.Classes\.Sphere](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere')

The sphere used to check for containment\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Inside(DiGi.Geometry.Spatial.Classes.Sphere,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for the geometric operation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if all components of the building are inside the sphere; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Analytical.Building.Interfaces.IComponent)'></a>

## BuildingModel\.Remove\(IComponent\) Method

Removes the specified component from the building model\.

```csharp
public bool Remove(DiGi.Analytical.Building.Interfaces.IComponent? component);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Analytical.Building.Interfaces.IComponent).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The component to be removed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the component was successfully removed; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Analytical.Building.Interfaces.IConstruction)'></a>

## BuildingModel\.Remove\(IConstruction\) Method

Removes the specified construction from the building model\.

```csharp
public bool Remove(DiGi.Analytical.Building.Interfaces.IConstruction? construction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Analytical.Building.Interfaces.IConstruction).construction'></a>

`construction` [DiGi\.Analytical\.Building\.Interfaces\.IConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction')

The construction to be removed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the construction was successfully removed; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Analytical.Building.Interfaces.IInternalCondition)'></a>

## BuildingModel\.Remove\(IInternalCondition\) Method

Removes the specified internal condition from the building model\.

```csharp
public bool Remove(DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Analytical.Building.Interfaces.IInternalCondition).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the internal condition was successfully removed; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Analytical.Building.Interfaces.IOpening)'></a>

## BuildingModel\.Remove\(IOpening\) Method

Removes the opening associated with the specified opening object\.

```csharp
public bool Remove(DiGi.Analytical.Building.Interfaces.IOpening? opening);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Analytical.Building.Interfaces.IOpening).opening'></a>

`opening` [DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')

The opening to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the opening was successfully removed; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Analytical.Building.Interfaces.IShade)'></a>

## BuildingModel\.Remove\(IShade\) Method

Removes the shade associated with the specified object from the building model\.

```csharp
public bool Remove(DiGi.Analytical.Building.Interfaces.IShade? shade);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Analytical.Building.Interfaces.IShade).shade'></a>

`shade` [DiGi\.Analytical\.Building\.Interfaces\.IShade](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ishade 'DiGi\.Analytical\.Building\.Interfaces\.IShade')

The shade to be removed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the shade was successfully removed; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Analytical.Building.Interfaces.ISpace)'></a>

## BuildingModel\.Remove\(ISpace\) Method

Removes the specified space from the building model\.

```csharp
public bool Remove(DiGi.Analytical.Building.Interfaces.ISpace? space);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Analytical.Building.Interfaces.ISpace).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space to be removed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the space was successfully removed; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Analytical.Building.Interfaces.IZone)'></a>

## BuildingModel\.Remove\(IZone\) Method

Removes the specified zone from the building model\.

```csharp
public bool Remove(DiGi.Analytical.Building.Interfaces.IZone? zone);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Analytical.Building.Interfaces.IZone).zone'></a>

`zone` [DiGi\.Analytical\.Building\.Interfaces\.IZone](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.izone 'DiGi\.Analytical\.Building\.Interfaces\.IZone')

The zone to be removed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the zone was successfully removed; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Core.Classes.GuidReference)'></a>

## BuildingModel\.Remove\(GuidReference\) Method

Removes the object associated with the specified GUID reference from the building model\.

```csharp
public bool Remove(DiGi.Core.Classes.GuidReference? guidReference);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Remove(DiGi.Core.Classes.GuidReference).guidReference'></a>

`guidReference` [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')

The [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference') of the object to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the object was successfully removed; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.TryGetObject_TBuildingGuidObject_(DiGi.Core.Classes.GuidReference,TBuildingGuidObject)'></a>

## BuildingModel\.TryGetObject\<TBuildingGuidObject\>\(GuidReference, TBuildingGuidObject\) Method

Attempts to retrieve a building GUID object from the model using the specified reference\.

```csharp
public bool TryGetObject<TBuildingGuidObject>(DiGi.Core.Classes.GuidReference? guidReference, out TBuildingGuidObject? buildingUniqueObject)
    where TBuildingGuidObject : DiGi.Analytical.Building.Interfaces.IBuildingGuidObject;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.TryGetObject_TBuildingGuidObject_(DiGi.Core.Classes.GuidReference,TBuildingGuidObject).TBuildingGuidObject'></a>

`TBuildingGuidObject`

The type of the building GUID object to be retrieved\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.TryGetObject_TBuildingGuidObject_(DiGi.Core.Classes.GuidReference,TBuildingGuidObject).guidReference'></a>

`guidReference` [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')

The [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference') used to identify the object\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.TryGetObject_TBuildingGuidObject_(DiGi.Core.Classes.GuidReference,TBuildingGuidObject).buildingUniqueObject'></a>

`buildingUniqueObject` [TBuildingGuidObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.TryGetObject_TBuildingGuidObject_(DiGi.Core.Classes.GuidReference,TBuildingGuidObject).TBuildingGuidObject 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.TryGetObject\<TBuildingGuidObject\>\(DiGi\.Core\.Classes\.GuidReference, TBuildingGuidObject\)\.TBuildingGuidObject')

When this method returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), contains the cloned instance of the retrieved object; otherwise, it is set to [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the object was successfully found and retrieved; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Unassign(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.IOpening)'></a>

## BuildingModel\.Unassign\(IComponent, IOpening\) Method

Unassigns a component from a specific opening\.

```csharp
public bool Unassign(DiGi.Analytical.Building.Interfaces.IComponent? component, DiGi.Analytical.Building.Interfaces.IOpening? opening);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Unassign(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.IOpening).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The component to be unassigned\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Unassign(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.IOpening).opening'></a>

`opening` [DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')

The opening from which the component is being removed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the unassignment was successful; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Unassign(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace)'></a>

## BuildingModel\.Unassign\(IComponent, ISpace\) Method

Unassigns a component from a specific space by removing the association between them\.

```csharp
public bool Unassign(DiGi.Analytical.Building.Interfaces.IComponent? component, DiGi.Analytical.Building.Interfaces.ISpace? space);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Unassign(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The component to be unassigned\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Unassign(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space from which the component should be removed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the component was successfully unassigned; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Unassign(DiGi.Analytical.Building.Interfaces.IZone,DiGi.Analytical.Building.Interfaces.ISpace)'></a>

## BuildingModel\.Unassign\(IZone, ISpace\) Method

Unassigns a space from a specific zone within the building model\.

```csharp
public bool Unassign(DiGi.Analytical.Building.Interfaces.IZone? zone, DiGi.Analytical.Building.Interfaces.ISpace? space);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Unassign(DiGi.Analytical.Building.Interfaces.IZone,DiGi.Analytical.Building.Interfaces.ISpace).zone'></a>

`zone` [DiGi\.Analytical\.Building\.Interfaces\.IZone](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.izone 'DiGi\.Analytical\.Building\.Interfaces\.IZone')

The zone from which the space should be unassigned\. Can be null\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Unassign(DiGi.Analytical.Building.Interfaces.IZone,DiGi.Analytical.Building.Interfaces.ISpace).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space to be removed from the zone's association\. Can be null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the space was successfully unassigned from the zone; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Update(DiGi.Analytical.Building.Interfaces.IComponent)'></a>

## BuildingModel\.Update\(IComponent\) Method

Updates the building model by adding a clone of the specified component to the relation cluster\.

```csharp
public bool Update(DiGi.Analytical.Building.Interfaces.IComponent? component);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Update(DiGi.Analytical.Building.Interfaces.IComponent).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The component to be updated in the model; can be null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the component was successfully added to the relation cluster; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Update(DiGi.Analytical.Building.Interfaces.IConstruction)'></a>

## BuildingModel\.Update\(IConstruction\) Method

Updates the building model by adding the specified construction to the relation cluster\.

```csharp
public bool Update(DiGi.Analytical.Building.Interfaces.IConstruction? construction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Update(DiGi.Analytical.Building.Interfaces.IConstruction).construction'></a>

`construction` [DiGi\.Analytical\.Building\.Interfaces\.IConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction')

The construction object to be updated\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the construction was successfully added; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Update(DiGi.Analytical.Building.Interfaces.IInternalCondition)'></a>

## BuildingModel\.Update\(IInternalCondition\) Method

Updates the building model by adding the specified internal condition\.

```csharp
public bool Update(DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Update(DiGi.Analytical.Building.Interfaces.IInternalCondition).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition to be updated\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update was successful; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Update(DiGi.Analytical.Building.Interfaces.IOpening)'></a>

## BuildingModel\.Update\(IOpening\) Method

Updates the building model by adding or updating the specified opening within the relation cluster\.

```csharp
public bool Update(DiGi.Analytical.Building.Interfaces.IOpening? opening);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Update(DiGi.Analytical.Building.Interfaces.IOpening).opening'></a>

`opening` [DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')

The opening object to be updated\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update was successful; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Update(DiGi.Analytical.Building.Interfaces.IShade)'></a>

## BuildingModel\.Update\(IShade\) Method

Updates the building model by adding or updating the specified shade in the relation cluster\.

```csharp
public bool Update(DiGi.Analytical.Building.Interfaces.IShade? shade);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Update(DiGi.Analytical.Building.Interfaces.IShade).shade'></a>

`shade` [DiGi\.Analytical\.Building\.Interfaces\.IShade](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ishade 'DiGi\.Analytical\.Building\.Interfaces\.IShade')

The shade object to be updated\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update was successful; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Update(DiGi.Analytical.Building.Interfaces.ISpace)'></a>

## BuildingModel\.Update\(ISpace\) Method

Updates the building model by adding a clone of the specified space to the relation cluster\.

```csharp
public bool Update(DiGi.Analytical.Building.Interfaces.ISpace? space);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Update(DiGi.Analytical.Building.Interfaces.ISpace).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space object to be added or updated in the building model\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the space was successfully added; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Update(DiGi.Analytical.Building.Interfaces.IZone)'></a>

## BuildingModel\.Update\(IZone\) Method

Updates the building model with the specified zone\.

```csharp
public bool Update(DiGi.Analytical.Building.Interfaces.IZone? zone);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModel.Update(DiGi.Analytical.Building.Interfaces.IZone).zone'></a>

`zone` [DiGi\.Analytical\.Building\.Interfaces\.IZone](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.izone 'DiGi\.Analytical\.Building\.Interfaces\.IZone')

The zone to update\. Can be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the zone was successfully updated; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Analytical.Building.Classes.BuildingModelFaceUpdater'></a>

## BuildingModelFaceUpdater Class

Provides functionality to update a [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') specifically associated with a [Face](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModelFaceUpdater.Face 'DiGi\.Analytical\.Building\.Classes\.BuildingModelFaceUpdater\.Face')\.

```csharp
public class BuildingModelFaceUpdater : DiGi.Analytical.Building.Classes.BuildingModelUpdater
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [BuildingModelUpdater](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModelUpdater 'DiGi\.Analytical\.Building\.Classes\.BuildingModelUpdater') → BuildingModelFaceUpdater
### Constructors

<a name='DiGi.Analytical.Building.Classes.BuildingModelFaceUpdater.BuildingModelFaceUpdater(DiGi.Analytical.Building.Classes.BuildingModel)'></a>

## BuildingModelFaceUpdater\(BuildingModel\) Constructor

Initializes a new instance of the [BuildingModelFaceUpdater](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModelFaceUpdater 'DiGi\.Analytical\.Building\.Classes\.BuildingModelFaceUpdater') class\.

```csharp
public BuildingModelFaceUpdater(DiGi.Analytical.Building.Classes.BuildingModel? value);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModelFaceUpdater.BuildingModelFaceUpdater(DiGi.Analytical.Building.Classes.BuildingModel).value'></a>

`value` [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model associated with this updater\.

<a name='DiGi.Analytical.Building.Classes.BuildingModelFaceUpdater.BuildingModelFaceUpdater(DiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Classes.Face)'></a>

## BuildingModelFaceUpdater\(BuildingModel, Face\) Constructor

Initializes a new instance of the [BuildingModelFaceUpdater](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModelFaceUpdater 'DiGi\.Analytical\.Building\.Classes\.BuildingModelFaceUpdater') class with the specified building model and face\.

```csharp
public BuildingModelFaceUpdater(DiGi.Analytical.Building.Classes.BuildingModel? value, DiGi.Analytical.Classes.Face? Face);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModelFaceUpdater.BuildingModelFaceUpdater(DiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Classes.Face).value'></a>

`value` [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model to be updated\.

<a name='DiGi.Analytical.Building.Classes.BuildingModelFaceUpdater.BuildingModelFaceUpdater(DiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Classes.Face).Face'></a>

`Face` [DiGi\.Analytical\.Classes\.Face](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.face 'DiGi\.Analytical\.Classes\.Face')

The face associated with the update operation\.
### Properties

<a name='DiGi.Analytical.Building.Classes.BuildingModelFaceUpdater.Face'></a>

## BuildingModelFaceUpdater\.Face Property

Gets or sets the face used for updating the building model\.

```csharp
public DiGi.Analytical.Classes.Face? Face { get; set; }
```

#### Property Value
[DiGi\.Analytical\.Classes\.Face](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.face 'DiGi\.Analytical\.Classes\.Face')
### Methods

<a name='DiGi.Analytical.Building.Classes.BuildingModelFaceUpdater.Update()'></a>

## BuildingModelFaceUpdater\.Update\(\) Method

Performs the update operation for the building model face\.

```csharp
public override bool Update();
```

Implements [Update\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater.update 'DiGi\.Core\.Interfaces\.IUpdater\.Update')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update was successful; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModelFaceUpdater.Update(DiGi.Analytical.Building.Interfaces.IComponent)'></a>

## BuildingModelFaceUpdater\.Update\(IComponent\) Method

Performs an update operation on the building model face and retrieves the updated component\.

```csharp
public bool Update(out DiGi.Analytical.Building.Interfaces.IComponent? component);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModelFaceUpdater.Update(DiGi.Analytical.Building.Interfaces.IComponent).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

When this method returns, contains the [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent') that was updated; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any changes were made or the update was successful; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellsUpdater'></a>

## BuildingModelShellsUpdater Class

Provides functionality to update shell components within a [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')\.

```csharp
public class BuildingModelShellsUpdater : DiGi.Analytical.Building.Classes.BuildingModelUpdater
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [BuildingModelUpdater](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModelUpdater 'DiGi\.Analytical\.Building\.Classes\.BuildingModelUpdater') → BuildingModelShellsUpdater
### Constructors

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellsUpdater.BuildingModelShellsUpdater(DiGi.Analytical.Building.Classes.BuildingModel)'></a>

## BuildingModelShellsUpdater\(BuildingModel\) Constructor

Initializes a new instance of the [BuildingModelShellsUpdater](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModelShellsUpdater 'DiGi\.Analytical\.Building\.Classes\.BuildingModelShellsUpdater') class\.

```csharp
public BuildingModelShellsUpdater(DiGi.Analytical.Building.Classes.BuildingModel value);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellsUpdater.BuildingModelShellsUpdater(DiGi.Analytical.Building.Classes.BuildingModel).value'></a>

`value` [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model to be updated\.
### Properties

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellsUpdater.Shells'></a>

## BuildingModelShellsUpdater\.Shells Property

Gets or sets the collection of shell elements to be updated in the building model\.

```csharp
public System.Collections.Generic.List<DiGi.Analytical.Classes.Shell>? Shells { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Classes\.Shell](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.shell 'DiGi\.Analytical\.Classes\.Shell')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellsUpdater.Tolerance'></a>

## BuildingModelShellsUpdater\.Tolerance Property

Gets or sets the distance tolerance used for geometric comparisons and operations during the shell update process\. The default value is [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

```csharp
public double Tolerance { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellsUpdater.UpdatedComponentUniqueReferences'></a>

## BuildingModelShellsUpdater\.UpdatedComponentUniqueReferences Property

Gets or sets the set of unique references for the components that have been updated\.

```csharp
public System.Collections.Generic.HashSet<DiGi.Core.Interfaces.IUniqueReference>? UpdatedComponentUniqueReferences { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')
### Methods

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellsUpdater.Update()'></a>

## BuildingModelShellsUpdater\.Update\(\) Method

Performs the update operation for the building model shells\.

```csharp
public override bool Update();
```

Implements [Update\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater.update 'DiGi\.Core\.Interfaces\.IUpdater\.Update')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any changes were made; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellsUpdater.Update(System.Collections.Generic.List_DiGi.Analytical.Building.Interfaces.ISpace_)'></a>

## BuildingModelShellsUpdater\.Update\(List\<ISpace\>\) Method

Updates the building model shells and retrieves the associated spaces\.

```csharp
public bool Update(out System.Collections.Generic.List<DiGi.Analytical.Building.Interfaces.ISpace>? spaces);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellsUpdater.Update(System.Collections.Generic.List_DiGi.Analytical.Building.Interfaces.ISpace_).spaces'></a>

`spaces` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace') objects that were updated or created; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update operation was successful; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellUpdater'></a>

## BuildingModelShellUpdater Class

Provides functionality to update the shell components of a [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')\.

```csharp
public class BuildingModelShellUpdater : DiGi.Analytical.Building.Classes.BuildingModelUpdater
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [BuildingModelUpdater](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModelUpdater 'DiGi\.Analytical\.Building\.Classes\.BuildingModelUpdater') → BuildingModelShellUpdater
### Constructors

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellUpdater.BuildingModelShellUpdater(DiGi.Analytical.Building.Classes.BuildingModel)'></a>

## BuildingModelShellUpdater\(BuildingModel\) Constructor

Initializes a new instance of the [BuildingModelShellUpdater](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModelShellUpdater 'DiGi\.Analytical\.Building\.Classes\.BuildingModelShellUpdater') class\.

```csharp
public BuildingModelShellUpdater(DiGi.Analytical.Building.Classes.BuildingModel value);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellUpdater.BuildingModelShellUpdater(DiGi.Analytical.Building.Classes.BuildingModel).value'></a>

`value` [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model to be used for the update process\.
### Properties

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellUpdater.Shell'></a>

## BuildingModelShellUpdater\.Shell Property

Gets or sets the shell associated with the building model update process\.

```csharp
public DiGi.Analytical.Classes.Shell? Shell { get; set; }
```

#### Property Value
[DiGi\.Analytical\.Classes\.Shell](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.shell 'DiGi\.Analytical\.Classes\.Shell')

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellUpdater.Tolerance'></a>

## BuildingModelShellUpdater\.Tolerance Property

Gets or sets the distance tolerance used during the building model shell update process\.

```csharp
public double Tolerance { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellUpdater.UpdatedComponentUniqueReferences'></a>

## BuildingModelShellUpdater\.UpdatedComponentUniqueReferences Property

Gets or sets the set of unique references for the components that have been updated during the shell update process\.

```csharp
public System.Collections.Generic.HashSet<DiGi.Core.Interfaces.IUniqueReference>? UpdatedComponentUniqueReferences { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')
### Methods

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellUpdater.Update()'></a>

## BuildingModelShellUpdater\.Update\(\) Method

Performs the update operation\.

```csharp
public override bool Update();
```

Implements [Update\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater.update 'DiGi\.Core\.Interfaces\.IUpdater\.Update')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update was successful; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellUpdater.Update(DiGi.Analytical.Building.Interfaces.ISpace)'></a>

## BuildingModelShellUpdater\.Update\(ISpace\) Method

Updates the building model shell and retrieves or creates the associated space\.

```csharp
public bool Update(out DiGi.Analytical.Building.Interfaces.ISpace? space);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModelShellUpdater.Update(DiGi.Analytical.Building.Interfaces.ISpace).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

When this method returns, contains the [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace') associated with the shell; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update operation was successful; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingModelUpdater'></a>

## BuildingModelUpdater Class

Provides an abstract base class for implementing logic to update a [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')\.

```csharp
public abstract class BuildingModelUpdater : DiGi.Core.Interfaces.IUpdater<DiGi.Analytical.Building.Classes.BuildingModel>, DiGi.Core.Interfaces.IUpdater, DiGi.Core.Interfaces.IEvaluator
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → BuildingModelUpdater

Derived  
↳ [BuildingModelFaceUpdater](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModelFaceUpdater 'DiGi\.Analytical\.Building\.Classes\.BuildingModelFaceUpdater')  
↳ [BuildingModelShellsUpdater](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModelShellsUpdater 'DiGi\.Analytical\.Building\.Classes\.BuildingModelShellsUpdater')  
↳ [BuildingModelShellUpdater](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModelShellUpdater 'DiGi\.Analytical\.Building\.Classes\.BuildingModelShellUpdater')

Implements [DiGi\.Core\.Interfaces\.IUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')[BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1'), [DiGi\.Core\.Interfaces\.IUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater 'DiGi\.Core\.Interfaces\.IUpdater'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator')
### Constructors

<a name='DiGi.Analytical.Building.Classes.BuildingModelUpdater.BuildingModelUpdater(DiGi.Analytical.Building.Classes.BuildingModel)'></a>

## BuildingModelUpdater\(BuildingModel\) Constructor

Initializes a new instance of the [BuildingModelUpdater](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModelUpdater 'DiGi\.Analytical\.Building\.Classes\.BuildingModelUpdater') class\.

```csharp
public BuildingModelUpdater(DiGi.Analytical.Building.Classes.BuildingModel? value);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingModelUpdater.BuildingModelUpdater(DiGi.Analytical.Building.Classes.BuildingModel).value'></a>

`value` [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') instance to be managed by this updater\.
### Properties

<a name='DiGi.Analytical.Building.Classes.BuildingModelUpdater.Value'></a>

## BuildingModelUpdater\.Value Property

Gets or sets the building model associated with the updater\.

```csharp
public DiGi.Analytical.Building.Classes.BuildingModel? Value { get; set; }
```

Implements [Value](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1.value 'DiGi\.Core\.Interfaces\.IUpdater\`1\.Value')

#### Property Value
[BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')
### Methods

<a name='DiGi.Analytical.Building.Classes.BuildingModelUpdater.Update()'></a>

## BuildingModelUpdater\.Update\(\) Method

Performs the update operation on the building model\.

```csharp
public abstract bool Update();
```

Implements [Update\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater.update 'DiGi\.Core\.Interfaces\.IUpdater\.Update')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update was successful; otherwise, false\.

<a name='DiGi.Analytical.Building.Classes.BuildingNamedObject'></a>

## BuildingNamedObject Class

Represents an abstract base class for building objects that possess a name identifier\.

```csharp
public abstract class BuildingNamedObject : DiGi.Analytical.Building.Classes.BuildingObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.INamedObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → BuildingNamedObject

Derived  
↳ [PhysicalComponentConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstruction 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstruction')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.BuildingNamedObject.BuildingNamedObject()'></a>

## BuildingNamedObject\(\) Constructor

Initializes a new instance of the [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject') class\.

```csharp
public BuildingNamedObject();
```

<a name='DiGi.Analytical.Building.Classes.BuildingNamedObject.BuildingNamedObject(DiGi.Analytical.Building.Classes.BuildingNamedObject)'></a>

## BuildingNamedObject\(BuildingNamedObject\) Constructor

Initializes a new instance of the [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject') class using an existing [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject') object\.

```csharp
public BuildingNamedObject(DiGi.Analytical.Building.Classes.BuildingNamedObject? buildingNamedObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingNamedObject.BuildingNamedObject(DiGi.Analytical.Building.Classes.BuildingNamedObject).buildingNamedObject'></a>

`buildingNamedObject` [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject')

The source [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject') object to copy values from\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.BuildingNamedObject.BuildingNamedObject(string)'></a>

## BuildingNamedObject\(string\) Constructor

Initializes a new instance of the [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject') class with the specified name\.

```csharp
public BuildingNamedObject(string? name);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingNamedObject.BuildingNamedObject(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name to assign to the building named object\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.BuildingNamedObject.BuildingNamedObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingNamedObject)'></a>

## BuildingNamedObject\(Guid, BuildingNamedObject\) Constructor

Initializes a new instance of the [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject') class using a specified unique identifier and an optional existing object to copy values from\.

```csharp
public BuildingNamedObject(System.Guid guid, DiGi.Analytical.Building.Classes.BuildingNamedObject? buildingNamedObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingNamedObject.BuildingNamedObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingNamedObject).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the building named object\.

<a name='DiGi.Analytical.Building.Classes.BuildingNamedObject.BuildingNamedObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingNamedObject).buildingNamedObject'></a>

`buildingNamedObject` [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject')

An optional [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject') instance used to initialize the properties of the new instance\.

<a name='DiGi.Analytical.Building.Classes.BuildingNamedObject.BuildingNamedObject(System.Guid,string)'></a>

## BuildingNamedObject\(Guid, string\) Constructor

Initializes a new instance of the [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject') class with the specified unique identifier and name\.

```csharp
public BuildingNamedObject(System.Guid guid, string? name);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingNamedObject.BuildingNamedObject(System.Guid,string).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the building named object\.

<a name='DiGi.Analytical.Building.Classes.BuildingNamedObject.BuildingNamedObject(System.Guid,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the building named object\.

<a name='DiGi.Analytical.Building.Classes.BuildingNamedObject.BuildingNamedObject(System.Text.Json.Nodes.JsonObject)'></a>

## BuildingNamedObject\(JsonObject\) Constructor

Initializes a new instance of the [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject') class using the specified JSON object\.

```csharp
public BuildingNamedObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingNamedObject.BuildingNamedObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the instance\. This value can be null\.
### Properties

<a name='DiGi.Analytical.Building.Classes.BuildingNamedObject.Name'></a>

## BuildingNamedObject\.Name Property

Gets or sets the name of the building named object\.

```csharp
public string? Name { get; set; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.Classes.BuildingObject'></a>

## BuildingObject Class

Represents an abstract base class for all building objects, providing fundamental properties for unique identification and parameterization within the analytical building model\.

```csharp
public abstract class BuildingObject : DiGi.Core.Parameter.Classes.ParametrizedGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → BuildingObject

Derived  
↳ [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject')  
↳ [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject')  
↳ [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject')  
↳ [InternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalCondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition')  
↳ [Zone](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Zone 'DiGi\.Analytical\.Building\.Classes\.Zone')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.BuildingObject.BuildingObject()'></a>

## BuildingObject\(\) Constructor

Initializes a new instance of the [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') class\.

```csharp
public BuildingObject();
```

<a name='DiGi.Analytical.Building.Classes.BuildingObject.BuildingObject(DiGi.Analytical.Building.Classes.BuildingObject)'></a>

## BuildingObject\(BuildingObject\) Constructor

Initializes a new instance of the [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') class using the specified building object\.

```csharp
public BuildingObject(DiGi.Analytical.Building.Classes.BuildingObject? buildingObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingObject.BuildingObject(DiGi.Analytical.Building.Classes.BuildingObject).buildingObject'></a>

`buildingObject` [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject')

The building object to initialize from\.

<a name='DiGi.Analytical.Building.Classes.BuildingObject.BuildingObject(System.Guid)'></a>

## BuildingObject\(Guid\) Constructor

Initializes a new instance of the [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') class with the specified unique identifier\.

```csharp
public BuildingObject(System.Guid guid);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingObject.BuildingObject(System.Guid).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the building object\.

<a name='DiGi.Analytical.Building.Classes.BuildingObject.BuildingObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingObject)'></a>

## BuildingObject\(Guid, BuildingObject\) Constructor

Initializes a new instance of the [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') class using the specified unique identifier and an optional existing building object\.

```csharp
public BuildingObject(System.Guid guid, DiGi.Analytical.Building.Classes.BuildingObject? buildingObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingObject.BuildingObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingObject).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier to assign to this object\.

<a name='DiGi.Analytical.Building.Classes.BuildingObject.BuildingObject(System.Guid,DiGi.Analytical.Building.Classes.BuildingObject).buildingObject'></a>

`buildingObject` [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject')

An optional [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') instance used to initialize the current instance\.

<a name='DiGi.Analytical.Building.Classes.BuildingObject.BuildingObject(System.Text.Json.Nodes.JsonObject)'></a>

## BuildingObject\(JsonObject\) Constructor

Initializes a new instance of the [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') class using the specified JSON object\.

```csharp
public BuildingObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingObject.BuildingObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the building object\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster'></a>

## BuildingRelationCluster Class

Represents a cluster of building relations, providing functionality to manage and organize relationships between building components\.

```csharp
public class BuildingRelationCluster : DiGi.Analytical.Building.Classes.ConstructionRelationCluster
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Cluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3') → [DiGi\.Core\.Classes\.ValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3') → [DiGi\.Core\.Classes\.SerializableObjectValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3') → [DiGi\.Core\.Classes\.UniqueObjectValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobjectvaluecluster-1 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\`1')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobjectvaluecluster-1 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\`1') → [DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationcluster-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\`2')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationcluster-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\`2')[DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingrelation 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationcluster-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\`2') → [ConstructionRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionRelationCluster 'DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster') → BuildingRelationCluster
### Constructors

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.BuildingRelationCluster()'></a>

## BuildingRelationCluster\(\) Constructor

Initializes a new instance of the [BuildingRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingRelationCluster 'DiGi\.Analytical\.Building\.Classes\.BuildingRelationCluster') class\.

```csharp
public BuildingRelationCluster();
```

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.BuildingRelationCluster(DiGi.Analytical.Building.Classes.BuildingRelationCluster)'></a>

## BuildingRelationCluster\(BuildingRelationCluster\) Constructor

Initializes a new instance of the [BuildingRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingRelationCluster 'DiGi\.Analytical\.Building\.Classes\.BuildingRelationCluster') class using an existing [BuildingRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingRelationCluster 'DiGi\.Analytical\.Building\.Classes\.BuildingRelationCluster') instance\.

```csharp
public BuildingRelationCluster(DiGi.Analytical.Building.Classes.BuildingRelationCluster? buildingRelationCluster);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.BuildingRelationCluster(DiGi.Analytical.Building.Classes.BuildingRelationCluster).buildingRelationCluster'></a>

`buildingRelationCluster` [BuildingRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingRelationCluster 'DiGi\.Analytical\.Building\.Classes\.BuildingRelationCluster')

The source [BuildingRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingRelationCluster 'DiGi\.Analytical\.Building\.Classes\.BuildingRelationCluster') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.BuildingRelationCluster(System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IBuildingGuidObject_)'></a>

## BuildingRelationCluster\(IEnumerable\<IBuildingGuidObject\>\) Constructor

Initializes a new instance of the [BuildingRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingRelationCluster 'DiGi\.Analytical\.Building\.Classes\.BuildingRelationCluster') class using a collection of unique building objects\.

```csharp
public BuildingRelationCluster(System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Interfaces.IBuildingGuidObject>? buildingUniqueObjects);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.BuildingRelationCluster(System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IBuildingGuidObject_).buildingUniqueObjects'></a>

`buildingUniqueObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique building objects to initialize the cluster with\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.BuildingRelationCluster(System.Text.Json.Nodes.JsonObject)'></a>

## BuildingRelationCluster\(JsonObject\) Constructor

Initializes a new instance of the [BuildingRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingRelationCluster 'DiGi\.Analytical\.Building\.Classes\.BuildingRelationCluster') class using the specified JSON object\.

```csharp
public BuildingRelationCluster(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.BuildingRelationCluster(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to populate the properties of the building relation cluster\.
### Methods

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace)'></a>

## BuildingRelationCluster\.AddRelation\(IComponent, ISpace, ISpace\) Method

Adds a spatial relation between a component and one or two spaces to the building relation cluster\.

```csharp
public DiGi.Analytical.Building.Classes.SpaceRelation? AddRelation(DiGi.Analytical.Building.Interfaces.IComponent? component, DiGi.Analytical.Building.Interfaces.ISpace? space_1, DiGi.Analytical.Building.Interfaces.ISpace? space_2=null);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The component that is part of the spatial relation\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace).space_1'></a>

`space_1` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The primary space associated with the relation\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace).space_2'></a>

`space_2` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

An optional secondary space associated with the relation\.

#### Returns
[SpaceRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceRelation')  
The newly created [SpaceRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceRelation') object if successful; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IDoor,DiGi.Analytical.Building.Interfaces.IDoorConstruction)'></a>

## BuildingRelationCluster\.AddRelation\(IDoor, IDoorConstruction\) Method

Adds a relation between a door and its construction, replacing any existing relation for the specified door\.

```csharp
public DiGi.Analytical.Building.Classes.OpeningConstructionRelation? AddRelation(DiGi.Analytical.Building.Interfaces.IDoor? door, DiGi.Analytical.Building.Interfaces.IDoorConstruction? doorConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IDoor,DiGi.Analytical.Building.Interfaces.IDoorConstruction).door'></a>

`door` [DiGi\.Analytical\.Building\.Interfaces\.IDoor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.idoor 'DiGi\.Analytical\.Building\.Interfaces\.IDoor')

The door object to be related\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IDoor,DiGi.Analytical.Building.Interfaces.IDoorConstruction).doorConstruction'></a>

`doorConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IDoorConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.idoorconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IDoorConstruction')

The door construction object to be related\.

#### Returns
[OpeningConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionRelation')  
The created [OpeningConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionRelation') if successful; otherwise, null if either parameter is null\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IFloor,DiGi.Analytical.Building.Interfaces.IFloorConstruction)'></a>

## BuildingRelationCluster\.AddRelation\(IFloor, IFloorConstruction\) Method

Adds a relation between a floor and its corresponding construction, replacing any existing relation for the specified floor\.

```csharp
public DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation? AddRelation(DiGi.Analytical.Building.Interfaces.IFloor? floor, DiGi.Analytical.Building.Interfaces.IFloorConstruction? floorConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IFloor,DiGi.Analytical.Building.Interfaces.IFloorConstruction).floor'></a>

`floor` [DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor')

The floor object to be associated with a construction\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IFloor,DiGi.Analytical.Building.Interfaces.IFloorConstruction).floorConstruction'></a>

`floorConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloorconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction')

The construction definition to associate with the floor\.

#### Returns
[PhysicalComponentConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionRelation')  
The newly created [PhysicalComponentConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionRelation') if successful; otherwise, `null` if either parameter is null\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IRoof,DiGi.Analytical.Building.Interfaces.IRoofConstruction)'></a>

## BuildingRelationCluster\.AddRelation\(IRoof, IRoofConstruction\) Method

Adds a relation between a roof component and its corresponding construction definition, replacing any existing relation for the specified roof\.

```csharp
public DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation? AddRelation(DiGi.Analytical.Building.Interfaces.IRoof? roof, DiGi.Analytical.Building.Interfaces.IRoofConstruction? roofConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IRoof,DiGi.Analytical.Building.Interfaces.IRoofConstruction).roof'></a>

`roof` [DiGi\.Analytical\.Building\.Interfaces\.IRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof')

The roof object to be associated with a construction\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IRoof,DiGi.Analytical.Building.Interfaces.IRoofConstruction).roofConstruction'></a>

`roofConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IRoofConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroofconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IRoofConstruction')

The roof construction definition to associate with the roof\.

#### Returns
[PhysicalComponentConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionRelation')  
The created [PhysicalComponentConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionRelation') if successful; otherwise, null if either parameter is null\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string)'></a>

## BuildingRelationCluster\.AddRelation\(ISpace, IInternalCondition, HourRange, string\) Method

Adds a relation between a space and an internal condition\.

```csharp
public DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation? AddRelation(DiGi.Analytical.Building.Interfaces.ISpace? space, DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition, DiGi.Analytical.Classes.HourRange? hourRange, string? id=null);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space associated with the internal condition\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition to be linked to the space\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).hourRange'></a>

`hourRange` [DiGi\.Analytical\.Classes\.HourRange](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.hourrange 'DiGi\.Analytical\.Classes\.HourRange')

The optional hour range during which the internal condition applies\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional unique identifier for the relation\.

#### Returns
[SpaceInternalConditionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalConditionRelation')  
The created [SpaceInternalConditionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalConditionRelation') if successful; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Analytical.Building.Interfaces.IWallConstruction)'></a>

## BuildingRelationCluster\.AddRelation\(IWall, IWallConstruction\) Method

Adds a relation between a wall and its corresponding wall construction\.

```csharp
public DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation? AddRelation(DiGi.Analytical.Building.Interfaces.IWall? wall, DiGi.Analytical.Building.Interfaces.IWallConstruction? wallConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Analytical.Building.Interfaces.IWallConstruction).wall'></a>

`wall` [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')

The wall instance to be associated\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Analytical.Building.Interfaces.IWallConstruction).wallConstruction'></a>

`wallConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IWallConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwallconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IWallConstruction')

The wall construction instance to be associated\.

#### Returns
[PhysicalComponentConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionRelation')  
The created [PhysicalComponentConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionRelation') if the relation was successfully added; otherwise, null\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IWindow,DiGi.Analytical.Building.Interfaces.IWindowConstruction)'></a>

## BuildingRelationCluster\.AddRelation\(IWindow, IWindowConstruction\) Method

Adds a relationship between the specified window and its corresponding window construction\.

```csharp
public DiGi.Analytical.Building.Classes.OpeningConstructionRelation? AddRelation(DiGi.Analytical.Building.Interfaces.IWindow? window, DiGi.Analytical.Building.Interfaces.IWindowConstruction? windowConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IWindow,DiGi.Analytical.Building.Interfaces.IWindowConstruction).window'></a>

`window` [DiGi\.Analytical\.Building\.Interfaces\.IWindow](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwindow 'DiGi\.Analytical\.Building\.Interfaces\.IWindow')

The window object to be associated\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IWindow,DiGi.Analytical.Building.Interfaces.IWindowConstruction).windowConstruction'></a>

`windowConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IWindowConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwindowconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IWindowConstruction')

The window construction object to be associated\.

#### Returns
[OpeningConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionRelation')  
The created [OpeningConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionRelation') if the relation was successfully added; otherwise, null\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IZone,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_)'></a>

## BuildingRelationCluster\.AddRelation\(IZone, IEnumerable\<ISpace\>\) Method

Adds a relationship between a zone and a collection of spaces to the cluster, replacing any existing relation for the specified zone\.

```csharp
public DiGi.Analytical.Building.Classes.ZoneRelation? AddRelation(DiGi.Analytical.Building.Interfaces.IZone? zone, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Interfaces.ISpace>? spaces);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IZone,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_).zone'></a>

`zone` [DiGi\.Analytical\.Building\.Interfaces\.IZone](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.izone 'DiGi\.Analytical\.Building\.Interfaces\.IZone')

The zone object involved in the relation\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IZone,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_).spaces'></a>

`spaces` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of space objects associated with the zone\.

#### Returns
[ZoneRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ZoneRelation 'DiGi\.Analytical\.Building\.Classes\.ZoneRelation')  
The newly created [ZoneRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ZoneRelation 'DiGi\.Analytical\.Building\.Classes\.ZoneRelation') if successful; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetComponent(DiGi.Analytical.Building.Classes.OpeningRelation)'></a>

## BuildingRelationCluster\.GetComponent\(OpeningRelation\) Method

Retrieves the component associated with the specified opening relation\.

```csharp
public DiGi.Analytical.Building.Interfaces.IComponent? GetComponent(DiGi.Analytical.Building.Classes.OpeningRelation? openingRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetComponent(DiGi.Analytical.Building.Classes.OpeningRelation).openingRelation'></a>

`openingRelation` [OpeningRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningRelation')

The opening relation used to identify the component\.

#### Returns
[DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')  
The [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent') if a matching component is found; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetComponent(DiGi.Analytical.Building.Classes.SpaceRelation)'></a>

## BuildingRelationCluster\.GetComponent\(SpaceRelation\) Method

Retrieves the component associated with the specified space relation\.

```csharp
public DiGi.Analytical.Building.Interfaces.IComponent? GetComponent(DiGi.Analytical.Building.Classes.SpaceRelation? spaceRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetComponent(DiGi.Analytical.Building.Classes.SpaceRelation).spaceRelation'></a>

`spaceRelation` [SpaceRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceRelation')

The space relation used to identify the component\. This value can be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

#### Returns
[DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')  
The [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent') associated with the provided space relation, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the relation is null, invalid, or no corresponding component is found\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetComponents_TComponent_()'></a>

## BuildingRelationCluster\.GetComponents\<TComponent\>\(\) Method

Retrieves all components of the specified type from the cluster\.

```csharp
public System.Collections.Generic.List<TComponent> GetComponents<TComponent>()
    where TComponent : DiGi.Analytical.Building.Interfaces.IComponent;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetComponents_TComponent_().TComponent'></a>

`TComponent`

The type of component to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetComponents_TComponent_().TComponent 'DiGi\.Analytical\.Building\.Classes\.BuildingRelationCluster\.GetComponents\<TComponent\>\(\)\.TComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing all components of type [TComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetComponents_TComponent_().TComponent 'DiGi\.Analytical\.Building\.Classes\.BuildingRelationCluster\.GetComponents\<TComponent\>\(\)\.TComponent')\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetInternalCondition(DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation)'></a>

## BuildingRelationCluster\.GetInternalCondition\(SpaceInternalConditionRelation\) Method

Retrieves the internal condition associated with the specified space internal condition relation\.

```csharp
public DiGi.Analytical.Building.Interfaces.IInternalCondition? GetInternalCondition(DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation? spaceInternalConditionRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetInternalCondition(DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation).spaceInternalConditionRelation'></a>

`spaceInternalConditionRelation` [SpaceInternalConditionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalConditionRelation')

The relation used to identify the internal condition\.

#### Returns
[DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')  
The [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition') if found; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetOpening(DiGi.Analytical.Building.Classes.OpeningConstructionRelation)'></a>

## BuildingRelationCluster\.GetOpening\(OpeningConstructionRelation\) Method

Retrieves the opening associated with the specified opening construction relation\.

```csharp
public DiGi.Analytical.Building.Interfaces.IOpening? GetOpening(DiGi.Analytical.Building.Classes.OpeningConstructionRelation? openingConstructionRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetOpening(DiGi.Analytical.Building.Classes.OpeningConstructionRelation).openingConstructionRelation'></a>

`openingConstructionRelation` [OpeningConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionRelation')

The opening construction relation used to look up the opening\.

#### Returns
[DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')  
The [DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening') if found; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetOpeningConstruction(DiGi.Analytical.Building.Classes.OpeningConstructionRelation)'></a>

## BuildingRelationCluster\.GetOpeningConstruction\(OpeningConstructionRelation\) Method

Retrieves the opening construction associated with the specified opening construction relation\.

```csharp
public DiGi.Analytical.Building.Interfaces.IOpeningConstruction? GetOpeningConstruction(DiGi.Analytical.Building.Classes.OpeningConstructionRelation? openingConstructionRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetOpeningConstruction(DiGi.Analytical.Building.Classes.OpeningConstructionRelation).openingConstructionRelation'></a>

`openingConstructionRelation` [OpeningConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionRelation')

The opening construction relation used to identify the target opening construction\.

#### Returns
[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')  
The [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction') if found; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetOpenings(DiGi.Analytical.Building.Classes.OpeningRelation)'></a>

## BuildingRelationCluster\.GetOpenings\(OpeningRelation\) Method

Retrieves a list of opening objects associated with the specified opening relation\.

```csharp
public System.Collections.Generic.List<DiGi.Analytical.Building.Interfaces.IOpening>? GetOpenings(DiGi.Analytical.Building.Classes.OpeningRelation? openingRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetOpenings(DiGi.Analytical.Building.Classes.OpeningRelation).openingRelation'></a>

`openingRelation` [OpeningRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningRelation')

The opening relation containing references to the openings to be retrieved\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening') objects if successfully retrieved; otherwise, null\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetPhysicalComponent(DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation)'></a>

## BuildingRelationCluster\.GetPhysicalComponent\(PhysicalComponentConstructionRelation\) Method

Retrieves the physical component associated with the specified construction relation\.

```csharp
public DiGi.Analytical.Building.Interfaces.IPhysicalComponent? GetPhysicalComponent(DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation? physicalComponentConstructionRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetPhysicalComponent(DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation).physicalComponentConstructionRelation'></a>

`physicalComponentConstructionRelation` [PhysicalComponentConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionRelation')

The physical component construction relation used to identify the component\.

#### Returns
[DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent')  
The [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent') if found; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetPhysicalComponentConstruction(DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation)'></a>

## BuildingRelationCluster\.GetPhysicalComponentConstruction\(PhysicalComponentConstructionRelation\) Method

Retrieves the physical component construction associated with the specified relation\.

```csharp
public DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction? GetPhysicalComponentConstruction(DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation? physicalComponentConstructionRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetPhysicalComponentConstruction(DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation).physicalComponentConstructionRelation'></a>

`physicalComponentConstructionRelation` [PhysicalComponentConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionRelation')

The relation used to identify the physical component construction\.

#### Returns
[DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')  
The matching [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction') if found; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetSpace_TSpace_(DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation)'></a>

## BuildingRelationCluster\.GetSpace\<TSpace\>\(SpaceInternalConditionRelation\) Method

Retrieves a space of the specified type based on the provided internal condition relation\.

```csharp
public TSpace? GetSpace<TSpace>(DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation? spaceInternalConditionRelation)
    where TSpace : DiGi.Analytical.Building.Interfaces.ISpace;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetSpace_TSpace_(DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation).TSpace'></a>

`TSpace`

The type of space to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')\.
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetSpace_TSpace_(DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation).spaceInternalConditionRelation'></a>

`spaceInternalConditionRelation` [SpaceInternalConditionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalConditionRelation')

The internal condition relation used to identify the space via its reference\.

#### Returns
[TSpace](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetSpace_TSpace_(DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation).TSpace 'DiGi\.Analytical\.Building\.Classes\.BuildingRelationCluster\.GetSpace\<TSpace\>\(DiGi\.Analytical\.Building\.Classes\.SpaceInternalConditionRelation\)\.TSpace')  
The space object of type \<typeparam ref="TSpace" /\> if found; otherwise, the default value for the type\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetSpaces(DiGi.Analytical.Building.Classes.SpaceRelation)'></a>

## BuildingRelationCluster\.GetSpaces\(SpaceRelation\) Method

Retrieves a list of space objects associated with the specified space relation\.

```csharp
public System.Collections.Generic.List<DiGi.Analytical.Building.Interfaces.ISpace>? GetSpaces(DiGi.Analytical.Building.Classes.SpaceRelation? spaceRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetSpaces(DiGi.Analytical.Building.Classes.SpaceRelation).spaceRelation'></a>

`spaceRelation` [SpaceRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceRelation')

The space relation containing references to the spaces to be retrieved\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace') objects if successfully retrieved; otherwise, null\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetSpaces(DiGi.Analytical.Building.Classes.ZoneRelation)'></a>

## BuildingRelationCluster\.GetSpaces\(ZoneRelation\) Method

Retrieves a list of space objects associated with the specified zone relation\.

```csharp
public System.Collections.Generic.List<DiGi.Analytical.Building.Interfaces.ISpace>? GetSpaces(DiGi.Analytical.Building.Classes.ZoneRelation? zoneRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetSpaces(DiGi.Analytical.Building.Classes.ZoneRelation).zoneRelation'></a>

`zoneRelation` [ZoneRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ZoneRelation 'DiGi\.Analytical\.Building\.Classes\.ZoneRelation')

The zone relation object containing references to the spaces\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace') objects if successfully retrieved; otherwise, null\.

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetSpaces_TSpace_()'></a>

## BuildingRelationCluster\.GetSpaces\<TSpace\>\(\) Method

Retrieves a list of space objects of the specified type from the cluster\.

```csharp
public System.Collections.Generic.List<TSpace>? GetSpaces<TSpace>()
    where TSpace : DiGi.Analytical.Building.Interfaces.ISpace;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetSpaces_TSpace_().TSpace'></a>

`TSpace`

The type of space object to retrieve, which must implement [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TSpace](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingRelationCluster.GetSpaces_TSpace_().TSpace 'DiGi\.Analytical\.Building\.Classes\.BuildingRelationCluster\.GetSpaces\<TSpace\>\(\)\.TSpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the retrieved space objects of type \<typeparam ref="TSpace" /\>, or null if no such spaces are found\.

<a name='DiGi.Analytical.Building.Classes.Component'></a>

## Component Class

Represents an abstract base class for building components within the analytical 3D geometry model\.

```csharp
public abstract class Component : DiGi.Analytical.Building.Classes.BuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IBuildingBoundable3D, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IConstructable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → Component

Derived  
↳ [AbstractComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent')  
↳ [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstructable](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstructable 'DiGi\.Analytical\.Building\.Interfaces\.IConstructable')
### Constructors

<a name='DiGi.Analytical.Building.Classes.Component.Component()'></a>

## Component\(\) Constructor

Initializes a new instance of the [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') class\.

```csharp
public Component();
```

<a name='DiGi.Analytical.Building.Classes.Component.Component(DiGi.Analytical.Building.Classes.Component)'></a>

## Component\(Component\) Constructor

Initializes a new instance of the [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') class based on an existing [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') instance\.

```csharp
public Component(DiGi.Analytical.Building.Classes.Component? component);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Component.Component(DiGi.Analytical.Building.Classes.Component).component'></a>

`component` [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component')

The source [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') used to initialize this instance\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.Component.Component(System.Guid)'></a>

## Component\(Guid\) Constructor

Initializes a new instance of the [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') class with the specified unique identifier\.

```csharp
public Component(System.Guid guid);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Component.Component(System.Guid).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the component\.

<a name='DiGi.Analytical.Building.Classes.Component.Component(System.Guid,DiGi.Analytical.Building.Classes.Component)'></a>

## Component\(Guid, Component\) Constructor

Initializes a new instance of the [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') class using the specified unique identifier and an optional source component\.

```csharp
public Component(System.Guid guid, DiGi.Analytical.Building.Classes.Component? component);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Component.Component(System.Guid,DiGi.Analytical.Building.Classes.Component).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the component\.

<a name='DiGi.Analytical.Building.Classes.Component.Component(System.Guid,DiGi.Analytical.Building.Classes.Component).component'></a>

`component` [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component')

An optional existing [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') instance to initialize from\.

<a name='DiGi.Analytical.Building.Classes.Component.Component(System.Text.Json.Nodes.JsonObject)'></a>

## Component\(JsonObject\) Constructor

Initializes a new instance of the [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') class using the specified JSON object\.

```csharp
public Component(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Component.Component(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the component\. This value can be null\.
### Methods

<a name='DiGi.Analytical.Building.Classes.Component.GetBoundingBox()'></a>

## Component\.GetBoundingBox\(\) Method

Gets the axis\-aligned bounding box of the component\.

```csharp
public abstract DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d.getboundingbox 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D\.GetBoundingBox')

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') encompassing the component, or null if it cannot be determined\.

<a name='DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_'></a>

## ComponentConstruction\<TConstructable\> Class

Provides an abstract base implementation for the construction of a specific constructable component\.

```csharp
public abstract class ComponentConstruction<TConstructable> : DiGi.Analytical.Building.Classes.PhysicalComponentConstruction, DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction<TConstructable>, DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction, DiGi.Analytical.Building.Interfaces.IConstruction, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject, DiGi.Analytical.Building.Interfaces.IBuildingDescribableObject, DiGi.Core.Interfaces.IDescribableObject, DiGi.Analytical.Building.Interfaces.IConstruction<TConstructable>
    where TConstructable : DiGi.Analytical.Building.Interfaces.IConstructable
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_.TConstructable'></a>

`TConstructable`

The type of the constructable object, which must implement the [DiGi\.Analytical\.Building\.Interfaces\.IConstructable](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstructable 'DiGi\.Analytical\.Building\.Interfaces\.IConstructable') interface\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject') → [PhysicalComponentConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstruction 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstruction') → ComponentConstruction\<TConstructable\>

Derived  
↳ [FloorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FloorConstruction 'DiGi\.Analytical\.Building\.Classes\.FloorConstruction')  
↳ [RoofConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.RoofConstruction 'DiGi\.Analytical\.Building\.Classes\.RoofConstruction')  
↳ [WallConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WallConstruction 'DiGi\.Analytical\.Building\.Classes\.WallConstruction')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction\`1')[TConstructable](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_.TConstructable 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>\.TConstructable')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingdescribableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction\`1')[TConstructable](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_.TConstructable 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>\.TConstructable')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_.ComponentConstruction()'></a>

## ComponentConstruction\(\) Constructor

Initializes a new instance of the [ComponentConstruction&lt;TConstructable&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>') class\.

```csharp
public ComponentConstruction();
```

<a name='DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_.ComponentConstruction(DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_)'></a>

## ComponentConstruction\(ComponentConstruction\<TConstructable\>\) Constructor

Initializes a new instance of the [ComponentConstruction&lt;TConstructable&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>') class using the specified component construction\.

```csharp
public ComponentConstruction(DiGi.Analytical.Building.Classes.ComponentConstruction<TConstructable>? componentConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_.ComponentConstruction(DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_).componentConstruction'></a>

`componentConstruction` [DiGi\.Analytical\.Building\.Classes\.ComponentConstruction&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>')[TConstructable](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_.TConstructable 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>\.TConstructable')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>')

The existing component construction instance from which to copy properties\.

<a name='DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_.ComponentConstruction(System.Guid,DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_)'></a>

## ComponentConstruction\(Guid, ComponentConstruction\<TConstructable\>\) Constructor

Initializes a new instance of the [ComponentConstruction&lt;TConstructable&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>') class using the specified unique identifier and an optional source construction object\.

```csharp
public ComponentConstruction(System.Guid guid, DiGi.Analytical.Building.Classes.ComponentConstruction<TConstructable>? componentConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_.ComponentConstruction(System.Guid,DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for this component construction\.

<a name='DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_.ComponentConstruction(System.Guid,DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_).componentConstruction'></a>

`componentConstruction` [DiGi\.Analytical\.Building\.Classes\.ComponentConstruction&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>')[TConstructable](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_.TConstructable 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>\.TConstructable')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>')

An optional existing [ComponentConstruction&lt;TConstructable&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>') instance to initialize from\.

<a name='DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_.ComponentConstruction(System.Text.Json.Nodes.JsonObject)'></a>

## ComponentConstruction\(JsonObject\) Constructor

Initializes a new instance of the [ComponentConstruction&lt;TConstructable&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>') class using the specified JSON object\.

```csharp
public ComponentConstruction(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_.ComponentConstruction(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the construction instance\.

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster'></a>

## ConstructionRelationCluster Class

Represents a cluster of unique object relations that manages the associations between analytical GUID objects and building relations within a construction context\.

```csharp
public class ConstructionRelationCluster : DiGi.Core.Relation.Classes.UniqueObjectRelationCluster<DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingRelation>, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Cluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3') → [DiGi\.Core\.Classes\.ValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3') → [DiGi\.Core\.Classes\.SerializableObjectValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3') → [DiGi\.Core\.Classes\.UniqueObjectValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobjectvaluecluster-1 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\`1')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobjectvaluecluster-1 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\`1') → [DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationcluster-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\`2')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationcluster-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\`2')[DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingrelation 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationcluster-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\`2') → ConstructionRelationCluster

Derived  
↳ [BuildingRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingRelationCluster 'DiGi\.Analytical\.Building\.Classes\.BuildingRelationCluster')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.ConstructionRelationCluster()'></a>

## ConstructionRelationCluster\(\) Constructor

Initializes a new instance of the [ConstructionRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionRelationCluster 'DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster') class\.

```csharp
public ConstructionRelationCluster();
```

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.ConstructionRelationCluster(DiGi.Analytical.Building.Classes.ConstructionRelationCluster)'></a>

## ConstructionRelationCluster\(ConstructionRelationCluster\) Constructor

Initializes a new instance of the [ConstructionRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionRelationCluster 'DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster') class using another [ConstructionRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionRelationCluster 'DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster') instance\.

```csharp
public ConstructionRelationCluster(DiGi.Analytical.Building.Classes.ConstructionRelationCluster? constructionRelationCluster);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.ConstructionRelationCluster(DiGi.Analytical.Building.Classes.ConstructionRelationCluster).constructionRelationCluster'></a>

`constructionRelationCluster` [ConstructionRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionRelationCluster 'DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster')

The source [ConstructionRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionRelationCluster 'DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.ConstructionRelationCluster(System.Collections.Generic.IEnumerable_DiGi.Analytical.Interfaces.IAnalyticalGuidObject_)'></a>

## ConstructionRelationCluster\(IEnumerable\<IAnalyticalGuidObject\>\) Constructor

Initializes a new instance of the [ConstructionRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionRelationCluster 'DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster') class using a collection of analytical GUID objects\.

```csharp
public ConstructionRelationCluster(System.Collections.Generic.IEnumerable<DiGi.Analytical.Interfaces.IAnalyticalGuidObject>? analyticalGuidObjects);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.ConstructionRelationCluster(System.Collections.Generic.IEnumerable_DiGi.Analytical.Interfaces.IAnalyticalGuidObject_).analyticalGuidObjects'></a>

`analyticalGuidObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of analytical GUID objects to initialize the cluster with\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.ConstructionRelationCluster(System.Text.Json.Nodes.JsonObject)'></a>

## ConstructionRelationCluster\(JsonObject\) Constructor

Initializes a new instance of the [ConstructionRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionRelationCluster 'DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster') class using the specified JSON object\.

```csharp
public ConstructionRelationCluster(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.ConstructionRelationCluster(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data used to initialize the cluster\. This value can be null\.
### Methods

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Enums.OpeningConstructionPart,DiGi.Analytical.Building.Interfaces.IStructureLayer)'></a>

## ConstructionRelationCluster\.AddRelation\(IOpeningConstruction, OpeningConstructionPart, IStructureLayer\) Method

Adds a relation between an opening construction and a structure layer based on the specified construction part\.

```csharp
public DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation? AddRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction? openingConstruction, DiGi.Analytical.Building.Enums.OpeningConstructionPart openingConstructionPart, DiGi.Analytical.Building.Interfaces.IStructureLayer? structureLayer);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Enums.OpeningConstructionPart,DiGi.Analytical.Building.Interfaces.IStructureLayer).openingConstruction'></a>

`openingConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')

The opening construction object involved in the relation\.

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Enums.OpeningConstructionPart,DiGi.Analytical.Building.Interfaces.IStructureLayer).openingConstructionPart'></a>

`openingConstructionPart` [OpeningConstructionPart](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.OpeningConstructionPart 'DiGi\.Analytical\.Building\.Enums\.OpeningConstructionPart')

The specific part of the opening construction to relate\.

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Enums.OpeningConstructionPart,DiGi.Analytical.Building.Interfaces.IStructureLayer).structureLayer'></a>

`structureLayer` [DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')

The structure layer object involved in the relation\.

#### Returns
[OpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionStructureLayersRelation')  
The created or updated [OpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionStructureLayersRelation'), or `null` if any input is null or the part is undefined\.

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer)'></a>

## ConstructionRelationCluster\.AddRelation\(IPhysicalComponentConstruction, IStructureLayer\) Method

Adds or updates a relation between a physical component construction and a structure layer within the construction relation cluster\.

```csharp
public DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation? AddRelation(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction? physicalComponentConstruction, DiGi.Analytical.Building.Interfaces.IStructureLayer? structureLayer);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer).physicalComponentConstruction'></a>

`physicalComponentConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')

The physical component construction object to be related\.

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer).structureLayer'></a>

`structureLayer` [DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')

The structure layer object to be related\.

#### Returns
[PhysicalComponentConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionStructureLayersRelation')  
The created or updated [PhysicalComponentConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionStructureLayersRelation'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either the [physicalComponentConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer).physicalComponentConstruction 'DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster\.AddRelation\(DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction, DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer\)\.physicalComponentConstruction') or [structureLayer](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionRelationCluster.AddRelation(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer).structureLayer 'DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster\.AddRelation\(DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction, DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer\)\.structureLayer') is null\.

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.AddRelation(DiGi.Analytical.Interfaces.IMaterial,DiGi.Analytical.Building.Interfaces.IStructureLayer)'></a>

## ConstructionRelationCluster\.AddRelation\(IMaterial, IStructureLayer\) Method

Adds a relation between the specified material and structure layer\.

```csharp
public DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation? AddRelation(DiGi.Analytical.Interfaces.IMaterial? material, DiGi.Analytical.Building.Interfaces.IStructureLayer? structureLayer);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.AddRelation(DiGi.Analytical.Interfaces.IMaterial,DiGi.Analytical.Building.Interfaces.IStructureLayer).material'></a>

`material` [DiGi\.Analytical\.Interfaces\.IMaterial](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.imaterial 'DiGi\.Analytical\.Interfaces\.IMaterial')

The material to be associated with the structure layer\.

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.AddRelation(DiGi.Analytical.Interfaces.IMaterial,DiGi.Analytical.Building.Interfaces.IStructureLayer).structureLayer'></a>

`structureLayer` [DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')

The structure layer to be associated with the material\.

#### Returns
[MaterialStructureLayerRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation 'DiGi\.Analytical\.Building\.Classes\.MaterialStructureLayerRelation')  
The created [MaterialStructureLayerRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation 'DiGi\.Analytical\.Building\.Classes\.MaterialStructureLayerRelation') if successful; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.GetMaterial(DiGi.Analytical.Building.Interfaces.IStructureLayer)'></a>

## ConstructionRelationCluster\.GetMaterial\(IStructureLayer\) Method

Retrieves the material associated with the specified structure layer\.

```csharp
public DiGi.Analytical.Interfaces.IMaterial? GetMaterial(DiGi.Analytical.Building.Interfaces.IStructureLayer? structureLayer);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.GetMaterial(DiGi.Analytical.Building.Interfaces.IStructureLayer).structureLayer'></a>

`structureLayer` [DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')

The structure layer for which to retrieve the associated material\.

#### Returns
[DiGi\.Analytical\.Interfaces\.IMaterial](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.imaterial 'DiGi\.Analytical\.Interfaces\.IMaterial')  
The [DiGi\.Analytical\.Interfaces\.IMaterial](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.imaterial 'DiGi\.Analytical\.Interfaces\.IMaterial') associated with the provided structure layer, or `null` if no relation exists or the [structureLayer](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionRelationCluster.GetMaterial(DiGi.Analytical.Building.Interfaces.IStructureLayer).structureLayer 'DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster\.GetMaterial\(DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer\)\.structureLayer') is null\.

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.GetStructureLayers(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction)'></a>

## ConstructionRelationCluster\.GetStructureLayers\(IPhysicalComponentConstruction\) Method

Retrieves the list of structure layers associated with the specified physical component construction\.

```csharp
public System.Collections.Generic.List<DiGi.Analytical.Building.Interfaces.IStructureLayer>? GetStructureLayers(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction? physicalComponentConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ConstructionRelationCluster.GetStructureLayers(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction).physicalComponentConstruction'></a>

`physicalComponentConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')

The physical component construction for which to retrieve the associated structure layers\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer') objects if found; otherwise, null\.

<a name='DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_'></a>

## ConstructionStructureLayersRelation\<TConstruction\> Class

Represents a one\-to\-many bidirectional relationship between a construction object and its associated structure layers\.

```csharp
public abstract class ConstructionStructureLayersRelation<TConstruction> : DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation<TConstruction, DiGi.Analytical.Building.Interfaces.IStructureLayer>, DiGi.Analytical.Building.Interfaces.IBuildingRelation, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
    where TConstruction : DiGi.Analytical.Building.Interfaces.IConstruction
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.TConstruction'></a>

`TConstruction`

The type of the construction object, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[TConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.TConstruction 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>\.TConstruction')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[TConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.TConstruction 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>\.TConstruction')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[TConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.TConstruction 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>\.TConstruction')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2') → ConstructionStructureLayersRelation\<TConstruction\>

Derived  
↳ [OpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionStructureLayersRelation')  
↳ [PhysicalComponentConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionStructureLayersRelation')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingrelation 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.ConstructionStructureLayersRelation(DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_)'></a>

## ConstructionStructureLayersRelation\(ConstructionStructureLayersRelation\<TConstruction\>\) Constructor

Initializes a new instance of the [ConstructionStructureLayersRelation&lt;TConstruction&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_ 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>') class using an existing relation instance\.

```csharp
public ConstructionStructureLayersRelation(DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation<TConstruction>? constructionStructureLayersRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.ConstructionStructureLayersRelation(DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_).constructionStructureLayersRelation'></a>

`constructionStructureLayersRelation` [DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_ 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>')[TConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.TConstruction 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>\.TConstruction')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_ 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>')

The source relation instance from which values are copied\.

<a name='DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.ConstructionStructureLayersRelation(System.Text.Json.Nodes.JsonObject)'></a>

## ConstructionStructureLayersRelation\(JsonObject\) Constructor

Initializes a new instance of the [ConstructionStructureLayersRelation&lt;TConstruction&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_ 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>') class from the specified JSON object\.

```csharp
public ConstructionStructureLayersRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.ConstructionStructureLayersRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to reconstruct the relation instance\.

<a name='DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.ConstructionStructureLayersRelation(TConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer)'></a>

## ConstructionStructureLayersRelation\(TConstruction, IStructureLayer\) Constructor

Initializes a new instance of the [ConstructionStructureLayersRelation&lt;TConstruction&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_ 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>') class using the specified construction and structure layer\.

```csharp
public ConstructionStructureLayersRelation(TConstruction? construction, DiGi.Analytical.Building.Interfaces.IStructureLayer? structureLayer);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.ConstructionStructureLayersRelation(TConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer).construction'></a>

`construction` [TConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.TConstruction 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>\.TConstruction')

The construction associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.ConstructionStructureLayersRelation(TConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer).structureLayer'></a>

`structureLayer` [DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')

The structure layer to be associated with the construction\.

<a name='DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.ConstructionStructureLayersRelation(TConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IStructureLayer_)'></a>

## ConstructionStructureLayersRelation\(TConstruction, IEnumerable\<IStructureLayer\>\) Constructor

Initializes a new instance of the [ConstructionStructureLayersRelation&lt;TConstruction&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_ 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>') class with the specified construction and collection of structure layers\.

```csharp
public ConstructionStructureLayersRelation(TConstruction? construction, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Interfaces.IStructureLayer>? structureLayers);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.ConstructionStructureLayersRelation(TConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IStructureLayer_).construction'></a>

`construction` [TConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.TConstruction 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>\.TConstruction')

The construction associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_.ConstructionStructureLayersRelation(TConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IStructureLayer_).structureLayers'></a>

`structureLayers` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of structure layers associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.CurveWall'></a>

## CurveWall Class

Represents a wall defined by a 3D curve\.

```csharp
public class CurveWall : DiGi.Analytical.Building.Classes.CurveWall<DiGi.Geometry.Spatial.Interfaces.ICurve3D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') → [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') → [DiGi\.Analytical\.Building\.Classes\.PhysicalComponent&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>') → [DiGi\.Analytical\.Building\.Classes\.Wall&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>') → [DiGi\.Analytical\.Building\.Classes\.CurveWall&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>')[DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>') → CurveWall
### Constructors

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Analytical.Building.Classes.CurveWall)'></a>

## CurveWall\(CurveWall\) Constructor

Initializes a new instance of the [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall') class using the specified [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall') instance\.

```csharp
public CurveWall(DiGi.Analytical.Building.Classes.CurveWall? curveWall);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Analytical.Building.Classes.CurveWall).curveWall'></a>

`curveWall` [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall')

The [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Geometry.Spatial.Interfaces.ICurve3D,double)'></a>

## CurveWall\(IWall, ICurve3D, double\) Constructor

Initializes a new instance of the [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall') class using an existing wall, a specified 3D curve, and a height\.

```csharp
public CurveWall(DiGi.Analytical.Building.Interfaces.IWall wall, DiGi.Geometry.Spatial.Interfaces.ICurve3D? curve3D, double height);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Geometry.Spatial.Interfaces.ICurve3D,double).wall'></a>

`wall` [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')

The source wall used to initialize properties for the new curved wall\.

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Geometry.Spatial.Interfaces.ICurve3D,double).curve3D'></a>

`curve3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D')

The 3D curve that defines the path of the curved wall\.

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Geometry.Spatial.Interfaces.ICurve3D,double).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the curved wall\.

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Geometry.Spatial.Interfaces.ICurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## CurveWall\(IWall, ICurve3D, double, Vector3D\) Constructor

Initializes a new instance of the [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall') class using an existing wall, a curve, height, and direction\.

```csharp
public CurveWall(DiGi.Analytical.Building.Interfaces.IWall wall, DiGi.Geometry.Spatial.Interfaces.ICurve3D? curve3D, double height, DiGi.Geometry.Spatial.Classes.Vector3D? direction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Geometry.Spatial.Interfaces.ICurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D).wall'></a>

`wall` [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')

The [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall') object to use as a basis for initialization\.

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Geometry.Spatial.Interfaces.ICurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D).curve3D'></a>

`curve3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D') that defines the base of the curved wall\.

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Geometry.Spatial.Interfaces.ICurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the wall\.

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Geometry.Spatial.Interfaces.ICurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D).direction'></a>

`direction` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the direction of the wall's extrusion\.

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Geometry.Spatial.Interfaces.ICurve3D,double)'></a>

## CurveWall\(ICurve3D, double\) Constructor

Initializes a new instance of the [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall') class with the specified curve and height\.

```csharp
public CurveWall(DiGi.Geometry.Spatial.Interfaces.ICurve3D? curve3D, double height);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Geometry.Spatial.Interfaces.ICurve3D,double).curve3D'></a>

`curve3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D')

The 3D curve that defines the base path of the wall\.

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Geometry.Spatial.Interfaces.ICurve3D,double).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the wall\.

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Geometry.Spatial.Interfaces.ICurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## CurveWall\(ICurve3D, double, Vector3D\) Constructor

Initializes a new instance of the [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall') class\.

```csharp
public CurveWall(DiGi.Geometry.Spatial.Interfaces.ICurve3D? curve3D, double height, DiGi.Geometry.Spatial.Classes.Vector3D? direction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Geometry.Spatial.Interfaces.ICurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D).curve3D'></a>

`curve3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D') that defines the base path of the curved wall\.

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Geometry.Spatial.Interfaces.ICurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the curved wall\.

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(DiGi.Geometry.Spatial.Interfaces.ICurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D).direction'></a>

`direction` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the direction of the curved wall\.

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(System.Guid,DiGi.Analytical.Building.Classes.CurveWall_DiGi.Geometry.Spatial.Interfaces.ICurve3D_)'></a>

## CurveWall\(Guid, CurveWall\<ICurve3D\>\) Constructor

Initializes a new instance of the [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall') class with a specified unique identifier and an existing curve wall\.

```csharp
public CurveWall(System.Guid guid, DiGi.Analytical.Building.Classes.CurveWall<DiGi.Geometry.Spatial.Interfaces.ICurve3D>? curveWall);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(System.Guid,DiGi.Analytical.Building.Classes.CurveWall_DiGi.Geometry.Spatial.Interfaces.ICurve3D_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the object\.

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(System.Guid,DiGi.Analytical.Building.Classes.CurveWall_DiGi.Geometry.Spatial.Interfaces.ICurve3D_).curveWall'></a>

`curveWall` [DiGi\.Analytical\.Building\.Classes\.CurveWall&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>')[DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>')

The source [CurveWall&lt;TCurve3D&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>') instance used to initialize the new object\.

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(System.Text.Json.Nodes.JsonObject)'></a>

## CurveWall\(JsonObject\) Constructor

Initializes a new instance of the [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall') class from the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public CurveWall(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.CurveWall.CurveWall(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to populate the properties of the new [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall') instance\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_'></a>

## CurveWall\<TCurve3D\> Class

Represents a wall defined by a curved geometry\.

```csharp
public class CurveWall<TCurve3D> : DiGi.Analytical.Building.Classes.Wall<TCurve3D>, DiGi.Analytical.Building.Interfaces.ICurveWall<TCurve3D>, DiGi.Analytical.Building.Interfaces.IWall, DiGi.Analytical.Building.Interfaces.IPhysicalComponent, DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IBuildingBoundable3D, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IConstructable, DiGi.Analytical.Building.Interfaces.IBuildingCurveObject<TCurve3D>, DiGi.Analytical.Building.Interfaces.IBuildingCurveObject, DiGi.Analytical.Building.Interfaces.IComponent<TCurve3D>, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject<TCurve3D>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<TCurve3D>
    where TCurve3D : DiGi.Geometry.Spatial.Interfaces.ICurve3D
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.TCurve3D'></a>

`TCurve3D`

The type of the 3D curve used to define the wall's path, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') → [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') → [DiGi\.Analytical\.Building\.Classes\.PhysicalComponent&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>')[TCurve3D](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.TCurve3D 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>\.TCurve3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>') → [DiGi\.Analytical\.Building\.Classes\.Wall&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>')[TCurve3D](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.TCurve3D 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>\.TCurve3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>') → CurveWall\<TCurve3D\>

Derived  
↳ [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall')

Implements [DiGi\.Analytical\.Building\.Interfaces\.ICurveWall&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icurvewall-1 'DiGi\.Analytical\.Building\.Interfaces\.ICurveWall\`1')[TCurve3D](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.TCurve3D 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>\.TCurve3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icurvewall-1 'DiGi\.Analytical\.Building\.Interfaces\.ICurveWall\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstructable](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstructable 'DiGi\.Analytical\.Building\.Interfaces\.IConstructable'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingCurveObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingcurveobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingCurveObject\`1')[TCurve3D](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.TCurve3D 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>\.TCurve3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingcurveobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingCurveObject\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingCurveObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingcurveobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingCurveObject'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IComponent\`1')[TCurve3D](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.TCurve3D 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>\.TCurve3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IComponent\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1')[TCurve3D](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.TCurve3D 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>\.TCurve3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[TCurve3D](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.TCurve3D 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>\.TCurve3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_)'></a>

## CurveWall\(CurveWall\<TCurve3D\>\) Constructor

Initializes a new instance of the [CurveWall&lt;TCurve3D&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>') class by copying an existing instance\.

```csharp
public CurveWall(DiGi.Analytical.Building.Classes.CurveWall<TCurve3D>? curveWall);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_).curveWall'></a>

`curveWall` [DiGi\.Analytical\.Building\.Classes\.CurveWall&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>')[TCurve3D](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.TCurve3D 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>\.TCurve3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>')

The source [CurveWall&lt;TCurve3D&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>') instance from which to copy properties\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,TCurve3D,double)'></a>

## CurveWall\(IWall, TCurve3D, double\) Constructor

Initializes a new instance of the [CurveWall&lt;TCurve3D&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>') class using an existing wall, a 3D curve, and a specified height, with the direction defaulting to World Z\.

```csharp
public CurveWall(DiGi.Analytical.Building.Interfaces.IWall wall, TCurve3D? curve3D, double height);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,TCurve3D,double).wall'></a>

`wall` [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')

The base wall object used for initialization\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,TCurve3D,double).curve3D'></a>

`curve3D` [TCurve3D](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.TCurve3D 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>\.TCurve3D')

The 3D curve defining the geometry of the curved wall\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,TCurve3D,double).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the wall along the World Z axis\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,TCurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## CurveWall\(IWall, TCurve3D, double, Vector3D\) Constructor

Initializes a new instance of the [CurveWall&lt;TCurve3D&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>') class using an existing wall, a base curve, a height, and a specific direction vector\.

```csharp
public CurveWall(DiGi.Analytical.Building.Interfaces.IWall wall, TCurve3D? curve3D, double height, DiGi.Geometry.Spatial.Classes.Vector3D? direction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,TCurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D).wall'></a>

`wall` [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')

The [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall') to use as a basis for initialization\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,TCurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D).curve3D'></a>

`curve3D` [TCurve3D](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.TCurve3D 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>\.TCurve3D')

The base 3D curve defining the wall path\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,TCurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the wall\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(DiGi.Analytical.Building.Interfaces.IWall,TCurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D).direction'></a>

`direction` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') defining the direction in which the wall extends from its base curve\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(System.Guid,DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_)'></a>

## CurveWall\(Guid, CurveWall\<TCurve3D\>\) Constructor

Initializes a new instance of the [CurveWall&lt;TCurve3D&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>') class using a unique identifier and an existing curve wall instance\.

```csharp
public CurveWall(System.Guid guid, DiGi.Analytical.Building.Classes.CurveWall<TCurve3D>? curveWall);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(System.Guid,DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the object\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(System.Guid,DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_).curveWall'></a>

`curveWall` [DiGi\.Analytical\.Building\.Classes\.CurveWall&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>')[TCurve3D](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.TCurve3D 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>\.TCurve3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>')

The existing [CurveWall&lt;TCurve3D&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>') instance to copy properties from\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(System.Text.Json.Nodes.JsonObject)'></a>

## CurveWall\(JsonObject\) Constructor

Initializes a new instance of the [CurveWall&lt;TCurve3D&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>') class from the specified JSON object\.

```csharp
public CurveWall(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the instance\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(TCurve3D,double)'></a>

## CurveWall\(TCurve3D, double\) Constructor

Initializes a new instance of the [CurveWall&lt;TCurve3D&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>') class using the specified curve and height, with the direction defaulting to the world Z\-axis\.

```csharp
public CurveWall(TCurve3D? curve3D, double height);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(TCurve3D,double).curve3D'></a>

`curve3D` [TCurve3D](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.TCurve3D 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>\.TCurve3D')

The 3D curve that defines the base of the wall\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(TCurve3D,double).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the wall\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(TCurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## CurveWall\(TCurve3D, double, Vector3D\) Constructor

Initializes a new instance of the [CurveWall&lt;TCurve3D&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>') class\.

```csharp
public CurveWall(TCurve3D? curve3D, double height, DiGi.Geometry.Spatial.Classes.Vector3D? direction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(TCurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D).curve3D'></a>

`curve3D` [TCurve3D](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.TCurve3D 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>\.TCurve3D')

The base 3D curve defining the wall path\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(TCurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the wall as a double\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.CurveWall(TCurve3D,double,DiGi.Geometry.Spatial.Classes.Vector3D).direction'></a>

`direction` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') direction vector used to determine the orientation and extrusion of the wall\.
### Properties

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.Vector'></a>

## CurveWall\<TCurve3D\>\.Vector Property

Gets or sets the [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') that defines the direction and magnitude of the curved wall's extrusion\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Vector { get; set; }
```

Implements [Vector](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icurvewall-1.vector 'DiGi\.Analytical\.Building\.Interfaces\.ICurveWall\`1\.Vector')

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')
### Methods

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.GetBoundingBox()'></a>

## CurveWall\<TCurve3D\>\.GetBoundingBox\(\) Method

Gets the axis\-aligned bounding box of the curved wall\.

```csharp
public override DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d.getboundingbox 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D\.GetBoundingBox')

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') encompassing the curved wall, or null if it cannot be determined\.

<a name='DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_.GetSurface3D()'></a>

## CurveWall\<TCurve3D\>\.GetSurface3D\(\) Method

Retrieves the 3D surface representation of the curved wall\.

```csharp
public DiGi.Geometry.Spatial.Interfaces.ISurface3D? GetSurface3D();
```

#### Returns
[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')  
The [DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D') representing the wall's surface if it can be determined; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Classes.DoorConstruction'></a>

## DoorConstruction Class

Represents a door construction element within the analytical building model, providing functionality for managing door\-specific openings\.

```csharp
public class DoorConstruction : DiGi.Analytical.Building.Classes.OpeningConstruction<DiGi.Analytical.Building.Interfaces.IDoor>, DiGi.Analytical.Building.Interfaces.IDoorConstruction, DiGi.Analytical.Building.Interfaces.IOpeningConstruction<DiGi.Analytical.Building.Interfaces.IDoor>, DiGi.Analytical.Building.Interfaces.IOpeningConstruction, DiGi.Analytical.Building.Interfaces.IGeometry2DConstruction, DiGi.Analytical.Building.Interfaces.IConstruction, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject, DiGi.Analytical.Building.Interfaces.IBuildingDescribableObject, DiGi.Core.Interfaces.IDescribableObject, DiGi.Analytical.Building.Interfaces.IGeometry2DConstruction<DiGi.Analytical.Building.Interfaces.IDoor, DiGi.Geometry.Planar.Interfaces.ISurface2D>, DiGi.Analytical.Building.Interfaces.IGeometry2DConstruction<DiGi.Analytical.Building.Interfaces.IDoor>, DiGi.Analytical.Building.Interfaces.IConstruction<DiGi.Analytical.Building.Interfaces.IDoor>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject') → [DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>') → [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction') → [DiGi\.Analytical\.Building\.Classes\.OpeningConstruction&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_ 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction\<TOpening\>')[DiGi\.Analytical\.Building\.Interfaces\.IDoor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.idoor 'DiGi\.Analytical\.Building\.Interfaces\.IDoor')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_ 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction\<TOpening\>') → DoorConstruction

Implements [DiGi\.Analytical\.Building\.Interfaces\.IDoorConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.idoorconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IDoorConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction\`1')[DiGi\.Analytical\.Building\.Interfaces\.IDoor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.idoor 'DiGi\.Analytical\.Building\.Interfaces\.IDoor')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingdescribableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction-2 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction\`2')[DiGi\.Analytical\.Building\.Interfaces\.IDoor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.idoor 'DiGi\.Analytical\.Building\.Interfaces\.IDoor')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction-2 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction\`2')[DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction-2 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction\`2'), [DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction\`1')[DiGi\.Analytical\.Building\.Interfaces\.IDoor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.idoor 'DiGi\.Analytical\.Building\.Interfaces\.IDoor')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction\`1')[DiGi\.Analytical\.Building\.Interfaces\.IDoor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.idoor 'DiGi\.Analytical\.Building\.Interfaces\.IDoor')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.DoorConstruction.DoorConstruction(DiGi.Analytical.Building.Classes.DoorConstruction)'></a>

## DoorConstruction\(DoorConstruction\) Constructor

Initializes a new instance of the [DoorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.DoorConstruction 'DiGi\.Analytical\.Building\.Classes\.DoorConstruction') class using an existing [DoorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.DoorConstruction 'DiGi\.Analytical\.Building\.Classes\.DoorConstruction') instance\.

```csharp
public DoorConstruction(DiGi.Analytical.Building.Classes.DoorConstruction? doorConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.DoorConstruction.DoorConstruction(DiGi.Analytical.Building.Classes.DoorConstruction).doorConstruction'></a>

`doorConstruction` [DoorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.DoorConstruction 'DiGi\.Analytical\.Building\.Classes\.DoorConstruction')

The source [DoorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.DoorConstruction 'DiGi\.Analytical\.Building\.Classes\.DoorConstruction') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.DoorConstruction.DoorConstruction(string,DiGi.Geometry.Planar.Interfaces.ISurface2D)'></a>

## DoorConstruction\(string, ISurface2D\) Constructor

Initializes a new instance of the [DoorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.DoorConstruction 'DiGi\.Analytical\.Building\.Classes\.DoorConstruction') class\.

```csharp
public DoorConstruction(string? name, DiGi.Geometry.Planar.Interfaces.ISurface2D? surface2D);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.DoorConstruction.DoorConstruction(string,DiGi.Geometry.Planar.Interfaces.ISurface2D).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional name of the door construction\.

<a name='DiGi.Analytical.Building.Classes.DoorConstruction.DoorConstruction(string,DiGi.Geometry.Planar.Interfaces.ISurface2D).surface2D'></a>

`surface2D` [DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')

The optional 2D surface associated with the door construction\.

<a name='DiGi.Analytical.Building.Classes.DoorConstruction.DoorConstruction(System.Guid,DiGi.Analytical.Building.Classes.DoorConstruction)'></a>

## DoorConstruction\(Guid, DoorConstruction\) Constructor

Initializes a new instance of the [DoorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.DoorConstruction 'DiGi\.Analytical\.Building\.Classes\.DoorConstruction') class with a specified unique identifier and an existing door construction\.

```csharp
public DoorConstruction(System.Guid guid, DiGi.Analytical.Building.Classes.DoorConstruction? doorConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.DoorConstruction.DoorConstruction(System.Guid,DiGi.Analytical.Building.Classes.DoorConstruction).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the door construction\.

<a name='DiGi.Analytical.Building.Classes.DoorConstruction.DoorConstruction(System.Guid,DiGi.Analytical.Building.Classes.DoorConstruction).doorConstruction'></a>

`doorConstruction` [DoorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.DoorConstruction 'DiGi\.Analytical\.Building\.Classes\.DoorConstruction')

An optional existing [DoorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.DoorConstruction 'DiGi\.Analytical\.Building\.Classes\.DoorConstruction') instance to copy properties from\.

<a name='DiGi.Analytical.Building.Classes.DoorConstruction.DoorConstruction(System.Text.Json.Nodes.JsonObject)'></a>

## DoorConstruction\(JsonObject\) Constructor

Initializes a new instance of the [DoorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.DoorConstruction 'DiGi\.Analytical\.Building\.Classes\.DoorConstruction') class from the specified JSON object\.

```csharp
public DoorConstruction(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.DoorConstruction.DoorConstruction(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.

<a name='DiGi.Analytical.Building.Classes.FaceFloor'></a>

## FaceFloor Class

Represents a building floor that is defined by a 3D face geometry\.

```csharp
public class FaceFloor : DiGi.Analytical.Building.Classes.Floor<DiGi.Geometry.Spatial.Interfaces.IFace3D>, DiGi.Analytical.Building.Interfaces.IFaceFloor, DiGi.Analytical.Building.Interfaces.IFloor, DiGi.Analytical.Building.Interfaces.IPhysicalComponent, DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IBuildingBoundable3D, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IConstructable, DiGi.Analytical.Building.Interfaces.IBuildingFaceObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject<DiGi.Geometry.Spatial.Interfaces.IFace3D>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Spatial.Interfaces.IFace3D>, DiGi.Analytical.Building.Interfaces.IComponent<DiGi.Geometry.Spatial.Interfaces.IFace3D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') → [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') → [DiGi\.Analytical\.Building\.Classes\.PhysicalComponent&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>') → [DiGi\.Analytical\.Building\.Classes\.Floor&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_ 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_ 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>') → FaceFloor

Implements [DiGi\.Analytical\.Building\.Interfaces\.IFaceFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifacefloor 'DiGi\.Analytical\.Building\.Interfaces\.IFaceFloor'), [DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstructable](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstructable 'DiGi\.Analytical\.Building\.Interfaces\.IConstructable'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingFaceObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingfaceobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingFaceObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IComponent\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IComponent\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.FaceFloor.FaceFloor(DiGi.Analytical.Building.Classes.FaceFloor)'></a>

## FaceFloor\(FaceFloor\) Constructor

Initializes a new instance of the [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor') class using an existing [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor') instance\.

```csharp
public FaceFloor(DiGi.Analytical.Building.Classes.FaceFloor? faceFloor);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.FaceFloor.FaceFloor(DiGi.Analytical.Building.Classes.FaceFloor).faceFloor'></a>

`faceFloor` [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor')

The source [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.FaceFloor.FaceFloor(DiGi.Analytical.Building.Interfaces.IFloor,DiGi.Geometry.Spatial.Interfaces.IFace3D)'></a>

## FaceFloor\(IFloor, IFace3D\) Constructor

Initializes a new instance of the [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor') class using the specified floor and geometry\.

```csharp
public FaceFloor(DiGi.Analytical.Building.Interfaces.IFloor? floor, DiGi.Geometry.Spatial.Interfaces.IFace3D? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.FaceFloor.FaceFloor(DiGi.Analytical.Building.Interfaces.IFloor,DiGi.Geometry.Spatial.Interfaces.IFace3D).floor'></a>

`floor` [DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor')

The source floor object to initialize from\.

<a name='DiGi.Analytical.Building.Classes.FaceFloor.FaceFloor(DiGi.Analytical.Building.Interfaces.IFloor,DiGi.Geometry.Spatial.Interfaces.IFace3D).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D')

The 3D face geometry associated with this floor\.

<a name='DiGi.Analytical.Building.Classes.FaceFloor.FaceFloor(DiGi.Geometry.Spatial.Interfaces.IFace3D)'></a>

## FaceFloor\(IFace3D\) Constructor

Initializes a new instance of the [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor') class using the specified geometry\.

```csharp
public FaceFloor(DiGi.Geometry.Spatial.Interfaces.IFace3D? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.FaceFloor.FaceFloor(DiGi.Geometry.Spatial.Interfaces.IFace3D).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D')

The 3D face geometry to associate with this floor instance\.

<a name='DiGi.Analytical.Building.Classes.FaceFloor.FaceFloor(System.Guid,DiGi.Analytical.Building.Classes.FaceFloor)'></a>

## FaceFloor\(Guid, FaceFloor\) Constructor

Initializes a new instance of the [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor') class with a specified unique identifier and an existing [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor') object\.

```csharp
public FaceFloor(System.Guid guid, DiGi.Analytical.Building.Classes.FaceFloor? faceFloor);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.FaceFloor.FaceFloor(System.Guid,DiGi.Analytical.Building.Classes.FaceFloor).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the floor face\.

<a name='DiGi.Analytical.Building.Classes.FaceFloor.FaceFloor(System.Guid,DiGi.Analytical.Building.Classes.FaceFloor).faceFloor'></a>

`faceFloor` [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor')

An optional [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor') instance to initialize from\.

<a name='DiGi.Analytical.Building.Classes.FaceFloor.FaceFloor(System.Text.Json.Nodes.JsonObject)'></a>

## FaceFloor\(JsonObject\) Constructor

Initializes a new instance of the [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor') class from the specified JSON object\.

```csharp
public FaceFloor(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.FaceFloor.FaceFloor(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.
### Methods

<a name='DiGi.Analytical.Building.Classes.FaceFloor.GetBoundingBox()'></a>

## FaceFloor\.GetBoundingBox\(\) Method

Gets the axis\-aligned bounding box of the face floor\.

```csharp
public override DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d.getboundingbox 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D\.GetBoundingBox')

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
The three\-dimensional bounding box encompassing the face floor, or null if it cannot be determined\.

<a name='DiGi.Analytical.Building.Classes.Floor_T_'></a>

## Floor\<T\> Class

Represents an abstract base class for a floor component within a building's analytical model\.

```csharp
public abstract class Floor<T> : DiGi.Analytical.Building.Classes.PhysicalComponent<T>, DiGi.Analytical.Building.Interfaces.IFloor, DiGi.Analytical.Building.Interfaces.IPhysicalComponent, DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IBuildingBoundable3D, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IConstructable
    where T : DiGi.Geometry.Spatial.Interfaces.IGeometry3D
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.Floor_T_.T'></a>

`T`

The type of 3D geometry associated with the floor, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') → [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') → [DiGi\.Analytical\.Building\.Classes\.PhysicalComponent&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_.T 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>') → Floor\<T\>

Derived  
↳ [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstructable](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstructable 'DiGi\.Analytical\.Building\.Interfaces\.IConstructable')
### Constructors

<a name='DiGi.Analytical.Building.Classes.Floor_T_.Floor(DiGi.Analytical.Building.Classes.Floor_T_)'></a>

## Floor\(Floor\<T\>\) Constructor

Initializes a new instance of the [Floor&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_ 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>') class using an existing [Floor&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_ 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>') instance\.

```csharp
public Floor(DiGi.Analytical.Building.Classes.Floor<T>? floor);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Floor_T_.Floor(DiGi.Analytical.Building.Classes.Floor_T_).floor'></a>

`floor` [DiGi\.Analytical\.Building\.Classes\.Floor&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_ 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_.T 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_ 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>')

The source [Floor&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_ 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.Floor_T_.Floor(DiGi.Analytical.Building.Interfaces.IFloor,T)'></a>

## Floor\(IFloor, T\) Constructor

Initializes a new instance of the [Floor&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_ 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>') class using an existing floor implementation and specified geometry\.

```csharp
public Floor(DiGi.Analytical.Building.Interfaces.IFloor? floor, T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Floor_T_.Floor(DiGi.Analytical.Building.Interfaces.IFloor,T).floor'></a>

`floor` [DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor')

The source floor object used to initialize the current instance\.

<a name='DiGi.Analytical.Building.Classes.Floor_T_.Floor(DiGi.Analytical.Building.Interfaces.IFloor,T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_.T 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>\.T')

The 3D geometry associated with this floor\.

<a name='DiGi.Analytical.Building.Classes.Floor_T_.Floor(System.Guid,DiGi.Analytical.Building.Classes.Floor_T_)'></a>

## Floor\(Guid, Floor\<T\>\) Constructor

Initializes a new instance of the [Floor&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_ 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>') class with a specified unique identifier and an optional source floor\.

```csharp
public Floor(System.Guid guid, DiGi.Analytical.Building.Classes.Floor<T>? floor);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Floor_T_.Floor(System.Guid,DiGi.Analytical.Building.Classes.Floor_T_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the floor\.

<a name='DiGi.Analytical.Building.Classes.Floor_T_.Floor(System.Guid,DiGi.Analytical.Building.Classes.Floor_T_).floor'></a>

`floor` [DiGi\.Analytical\.Building\.Classes\.Floor&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_ 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_.T 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_ 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>')

An existing [Floor&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_ 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>') instance to initialize from\.

<a name='DiGi.Analytical.Building.Classes.Floor_T_.Floor(System.Text.Json.Nodes.JsonObject)'></a>

## Floor\(JsonObject\) Constructor

Initializes a new instance of the [Floor&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_ 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>') class using the specified JSON object\.

```csharp
public Floor(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Floor_T_.Floor(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data used to initialize the instance\.

<a name='DiGi.Analytical.Building.Classes.Floor_T_.Floor(T)'></a>

## Floor\(T\) Constructor

Initializes a new instance of the [Floor&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_ 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>') class with the specified geometry\.

```csharp
public Floor(T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Floor_T_.Floor(T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_.T 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>\.T')

The geometry to associate with the floor instance\.

<a name='DiGi.Analytical.Building.Classes.FloorConstruction'></a>

## FloorConstruction Class

Represents the construction details and properties of a floor component within the analytical building model\.

```csharp
public class FloorConstruction : DiGi.Analytical.Building.Classes.ComponentConstruction<DiGi.Analytical.Building.Interfaces.IFloor>, DiGi.Analytical.Building.Interfaces.IFloorConstruction, DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction<DiGi.Analytical.Building.Interfaces.IFloor>, DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction, DiGi.Analytical.Building.Interfaces.IConstruction, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject, DiGi.Analytical.Building.Interfaces.IBuildingDescribableObject, DiGi.Core.Interfaces.IDescribableObject, DiGi.Analytical.Building.Interfaces.IConstruction<DiGi.Analytical.Building.Interfaces.IFloor>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject') → [PhysicalComponentConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstruction 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstruction') → [DiGi\.Analytical\.Building\.Classes\.ComponentConstruction&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>')[DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>') → FloorConstruction

Implements [DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloorconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction\`1')[DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingdescribableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction\`1')[DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.FloorConstruction.FloorConstruction()'></a>

## FloorConstruction\(\) Constructor

Initializes a new instance of the [FloorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FloorConstruction 'DiGi\.Analytical\.Building\.Classes\.FloorConstruction') class\.

```csharp
public FloorConstruction();
```

<a name='DiGi.Analytical.Building.Classes.FloorConstruction.FloorConstruction(DiGi.Analytical.Building.Classes.FloorConstruction)'></a>

## FloorConstruction\(FloorConstruction\) Constructor

Initializes a new instance of the [FloorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FloorConstruction 'DiGi\.Analytical\.Building\.Classes\.FloorConstruction') class using the specified existing construction\.

```csharp
public FloorConstruction(DiGi.Analytical.Building.Classes.FloorConstruction? floorConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.FloorConstruction.FloorConstruction(DiGi.Analytical.Building.Classes.FloorConstruction).floorConstruction'></a>

`floorConstruction` [FloorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FloorConstruction 'DiGi\.Analytical\.Building\.Classes\.FloorConstruction')

The source [FloorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FloorConstruction 'DiGi\.Analytical\.Building\.Classes\.FloorConstruction') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.FloorConstruction.FloorConstruction(System.Guid,DiGi.Analytical.Building.Classes.FloorConstruction)'></a>

## FloorConstruction\(Guid, FloorConstruction\) Constructor

Initializes a new instance of the [FloorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FloorConstruction 'DiGi\.Analytical\.Building\.Classes\.FloorConstruction') class with a specified unique identifier and an optional existing construction\.

```csharp
public FloorConstruction(System.Guid guid, DiGi.Analytical.Building.Classes.FloorConstruction? floorConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.FloorConstruction.FloorConstruction(System.Guid,DiGi.Analytical.Building.Classes.FloorConstruction).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the floor construction\.

<a name='DiGi.Analytical.Building.Classes.FloorConstruction.FloorConstruction(System.Guid,DiGi.Analytical.Building.Classes.FloorConstruction).floorConstruction'></a>

`floorConstruction` [FloorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FloorConstruction 'DiGi\.Analytical\.Building\.Classes\.FloorConstruction')

An optional [FloorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FloorConstruction 'DiGi\.Analytical\.Building\.Classes\.FloorConstruction') instance to initialize from\.

<a name='DiGi.Analytical.Building.Classes.FloorConstruction.FloorConstruction(System.Text.Json.Nodes.JsonObject)'></a>

## FloorConstruction\(JsonObject\) Constructor

Initializes a new instance of the [FloorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FloorConstruction 'DiGi\.Analytical\.Building\.Classes\.FloorConstruction') class using the specified JSON object\.

```csharp
public FloorConstruction(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.FloorConstruction.FloorConstruction(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the floor construction properties\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation'></a>

## FrameOpeningConstructionStructureLayersRelation Class

Represents the relation between a frame opening construction and its associated structure layers\.

```csharp
public class FrameOpeningConstructionStructureLayersRelation : DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2') → [DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_ 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>')[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_ 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>') → [OpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionStructureLayersRelation') → FrameOpeningConstructionStructureLayersRelation
### Constructors

<a name='DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation.FrameOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation)'></a>

## FrameOpeningConstructionStructureLayersRelation\(FrameOpeningConstructionStructureLayersRelation\) Constructor

Initializes a new instance of the [FrameOpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.FrameOpeningConstructionStructureLayersRelation') class using an existing instance\.

```csharp
public FrameOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation? frameOpeningConstructionStructureLayersRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation.FrameOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation).frameOpeningConstructionStructureLayersRelation'></a>

`frameOpeningConstructionStructureLayersRelation` [FrameOpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.FrameOpeningConstructionStructureLayersRelation')

The source relation instance to copy\.

<a name='DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation.FrameOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer)'></a>

## FrameOpeningConstructionStructureLayersRelation\(IOpeningConstruction, IStructureLayer\) Constructor

Initializes a new instance of the [FrameOpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.FrameOpeningConstructionStructureLayersRelation') class\.

```csharp
public FrameOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction? openingConstruction, DiGi.Analytical.Building.Interfaces.IStructureLayer? structureLayer);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation.FrameOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer).openingConstruction'></a>

`openingConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')

The opening construction associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation.FrameOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer).structureLayer'></a>

`structureLayer` [DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')

The structure layer associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation.FrameOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IStructureLayer_)'></a>

## FrameOpeningConstructionStructureLayersRelation\(IOpeningConstruction, IEnumerable\<IStructureLayer\>\) Constructor

Initializes a new instance of the [FrameOpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.FrameOpeningConstructionStructureLayersRelation') class\.

```csharp
public FrameOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction? openingConstruction, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Interfaces.IStructureLayer>? structureLayers);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation.FrameOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IStructureLayer_).openingConstruction'></a>

`openingConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')

The opening construction associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation.FrameOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IStructureLayer_).structureLayers'></a>

`structureLayers` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of structure layers associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation.FrameOpeningConstructionStructureLayersRelation(System.Text.Json.Nodes.JsonObject)'></a>

## FrameOpeningConstructionStructureLayersRelation\(JsonObject\) Constructor

Initializes a new instance of the [FrameOpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.FrameOpeningConstructionStructureLayersRelation') class from the specified JSON object\.

```csharp
public FrameOpeningConstructionStructureLayersRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation.FrameOpeningConstructionStructureLayersRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to populate the properties of the relation\.

<a name='DiGi.Analytical.Building.Classes.InternalCondition'></a>

## InternalCondition Class

Represents the internal condition of a building object, containing descriptive information about its current state\.

```csharp
public class InternalCondition : DiGi.Analytical.Building.Classes.BuildingObject, DiGi.Analytical.Building.Interfaces.IInternalCondition, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject, DiGi.Core.Parameter.Interfaces.IParametrizedObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → InternalCondition

Implements [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizedobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.InternalCondition.InternalCondition(DiGi.Analytical.Building.Classes.InternalCondition)'></a>

## InternalCondition\(InternalCondition\) Constructor

Initializes a new instance of the [InternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalCondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition') class using an existing [InternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalCondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition') instance\.

```csharp
public InternalCondition(DiGi.Analytical.Building.Classes.InternalCondition? internalCondition);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.InternalCondition.InternalCondition(DiGi.Analytical.Building.Classes.InternalCondition).internalCondition'></a>

`internalCondition` [InternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalCondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition')

The source [InternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalCondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition') instance to copy values from\.

<a name='DiGi.Analytical.Building.Classes.InternalCondition.InternalCondition(string)'></a>

## InternalCondition\(string\) Constructor

Initializes a new instance of the [InternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalCondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition') class with the specified name\.

```csharp
public InternalCondition(string? name);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.InternalCondition.InternalCondition(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the internal condition\.

<a name='DiGi.Analytical.Building.Classes.InternalCondition.InternalCondition(System.Guid,DiGi.Analytical.Building.Classes.InternalCondition)'></a>

## InternalCondition\(Guid, InternalCondition\) Constructor

Initializes a new instance of the [InternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalCondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition') class using a specified unique identifier and an optional existing condition to copy values from\.

```csharp
public InternalCondition(System.Guid guid, DiGi.Analytical.Building.Classes.InternalCondition? internalCondition);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.InternalCondition.InternalCondition(System.Guid,DiGi.Analytical.Building.Classes.InternalCondition).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the internal condition\.

<a name='DiGi.Analytical.Building.Classes.InternalCondition.InternalCondition(System.Guid,DiGi.Analytical.Building.Classes.InternalCondition).internalCondition'></a>

`internalCondition` [InternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalCondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition')

An optional [InternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalCondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition') instance used to initialize the properties of the new instance\.

<a name='DiGi.Analytical.Building.Classes.InternalCondition.InternalCondition(System.Text.Json.Nodes.JsonObject)'></a>

## InternalCondition\(JsonObject\) Constructor

Initializes a new instance of the [InternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalCondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public InternalCondition(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.InternalCondition.InternalCondition(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.
### Properties

<a name='DiGi.Analytical.Building.Classes.InternalCondition.Description'></a>

## InternalCondition\.Description Property

Gets or sets the description of the internal condition\.

```csharp
public string? Description { get; set; }
```

Implements [Description](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition.description 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition\.Description')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.Classes.InternalCondition.Name'></a>

## InternalCondition\.Name Property

Gets or sets the name of the internal condition\.

```csharp
public string? Name { get; set; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.Classes.InternalConditionsFile'></a>

## InternalConditionsFile Class

Represents a storage file specifically designed to manage and persist a collection of internal conditions\.

```csharp
public class InternalConditionsFile : DiGi.Core.IO.File.Classes.StorageFile<DiGi.Analytical.Building.Interfaces.IInternalCondition>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.IO\.File\.Classes\.File](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.file 'DiGi\.Core\.IO\.File\.Classes\.File') → [DiGi\.Core\.IO\.File\.Classes\.StorageFile&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1')[DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1') → InternalConditionsFile
### Constructors

<a name='DiGi.Analytical.Building.Classes.InternalConditionsFile.InternalConditionsFile(DiGi.Analytical.Building.Classes.InternalConditionsFile)'></a>

## InternalConditionsFile\(InternalConditionsFile\) Constructor

Initializes a new instance of the [InternalConditionsFile](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalConditionsFile 'DiGi\.Analytical\.Building\.Classes\.InternalConditionsFile') class using an existing [InternalConditionsFile](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalConditionsFile 'DiGi\.Analytical\.Building\.Classes\.InternalConditionsFile') instance\.

```csharp
public InternalConditionsFile(DiGi.Analytical.Building.Classes.InternalConditionsFile? internalConditionsFile);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.InternalConditionsFile.InternalConditionsFile(DiGi.Analytical.Building.Classes.InternalConditionsFile).internalConditionsFile'></a>

`internalConditionsFile` [InternalConditionsFile](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalConditionsFile 'DiGi\.Analytical\.Building\.Classes\.InternalConditionsFile')

The source [InternalConditionsFile](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalConditionsFile 'DiGi\.Analytical\.Building\.Classes\.InternalConditionsFile') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.InternalConditionsFile.InternalConditionsFile(string)'></a>

## InternalConditionsFile\(string\) Constructor

Initializes a new instance of the [InternalConditionsFile](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalConditionsFile 'DiGi\.Analytical\.Building\.Classes\.InternalConditionsFile') class using the specified file path\.

```csharp
public InternalConditionsFile(string? path);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.InternalConditionsFile.InternalConditionsFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the internal conditions file\.

<a name='DiGi.Analytical.Building.Classes.InternalConditionsFile.InternalConditionsFile(System.Text.Json.Nodes.JsonObject)'></a>

## InternalConditionsFile\(JsonObject\) Constructor

Initializes a new instance of the [InternalConditionsFile](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.InternalConditionsFile 'DiGi\.Analytical\.Building\.Classes\.InternalConditionsFile') class using the specified JSON object\.

```csharp
public InternalConditionsFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.InternalConditionsFile.InternalConditionsFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data for the internal conditions file\.
### Methods

<a name='DiGi.Analytical.Building.Classes.InternalConditionsFile.GetUniqueReference(DiGi.Analytical.Building.Interfaces.IInternalCondition)'></a>

## InternalConditionsFile\.GetUniqueReference\(IInternalCondition\) Method

Retrieves the unique reference for the specified internal condition\.

```csharp
public override DiGi.Core.Classes.UniqueReference? GetUniqueReference(DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.InternalConditionsFile.GetUniqueReference(DiGi.Analytical.Building.Interfaces.IInternalCondition).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition to retrieve the reference for\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
The unique reference associated with the specified internal condition, or null\.

<a name='DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation'></a>

## MaterialStructureLayerRelation Class

Represents a one\-to\-one bidirectional relation between a material and a structure layer\.

```csharp
public class MaterialStructureLayerRelation : DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation<DiGi.Analytical.Interfaces.IMaterial, DiGi.Analytical.Building.Interfaces.IStructureLayer>, DiGi.Analytical.Building.Interfaces.IBuildingRelation, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Interfaces\.IMaterial](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.imaterial 'DiGi\.Analytical\.Interfaces\.IMaterial')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[DiGi\.Analytical\.Interfaces\.IMaterial](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.imaterial 'DiGi\.Analytical\.Interfaces\.IMaterial')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2')[DiGi\.Analytical\.Interfaces\.IMaterial](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.imaterial 'DiGi\.Analytical\.Interfaces\.IMaterial')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2') → MaterialStructureLayerRelation

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingrelation 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation.MaterialStructureLayerRelation(DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation)'></a>

## MaterialStructureLayerRelation\(MaterialStructureLayerRelation\) Constructor

Initializes a new instance of the [MaterialStructureLayerRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation 'DiGi\.Analytical\.Building\.Classes\.MaterialStructureLayerRelation') class using an existing relation instance\.

```csharp
public MaterialStructureLayerRelation(DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation? materialStructureLayerRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation.MaterialStructureLayerRelation(DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation).materialStructureLayerRelation'></a>

`materialStructureLayerRelation` [MaterialStructureLayerRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation 'DiGi\.Analytical\.Building\.Classes\.MaterialStructureLayerRelation')

The source [MaterialStructureLayerRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation 'DiGi\.Analytical\.Building\.Classes\.MaterialStructureLayerRelation') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation.MaterialStructureLayerRelation(DiGi.Analytical.Interfaces.IMaterial,DiGi.Analytical.Building.Interfaces.IStructureLayer)'></a>

## MaterialStructureLayerRelation\(IMaterial, IStructureLayer\) Constructor

Initializes a new instance of the [MaterialStructureLayerRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation 'DiGi\.Analytical\.Building\.Classes\.MaterialStructureLayerRelation') class\.

```csharp
public MaterialStructureLayerRelation(DiGi.Analytical.Interfaces.IMaterial? material, DiGi.Analytical.Building.Interfaces.IStructureLayer? structureLayer);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation.MaterialStructureLayerRelation(DiGi.Analytical.Interfaces.IMaterial,DiGi.Analytical.Building.Interfaces.IStructureLayer).material'></a>

`material` [DiGi\.Analytical\.Interfaces\.IMaterial](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.imaterial 'DiGi\.Analytical\.Interfaces\.IMaterial')

The material to be associated with the structure layer\.

<a name='DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation.MaterialStructureLayerRelation(DiGi.Analytical.Interfaces.IMaterial,DiGi.Analytical.Building.Interfaces.IStructureLayer).structureLayer'></a>

`structureLayer` [DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')

The structure layer to be associated with the material\.

<a name='DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation.MaterialStructureLayerRelation(System.Text.Json.Nodes.JsonObject)'></a>

## MaterialStructureLayerRelation\(JsonObject\) Constructor

Initializes a new instance of the [MaterialStructureLayerRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation 'DiGi\.Analytical\.Building\.Classes\.MaterialStructureLayerRelation') class from the specified JSON object\.

```csharp
public MaterialStructureLayerRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.MaterialStructureLayerRelation.MaterialStructureLayerRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the relation\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction'></a>

## OpeningConstruction Class

Represents an abstract base class for opening constructions in a building, providing functionality for managing the geometric properties of an opening associated with a 2D surface\.

```csharp
public abstract class OpeningConstruction : DiGi.Analytical.Building.Classes.BuildingGeometry2DObject<DiGi.Geometry.Planar.Interfaces.ISurface2D>, DiGi.Analytical.Building.Interfaces.IOpeningConstruction, DiGi.Analytical.Building.Interfaces.IGeometry2DConstruction, DiGi.Analytical.Building.Interfaces.IConstruction, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject, DiGi.Analytical.Building.Interfaces.IBuildingDescribableObject, DiGi.Core.Interfaces.IDescribableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject') → [DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>') → OpeningConstruction

Derived  
↳ [OpeningConstruction&lt;TOpening&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_ 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction\<TOpening\>')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingdescribableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction.OpeningConstruction(DiGi.Analytical.Building.Classes.OpeningConstruction)'></a>

## OpeningConstruction\(OpeningConstruction\) Constructor

Initializes a new instance of the [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction') class by copying an existing instance\.

```csharp
public OpeningConstruction(DiGi.Analytical.Building.Classes.OpeningConstruction? openingConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction.OpeningConstruction(DiGi.Analytical.Building.Classes.OpeningConstruction).openingConstruction'></a>

`openingConstruction` [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction')

The source [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction') object to copy from\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction.OpeningConstruction(string,DiGi.Geometry.Planar.Interfaces.ISurface2D)'></a>

## OpeningConstruction\(string, ISurface2D\) Constructor

Initializes a new instance of the [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction') class\.

```csharp
public OpeningConstruction(string? name, DiGi.Geometry.Planar.Interfaces.ISurface2D? surface2D);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction.OpeningConstruction(string,DiGi.Geometry.Planar.Interfaces.ISurface2D).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the opening construction\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction.OpeningConstruction(string,DiGi.Geometry.Planar.Interfaces.ISurface2D).surface2D'></a>

`surface2D` [DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')

The 2D surface associated with the opening construction\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction.OpeningConstruction(System.Guid,DiGi.Analytical.Building.Classes.OpeningConstruction)'></a>

## OpeningConstruction\(Guid, OpeningConstruction\) Constructor

Initializes a new instance of the [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction') class with a specified unique identifier and an optional existing construction object\.

```csharp
public OpeningConstruction(System.Guid guid, DiGi.Analytical.Building.Classes.OpeningConstruction? openingConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction.OpeningConstruction(System.Guid,DiGi.Analytical.Building.Classes.OpeningConstruction).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the opening construction\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction.OpeningConstruction(System.Guid,DiGi.Analytical.Building.Classes.OpeningConstruction).openingConstruction'></a>

`openingConstruction` [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction')

An optional existing [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction') instance to initialize from\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction.OpeningConstruction(System.Text.Json.Nodes.JsonObject)'></a>

## OpeningConstruction\(JsonObject\) Constructor

Initializes a new instance of the [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public OpeningConstruction(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction.OpeningConstruction(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the object\. This value can be null\.
### Properties

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction.Description'></a>

## OpeningConstruction\.Description Property

Gets or sets the description of the opening construction\.

```csharp
public string? Description { get; set; }
```

Implements [Description](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject.description 'DiGi\.Core\.Interfaces\.IDescribableObject\.Description')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction.Name'></a>

## OpeningConstruction\.Name Property

Gets or sets the name of the opening construction\.

```csharp
public string? Name { get; set; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_'></a>

## OpeningConstruction\<TOpening\> Class

Represents an abstract base class for a construction of an opening, providing generic support for a specific opening type\.

```csharp
public abstract class OpeningConstruction<TOpening> : DiGi.Analytical.Building.Classes.OpeningConstruction, DiGi.Analytical.Building.Interfaces.IOpeningConstruction<TOpening>, DiGi.Analytical.Building.Interfaces.IOpeningConstruction, DiGi.Analytical.Building.Interfaces.IGeometry2DConstruction, DiGi.Analytical.Building.Interfaces.IConstruction, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject, DiGi.Analytical.Building.Interfaces.IBuildingDescribableObject, DiGi.Core.Interfaces.IDescribableObject, DiGi.Analytical.Building.Interfaces.IGeometry2DConstruction<TOpening, DiGi.Geometry.Planar.Interfaces.ISurface2D>, DiGi.Analytical.Building.Interfaces.IGeometry2DConstruction<TOpening>, DiGi.Analytical.Building.Interfaces.IConstruction<TOpening>
    where TOpening : DiGi.Analytical.Building.Interfaces.IOpening
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_.TOpening'></a>

`TOpening`

The type of the opening associated with this construction, which must implement [DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject') → [DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>') → [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction') → OpeningConstruction\<TOpening\>

Derived  
↳ [DoorConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.DoorConstruction 'DiGi\.Analytical\.Building\.Classes\.DoorConstruction')  
↳ [WindowConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WindowConstruction 'DiGi\.Analytical\.Building\.Classes\.WindowConstruction')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction\`1')[TOpening](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_.TOpening 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction\<TOpening\>\.TOpening')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingdescribableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction-2 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction\`2')[TOpening](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_.TOpening 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction\<TOpening\>\.TOpening')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction-2 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction\`2')[DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction-2 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction\`2'), [DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction\`1')[TOpening](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_.TOpening 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction\<TOpening\>\.TOpening')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction\`1')[TOpening](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_.TOpening 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction\<TOpening\>\.TOpening')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_.OpeningConstruction(DiGi.Analytical.Building.Classes.OpeningConstruction)'></a>

## OpeningConstruction\(OpeningConstruction\) Constructor

Initializes a new instance of the [OpeningConstruction&lt;TOpening&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_ 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction\<TOpening\>') class using an existing [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction') object\.

```csharp
public OpeningConstruction(DiGi.Analytical.Building.Classes.OpeningConstruction? openingConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_.OpeningConstruction(DiGi.Analytical.Building.Classes.OpeningConstruction).openingConstruction'></a>

`openingConstruction` [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction')

The source [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction') object to copy from\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_.OpeningConstruction(string,DiGi.Geometry.Planar.Interfaces.ISurface2D)'></a>

## OpeningConstruction\(string, ISurface2D\) Constructor

Initializes a new instance of the [OpeningConstruction&lt;TOpening&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_ 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction\<TOpening\>') class\.

```csharp
public OpeningConstruction(string? name, DiGi.Geometry.Planar.Interfaces.ISurface2D? surface2D);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_.OpeningConstruction(string,DiGi.Geometry.Planar.Interfaces.ISurface2D).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional name of the opening construction\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_.OpeningConstruction(string,DiGi.Geometry.Planar.Interfaces.ISurface2D).surface2D'></a>

`surface2D` [DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')

The optional 2D surface associated with the opening construction\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_.OpeningConstruction(System.Guid,DiGi.Analytical.Building.Classes.OpeningConstruction)'></a>

## OpeningConstruction\(Guid, OpeningConstruction\) Constructor

Initializes a new instance of the [OpeningConstruction&lt;TOpening&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_ 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction\<TOpening\>') class using the specified unique identifier and an existing opening construction\.

```csharp
public OpeningConstruction(System.Guid guid, DiGi.Analytical.Building.Classes.OpeningConstruction? openingConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_.OpeningConstruction(System.Guid,DiGi.Analytical.Building.Classes.OpeningConstruction).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the object\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_.OpeningConstruction(System.Guid,DiGi.Analytical.Building.Classes.OpeningConstruction).openingConstruction'></a>

`openingConstruction` [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction')

An optional existing opening construction instance used to initialize the current instance\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_.OpeningConstruction(System.Text.Json.Nodes.JsonObject)'></a>

## OpeningConstruction\(JsonObject\) Constructor

Initializes a new instance of the [OpeningConstruction&lt;TOpening&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_ 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction\<TOpening\>') class from the specified JSON object\.

```csharp
public OpeningConstruction(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_.OpeningConstruction(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the instance\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionRelation'></a>

## OpeningConstructionRelation Class

Represents a one\-to\-one bidirectional relation between an opening and an opening construction\.

```csharp
public class OpeningConstructionRelation : DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation<DiGi.Analytical.Building.Interfaces.IOpening, DiGi.Analytical.Building.Interfaces.IOpeningConstruction>, DiGi.Analytical.Building.Interfaces.IBuildingRelation, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2') → OpeningConstructionRelation

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingrelation 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionRelation.OpeningConstructionRelation(DiGi.Analytical.Building.Classes.OpeningConstructionRelation)'></a>

## OpeningConstructionRelation\(OpeningConstructionRelation\) Constructor

Initializes a new instance of the [OpeningConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionRelation') class based on an existing relation instance\.

```csharp
public OpeningConstructionRelation(DiGi.Analytical.Building.Classes.OpeningConstructionRelation? openingConstructionRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionRelation.OpeningConstructionRelation(DiGi.Analytical.Building.Classes.OpeningConstructionRelation).openingConstructionRelation'></a>

`openingConstructionRelation` [OpeningConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionRelation')

The existing [OpeningConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionRelation') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionRelation.OpeningConstructionRelation(DiGi.Analytical.Building.Interfaces.IOpening,DiGi.Analytical.Building.Interfaces.IOpeningConstruction)'></a>

## OpeningConstructionRelation\(IOpening, IOpeningConstruction\) Constructor

Initializes a new instance of the [OpeningConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionRelation') class\.

```csharp
public OpeningConstructionRelation(DiGi.Analytical.Building.Interfaces.IOpening? opening, DiGi.Analytical.Building.Interfaces.IOpeningConstruction? openingConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionRelation.OpeningConstructionRelation(DiGi.Analytical.Building.Interfaces.IOpening,DiGi.Analytical.Building.Interfaces.IOpeningConstruction).opening'></a>

`opening` [DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')

The opening associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionRelation.OpeningConstructionRelation(DiGi.Analytical.Building.Interfaces.IOpening,DiGi.Analytical.Building.Interfaces.IOpeningConstruction).openingConstruction'></a>

`openingConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')

The opening construction associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionRelation.OpeningConstructionRelation(System.Text.Json.Nodes.JsonObject)'></a>

## OpeningConstructionRelation\(JsonObject\) Constructor

Initializes a new instance of the [OpeningConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionRelation') class from the specified JSON object\.

```csharp
public OpeningConstructionRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionRelation.OpeningConstructionRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the serialized data used to initialize the relation\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation'></a>

## OpeningConstructionStructureLayersRelation Class

Represents the relationship between an opening construction and its associated structure layers\.

```csharp
public abstract class OpeningConstructionStructureLayersRelation : DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation<DiGi.Analytical.Building.Interfaces.IOpeningConstruction>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2') → [DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_ 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>')[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_ 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>') → OpeningConstructionStructureLayersRelation

Derived  
↳ [FrameOpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FrameOpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.FrameOpeningConstructionStructureLayersRelation')  
↳ [PaneOpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.PaneOpeningConstructionStructureLayersRelation')
### Constructors

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation.OpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation)'></a>

## OpeningConstructionStructureLayersRelation\(OpeningConstructionStructureLayersRelation\) Constructor

Initializes a new instance of the [OpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionStructureLayersRelation') class based on an existing relation\.

```csharp
public OpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation? openingConstructionStructureLayersRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation.OpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation).openingConstructionStructureLayersRelation'></a>

`openingConstructionStructureLayersRelation` [OpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionStructureLayersRelation')

The source relation used to initialize the new instance\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation.OpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer)'></a>

## OpeningConstructionStructureLayersRelation\(IOpeningConstruction, IStructureLayer\) Constructor

Initializes a new instance of the [OpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionStructureLayersRelation') class using the specified opening construction and structure layer\.

```csharp
public OpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction? openingConstruction, DiGi.Analytical.Building.Interfaces.IStructureLayer? structureLayer);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation.OpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer).openingConstruction'></a>

`openingConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')

The opening construction associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation.OpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer).structureLayer'></a>

`structureLayer` [DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')

The structure layer associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation.OpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IStructureLayer_)'></a>

## OpeningConstructionStructureLayersRelation\(IOpeningConstruction, IEnumerable\<IStructureLayer\>\) Constructor

Initializes a new instance of the [OpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionStructureLayersRelation') class using the specified opening construction and a collection of structure layers\.

```csharp
public OpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction? openingConstruction, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Interfaces.IStructureLayer>? structureLayers);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation.OpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IStructureLayer_).openingConstruction'></a>

`openingConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')

The opening construction associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation.OpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IStructureLayer_).structureLayers'></a>

`structureLayers` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of structure layers associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation.OpeningConstructionStructureLayersRelation(System.Text.Json.Nodes.JsonObject)'></a>

## OpeningConstructionStructureLayersRelation\(JsonObject\) Constructor

Initializes a new instance of the [OpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionStructureLayersRelation') class from the specified JSON object\.

```csharp
public OpeningConstructionStructureLayersRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation.OpeningConstructionStructureLayersRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the instance\.

<a name='DiGi.Analytical.Building.Classes.OpeningRelation'></a>

## OpeningRelation Class

Represents a bidirectional one\-to\-many relationship between a building component and its associated openings\.

```csharp
public class OpeningRelation : DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation<DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IOpening>, DiGi.Analytical.Building.Interfaces.IBuildingRelation, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2') → OpeningRelation

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingrelation 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.OpeningRelation.OpeningRelation(DiGi.Analytical.Building.Classes.OpeningRelation)'></a>

## OpeningRelation\(OpeningRelation\) Constructor

Initializes a new instance of the [OpeningRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningRelation') class by copying an existing relation\.

```csharp
public OpeningRelation(DiGi.Analytical.Building.Classes.OpeningRelation? openingRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningRelation.OpeningRelation(DiGi.Analytical.Building.Classes.OpeningRelation).openingRelation'></a>

`openingRelation` [OpeningRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningRelation')

The source [OpeningRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningRelation') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.OpeningRelation.OpeningRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.IOpening)'></a>

## OpeningRelation\(IComponent, IOpening\) Constructor

Initializes a new instance of the [OpeningRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningRelation') class with the specified component and opening\.

```csharp
public OpeningRelation(DiGi.Analytical.Building.Interfaces.IComponent? component, DiGi.Analytical.Building.Interfaces.IOpening? opening);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningRelation.OpeningRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.IOpening).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The component associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.OpeningRelation.OpeningRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.IOpening).opening'></a>

`opening` [DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')

The opening associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.OpeningRelation.OpeningRelation(DiGi.Analytical.Building.Interfaces.IComponent,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IOpening_)'></a>

## OpeningRelation\(IComponent, IEnumerable\<IOpening\>\) Constructor

Initializes a new instance of the [OpeningRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningRelation') class using the specified component and collection of openings\.

```csharp
public OpeningRelation(DiGi.Analytical.Building.Interfaces.IComponent? component, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Interfaces.IOpening>? openings);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningRelation.OpeningRelation(DiGi.Analytical.Building.Interfaces.IComponent,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IOpening_).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The component associated with this opening relation\.

<a name='DiGi.Analytical.Building.Classes.OpeningRelation.OpeningRelation(DiGi.Analytical.Building.Interfaces.IComponent,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IOpening_).openings'></a>

`openings` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of openings associated with this opening relation\.

<a name='DiGi.Analytical.Building.Classes.OpeningRelation.OpeningRelation(System.Text.Json.Nodes.JsonObject)'></a>

## OpeningRelation\(JsonObject\) Constructor

Initializes a new instance of the [OpeningRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningRelation') class from the specified JSON object\.

```csharp
public OpeningRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.OpeningRelation.OpeningRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the serialized data used to populate the relation\.

<a name='DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation'></a>

## PaneOpeningConstructionStructureLayersRelation Class

Represents the relationship between a pane opening construction and its associated structure layers\.

```csharp
public class PaneOpeningConstructionStructureLayersRelation : DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2') → [DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_ 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>')[DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_ 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>') → [OpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.OpeningConstructionStructureLayersRelation') → PaneOpeningConstructionStructureLayersRelation
### Constructors

<a name='DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation.PaneOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation)'></a>

## PaneOpeningConstructionStructureLayersRelation\(PaneOpeningConstructionStructureLayersRelation\) Constructor

Initializes a new instance of the [PaneOpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.PaneOpeningConstructionStructureLayersRelation') class using an existing instance\.

```csharp
public PaneOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation? paneOpeningConstructionStructureLayersRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation.PaneOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation).paneOpeningConstructionStructureLayersRelation'></a>

`paneOpeningConstructionStructureLayersRelation` [PaneOpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.PaneOpeningConstructionStructureLayersRelation')

The source relation instance to copy\.

<a name='DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation.PaneOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer)'></a>

## PaneOpeningConstructionStructureLayersRelation\(IOpeningConstruction, IStructureLayer\) Constructor

Initializes a new instance of the [PaneOpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.PaneOpeningConstructionStructureLayersRelation') class using the specified opening construction and structure layer\.

```csharp
public PaneOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction? openingConstruction, DiGi.Analytical.Building.Interfaces.IStructureLayer? structureLayer);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation.PaneOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer).openingConstruction'></a>

`openingConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')

The opening construction associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation.PaneOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer).structureLayer'></a>

`structureLayer` [DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')

The structure layer associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation.PaneOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IStructureLayer_)'></a>

## PaneOpeningConstructionStructureLayersRelation\(IOpeningConstruction, IEnumerable\<IStructureLayer\>\) Constructor

Initializes a new instance of the [PaneOpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.PaneOpeningConstructionStructureLayersRelation') class using the specified opening construction and structure layers\.

```csharp
public PaneOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction? openingConstruction, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Interfaces.IStructureLayer>? structureLayers);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation.PaneOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IStructureLayer_).openingConstruction'></a>

`openingConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')

The opening construction associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation.PaneOpeningConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IOpeningConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IStructureLayer_).structureLayers'></a>

`structureLayers` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of structure layers associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation.PaneOpeningConstructionStructureLayersRelation(System.Text.Json.Nodes.JsonObject)'></a>

## PaneOpeningConstructionStructureLayersRelation\(JsonObject\) Constructor

Initializes a new instance of the [PaneOpeningConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.PaneOpeningConstructionStructureLayersRelation') class using the specified JSON object\.

```csharp
public PaneOpeningConstructionStructureLayersRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PaneOpeningConstructionStructureLayersRelation.PaneOpeningConstructionStructureLayersRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object from which to initialize the relation\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent'></a>

## PhysicalComponent Class

Represents an abstract base class for all physical components within the analytical building model, providing core functionality for structural positioning and identity\.

```csharp
public abstract class PhysicalComponent : DiGi.Analytical.Building.Classes.Component, DiGi.Analytical.Building.Interfaces.IPhysicalComponent, DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IBuildingBoundable3D, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IConstructable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') → PhysicalComponent

Derived  
↳ [PhysicalComponent&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstructable](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstructable 'DiGi\.Analytical\.Building\.Interfaces\.IConstructable')
### Constructors

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent.PhysicalComponent()'></a>

## PhysicalComponent\(\) Constructor

Initializes a new instance of the [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') class\.

```csharp
public PhysicalComponent();
```

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent.PhysicalComponent(DiGi.Analytical.Building.Classes.PhysicalComponent)'></a>

## PhysicalComponent\(PhysicalComponent\) Constructor

Initializes a new instance of the [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') class using an existing physical component\.

```csharp
public PhysicalComponent(DiGi.Analytical.Building.Classes.PhysicalComponent? physicalComponent);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent.PhysicalComponent(DiGi.Analytical.Building.Classes.PhysicalComponent).physicalComponent'></a>

`physicalComponent` [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent')

The source [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') to copy properties from\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent.PhysicalComponent(System.Guid)'></a>

## PhysicalComponent\(Guid\) Constructor

Initializes a new instance of the [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') class using the specified unique identifier\.

```csharp
public PhysicalComponent(System.Guid guid);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent.PhysicalComponent(System.Guid).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the physical component\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent.PhysicalComponent(System.Guid,DiGi.Analytical.Building.Classes.PhysicalComponent)'></a>

## PhysicalComponent\(Guid, PhysicalComponent\) Constructor

Initializes a new instance of the [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') class using a specified unique identifier and an optional existing physical component\.

```csharp
public PhysicalComponent(System.Guid guid, DiGi.Analytical.Building.Classes.PhysicalComponent? physicalComponent);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent.PhysicalComponent(System.Guid,DiGi.Analytical.Building.Classes.PhysicalComponent).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the physical component\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent.PhysicalComponent(System.Guid,DiGi.Analytical.Building.Classes.PhysicalComponent).physicalComponent'></a>

`physicalComponent` [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent')

An optional [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') instance to initialize from\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent.PhysicalComponent(System.Text.Json.Nodes.JsonObject)'></a>

## PhysicalComponent\(JsonObject\) Constructor

Initializes a new instance of the [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') class using the specified JSON object\.

```csharp
public PhysicalComponent(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent.PhysicalComponent(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the component; can be null\.
### Properties

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent.StructurePosition'></a>

## PhysicalComponent\.StructurePosition Property

Gets or sets the position of the physical component within the structure\.

```csharp
public DiGi.Analytical.Building.Enums.StructurePosition StructurePosition { get; set; }
```

Implements [StructurePosition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent.structureposition 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent\.StructurePosition')

#### Property Value
[StructurePosition](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.StructurePosition 'DiGi\.Analytical\.Building\.Enums\.StructurePosition')

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent_T_'></a>

## PhysicalComponent\<T\> Class

Represents an abstract base class for components that possess a physical presence and spatial positioning within a structure\.

```csharp
public abstract class PhysicalComponent<T> : DiGi.Analytical.Building.Classes.PhysicalComponent, DiGi.Analytical.Building.Interfaces.IPhysicalComponent<T>, DiGi.Analytical.Building.Interfaces.IPhysicalComponent, DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IBuildingBoundable3D, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IConstructable, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject<T>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<T>
    where T : DiGi.Geometry.Spatial.Interfaces.IGeometry3D
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent_T_.T'></a>

`T`

The type of 3D geometry\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') → [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') → PhysicalComponent\<T\>

Derived  
↳ [Floor&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Floor_T_ 'DiGi\.Analytical\.Building\.Classes\.Floor\<T\>')  
↳ [Roof&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_ 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>')  
↳ [Wall&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstructable](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstructable 'DiGi\.Analytical\.Building\.Interfaces\.IConstructable'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent_T_.PhysicalComponent(DiGi.Analytical.Building.Classes.PhysicalComponent,T)'></a>

## PhysicalComponent\(PhysicalComponent, T\) Constructor

Initializes a new instance of the [PhysicalComponent&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>') class using an existing physical component and a specific geometry\.

```csharp
public PhysicalComponent(DiGi.Analytical.Building.Classes.PhysicalComponent? physicalComponent, T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent_T_.PhysicalComponent(DiGi.Analytical.Building.Classes.PhysicalComponent,T).physicalComponent'></a>

`physicalComponent` [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent')

The source physical component to copy properties from\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent_T_.PhysicalComponent(DiGi.Analytical.Building.Classes.PhysicalComponent,T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>\.T')

The geometry to assign to the new component\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent_T_.PhysicalComponent(DiGi.Analytical.Building.Classes.PhysicalComponent_T_)'></a>

## PhysicalComponent\(PhysicalComponent\<T\>\) Constructor

Initializes a new instance of the [PhysicalComponent&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>') class by copying the properties and geometry from an existing physical component\.

```csharp
public PhysicalComponent(DiGi.Analytical.Building.Classes.PhysicalComponent<T>? physicalComponent);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent_T_.PhysicalComponent(DiGi.Analytical.Building.Classes.PhysicalComponent_T_).physicalComponent'></a>

`physicalComponent` [DiGi\.Analytical\.Building\.Classes\.PhysicalComponent&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>')

The source physical component to copy data from\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent_T_.PhysicalComponent(System.Guid,DiGi.Analytical.Building.Classes.PhysicalComponent_T_)'></a>

## PhysicalComponent\(Guid, PhysicalComponent\<T\>\) Constructor

Initializes a new instance of the [PhysicalComponent&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>') class with a specified unique identifier and an optional existing physical component to clone geometry from\.

```csharp
public PhysicalComponent(System.Guid guid, DiGi.Analytical.Building.Classes.PhysicalComponent<T>? physicalComponent);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent_T_.PhysicalComponent(System.Guid,DiGi.Analytical.Building.Classes.PhysicalComponent_T_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the new physical component\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent_T_.PhysicalComponent(System.Guid,DiGi.Analytical.Building.Classes.PhysicalComponent_T_).physicalComponent'></a>

`physicalComponent` [DiGi\.Analytical\.Building\.Classes\.PhysicalComponent&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>')

An optional existing physical component used to initialize the current instance's geometry\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent_T_.PhysicalComponent(System.Text.Json.Nodes.JsonObject)'></a>

## PhysicalComponent\(JsonObject\) Constructor

Initializes a new instance of the [PhysicalComponent&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>') class using the specified JSON object\.

```csharp
public PhysicalComponent(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent_T_.PhysicalComponent(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the component\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent_T_.PhysicalComponent(T)'></a>

## PhysicalComponent\(T\) Constructor

Initializes a new instance of the [PhysicalComponent&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>') class with the specified geometry\.

```csharp
public PhysicalComponent(T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent_T_.PhysicalComponent(T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>\.T')

The geometry to assign to the component; this object is cloned if it is not null\.
### Properties

<a name='DiGi.Analytical.Building.Classes.PhysicalComponent_T_.Geometry'></a>

## PhysicalComponent\<T\>\.Geometry Property

Gets the three\-dimensional geometry of the physical component\.

```csharp
public T? Geometry { get; }
```

Implements [Geometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1.geometry 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1\.Geometry')

#### Property Value
[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_.T 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>\.T')

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstruction'></a>

## PhysicalComponentConstruction Class

Represents the abstract base class for the construction specifications of a physical building component\.

```csharp
public abstract class PhysicalComponentConstruction : DiGi.Analytical.Building.Classes.BuildingNamedObject, DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction, DiGi.Analytical.Building.Interfaces.IConstruction, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject, DiGi.Analytical.Building.Interfaces.IBuildingDescribableObject, DiGi.Core.Interfaces.IDescribableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject') → PhysicalComponentConstruction

Derived  
↳ [ComponentConstruction&lt;TConstructable&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingdescribableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstruction.PhysicalComponentConstruction()'></a>

## PhysicalComponentConstruction\(\) Constructor

Initializes a new instance of the [PhysicalComponentConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstruction 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstruction') class\.

```csharp
public PhysicalComponentConstruction();
```

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstruction.PhysicalComponentConstruction(DiGi.Analytical.Building.Classes.PhysicalComponentConstruction)'></a>

## PhysicalComponentConstruction\(PhysicalComponentConstruction\) Constructor

Initializes a new instance of the [PhysicalComponentConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstruction 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstruction') class using the specified construction object\.

```csharp
public PhysicalComponentConstruction(DiGi.Analytical.Building.Classes.PhysicalComponentConstruction? componentConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstruction.PhysicalComponentConstruction(DiGi.Analytical.Building.Classes.PhysicalComponentConstruction).componentConstruction'></a>

`componentConstruction` [PhysicalComponentConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstruction 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstruction')

The source [PhysicalComponentConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstruction 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstruction') object to copy properties from\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstruction.PhysicalComponentConstruction(System.Guid,DiGi.Analytical.Building.Classes.PhysicalComponentConstruction)'></a>

## PhysicalComponentConstruction\(Guid, PhysicalComponentConstruction\) Constructor

Initializes a new instance of the [PhysicalComponentConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstruction 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstruction') class using a specified unique identifier and an optional source construction object\.

```csharp
public PhysicalComponentConstruction(System.Guid guid, DiGi.Analytical.Building.Classes.PhysicalComponentConstruction? componentConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstruction.PhysicalComponentConstruction(System.Guid,DiGi.Analytical.Building.Classes.PhysicalComponentConstruction).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the physical component construction\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstruction.PhysicalComponentConstruction(System.Guid,DiGi.Analytical.Building.Classes.PhysicalComponentConstruction).componentConstruction'></a>

`componentConstruction` [PhysicalComponentConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstruction 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstruction')

An optional existing [PhysicalComponentConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstruction 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstruction') instance to copy properties from\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstruction.PhysicalComponentConstruction(System.Text.Json.Nodes.JsonObject)'></a>

## PhysicalComponentConstruction\(JsonObject\) Constructor

Initializes a new instance of the [PhysicalComponentConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstruction 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstruction') class using the specified JSON object\.

```csharp
public PhysicalComponentConstruction(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstruction.PhysicalComponentConstruction(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the instance; may be null\.
### Properties

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstruction.Description'></a>

## PhysicalComponentConstruction\.Description Property

Gets or sets the description of the physical component construction\.

```csharp
public string? Description { get; set; }
```

Implements [Description](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject.description 'DiGi\.Core\.Interfaces\.IDescribableObject\.Description')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation'></a>

## PhysicalComponentConstructionRelation Class

Represents a one\-to\-one bidirectional relation between a component and its physical component construction\.

```csharp
public class PhysicalComponentConstructionRelation : DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation<DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction>, DiGi.Analytical.Building.Interfaces.IBuildingRelation, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2') → PhysicalComponentConstructionRelation

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingrelation 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation.PhysicalComponentConstructionRelation(DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation)'></a>

## PhysicalComponentConstructionRelation\(PhysicalComponentConstructionRelation\) Constructor

Initializes a new instance of the [PhysicalComponentConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionRelation') class based on an existing relation instance\.

```csharp
public PhysicalComponentConstructionRelation(DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation? physicalComponentConstructionRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation.PhysicalComponentConstructionRelation(DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation).physicalComponentConstructionRelation'></a>

`physicalComponentConstructionRelation` [PhysicalComponentConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionRelation')

The existing [PhysicalComponentConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionRelation') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation.PhysicalComponentConstructionRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction)'></a>

## PhysicalComponentConstructionRelation\(IComponent, IPhysicalComponentConstruction\) Constructor

Initializes a new instance of the [PhysicalComponentConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionRelation') class\.

```csharp
public PhysicalComponentConstructionRelation(DiGi.Analytical.Building.Interfaces.IComponent? component, DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction? componentConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation.PhysicalComponentConstructionRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The component associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation.PhysicalComponentConstructionRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction).componentConstruction'></a>

`componentConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')

The physical component construction associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation.PhysicalComponentConstructionRelation(System.Text.Json.Nodes.JsonObject)'></a>

## PhysicalComponentConstructionRelation\(JsonObject\) Constructor

Initializes a new instance of the [PhysicalComponentConstructionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionRelation') class using the specified JSON object\.

```csharp
public PhysicalComponentConstructionRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionRelation.PhysicalComponentConstructionRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object from which to initialize the relation\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation'></a>

## PhysicalComponentConstructionStructureLayersRelation Class

Represents the relationship between a physical component construction and one or more structure layers\.

```csharp
public class PhysicalComponentConstructionStructureLayersRelation : DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation<DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2') → [DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_ 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>')[DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionStructureLayersRelation_TConstruction_ 'DiGi\.Analytical\.Building\.Classes\.ConstructionStructureLayersRelation\<TConstruction\>') → PhysicalComponentConstructionStructureLayersRelation
### Constructors

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation.PhysicalComponentConstructionStructureLayersRelation(DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation)'></a>

## PhysicalComponentConstructionStructureLayersRelation\(PhysicalComponentConstructionStructureLayersRelation\) Constructor

Initializes a new instance of the [PhysicalComponentConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionStructureLayersRelation') class based on an existing relation\.

```csharp
public PhysicalComponentConstructionStructureLayersRelation(DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation? physicalComponentConstructionStructureLayersRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation.PhysicalComponentConstructionStructureLayersRelation(DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation).physicalComponentConstructionStructureLayersRelation'></a>

`physicalComponentConstructionStructureLayersRelation` [PhysicalComponentConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionStructureLayersRelation')

The source relation instance to copy\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation.PhysicalComponentConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer)'></a>

## PhysicalComponentConstructionStructureLayersRelation\(IPhysicalComponentConstruction, IStructureLayer\) Constructor

Initializes a new instance of the [PhysicalComponentConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionStructureLayersRelation') class\.

```csharp
public PhysicalComponentConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction? physicalComponentConstruction, DiGi.Analytical.Building.Interfaces.IStructureLayer? structureLayer);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation.PhysicalComponentConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer).physicalComponentConstruction'></a>

`physicalComponentConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')

The physical component construction associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation.PhysicalComponentConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,DiGi.Analytical.Building.Interfaces.IStructureLayer).structureLayer'></a>

`structureLayer` [DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')

The structure layer associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation.PhysicalComponentConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IStructureLayer_)'></a>

## PhysicalComponentConstructionStructureLayersRelation\(IPhysicalComponentConstruction, IEnumerable\<IStructureLayer\>\) Constructor

Initializes a new instance of the [PhysicalComponentConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionStructureLayersRelation') class using a physical component construction and a collection of structure layers\.

```csharp
public PhysicalComponentConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction? physicalComponentConstruction, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Interfaces.IStructureLayer>? structureLayers);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation.PhysicalComponentConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IStructureLayer_).physicalComponentConstruction'></a>

`physicalComponentConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')

The physical component construction to be associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation.PhysicalComponentConstructionStructureLayersRelation(DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.IStructureLayer_).structureLayers'></a>

`structureLayers` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.istructurelayer 'DiGi\.Analytical\.Building\.Interfaces\.IStructureLayer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of structure layers to be associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation.PhysicalComponentConstructionStructureLayersRelation(System.Text.Json.Nodes.JsonObject)'></a>

## PhysicalComponentConstructionStructureLayersRelation\(JsonObject\) Constructor

Initializes a new instance of the [PhysicalComponentConstructionStructureLayersRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstructionStructureLayersRelation') class using the specified JSON object\.

```csharp
public PhysicalComponentConstructionStructureLayersRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.PhysicalComponentConstructionStructureLayersRelation.PhysicalComponentConstructionStructureLayersRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object from which to initialize the relation\.

<a name='DiGi.Analytical.Building.Classes.Profile'></a>

## Profile Class

Represents a structural or analytical profile consisting of a collection of numerical values\.

```csharp
public class Profile : DiGi.Core.Classes.SerializableObject, DiGi.Analytical.Building.Interfaces.IProfile, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Profile

Implements [DiGi\.Analytical\.Building\.Interfaces\.IProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iprofile 'DiGi\.Analytical\.Building\.Interfaces\.IProfile'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.Profile.Profile(DiGi.Analytical.Building.Classes.Profile)'></a>

## Profile\(Profile\) Constructor

Initializes a new instance of the [Profile](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Profile 'DiGi\.Analytical\.Building\.Classes\.Profile') class by copying the values from an existing [Profile](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Profile 'DiGi\.Analytical\.Building\.Classes\.Profile') instance\.

```csharp
public Profile(DiGi.Analytical.Building.Classes.Profile? profile);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Profile.Profile(DiGi.Analytical.Building.Classes.Profile).profile'></a>

`profile` [Profile](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Profile 'DiGi\.Analytical\.Building\.Classes\.Profile')

The source [Profile](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Profile 'DiGi\.Analytical\.Building\.Classes\.Profile') instance to copy data from, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Analytical.Building.Classes.Profile.Profile(System.Collections.Generic.IEnumerable_double_)'></a>

## Profile\(IEnumerable\<double\>\) Constructor

Initializes a new instance of the [Profile](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Profile 'DiGi\.Analytical\.Building\.Classes\.Profile') class using the specified collection of values\.

```csharp
public Profile(System.Collections.Generic.IEnumerable<double>? values);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Profile.Profile(System.Collections.Generic.IEnumerable_double_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of double\-precision floating\-point numbers used to initialize the profile\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.Profile.Profile(System.Text.Json.Nodes.JsonObject)'></a>

## Profile\(JsonObject\) Constructor

Initializes a new instance of the [Profile](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Profile 'DiGi\.Analytical\.Building\.Classes\.Profile') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Profile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Profile.Profile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the profile\. This value can be null\.
### Properties

<a name='DiGi.Analytical.Building.Classes.Profile.Count'></a>

## Profile\.Count Property

Gets the number of elements contained in the profile\.

```csharp
public int Count { get; }
```

Implements [Count](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iprofile.count 'DiGi\.Analytical\.Building\.Interfaces\.IProfile\.Count')

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Analytical.Building.Classes.Profile.this[int]'></a>

## Profile\.this\[int\] Property

Gets the value at the specified index of the profile values\.

```csharp
public double this[int index] { get; }
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Profile.this[int].index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the value to retrieve\.

Implements [this\[int\]](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iprofile.item#digi-analytical-building-interfaces-iprofile-item(system-int32) 'DiGi\.Analytical\.Building\.Interfaces\.IProfile\.Item\(System\.Int32\)')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Analytical.Building.Classes.Profile.Values'></a>

## Profile\.Values Property

Gets the collection of numeric values associated with this profile\.

```csharp
public double[]? Values { get; }
```

Implements [Values](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iprofile.values 'DiGi\.Analytical\.Building\.Interfaces\.IProfile\.Values')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Analytical.Building.Classes.Roof_T_'></a>

## Roof\<T\> Class

Represents an abstract physical component that defines the characteristics of a roof within a building model\.

```csharp
public abstract class Roof<T> : DiGi.Analytical.Building.Classes.PhysicalComponent<T>, DiGi.Analytical.Building.Interfaces.IRoof, DiGi.Analytical.Building.Interfaces.IPhysicalComponent, DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IBuildingBoundable3D, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IConstructable
    where T : DiGi.Geometry.Spatial.Interfaces.ISurface3D
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.Roof_T_.T'></a>

`T`

The type of 3D surface geometry used to represent the roof, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') → [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') → [DiGi\.Analytical\.Building\.Classes\.PhysicalComponent&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_.T 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>') → Roof\<T\>

Derived  
↳ [SurfaceRoof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceRoof 'DiGi\.Analytical\.Building\.Classes\.SurfaceRoof')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstructable](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstructable 'DiGi\.Analytical\.Building\.Interfaces\.IConstructable')
### Constructors

<a name='DiGi.Analytical.Building.Classes.Roof_T_.Roof(DiGi.Analytical.Building.Classes.Roof_T_)'></a>

## Roof\(Roof\<T\>\) Constructor

Initializes a new instance of the [Roof&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_ 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>') class by copying the specified roof\.

```csharp
public Roof(DiGi.Analytical.Building.Classes.Roof<T>? roof);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Roof_T_.Roof(DiGi.Analytical.Building.Classes.Roof_T_).roof'></a>

`roof` [DiGi\.Analytical\.Building\.Classes\.Roof&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_ 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_.T 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_ 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>')

The source [Roof&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_ 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.Roof_T_.Roof(DiGi.Analytical.Building.Interfaces.IRoof,T)'></a>

## Roof\(IRoof, T\) Constructor

Initializes a new instance of the [Roof&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_ 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>') class using the specified roof and geometry\.

```csharp
public Roof(DiGi.Analytical.Building.Interfaces.IRoof? roof, T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Roof_T_.Roof(DiGi.Analytical.Building.Interfaces.IRoof,T).roof'></a>

`roof` [DiGi\.Analytical\.Building\.Interfaces\.IRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof')

The existing [DiGi\.Analytical\.Building\.Interfaces\.IRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof') instance to initialize from\.

<a name='DiGi.Analytical.Building.Classes.Roof_T_.Roof(DiGi.Analytical.Building.Interfaces.IRoof,T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_.T 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>\.T')

The geometry to associate with the roof\.

<a name='DiGi.Analytical.Building.Classes.Roof_T_.Roof(System.Guid,DiGi.Analytical.Building.Classes.Roof_T_)'></a>

## Roof\(Guid, Roof\<T\>\) Constructor

Initializes a new instance of the [Roof&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_ 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>') class using a specified unique identifier and an existing roof object\.

```csharp
public Roof(System.Guid guid, DiGi.Analytical.Building.Classes.Roof<T>? roof);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Roof_T_.Roof(System.Guid,DiGi.Analytical.Building.Classes.Roof_T_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the roof\.

<a name='DiGi.Analytical.Building.Classes.Roof_T_.Roof(System.Guid,DiGi.Analytical.Building.Classes.Roof_T_).roof'></a>

`roof` [DiGi\.Analytical\.Building\.Classes\.Roof&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_ 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_.T 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_ 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>')

The existing roof instance to copy properties from\.

<a name='DiGi.Analytical.Building.Classes.Roof_T_.Roof(System.Text.Json.Nodes.JsonObject)'></a>

## Roof\(JsonObject\) Constructor

Initializes a new instance of the [Roof&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_ 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>') class using the specified JSON object\.

```csharp
public Roof(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Roof_T_.Roof(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the roof instance\.

<a name='DiGi.Analytical.Building.Classes.Roof_T_.Roof(T)'></a>

## Roof\(T\) Constructor

Initializes a new instance of the [Roof&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_ 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>') class with the specified geometry\.

```csharp
public Roof(T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Roof_T_.Roof(T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_.T 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>\.T')

The geometry to associate with the roof\.

<a name='DiGi.Analytical.Building.Classes.RoofConstruction'></a>

## RoofConstruction Class

Represents the construction details of a roof component within the analytical building model\.

```csharp
public class RoofConstruction : DiGi.Analytical.Building.Classes.ComponentConstruction<DiGi.Analytical.Building.Interfaces.IRoof>, DiGi.Analytical.Building.Interfaces.IRoofConstruction, DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction<DiGi.Analytical.Building.Interfaces.IRoof>, DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction, DiGi.Analytical.Building.Interfaces.IConstruction, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject, DiGi.Analytical.Building.Interfaces.IBuildingDescribableObject, DiGi.Core.Interfaces.IDescribableObject, DiGi.Analytical.Building.Interfaces.IConstruction<DiGi.Analytical.Building.Interfaces.IRoof>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject') → [PhysicalComponentConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstruction 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstruction') → [DiGi\.Analytical\.Building\.Classes\.ComponentConstruction&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>')[DiGi\.Analytical\.Building\.Interfaces\.IRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>') → RoofConstruction

Implements [DiGi\.Analytical\.Building\.Interfaces\.IRoofConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroofconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IRoofConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction\`1')[DiGi\.Analytical\.Building\.Interfaces\.IRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingdescribableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction\`1')[DiGi\.Analytical\.Building\.Interfaces\.IRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.RoofConstruction.RoofConstruction()'></a>

## RoofConstruction\(\) Constructor

Initializes a new instance of the [RoofConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.RoofConstruction 'DiGi\.Analytical\.Building\.Classes\.RoofConstruction') class\.

```csharp
public RoofConstruction();
```

<a name='DiGi.Analytical.Building.Classes.RoofConstruction.RoofConstruction(DiGi.Analytical.Building.Classes.RoofConstruction)'></a>

## RoofConstruction\(RoofConstruction\) Constructor

Initializes a new instance of the [RoofConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.RoofConstruction 'DiGi\.Analytical\.Building\.Classes\.RoofConstruction') class using the specified existing construction\.

```csharp
public RoofConstruction(DiGi.Analytical.Building.Classes.RoofConstruction? roofConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.RoofConstruction.RoofConstruction(DiGi.Analytical.Building.Classes.RoofConstruction).roofConstruction'></a>

`roofConstruction` [RoofConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.RoofConstruction 'DiGi\.Analytical\.Building\.Classes\.RoofConstruction')

The source [RoofConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.RoofConstruction 'DiGi\.Analytical\.Building\.Classes\.RoofConstruction') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.RoofConstruction.RoofConstruction(System.Guid,DiGi.Analytical.Building.Classes.RoofConstruction)'></a>

## RoofConstruction\(Guid, RoofConstruction\) Constructor

Initializes a new instance of the [RoofConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.RoofConstruction 'DiGi\.Analytical\.Building\.Classes\.RoofConstruction') class using a specified unique identifier and an optional source construction\.

```csharp
public RoofConstruction(System.Guid guid, DiGi.Analytical.Building.Classes.RoofConstruction? roofConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.RoofConstruction.RoofConstruction(System.Guid,DiGi.Analytical.Building.Classes.RoofConstruction).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the roof construction\.

<a name='DiGi.Analytical.Building.Classes.RoofConstruction.RoofConstruction(System.Guid,DiGi.Analytical.Building.Classes.RoofConstruction).roofConstruction'></a>

`roofConstruction` [RoofConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.RoofConstruction 'DiGi\.Analytical\.Building\.Classes\.RoofConstruction')

An optional existing [RoofConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.RoofConstruction 'DiGi\.Analytical\.Building\.Classes\.RoofConstruction') instance to initialize from\.

<a name='DiGi.Analytical.Building.Classes.RoofConstruction.RoofConstruction(System.Text.Json.Nodes.JsonObject)'></a>

## RoofConstruction\(JsonObject\) Constructor

Initializes a new instance of the [RoofConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.RoofConstruction 'DiGi\.Analytical\.Building\.Classes\.RoofConstruction') class using the specified JSON object\.

```csharp
public RoofConstruction(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.RoofConstruction.RoofConstruction(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data used to initialize the roof construction instance\.

<a name='DiGi.Analytical.Building.Classes.Shade_T_'></a>

## Shade\<T\> Class

Represents an abstract base class for shade elements within a building's analytical geometry\.

```csharp
public abstract class Shade<T> : DiGi.Analytical.Building.Classes.BuildingGeometry3DObject<T>, DiGi.Analytical.Building.Interfaces.IShade<T>, DiGi.Analytical.Building.Interfaces.IShade, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject<T>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<T>
    where T : DiGi.Geometry.Spatial.Interfaces.IGeometry3D
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.Shade_T_.T'></a>

`T`

The type of the 3D geometry associated with the shade, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_.T 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>') → Shade\<T\>

Derived  
↳ [SurfaceShade](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceShade 'DiGi\.Analytical\.Building\.Classes\.SurfaceShade')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IShade&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ishade-1 'DiGi\.Analytical\.Building\.Interfaces\.IShade\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_.T 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ishade-1 'DiGi\.Analytical\.Building\.Interfaces\.IShade\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IShade](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ishade 'DiGi\.Analytical\.Building\.Interfaces\.IShade'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_.T 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_.T 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.Shade_T_.Shade(DiGi.Analytical.Building.Classes.Shade_T_)'></a>

## Shade\(Shade\<T\>\) Constructor

Initializes a new instance of the [Shade&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_ 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>') class using the specified shade object\.

```csharp
public Shade(DiGi.Analytical.Building.Classes.Shade<T>? shade);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Shade_T_.Shade(DiGi.Analytical.Building.Classes.Shade_T_).shade'></a>

`shade` [DiGi\.Analytical\.Building\.Classes\.Shade&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_ 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_.T 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_ 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>')

The source shade instance from which to initialize this instance\.

<a name='DiGi.Analytical.Building.Classes.Shade_T_.Shade(System.Guid,DiGi.Analytical.Building.Classes.Shade_T_)'></a>

## Shade\(Guid, Shade\<T\>\) Constructor

Initializes a new instance of the [Shade&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_ 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>') class with a specified unique identifier and an existing shade object\.

```csharp
public Shade(System.Guid guid, DiGi.Analytical.Building.Classes.Shade<T>? shade);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Shade_T_.Shade(System.Guid,DiGi.Analytical.Building.Classes.Shade_T_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the shade object\.

<a name='DiGi.Analytical.Building.Classes.Shade_T_.Shade(System.Guid,DiGi.Analytical.Building.Classes.Shade_T_).shade'></a>

`shade` [DiGi\.Analytical\.Building\.Classes\.Shade&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_ 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_.T 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_ 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>')

The existing shade object to initialize from\.

<a name='DiGi.Analytical.Building.Classes.Shade_T_.Shade(System.Text.Json.Nodes.JsonObject)'></a>

## Shade\(JsonObject\) Constructor

Initializes a new instance of the [Shade&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_ 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>') class using the specified JSON object\.

```csharp
public Shade(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Shade_T_.Shade(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data used to initialize the shade instance\.

<a name='DiGi.Analytical.Building.Classes.Shade_T_.Shade(T)'></a>

## Shade\(T\) Constructor

Initializes a new instance of the [Shade&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_ 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>') class using the specified geometry\.

```csharp
public Shade(T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Shade_T_.Shade(T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_.T 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>\.T')

The geometry to be assigned to the shade instance\.

<a name='DiGi.Analytical.Building.Classes.Space'></a>

## Space Class

Represents a spatial area or room within a building's analytical model, associated with a specific 3D point geometry\.

```csharp
public class Space : DiGi.Analytical.Building.Classes.BuildingGeometry3DObject<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Analytical.Building.Interfaces.ISpace, DiGi.Analytical.Building.Interfaces.IBuildingPointObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Geometry.Object.Spatial.Interfaces.IPoint3DObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>') → Space

Implements [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingPointObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingpointobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingPointObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IPoint3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.ipoint3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IPoint3DObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject-1 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject-1 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.Space.Space(DiGi.Analytical.Building.Classes.Space)'></a>

## Space\(Space\) Constructor

Initializes a new instance of the [Space](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Space 'DiGi\.Analytical\.Building\.Classes\.Space') class by copying properties from an existing [Space](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Space 'DiGi\.Analytical\.Building\.Classes\.Space') instance\.

```csharp
public Space(DiGi.Analytical.Building.Classes.Space? space);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Space.Space(DiGi.Analytical.Building.Classes.Space).space'></a>

`space` [Space](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Space 'DiGi\.Analytical\.Building\.Classes\.Space')

The source [Space](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Space 'DiGi\.Analytical\.Building\.Classes\.Space') instance to copy data from; may be null\.

<a name='DiGi.Analytical.Building.Classes.Space.Space(DiGi.Geometry.Spatial.Classes.Point3D,string)'></a>

## Space\(Point3D, string\) Constructor

Initializes a new instance of the [Space](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Space 'DiGi\.Analytical\.Building\.Classes\.Space') class\.

```csharp
public Space(DiGi.Geometry.Spatial.Classes.Point3D? geometry, string? name);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Space.Space(DiGi.Geometry.Spatial.Classes.Point3D,string).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the geometry of the space\.

<a name='DiGi.Analytical.Building.Classes.Space.Space(DiGi.Geometry.Spatial.Classes.Point3D,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the space\.

<a name='DiGi.Analytical.Building.Classes.Space.Space(System.Guid,DiGi.Analytical.Building.Classes.Space)'></a>

## Space\(Guid, Space\) Constructor

Initializes a new instance of the [Space](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Space 'DiGi\.Analytical\.Building\.Classes\.Space') class using a specified unique identifier and an optional existing space object to copy properties from\.

```csharp
public Space(System.Guid guid, DiGi.Analytical.Building.Classes.Space? space);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Space.Space(System.Guid,DiGi.Analytical.Building.Classes.Space).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the space\.

<a name='DiGi.Analytical.Building.Classes.Space.Space(System.Guid,DiGi.Analytical.Building.Classes.Space).space'></a>

`space` [Space](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Space 'DiGi\.Analytical\.Building\.Classes\.Space')

An optional [Space](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Space 'DiGi\.Analytical\.Building\.Classes\.Space') instance used to initialize the current instance's properties\.

<a name='DiGi.Analytical.Building.Classes.Space.Space(System.Text.Json.Nodes.JsonObject)'></a>

## Space\(JsonObject\) Constructor

Initializes a new instance of the [Space](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Space 'DiGi\.Analytical\.Building\.Classes\.Space') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Space(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Space.Space(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.
### Properties

<a name='DiGi.Analytical.Building.Classes.Space.Description'></a>

## Space\.Description Property

Gets or sets the description of the space\.

```csharp
public string? Description { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.Classes.Space.Name'></a>

## Space\.Name Property

Gets or sets the name of the space\.

```csharp
public string? Name { get; set; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.Classes.SpaceInternalCondition'></a>

## SpaceInternalCondition Class

Represents the internal environmental conditions of a space within a building, typically associated with a specific time interval\.

```csharp
public class SpaceInternalCondition : DiGi.Core.Classes.SerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → SpaceInternalCondition

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.SpaceInternalCondition.SpaceInternalCondition(DiGi.Analytical.Building.Classes.SpaceInternalCondition)'></a>

## SpaceInternalCondition\(SpaceInternalCondition\) Constructor

Initializes a new instance of the [SpaceInternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalCondition 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalCondition') class by cloning an existing instance\.

```csharp
public SpaceInternalCondition(DiGi.Analytical.Building.Classes.SpaceInternalCondition? spaceInternalCondition);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SpaceInternalCondition.SpaceInternalCondition(DiGi.Analytical.Building.Classes.SpaceInternalCondition).spaceInternalCondition'></a>

`spaceInternalCondition` [SpaceInternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalCondition 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalCondition')

The source [SpaceInternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalCondition 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalCondition') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.SpaceInternalCondition.SpaceInternalCondition(DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string)'></a>

## SpaceInternalCondition\(IInternalCondition, HourRange, string\) Constructor

Initializes a new instance of the [SpaceInternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalCondition 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalCondition') class\.

```csharp
public SpaceInternalCondition(DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition, DiGi.Analytical.Classes.HourRange? hourRange, string? id=null);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SpaceInternalCondition.SpaceInternalCondition(DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition to be associated with the space\.

<a name='DiGi.Analytical.Building.Classes.SpaceInternalCondition.SpaceInternalCondition(DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).hourRange'></a>

`hourRange` [DiGi\.Analytical\.Classes\.HourRange](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.hourrange 'DiGi\.Analytical\.Classes\.HourRange')

The hour range during which this internal condition is applicable\.

<a name='DiGi.Analytical.Building.Classes.SpaceInternalCondition.SpaceInternalCondition(DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional unique identifier for the space internal condition\.

<a name='DiGi.Analytical.Building.Classes.SpaceInternalCondition.SpaceInternalCondition(System.Text.Json.Nodes.JsonObject)'></a>

## SpaceInternalCondition\(JsonObject\) Constructor

Initializes a new instance of the [SpaceInternalCondition](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalCondition 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalCondition') class using the specified JSON object\.

```csharp
public SpaceInternalCondition(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SpaceInternalCondition.SpaceInternalCondition(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object from which to initialize the instance\. This value can be null\.
### Properties

<a name='DiGi.Analytical.Building.Classes.SpaceInternalCondition.HourRange'></a>

## SpaceInternalCondition\.HourRange Property

Gets the hour range associated with the internal condition of the space\.

```csharp
public DiGi.Analytical.Classes.HourRange? HourRange { get; }
```

#### Property Value
[DiGi\.Analytical\.Classes\.HourRange](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.hourrange 'DiGi\.Analytical\.Classes\.HourRange')

<a name='DiGi.Analytical.Building.Classes.SpaceInternalCondition.Id'></a>

## SpaceInternalCondition\.Id Property

Gets the unique identifier for the space internal condition\.

```csharp
public string? Id { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.Classes.SpaceInternalCondition.InternalCondition'></a>

## SpaceInternalCondition\.InternalCondition Property

Gets the internal condition associated with the space\.

```csharp
public DiGi.Analytical.Building.Interfaces.IInternalCondition? InternalCondition { get; }
```

#### Property Value
[DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

<a name='DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation'></a>

## SpaceInternalConditionRelation Class

Represents a one\-to\-one bidirectional relationship between a space and an internal condition,
providing metadata such as the hour range during which the condition applies\.

```csharp
public class SpaceInternalConditionRelation : DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation<DiGi.Analytical.Building.Interfaces.ISpace, DiGi.Analytical.Building.Interfaces.IInternalCondition>, DiGi.Analytical.Building.Interfaces.IBuildingRelation, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2') → SpaceInternalConditionRelation

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingrelation 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation.SpaceInternalConditionRelation(DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation)'></a>

## SpaceInternalConditionRelation\(SpaceInternalConditionRelation\) Constructor

Initializes a new instance of the [SpaceInternalConditionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalConditionRelation') class by copying the properties of an existing relation instance\.

```csharp
public SpaceInternalConditionRelation(DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation? spaceInternalConditionRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation.SpaceInternalConditionRelation(DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation).spaceInternalConditionRelation'></a>

`spaceInternalConditionRelation` [SpaceInternalConditionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalConditionRelation')

The source [SpaceInternalConditionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalConditionRelation') instance to copy from, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation.SpaceInternalConditionRelation(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string)'></a>

## SpaceInternalConditionRelation\(ISpace, IInternalCondition, HourRange, string\) Constructor

Initializes a new instance of the [SpaceInternalConditionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalConditionRelation') class\.

```csharp
public SpaceInternalConditionRelation(DiGi.Analytical.Building.Interfaces.ISpace? space, DiGi.Analytical.Building.Interfaces.IInternalCondition? internalCondition, DiGi.Analytical.Classes.HourRange? hourRange, string? id);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation.SpaceInternalConditionRelation(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation.SpaceInternalConditionRelation(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).internalCondition'></a>

`internalCondition` [DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iinternalcondition 'DiGi\.Analytical\.Building\.Interfaces\.IInternalCondition')

The internal condition associated with this relation\.

<a name='DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation.SpaceInternalConditionRelation(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).hourRange'></a>

`hourRange` [DiGi\.Analytical\.Classes\.HourRange](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.hourrange 'DiGi\.Analytical\.Classes\.HourRange')

The hour range during which the internal condition applies to the space\.

<a name='DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation.SpaceInternalConditionRelation(DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.IInternalCondition,DiGi.Analytical.Classes.HourRange,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the relation\.

<a name='DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation.SpaceInternalConditionRelation(System.Text.Json.Nodes.JsonObject)'></a>

## SpaceInternalConditionRelation\(JsonObject\) Constructor

Initializes a new instance of the [SpaceInternalConditionRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceInternalConditionRelation') class using the specified JSON object\.

```csharp
public SpaceInternalConditionRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation.SpaceInternalConditionRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the relation\.
### Properties

<a name='DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation.HourRange'></a>

## SpaceInternalConditionRelation\.HourRange Property

Gets the hour range associated with the relation between the space and the internal condition\.

```csharp
public DiGi.Analytical.Classes.HourRange? HourRange { get; }
```

#### Property Value
[DiGi\.Analytical\.Classes\.HourRange](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.hourrange 'DiGi\.Analytical\.Classes\.HourRange')

<a name='DiGi.Analytical.Building.Classes.SpaceInternalConditionRelation.Id'></a>

## SpaceInternalConditionRelation\.Id Property

Gets the unique identifier of the space internal condition relation\.

```csharp
public string? Id { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.Classes.SpaceRelation'></a>

## SpaceRelation Class

Represents a bidirectional one\-to\-many relationship between a building component and its associated spaces\.

```csharp
public class SpaceRelation : DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation<DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.ISpace>, DiGi.Analytical.Building.Interfaces.IBuildingRelation, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2') → SpaceRelation

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingrelation 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.SpaceRelation.SpaceRelation(DiGi.Analytical.Building.Classes.SpaceRelation)'></a>

## SpaceRelation\(SpaceRelation\) Constructor

Initializes a new instance of the [SpaceRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceRelation') class by copying an existing relation\.

```csharp
public SpaceRelation(DiGi.Analytical.Building.Classes.SpaceRelation? spaceRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SpaceRelation.SpaceRelation(DiGi.Analytical.Building.Classes.SpaceRelation).spaceRelation'></a>

`spaceRelation` [SpaceRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceRelation')

The source [SpaceRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceRelation') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.SpaceRelation.SpaceRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace)'></a>

## SpaceRelation\(IComponent, ISpace\) Constructor

Initializes a new instance of the [SpaceRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceRelation') class\.

```csharp
public SpaceRelation(DiGi.Analytical.Building.Interfaces.IComponent? component, DiGi.Analytical.Building.Interfaces.ISpace? space);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SpaceRelation.SpaceRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent') that is part of this relation\.

<a name='DiGi.Analytical.Building.Classes.SpaceRelation.SpaceRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace') that is part of this relation\.

<a name='DiGi.Analytical.Building.Classes.SpaceRelation.SpaceRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace)'></a>

## SpaceRelation\(IComponent, ISpace, ISpace\) Constructor

Initializes a new instance of the [SpaceRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceRelation') class with a specified component and two spaces\.

```csharp
public SpaceRelation(DiGi.Analytical.Building.Interfaces.IComponent? component, DiGi.Analytical.Building.Interfaces.ISpace? space_1, DiGi.Analytical.Building.Interfaces.ISpace? space_2);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SpaceRelation.SpaceRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The component associated with the relation\.

<a name='DiGi.Analytical.Building.Classes.SpaceRelation.SpaceRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace).space_1'></a>

`space_1` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The first space associated with the relation\.

<a name='DiGi.Analytical.Building.Classes.SpaceRelation.SpaceRelation(DiGi.Analytical.Building.Interfaces.IComponent,DiGi.Analytical.Building.Interfaces.ISpace,DiGi.Analytical.Building.Interfaces.ISpace).space_2'></a>

`space_2` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The second space associated with the relation\.

<a name='DiGi.Analytical.Building.Classes.SpaceRelation.SpaceRelation(System.Text.Json.Nodes.JsonObject)'></a>

## SpaceRelation\(JsonObject\) Constructor

Initializes a new instance of the [SpaceRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SpaceRelation 'DiGi\.Analytical\.Building\.Classes\.SpaceRelation') class using the specified JSON object\.

```csharp
public SpaceRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SpaceRelation.SpaceRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the relation; may be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Analytical.Building.Classes.SurfaceAir'></a>

## SurfaceAir Class

Represents an analytical building air element associated with a 3D surface\.

```csharp
public class SurfaceAir : DiGi.Analytical.Building.Classes.Air<DiGi.Geometry.Spatial.Interfaces.ISurface3D>, DiGi.Analytical.Building.Interfaces.ISurfaceAir, DiGi.Analytical.Building.Interfaces.IAir<DiGi.Geometry.Spatial.Interfaces.ISurface3D>, DiGi.Analytical.Building.Interfaces.IAbstractComponent<DiGi.Geometry.Spatial.Interfaces.ISurface3D>, DiGi.Analytical.Building.Interfaces.IAbstractComponent, DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IBuildingBoundable3D, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IConstructable, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject<DiGi.Geometry.Spatial.Interfaces.ISurface3D>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Spatial.Interfaces.ISurface3D>, DiGi.Analytical.Building.Interfaces.IBuildingSurfaceObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') → [AbstractComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent') → [DiGi\.Analytical\.Building\.Classes\.AbstractComponent&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.AbstractComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.AbstractComponent\<T\>') → [DiGi\.Analytical\.Building\.Classes\.Air&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_ 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Air_T_ 'DiGi\.Analytical\.Building\.Classes\.Air\<T\>') → SurfaceAir

Implements [DiGi\.Analytical\.Building\.Interfaces\.ISurfaceAir](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.isurfaceair 'DiGi\.Analytical\.Building\.Interfaces\.ISurfaceAir'), [DiGi\.Analytical\.Building\.Interfaces\.IAir&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iair-1 'DiGi\.Analytical\.Building\.Interfaces\.IAir\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iair-1 'DiGi\.Analytical\.Building\.Interfaces\.IAir\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IAbstractComponent&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iabstractcomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IAbstractComponent\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iabstractcomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IAbstractComponent\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IAbstractComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iabstractcomponent 'DiGi\.Analytical\.Building\.Interfaces\.IAbstractComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstructable](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstructable 'DiGi\.Analytical\.Building\.Interfaces\.IConstructable'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSurfaceObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingsurfaceobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSurfaceObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.SurfaceAir.SurfaceAir(DiGi.Analytical.Building.Classes.SurfaceAir)'></a>

## SurfaceAir\(SurfaceAir\) Constructor

Initializes a new instance of the [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir') class using an existing [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir') instance\.

```csharp
public SurfaceAir(DiGi.Analytical.Building.Classes.SurfaceAir? surfaceAir);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceAir.SurfaceAir(DiGi.Analytical.Building.Classes.SurfaceAir).surfaceAir'></a>

`surfaceAir` [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir')

The source [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.SurfaceAir.SurfaceAir(DiGi.Analytical.Building.Interfaces.IAir,DiGi.Geometry.Spatial.Interfaces.ISurface3D)'></a>

## SurfaceAir\(IAir, ISurface3D\) Constructor

Initializes a new instance of the [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir') class using the specified air object and geometry surface\.

```csharp
public SurfaceAir(DiGi.Analytical.Building.Interfaces.IAir? air, DiGi.Geometry.Spatial.Interfaces.ISurface3D? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceAir.SurfaceAir(DiGi.Analytical.Building.Interfaces.IAir,DiGi.Geometry.Spatial.Interfaces.ISurface3D).air'></a>

`air` [DiGi\.Analytical\.Building\.Interfaces\.IAir](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iair 'DiGi\.Analytical\.Building\.Interfaces\.IAir')

The [DiGi\.Analytical\.Building\.Interfaces\.IAir](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iair 'DiGi\.Analytical\.Building\.Interfaces\.IAir') object to provide base properties\.

<a name='DiGi.Analytical.Building.Classes.SurfaceAir.SurfaceAir(DiGi.Analytical.Building.Interfaces.IAir,DiGi.Geometry.Spatial.Interfaces.ISurface3D).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D') geometry associated with this surface air element\.

<a name='DiGi.Analytical.Building.Classes.SurfaceAir.SurfaceAir(DiGi.Geometry.Spatial.Interfaces.ISurface3D)'></a>

## SurfaceAir\(ISurface3D\) Constructor

Initializes a new instance of the [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir') class using the specified surface geometry\.

```csharp
public SurfaceAir(DiGi.Geometry.Spatial.Interfaces.ISurface3D? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceAir.SurfaceAir(DiGi.Geometry.Spatial.Interfaces.ISurface3D).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')

The surface geometry to associate with this air surface\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.SurfaceAir.SurfaceAir(System.Guid,DiGi.Analytical.Building.Classes.SurfaceAir)'></a>

## SurfaceAir\(Guid, SurfaceAir\) Constructor

Initializes a new instance of the [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir') class using a unique identifier and an existing [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir') object\.

```csharp
public SurfaceAir(System.Guid guid, DiGi.Analytical.Building.Classes.SurfaceAir? surfaceAir);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceAir.SurfaceAir(System.Guid,DiGi.Analytical.Building.Classes.SurfaceAir).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the object\.

<a name='DiGi.Analytical.Building.Classes.SurfaceAir.SurfaceAir(System.Guid,DiGi.Analytical.Building.Classes.SurfaceAir).surfaceAir'></a>

`surfaceAir` [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir')

An optional [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir') instance to initialize from\.

<a name='DiGi.Analytical.Building.Classes.SurfaceAir.SurfaceAir(System.Text.Json.Nodes.JsonObject)'></a>

## SurfaceAir\(JsonObject\) Constructor

Initializes a new instance of the [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir') class using the specified JSON object\.

```csharp
public SurfaceAir(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceAir.SurfaceAir(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the instance\.
### Methods

<a name='DiGi.Analytical.Building.Classes.SurfaceAir.GetBoundingBox()'></a>

## SurfaceAir\.GetBoundingBox\(\) Method

Gets the axis\-aligned bounding box of the surface air's geometry\.

```csharp
public override DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d.getboundingbox 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D\.GetBoundingBox')

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') encompassing the geometry, or null if no geometry is defined\.

<a name='DiGi.Analytical.Building.Classes.SurfaceRoof'></a>

## SurfaceRoof Class

Represents a building roof defined by a 3D surface geometry\.

```csharp
public class SurfaceRoof : DiGi.Analytical.Building.Classes.Roof<DiGi.Geometry.Spatial.Interfaces.ISurface3D>, DiGi.Analytical.Building.Interfaces.ISurfaceRoof, DiGi.Analytical.Building.Interfaces.IRoof, DiGi.Analytical.Building.Interfaces.IPhysicalComponent, DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IBuildingBoundable3D, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IConstructable, DiGi.Analytical.Building.Interfaces.IBuildingSurfaceObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject<DiGi.Geometry.Spatial.Interfaces.ISurface3D>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Spatial.Interfaces.ISurface3D>, DiGi.Analytical.Building.Interfaces.IComponent<DiGi.Geometry.Spatial.Interfaces.ISurface3D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') → [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') → [DiGi\.Analytical\.Building\.Classes\.PhysicalComponent&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>') → [DiGi\.Analytical\.Building\.Classes\.Roof&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_ 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Roof_T_ 'DiGi\.Analytical\.Building\.Classes\.Roof\<T\>') → SurfaceRoof

Implements [DiGi\.Analytical\.Building\.Interfaces\.ISurfaceRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.isurfaceroof 'DiGi\.Analytical\.Building\.Interfaces\.ISurfaceRoof'), [DiGi\.Analytical\.Building\.Interfaces\.IRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstructable](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstructable 'DiGi\.Analytical\.Building\.Interfaces\.IConstructable'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSurfaceObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingsurfaceobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSurfaceObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IComponent\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IComponent\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.SurfaceRoof.SurfaceRoof(DiGi.Analytical.Building.Classes.SurfaceRoof)'></a>

## SurfaceRoof\(SurfaceRoof\) Constructor

Initializes a new instance of the [SurfaceRoof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceRoof 'DiGi\.Analytical\.Building\.Classes\.SurfaceRoof') class using an existing [SurfaceRoof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceRoof 'DiGi\.Analytical\.Building\.Classes\.SurfaceRoof') object\.

```csharp
public SurfaceRoof(DiGi.Analytical.Building.Classes.SurfaceRoof? surfaceRoof);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceRoof.SurfaceRoof(DiGi.Analytical.Building.Classes.SurfaceRoof).surfaceRoof'></a>

`surfaceRoof` [SurfaceRoof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceRoof 'DiGi\.Analytical\.Building\.Classes\.SurfaceRoof')

The source [SurfaceRoof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceRoof 'DiGi\.Analytical\.Building\.Classes\.SurfaceRoof') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.SurfaceRoof.SurfaceRoof(DiGi.Analytical.Building.Interfaces.IRoof,DiGi.Geometry.Spatial.Interfaces.ISurface3D)'></a>

## SurfaceRoof\(IRoof, ISurface3D\) Constructor

Initializes a new instance of the [SurfaceRoof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceRoof 'DiGi\.Analytical\.Building\.Classes\.SurfaceRoof') class using an existing roof and surface geometry\.

```csharp
public SurfaceRoof(DiGi.Analytical.Building.Interfaces.IRoof? roof, DiGi.Geometry.Spatial.Interfaces.ISurface3D? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceRoof.SurfaceRoof(DiGi.Analytical.Building.Interfaces.IRoof,DiGi.Geometry.Spatial.Interfaces.ISurface3D).roof'></a>

`roof` [DiGi\.Analytical\.Building\.Interfaces\.IRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof')

The roof object to initialize from\.

<a name='DiGi.Analytical.Building.Classes.SurfaceRoof.SurfaceRoof(DiGi.Analytical.Building.Interfaces.IRoof,DiGi.Geometry.Spatial.Interfaces.ISurface3D).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')

The surface geometry for the roof\.

<a name='DiGi.Analytical.Building.Classes.SurfaceRoof.SurfaceRoof(DiGi.Geometry.Spatial.Interfaces.ISurface3D)'></a>

## SurfaceRoof\(ISurface3D\) Constructor

Initializes a new instance of the [SurfaceRoof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceRoof 'DiGi\.Analytical\.Building\.Classes\.SurfaceRoof') class using the specified geometry\.

```csharp
public SurfaceRoof(DiGi.Geometry.Spatial.Interfaces.ISurface3D? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceRoof.SurfaceRoof(DiGi.Geometry.Spatial.Interfaces.ISurface3D).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D') geometry to associate with the roof\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.SurfaceRoof.SurfaceRoof(System.Guid,DiGi.Analytical.Building.Classes.SurfaceRoof)'></a>

## SurfaceRoof\(Guid, SurfaceRoof\) Constructor

Initializes a new instance of the [SurfaceRoof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceRoof 'DiGi\.Analytical\.Building\.Classes\.SurfaceRoof') class using a specified unique identifier and an optional existing roof instance\.

```csharp
public SurfaceRoof(System.Guid guid, DiGi.Analytical.Building.Classes.SurfaceRoof? surfaceRoof);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceRoof.SurfaceRoof(System.Guid,DiGi.Analytical.Building.Classes.SurfaceRoof).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the object\.

<a name='DiGi.Analytical.Building.Classes.SurfaceRoof.SurfaceRoof(System.Guid,DiGi.Analytical.Building.Classes.SurfaceRoof).surfaceRoof'></a>

`surfaceRoof` [SurfaceRoof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceRoof 'DiGi\.Analytical\.Building\.Classes\.SurfaceRoof')

An optional [SurfaceRoof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceRoof 'DiGi\.Analytical\.Building\.Classes\.SurfaceRoof') instance to initialize from\.

<a name='DiGi.Analytical.Building.Classes.SurfaceRoof.SurfaceRoof(System.Text.Json.Nodes.JsonObject)'></a>

## SurfaceRoof\(JsonObject\) Constructor

Initializes a new instance of the [SurfaceRoof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceRoof 'DiGi\.Analytical\.Building\.Classes\.SurfaceRoof') class using the specified JSON object\.

```csharp
public SurfaceRoof(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceRoof.SurfaceRoof(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data used to initialize the instance\. This value can be null\.
### Methods

<a name='DiGi.Analytical.Building.Classes.SurfaceRoof.GetBoundingBox()'></a>

## SurfaceRoof\.GetBoundingBox\(\) Method

Gets the axis\-aligned bounding box of the surface roof\.

```csharp
public override DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d.getboundingbox 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D\.GetBoundingBox')

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') encompassing the surface roof, or null if it cannot be determined\.

<a name='DiGi.Analytical.Building.Classes.SurfaceShade'></a>

## SurfaceShade Class

Represents a shading element that is associated with a 3D surface\.

```csharp
public class SurfaceShade : DiGi.Analytical.Building.Classes.Shade<DiGi.Geometry.Spatial.Interfaces.ISurface3D>, DiGi.Analytical.Building.Interfaces.ISurfaceShade, DiGi.Analytical.Building.Interfaces.IShade<DiGi.Geometry.Spatial.Interfaces.ISurface3D>, DiGi.Analytical.Building.Interfaces.IShade, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject<DiGi.Geometry.Spatial.Interfaces.ISurface3D>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Spatial.Interfaces.ISurface3D>, DiGi.Analytical.Building.Interfaces.IBuildingSurfaceObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject\<T\>') → [DiGi\.Analytical\.Building\.Classes\.Shade&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_ 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Shade_T_ 'DiGi\.Analytical\.Building\.Classes\.Shade\<T\>') → SurfaceShade

Implements [DiGi\.Analytical\.Building\.Interfaces\.ISurfaceShade](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.isurfaceshade 'DiGi\.Analytical\.Building\.Interfaces\.ISurfaceShade'), [DiGi\.Analytical\.Building\.Interfaces\.IShade&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ishade-1 'DiGi\.Analytical\.Building\.Interfaces\.IShade\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ishade-1 'DiGi\.Analytical\.Building\.Interfaces\.IShade\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IShade](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ishade 'DiGi\.Analytical\.Building\.Interfaces\.IShade'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSurfaceObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingsurfaceobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSurfaceObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.SurfaceShade.SurfaceShade(DiGi.Analytical.Building.Classes.SurfaceShade)'></a>

## SurfaceShade\(SurfaceShade\) Constructor

Initializes a new instance of the [SurfaceShade](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceShade 'DiGi\.Analytical\.Building\.Classes\.SurfaceShade') class using the specified [SurfaceShade](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceShade 'DiGi\.Analytical\.Building\.Classes\.SurfaceShade') instance\.

```csharp
public SurfaceShade(DiGi.Analytical.Building.Classes.SurfaceShade? surfaceShade);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceShade.SurfaceShade(DiGi.Analytical.Building.Classes.SurfaceShade).surfaceShade'></a>

`surfaceShade` [SurfaceShade](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceShade 'DiGi\.Analytical\.Building\.Classes\.SurfaceShade')

The [SurfaceShade](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceShade 'DiGi\.Analytical\.Building\.Classes\.SurfaceShade') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.SurfaceShade.SurfaceShade(DiGi.Geometry.Spatial.Interfaces.ISurface3D)'></a>

## SurfaceShade\(ISurface3D\) Constructor

Initializes a new instance of the [SurfaceShade](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceShade 'DiGi\.Analytical\.Building\.Classes\.SurfaceShade') class using the specified 3D surface\.

```csharp
public SurfaceShade(DiGi.Geometry.Spatial.Interfaces.ISurface3D? surface3D);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceShade.SurfaceShade(DiGi.Geometry.Spatial.Interfaces.ISurface3D).surface3D'></a>

`surface3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')

The 3D surface to be used as the shading element\.

<a name='DiGi.Analytical.Building.Classes.SurfaceShade.SurfaceShade(System.Guid,DiGi.Analytical.Building.Classes.SurfaceShade)'></a>

## SurfaceShade\(Guid, SurfaceShade\) Constructor

Initializes a new instance of the [SurfaceShade](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceShade 'DiGi\.Analytical\.Building\.Classes\.SurfaceShade') class with a specified unique identifier and an optional source surface shade\.

```csharp
public SurfaceShade(System.Guid guid, DiGi.Analytical.Building.Classes.SurfaceShade? surfaceShade);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceShade.SurfaceShade(System.Guid,DiGi.Analytical.Building.Classes.SurfaceShade).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the object\.

<a name='DiGi.Analytical.Building.Classes.SurfaceShade.SurfaceShade(System.Guid,DiGi.Analytical.Building.Classes.SurfaceShade).surfaceShade'></a>

`surfaceShade` [SurfaceShade](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceShade 'DiGi\.Analytical\.Building\.Classes\.SurfaceShade')

An optional existing [SurfaceShade](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceShade 'DiGi\.Analytical\.Building\.Classes\.SurfaceShade') instance to initialize from\.

<a name='DiGi.Analytical.Building.Classes.SurfaceShade.SurfaceShade(System.Text.Json.Nodes.JsonObject)'></a>

## SurfaceShade\(JsonObject\) Constructor

Initializes a new instance of the [SurfaceShade](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceShade 'DiGi\.Analytical\.Building\.Classes\.SurfaceShade') class using the specified JSON object\.

```csharp
public SurfaceShade(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceShade.SurfaceShade(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.

<a name='DiGi.Analytical.Building.Classes.SurfaceWall'></a>

## SurfaceWall Class

Represents a wall in an analytical building model where the geometry is defined as a 3D surface\.

```csharp
public class SurfaceWall : DiGi.Analytical.Building.Classes.Wall<DiGi.Geometry.Spatial.Interfaces.ISurface3D>, DiGi.Analytical.Building.Interfaces.ISurfaceWall, DiGi.Analytical.Building.Interfaces.IWall, DiGi.Analytical.Building.Interfaces.IPhysicalComponent, DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IBuildingBoundable3D, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IConstructable, DiGi.Analytical.Building.Interfaces.IBuildingSurfaceObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject<DiGi.Geometry.Spatial.Interfaces.ISurface3D>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Spatial.Interfaces.ISurface3D>, DiGi.Analytical.Building.Interfaces.IComponent<DiGi.Geometry.Spatial.Interfaces.ISurface3D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') → [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') → [DiGi\.Analytical\.Building\.Classes\.PhysicalComponent&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>') → [DiGi\.Analytical\.Building\.Classes\.Wall&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>') → SurfaceWall

Implements [DiGi\.Analytical\.Building\.Interfaces\.ISurfaceWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.isurfacewall 'DiGi\.Analytical\.Building\.Interfaces\.ISurfaceWall'), [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstructable](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstructable 'DiGi\.Analytical\.Building\.Interfaces\.IConstructable'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSurfaceObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingsurfaceobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSurfaceObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IComponent\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IComponent\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.SurfaceWall.SurfaceWall(DiGi.Analytical.Building.Classes.SurfaceWall)'></a>

## SurfaceWall\(SurfaceWall\) Constructor

Initializes a new instance of the [SurfaceWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceWall 'DiGi\.Analytical\.Building\.Classes\.SurfaceWall') class using an existing [SurfaceWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceWall 'DiGi\.Analytical\.Building\.Classes\.SurfaceWall') instance\.

```csharp
public SurfaceWall(DiGi.Analytical.Building.Classes.SurfaceWall? surfaceWall);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceWall.SurfaceWall(DiGi.Analytical.Building.Classes.SurfaceWall).surfaceWall'></a>

`surfaceWall` [SurfaceWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceWall 'DiGi\.Analytical\.Building\.Classes\.SurfaceWall')

The source [SurfaceWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceWall 'DiGi\.Analytical\.Building\.Classes\.SurfaceWall') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.SurfaceWall.SurfaceWall(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Geometry.Spatial.Interfaces.ISurface3D)'></a>

## SurfaceWall\(IWall, ISurface3D\) Constructor

Initializes a new instance of the [SurfaceWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceWall 'DiGi\.Analytical\.Building\.Classes\.SurfaceWall') class using an existing wall and a specific surface geometry\.

```csharp
public SurfaceWall(DiGi.Analytical.Building.Interfaces.IWall? wall, DiGi.Geometry.Spatial.Interfaces.ISurface3D? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceWall.SurfaceWall(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Geometry.Spatial.Interfaces.ISurface3D).wall'></a>

`wall` [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')

The source wall from which to copy properties\.

<a name='DiGi.Analytical.Building.Classes.SurfaceWall.SurfaceWall(DiGi.Analytical.Building.Interfaces.IWall,DiGi.Geometry.Spatial.Interfaces.ISurface3D).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')

The surface geometry associated with the wall\.

<a name='DiGi.Analytical.Building.Classes.SurfaceWall.SurfaceWall(DiGi.Geometry.Spatial.Interfaces.ISurface3D)'></a>

## SurfaceWall\(ISurface3D\) Constructor

Initializes a new instance of the [SurfaceWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceWall 'DiGi\.Analytical\.Building\.Classes\.SurfaceWall') class using the specified geometry\.

```csharp
public SurfaceWall(DiGi.Geometry.Spatial.Interfaces.ISurface3D? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceWall.SurfaceWall(DiGi.Geometry.Spatial.Interfaces.ISurface3D).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D') geometry to assign to the wall\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.SurfaceWall.SurfaceWall(System.Guid,DiGi.Analytical.Building.Classes.SurfaceWall)'></a>

## SurfaceWall\(Guid, SurfaceWall\) Constructor

Initializes a new instance of the [SurfaceWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceWall 'DiGi\.Analytical\.Building\.Classes\.SurfaceWall') class with a specified unique identifier and an optional existing surface wall\.

```csharp
public SurfaceWall(System.Guid guid, DiGi.Analytical.Building.Classes.SurfaceWall? surfaceWall);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceWall.SurfaceWall(System.Guid,DiGi.Analytical.Building.Classes.SurfaceWall).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the surface wall\.

<a name='DiGi.Analytical.Building.Classes.SurfaceWall.SurfaceWall(System.Guid,DiGi.Analytical.Building.Classes.SurfaceWall).surfaceWall'></a>

`surfaceWall` [SurfaceWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceWall 'DiGi\.Analytical\.Building\.Classes\.SurfaceWall')

An optional existing [SurfaceWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceWall 'DiGi\.Analytical\.Building\.Classes\.SurfaceWall') instance to initialize from\.

<a name='DiGi.Analytical.Building.Classes.SurfaceWall.SurfaceWall(System.Text.Json.Nodes.JsonObject)'></a>

## SurfaceWall\(JsonObject\) Constructor

Initializes a new instance of the [SurfaceWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceWall 'DiGi\.Analytical\.Building\.Classes\.SurfaceWall') class from the specified JSON object\.

```csharp
public SurfaceWall(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.SurfaceWall.SurfaceWall(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.
### Methods

<a name='DiGi.Analytical.Building.Classes.SurfaceWall.GetBoundingBox()'></a>

## SurfaceWall\.GetBoundingBox\(\) Method

Gets the axis\-aligned bounding box of the surface wall\.

```csharp
public override DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d.getboundingbox 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D\.GetBoundingBox')

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
The bounding box encompassing the surface wall, or null if it cannot be determined\.

<a name='DiGi.Analytical.Building.Classes.Wall_T_'></a>

## Wall\<T\> Class

Represents an abstract base class for a wall component within a building's analytical structure\.

```csharp
public abstract class Wall<T> : DiGi.Analytical.Building.Classes.PhysicalComponent<T>, DiGi.Analytical.Building.Interfaces.IWall<T>, DiGi.Analytical.Building.Interfaces.IWall, DiGi.Analytical.Building.Interfaces.IPhysicalComponent, DiGi.Analytical.Building.Interfaces.IComponent, DiGi.Analytical.Building.Interfaces.IBuildingBoundable3D, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Analytical.Building.Interfaces.IConstructable, DiGi.Analytical.Building.Interfaces.IPhysicalComponent<T>, DiGi.Analytical.Building.Interfaces.IBuildingGeometryObject<T>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<T>
    where T : DiGi.Geometry.Spatial.Interfaces.IGeometry3D
```
#### Type parameters

<a name='DiGi.Analytical.Building.Classes.Wall_T_.T'></a>

`T`

The type of the 3D geometry associated with the wall, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry3DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry3DObject') → [Component](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Component 'DiGi\.Analytical\.Building\.Classes\.Component') → [PhysicalComponent](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent') → [DiGi\.Analytical\.Building\.Classes\.PhysicalComponent&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_.T 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponent_T_ 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponent\<T\>') → Wall\<T\>

Derived  
↳ [CurveWall&lt;TCurve3D&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall_TCurve3D_ 'DiGi\.Analytical\.Building\.Classes\.CurveWall\<TCurve3D\>')  
↳ [SurfaceWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceWall 'DiGi\.Analytical\.Building\.Classes\.SurfaceWall')

Implements [DiGi\.Analytical\.Building\.Interfaces\.IWall&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall-1 'DiGi\.Analytical\.Building\.Interfaces\.IWall\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_.T 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall-1 'DiGi\.Analytical\.Building\.Interfaces\.IWall\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingboundable3d 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingBoundable3D'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstructable](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstructable 'DiGi\.Analytical\.Building\.Interfaces\.IConstructable'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_.T 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponent-1 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_.T 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometryobject-1 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometryObject\`1'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_.T 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.Wall_T_.Wall(DiGi.Analytical.Building.Classes.Wall_T_)'></a>

## Wall\(Wall\<T\>\) Constructor

Initializes a new instance of the [Wall&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>') class using an existing wall instance\.

```csharp
public Wall(DiGi.Analytical.Building.Classes.Wall<T>? wall);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Wall_T_.Wall(DiGi.Analytical.Building.Classes.Wall_T_).wall'></a>

`wall` [DiGi\.Analytical\.Building\.Classes\.Wall&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_.T 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>')

The source [Wall&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.Wall_T_.Wall(DiGi.Analytical.Building.Interfaces.IWall,T)'></a>

## Wall\(IWall, T\) Constructor

Initializes a new instance of the [Wall&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>') class using an existing wall and specific geometry\.

```csharp
public Wall(DiGi.Analytical.Building.Interfaces.IWall? wall, T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Wall_T_.Wall(DiGi.Analytical.Building.Interfaces.IWall,T).wall'></a>

`wall` [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')

The source wall from which to copy properties\.

<a name='DiGi.Analytical.Building.Classes.Wall_T_.Wall(DiGi.Analytical.Building.Interfaces.IWall,T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_.T 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>\.T')

The 3D geometry to assign to the wall\.

<a name='DiGi.Analytical.Building.Classes.Wall_T_.Wall(System.Guid,DiGi.Analytical.Building.Classes.Wall_T_)'></a>

## Wall\(Guid, Wall\<T\>\) Constructor

Initializes a new instance of the [Wall&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>') class using a specified unique identifier and an optional source wall object\.

```csharp
public Wall(System.Guid guid, DiGi.Analytical.Building.Classes.Wall<T>? wall);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Wall_T_.Wall(System.Guid,DiGi.Analytical.Building.Classes.Wall_T_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the wall\.

<a name='DiGi.Analytical.Building.Classes.Wall_T_.Wall(System.Guid,DiGi.Analytical.Building.Classes.Wall_T_).wall'></a>

`wall` [DiGi\.Analytical\.Building\.Classes\.Wall&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>')[T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_.T 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>\.T')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>')

An existing wall instance from which to copy properties, such as the structure position\.

<a name='DiGi.Analytical.Building.Classes.Wall_T_.Wall(System.Text.Json.Nodes.JsonObject)'></a>

## Wall\(JsonObject\) Constructor

Initializes a new instance of the [Wall&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>') class using the specified JSON object\.

```csharp
public Wall(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Wall_T_.Wall(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data for initialization\.

<a name='DiGi.Analytical.Building.Classes.Wall_T_.Wall(T)'></a>

## Wall\(T\) Constructor

Initializes a new instance of the [Wall&lt;T&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_ 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>') class with the specified geometry\.

```csharp
public Wall(T? geometry);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Wall_T_.Wall(T).geometry'></a>

`geometry` [T](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Wall_T_.T 'DiGi\.Analytical\.Building\.Classes\.Wall\<T\>\.T')

The optional 3D geometry to associate with the wall\.

<a name='DiGi.Analytical.Building.Classes.WallConstruction'></a>

## WallConstruction Class

Represents the construction properties and specifications for a wall component within the analytical building model\.

```csharp
public class WallConstruction : DiGi.Analytical.Building.Classes.ComponentConstruction<DiGi.Analytical.Building.Interfaces.IWall>, DiGi.Analytical.Building.Interfaces.IWallConstruction, DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction<DiGi.Analytical.Building.Interfaces.IWall>, DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction, DiGi.Analytical.Building.Interfaces.IConstruction, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject, DiGi.Analytical.Building.Interfaces.IBuildingDescribableObject, DiGi.Core.Interfaces.IDescribableObject, DiGi.Analytical.Building.Interfaces.IConstruction<DiGi.Analytical.Building.Interfaces.IWall>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingNamedObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingNamedObject 'DiGi\.Analytical\.Building\.Classes\.BuildingNamedObject') → [PhysicalComponentConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.PhysicalComponentConstruction 'DiGi\.Analytical\.Building\.Classes\.PhysicalComponentConstruction') → [DiGi\.Analytical\.Building\.Classes\.ComponentConstruction&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>')[DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ComponentConstruction_TConstructable_ 'DiGi\.Analytical\.Building\.Classes\.ComponentConstruction\<TConstructable\>') → WallConstruction

Implements [DiGi\.Analytical\.Building\.Interfaces\.IWallConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwallconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IWallConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction\`1')[DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingdescribableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction\`1')[DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.WallConstruction.WallConstruction()'></a>

## WallConstruction\(\) Constructor

Initializes a new instance of the [WallConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WallConstruction 'DiGi\.Analytical\.Building\.Classes\.WallConstruction') class\.

```csharp
public WallConstruction();
```

<a name='DiGi.Analytical.Building.Classes.WallConstruction.WallConstruction(DiGi.Analytical.Building.Classes.WallConstruction)'></a>

## WallConstruction\(WallConstruction\) Constructor

Initializes a new instance of the [WallConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WallConstruction 'DiGi\.Analytical\.Building\.Classes\.WallConstruction') class using an existing [WallConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WallConstruction 'DiGi\.Analytical\.Building\.Classes\.WallConstruction') instance\.

```csharp
public WallConstruction(DiGi.Analytical.Building.Classes.WallConstruction? wallConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.WallConstruction.WallConstruction(DiGi.Analytical.Building.Classes.WallConstruction).wallConstruction'></a>

`wallConstruction` [WallConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WallConstruction 'DiGi\.Analytical\.Building\.Classes\.WallConstruction')

The source [WallConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WallConstruction 'DiGi\.Analytical\.Building\.Classes\.WallConstruction') instance to copy from\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.WallConstruction.WallConstruction(System.Guid,DiGi.Analytical.Building.Classes.WallConstruction)'></a>

## WallConstruction\(Guid, WallConstruction\) Constructor

Initializes a new instance of the [WallConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WallConstruction 'DiGi\.Analytical\.Building\.Classes\.WallConstruction') class using a specified unique identifier and an optional source construction\.

```csharp
public WallConstruction(System.Guid guid, DiGi.Analytical.Building.Classes.WallConstruction? wallConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.WallConstruction.WallConstruction(System.Guid,DiGi.Analytical.Building.Classes.WallConstruction).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the wall construction\.

<a name='DiGi.Analytical.Building.Classes.WallConstruction.WallConstruction(System.Guid,DiGi.Analytical.Building.Classes.WallConstruction).wallConstruction'></a>

`wallConstruction` [WallConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WallConstruction 'DiGi\.Analytical\.Building\.Classes\.WallConstruction')

An optional existing [WallConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WallConstruction 'DiGi\.Analytical\.Building\.Classes\.WallConstruction') instance to use as a template or source for initialization\.

<a name='DiGi.Analytical.Building.Classes.WallConstruction.WallConstruction(System.Text.Json.Nodes.JsonObject)'></a>

## WallConstruction\(JsonObject\) Constructor

Initializes a new instance of the [WallConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WallConstruction 'DiGi\.Analytical\.Building\.Classes\.WallConstruction') class using the specified JSON object\.

```csharp
public WallConstruction(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.WallConstruction.WallConstruction(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the wall construction\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.WindowConstruction'></a>

## WindowConstruction Class

Represents the construction details of a window within a building's analytical model, providing functionality for managing window\-specific properties and geometry\.

```csharp
public class WindowConstruction : DiGi.Analytical.Building.Classes.OpeningConstruction<DiGi.Analytical.Building.Interfaces.IWindow>, DiGi.Analytical.Building.Interfaces.IWindowConstruction, DiGi.Analytical.Building.Interfaces.IOpeningConstruction<DiGi.Analytical.Building.Interfaces.IWindow>, DiGi.Analytical.Building.Interfaces.IOpeningConstruction, DiGi.Analytical.Building.Interfaces.IGeometry2DConstruction, DiGi.Analytical.Building.Interfaces.IConstruction, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject, DiGi.Analytical.Building.Interfaces.IBuildingDescribableObject, DiGi.Core.Interfaces.IDescribableObject, DiGi.Analytical.Building.Interfaces.IGeometry2DConstruction<DiGi.Analytical.Building.Interfaces.IWindow, DiGi.Geometry.Planar.Interfaces.ISurface2D>, DiGi.Analytical.Building.Interfaces.IGeometry2DConstruction<DiGi.Analytical.Building.Interfaces.IWindow>, DiGi.Analytical.Building.Interfaces.IConstruction<DiGi.Analytical.Building.Interfaces.IWindow>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → [BuildingGeometry2DObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject') → [DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingGeometry2DObject_T_ 'DiGi\.Analytical\.Building\.Classes\.BuildingGeometry2DObject\<T\>') → [OpeningConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction') → [DiGi\.Analytical\.Building\.Classes\.OpeningConstruction&lt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_ 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction\<TOpening\>')[DiGi\.Analytical\.Building\.Interfaces\.IWindow](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwindow 'DiGi\.Analytical\.Building\.Interfaces\.IWindow')[&gt;](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.OpeningConstruction_TOpening_ 'DiGi\.Analytical\.Building\.Classes\.OpeningConstruction\<TOpening\>') → WindowConstruction

Implements [DiGi\.Analytical\.Building\.Interfaces\.IWindowConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwindowconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IWindowConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction\`1')[DiGi\.Analytical\.Building\.Interfaces\.IWindow](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwindow 'DiGi\.Analytical\.Building\.Interfaces\.IWindow')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingdescribableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingDescribableObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction-2 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction\`2')[DiGi\.Analytical\.Building\.Interfaces\.IWindow](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwindow 'DiGi\.Analytical\.Building\.Interfaces\.IWindow')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction-2 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction\`2')[DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction-2 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction\`2'), [DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction\`1')[DiGi\.Analytical\.Building\.Interfaces\.IWindow](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwindow 'DiGi\.Analytical\.Building\.Interfaces\.IWindow')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.igeometry2dconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IGeometry2DConstruction\`1'), [DiGi\.Analytical\.Building\.Interfaces\.IConstruction&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction\`1')[DiGi\.Analytical\.Building\.Interfaces\.IWindow](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwindow 'DiGi\.Analytical\.Building\.Interfaces\.IWindow')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iconstruction-1 'DiGi\.Analytical\.Building\.Interfaces\.IConstruction\`1')
### Constructors

<a name='DiGi.Analytical.Building.Classes.WindowConstruction.WindowConstruction(DiGi.Analytical.Building.Classes.WindowConstruction)'></a>

## WindowConstruction\(WindowConstruction\) Constructor

Initializes a new instance of the [WindowConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WindowConstruction 'DiGi\.Analytical\.Building\.Classes\.WindowConstruction') class using an existing [WindowConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WindowConstruction 'DiGi\.Analytical\.Building\.Classes\.WindowConstruction') instance\.

```csharp
public WindowConstruction(DiGi.Analytical.Building.Classes.WindowConstruction? windowConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.WindowConstruction.WindowConstruction(DiGi.Analytical.Building.Classes.WindowConstruction).windowConstruction'></a>

`windowConstruction` [WindowConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WindowConstruction 'DiGi\.Analytical\.Building\.Classes\.WindowConstruction')

The source [WindowConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WindowConstruction 'DiGi\.Analytical\.Building\.Classes\.WindowConstruction') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.WindowConstruction.WindowConstruction(string,DiGi.Geometry.Planar.Interfaces.ISurface2D)'></a>

## WindowConstruction\(string, ISurface2D\) Constructor

Initializes a new instance of the [WindowConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WindowConstruction 'DiGi\.Analytical\.Building\.Classes\.WindowConstruction') class\.

```csharp
public WindowConstruction(string? name, DiGi.Geometry.Planar.Interfaces.ISurface2D? surface2D);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.WindowConstruction.WindowConstruction(string,DiGi.Geometry.Planar.Interfaces.ISurface2D).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional name of the window construction\.

<a name='DiGi.Analytical.Building.Classes.WindowConstruction.WindowConstruction(string,DiGi.Geometry.Planar.Interfaces.ISurface2D).surface2D'></a>

`surface2D` [DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')

The optional 2D surface associated with the window construction\.

<a name='DiGi.Analytical.Building.Classes.WindowConstruction.WindowConstruction(System.Guid,DiGi.Analytical.Building.Classes.WindowConstruction)'></a>

## WindowConstruction\(Guid, WindowConstruction\) Constructor

Initializes a new instance of the [WindowConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WindowConstruction 'DiGi\.Analytical\.Building\.Classes\.WindowConstruction') class with a specified unique identifier and an optional source window construction\.

```csharp
public WindowConstruction(System.Guid guid, DiGi.Analytical.Building.Classes.WindowConstruction? windowConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.WindowConstruction.WindowConstruction(System.Guid,DiGi.Analytical.Building.Classes.WindowConstruction).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the object\.

<a name='DiGi.Analytical.Building.Classes.WindowConstruction.WindowConstruction(System.Guid,DiGi.Analytical.Building.Classes.WindowConstruction).windowConstruction'></a>

`windowConstruction` [WindowConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WindowConstruction 'DiGi\.Analytical\.Building\.Classes\.WindowConstruction')

The existing [WindowConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WindowConstruction 'DiGi\.Analytical\.Building\.Classes\.WindowConstruction') instance to copy properties from\.

<a name='DiGi.Analytical.Building.Classes.WindowConstruction.WindowConstruction(System.Text.Json.Nodes.JsonObject)'></a>

## WindowConstruction\(JsonObject\) Constructor

Initializes a new instance of the [WindowConstruction](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.WindowConstruction 'DiGi\.Analytical\.Building\.Classes\.WindowConstruction') class using the specified JSON object\.

```csharp
public WindowConstruction(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.WindowConstruction.WindowConstruction(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the instance\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.Zone'></a>

## Zone Class

Represents a specific zone within a building, implementing the [DiGi\.Analytical\.Building\.Interfaces\.IZone](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.izone 'DiGi\.Analytical\.Building\.Interfaces\.IZone') interface and inheriting from [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject')\.

```csharp
public class Zone : DiGi.Analytical.Building.Classes.BuildingObject, DiGi.Analytical.Building.Interfaces.IZone, DiGi.Analytical.Building.Interfaces.IBuildingGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingSerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Analytical.Building.Interfaces.IBuildingNamedObject, DiGi.Core.Interfaces.INamedObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → [BuildingObject](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingObject 'DiGi\.Analytical\.Building\.Classes\.BuildingObject') → Zone

Implements [DiGi\.Analytical\.Building\.Interfaces\.IZone](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.izone 'DiGi\.Analytical\.Building\.Interfaces\.IZone'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingguidobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingserializableobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingSerializableObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticaluniqueobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingnamedobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingNamedObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.Zone.Zone(DiGi.Analytical.Building.Classes.Zone)'></a>

## Zone\(Zone\) Constructor

Initializes a new instance of the [Zone](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Zone 'DiGi\.Analytical\.Building\.Classes\.Zone') class using the data from an existing [Zone](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Zone 'DiGi\.Analytical\.Building\.Classes\.Zone') instance\.

```csharp
public Zone(DiGi.Analytical.Building.Classes.Zone? zone);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Zone.Zone(DiGi.Analytical.Building.Classes.Zone).zone'></a>

`zone` [Zone](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Zone 'DiGi\.Analytical\.Building\.Classes\.Zone')

The source [Zone](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Zone 'DiGi\.Analytical\.Building\.Classes\.Zone') instance to copy properties from\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.Zone.Zone(string)'></a>

## Zone\(string\) Constructor

Initializes a new instance of the [Zone](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Zone 'DiGi\.Analytical\.Building\.Classes\.Zone') class with the specified name\.

```csharp
public Zone(string? name);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Zone.Zone(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the zone\.

<a name='DiGi.Analytical.Building.Classes.Zone.Zone(System.Guid,DiGi.Analytical.Building.Classes.Zone)'></a>

## Zone\(Guid, Zone\) Constructor

Initializes a new instance of the [Zone](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Zone 'DiGi\.Analytical\.Building\.Classes\.Zone') class using a specified unique identifier and an optional source zone for initialization\.

```csharp
public Zone(System.Guid guid, DiGi.Analytical.Building.Classes.Zone? zone);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Zone.Zone(System.Guid,DiGi.Analytical.Building.Classes.Zone).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique global identifier for the zone\.

<a name='DiGi.Analytical.Building.Classes.Zone.Zone(System.Guid,DiGi.Analytical.Building.Classes.Zone).zone'></a>

`zone` [Zone](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Zone 'DiGi\.Analytical\.Building\.Classes\.Zone')

An optional [Zone](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Zone 'DiGi\.Analytical\.Building\.Classes\.Zone') object from which to copy properties\.

<a name='DiGi.Analytical.Building.Classes.Zone.Zone(System.Text.Json.Nodes.JsonObject)'></a>

## Zone\(JsonObject\) Constructor

Initializes a new instance of the [Zone](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.Zone 'DiGi\.Analytical\.Building\.Classes\.Zone') class using the specified JSON object\.

```csharp
public Zone(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.Zone.Zone(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the zone\.
### Properties

<a name='DiGi.Analytical.Building.Classes.Zone.Name'></a>

## Zone\.Name Property

Gets or sets the name of the zone\.

```csharp
public string? Name { get; set; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Analytical.Building.Classes.ZoneRelation'></a>

## ZoneRelation Class

Represents a one\-to\-many bidirectional relationship between a zone and its associated spaces within a building\.

```csharp
public class ZoneRelation : DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation<DiGi.Analytical.Building.Interfaces.IZone, DiGi.Analytical.Building.Interfaces.ISpace>, DiGi.Analytical.Building.Interfaces.IBuildingRelation, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IZone](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.izone 'DiGi\.Analytical\.Building\.Interfaces\.IZone')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IZone](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.izone 'DiGi\.Analytical\.Building\.Interfaces\.IZone')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.IZone](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.izone 'DiGi\.Analytical\.Building\.Interfaces\.IZone')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2') → ZoneRelation

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingrelation 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingRelation'), [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Analytical.Building.Classes.ZoneRelation.ZoneRelation(DiGi.Analytical.Building.Classes.ZoneRelation)'></a>

## ZoneRelation\(ZoneRelation\) Constructor

Initializes a new instance of the [ZoneRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ZoneRelation 'DiGi\.Analytical\.Building\.Classes\.ZoneRelation') class by copying an existing relation\.

```csharp
public ZoneRelation(DiGi.Analytical.Building.Classes.ZoneRelation? zoneRelation);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ZoneRelation.ZoneRelation(DiGi.Analytical.Building.Classes.ZoneRelation).zoneRelation'></a>

`zoneRelation` [ZoneRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ZoneRelation 'DiGi\.Analytical\.Building\.Classes\.ZoneRelation')

The source [ZoneRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ZoneRelation 'DiGi\.Analytical\.Building\.Classes\.ZoneRelation') instance to copy from\.

<a name='DiGi.Analytical.Building.Classes.ZoneRelation.ZoneRelation(DiGi.Analytical.Building.Interfaces.IZone,DiGi.Analytical.Building.Interfaces.ISpace)'></a>

## ZoneRelation\(IZone, ISpace\) Constructor

Initializes a new instance of the [ZoneRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ZoneRelation 'DiGi\.Analytical\.Building\.Classes\.ZoneRelation') class that relates a specific zone to a single space\.

```csharp
public ZoneRelation(DiGi.Analytical.Building.Interfaces.IZone? zone, DiGi.Analytical.Building.Interfaces.ISpace? space);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ZoneRelation.ZoneRelation(DiGi.Analytical.Building.Interfaces.IZone,DiGi.Analytical.Building.Interfaces.ISpace).zone'></a>

`zone` [DiGi\.Analytical\.Building\.Interfaces\.IZone](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.izone 'DiGi\.Analytical\.Building\.Interfaces\.IZone')

The zone associated with this relation\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.ZoneRelation.ZoneRelation(DiGi.Analytical.Building.Interfaces.IZone,DiGi.Analytical.Building.Interfaces.ISpace).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space associated with this relation\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.ZoneRelation.ZoneRelation(DiGi.Analytical.Building.Interfaces.IZone,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_)'></a>

## ZoneRelation\(IZone, IEnumerable\<ISpace\>\) Constructor

Initializes a new instance of the [ZoneRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ZoneRelation 'DiGi\.Analytical\.Building\.Classes\.ZoneRelation') class with the specified zone and collection of spaces\.

```csharp
public ZoneRelation(DiGi.Analytical.Building.Interfaces.IZone? zone, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Interfaces.ISpace>? spaces);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ZoneRelation.ZoneRelation(DiGi.Analytical.Building.Interfaces.IZone,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_).zone'></a>

`zone` [DiGi\.Analytical\.Building\.Interfaces\.IZone](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.izone 'DiGi\.Analytical\.Building\.Interfaces\.IZone')

The zone associated with this relation\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.ZoneRelation.ZoneRelation(DiGi.Analytical.Building.Interfaces.IZone,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_).spaces'></a>

`spaces` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of spaces associated with this relation\. This value can be null\.

<a name='DiGi.Analytical.Building.Classes.ZoneRelation.ZoneRelation(System.Text.Json.Nodes.JsonObject)'></a>

## ZoneRelation\(JsonObject\) Constructor

Initializes a new instance of the [ZoneRelation](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ZoneRelation 'DiGi\.Analytical\.Building\.Classes\.ZoneRelation') class from the specified JSON object\.

```csharp
public ZoneRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Building.Classes.ZoneRelation.ZoneRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the serialized data used to populate the relation\.