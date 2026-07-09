#### [DiGi\.Analytical\.Urban](DiGi.Analytical.Urban.Overview.md 'DiGi\.Analytical\.Urban\.Overview')

## DiGi\.Analytical\.Urban\.Classes Namespace
### Classes

<a name='DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation'></a>

## BuildingModelBoundingBoxRelation Class

Represents a one\-to\-one bidirectional relationship between a [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') and a [DiGi\.Analytical\.Classes\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.boundingbox 'DiGi\.Analytical\.Classes\.BoundingBox')\.

```csharp
public class BuildingModelBoundingBoxRelation : DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation<DiGi.Analytical.Building.Classes.BuildingModel, DiGi.Analytical.Classes.BoundingBox>, DiGi.Analytical.Urban.Interfaces.IUrbanRelation, DiGi.Analytical.Urban.Interfaces.IUrbanObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Analytical\.Classes\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.boundingbox 'DiGi\.Analytical\.Classes\.BoundingBox')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[DiGi\.Analytical\.Classes\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.boundingbox 'DiGi\.Analytical\.Classes\.BoundingBox')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2')[DiGi\.Analytical\.Classes\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.boundingbox 'DiGi\.Analytical\.Classes\.BoundingBox')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2') → BuildingModelBoundingBoxRelation

Implements [DiGi\.Analytical\.Urban\.Interfaces\.IUrbanRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.urban.interfaces.iurbanrelation 'DiGi\.Analytical\.Urban\.Interfaces\.IUrbanRelation'), [DiGi\.Analytical\.Urban\.Interfaces\.IUrbanObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.urban.interfaces.iurbanobject 'DiGi\.Analytical\.Urban\.Interfaces\.IUrbanObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation.BuildingModelBoundingBoxRelation(DiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Classes.BoundingBox)'></a>

## BuildingModelBoundingBoxRelation\(BuildingModel, BoundingBox\) Constructor

Initializes a new instance of the [BuildingModelBoundingBoxRelation](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation 'DiGi\.Analytical\.Urban\.Classes\.BuildingModelBoundingBoxRelation') class\.

```csharp
public BuildingModelBoundingBoxRelation(DiGi.Analytical.Building.Classes.BuildingModel? buildingModel, DiGi.Analytical.Classes.BoundingBox? boundingBox3D);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation.BuildingModelBoundingBoxRelation(DiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Classes.BoundingBox).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model associated with this relation\.

<a name='DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation.BuildingModelBoundingBoxRelation(DiGi.Analytical.Building.Classes.BuildingModel,DiGi.Analytical.Classes.BoundingBox).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Analytical\.Classes\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.classes.boundingbox 'DiGi\.Analytical\.Classes\.BoundingBox')

The 3D bounding box associated with this relation\.

<a name='DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation.BuildingModelBoundingBoxRelation(DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation)'></a>

## BuildingModelBoundingBoxRelation\(BuildingModelBoundingBoxRelation\) Constructor

Initializes a new instance of the [BuildingModelBoundingBoxRelation](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation 'DiGi\.Analytical\.Urban\.Classes\.BuildingModelBoundingBoxRelation') class using an existing relation instance\.

```csharp
public BuildingModelBoundingBoxRelation(DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation? buildingModelBoundingBoxRelation);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation.BuildingModelBoundingBoxRelation(DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation).buildingModelBoundingBoxRelation'></a>

`buildingModelBoundingBoxRelation` [BuildingModelBoundingBoxRelation](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation 'DiGi\.Analytical\.Urban\.Classes\.BuildingModelBoundingBoxRelation')

The existing [BuildingModelBoundingBoxRelation](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation 'DiGi\.Analytical\.Urban\.Classes\.BuildingModelBoundingBoxRelation') instance to copy from\.

<a name='DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation.BuildingModelBoundingBoxRelation(System.Text.Json.Nodes.JsonObject)'></a>

## BuildingModelBoundingBoxRelation\(JsonObject\) Constructor

Initializes a new instance of the [BuildingModelBoundingBoxRelation](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation 'DiGi\.Analytical\.Urban\.Classes\.BuildingModelBoundingBoxRelation') class using the specified JSON object\.

```csharp
public BuildingModelBoundingBoxRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation.BuildingModelBoundingBoxRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the relation\.

<a name='DiGi.Analytical.Urban.Classes.UrbanInformation'></a>

## UrbanInformation Class

Represents urban\-related information for a building object, providing spatial context through coordinates\.

```csharp
public class UrbanInformation : DiGi.Core.Classes.SerializableObject, DiGi.Analytical.Building.Interfaces.IBuildingObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → UrbanInformation

Implements [DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildingobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingObject'), [DiGi\.Analytical\.Interfaces\.IAnalyticalObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Analytical.Urban.Classes.UrbanInformation.UrbanInformation()'></a>

## UrbanInformation\(\) Constructor

Initializes a new instance of the [UrbanInformation](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanInformation 'DiGi\.Analytical\.Urban\.Classes\.UrbanInformation') class\.

```csharp
public UrbanInformation();
```

<a name='DiGi.Analytical.Urban.Classes.UrbanInformation.UrbanInformation(DiGi.Analytical.Urban.Classes.UrbanInformation)'></a>

## UrbanInformation\(UrbanInformation\) Constructor

Initializes a new instance of the [UrbanInformation](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanInformation 'DiGi\.Analytical\.Urban\.Classes\.UrbanInformation') class using an existing [UrbanInformation](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanInformation 'DiGi\.Analytical\.Urban\.Classes\.UrbanInformation') instance\.

```csharp
public UrbanInformation(DiGi.Analytical.Urban.Classes.UrbanInformation? urbanInformation);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.UrbanInformation.UrbanInformation(DiGi.Analytical.Urban.Classes.UrbanInformation).urbanInformation'></a>

`urbanInformation` [UrbanInformation](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanInformation 'DiGi\.Analytical\.Urban\.Classes\.UrbanInformation')

The source [UrbanInformation](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanInformation 'DiGi\.Analytical\.Urban\.Classes\.UrbanInformation') object to copy data from\. This value can be null\.

<a name='DiGi.Analytical.Urban.Classes.UrbanInformation.UrbanInformation(System.Text.Json.Nodes.JsonObject)'></a>

## UrbanInformation\(JsonObject\) Constructor

Initializes a new instance of the [UrbanInformation](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanInformation 'DiGi\.Analytical\.Urban\.Classes\.UrbanInformation') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public UrbanInformation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.UrbanInformation.UrbanInformation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.
### Properties

<a name='DiGi.Analytical.Urban.Classes.UrbanInformation.Coordinates'></a>

## UrbanInformation\.Coordinates Property

Gets or sets the geographic coordinates associated with the urban information\.

```csharp
public DiGi.Core.Classes.Coordinates? Coordinates { get; set; }
```

#### Property Value
[DiGi\.Core\.Classes\.Coordinates](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.coordinates 'DiGi\.Core\.Classes\.Coordinates')

<a name='DiGi.Analytical.Urban.Classes.UrbanModel'></a>

## UrbanModel Class

Represents an urban model that manages urban\-related information and relation clusters within a parametrized GUID object framework\.

```csharp
public class UrbanModel : DiGi.Core.Parameter.Classes.ParametrizedGuidObject, DiGi.Analytical.Urban.Interfaces.IUrbanGuidObject, DiGi.Analytical.Urban.Interfaces.IUrbanObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IGuidModel, DiGi.Core.Interfaces.ISerializableModel, DiGi.Core.Interfaces.IModel
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedguidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject') → UrbanModel

Implements [DiGi\.Analytical\.Urban\.Interfaces\.IUrbanGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.urban.interfaces.iurbanguidobject 'DiGi\.Analytical\.Urban\.Interfaces\.IUrbanGuidObject'), [DiGi\.Analytical\.Urban\.Interfaces\.IUrbanObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.urban.interfaces.iurbanobject 'DiGi\.Analytical\.Urban\.Interfaces\.IUrbanObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IGuidModel](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidmodel 'DiGi\.Core\.Interfaces\.IGuidModel'), [DiGi\.Core\.Interfaces\.ISerializableModel](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializablemodel 'DiGi\.Core\.Interfaces\.ISerializableModel'), [DiGi\.Core\.Interfaces\.IModel](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.imodel 'DiGi\.Core\.Interfaces\.IModel')
### Constructors

<a name='DiGi.Analytical.Urban.Classes.UrbanModel.UrbanModel(DiGi.Analytical.Urban.Classes.UrbanModel)'></a>

## UrbanModel\(UrbanModel\) Constructor

Initializes a new instance of the [UrbanModel](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanModel 'DiGi\.Analytical\.Urban\.Classes\.UrbanModel') class by cloning an existing urban model\.

```csharp
public UrbanModel(DiGi.Analytical.Urban.Classes.UrbanModel? urbanModel);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.UrbanModel.UrbanModel(DiGi.Analytical.Urban.Classes.UrbanModel).urbanModel'></a>

`urbanModel` [UrbanModel](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanModel 'DiGi\.Analytical\.Urban\.Classes\.UrbanModel')

The source [UrbanModel](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanModel 'DiGi\.Analytical\.Urban\.Classes\.UrbanModel') to clone from; if null, a default instance is initialized\.

<a name='DiGi.Analytical.Urban.Classes.UrbanModel.UrbanModel(System.Text.Json.Nodes.JsonObject)'></a>

## UrbanModel\(JsonObject\) Constructor

Initializes a new instance of the [UrbanModel](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanModel 'DiGi\.Analytical\.Urban\.Classes\.UrbanModel') class from the specified JSON object\.

```csharp
public UrbanModel(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.UrbanModel.UrbanModel(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the model; may be null\.
### Properties

<a name='DiGi.Analytical.Urban.Classes.UrbanModel.UrbanInformation'></a>

## UrbanModel\.UrbanInformation Property

Gets or sets the urban information associated with this urban model\.

```csharp
public DiGi.Analytical.Urban.Classes.UrbanInformation UrbanInformation { get; set; }
```

#### Property Value
[UrbanInformation](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanInformation 'DiGi\.Analytical\.Urban\.Classes\.UrbanInformation')
### Methods

<a name='DiGi.Analytical.Urban.Classes.UrbanModel.GetBoundingBox()'></a>

## UrbanModel\.GetBoundingBox\(\) Method

Gets the axis\-aligned bounding box encompassing all building models within the urban model\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the combined bounding box of all buildings, or null if no valid bounding boxes could be determined\.

<a name='DiGi.Analytical.Urban.Classes.UrbanModel.GetBoundingBox(DiGi.Analytical.Building.Classes.BuildingModel)'></a>

## UrbanModel\.GetBoundingBox\(BuildingModel\) Method

Gets the axis\-aligned bounding box of the specified building model\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox(DiGi.Analytical.Building.Classes.BuildingModel? buildingModel);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.UrbanModel.GetBoundingBox(DiGi.Analytical.Building.Classes.BuildingModel).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model for which to retrieve the bounding box\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the bounding box of the building model, or null if it cannot be determined or the provided model is null\.

<a name='DiGi.Analytical.Urban.Classes.UrbanModel.GetBuildingModels()'></a>

## UrbanModel\.GetBuildingModels\(\) Method

Gets all building models contained in the urban model\.

```csharp
public System.Collections.Generic.List<DiGi.Analytical.Building.Classes.BuildingModel>? GetBuildingModels();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') instances contained in the urban model, or null if none are available\.

<a name='DiGi.Analytical.Urban.Classes.UrbanModel.Remove(DiGi.Analytical.Building.Classes.BuildingModel)'></a>

## UrbanModel\.Remove\(BuildingModel\) Method

Removes the specified building model from the urban model\.

```csharp
public bool Remove(DiGi.Analytical.Building.Classes.BuildingModel? buildingModel);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.UrbanModel.Remove(DiGi.Analytical.Building.Classes.BuildingModel).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model to be removed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the building model was successfully removed; otherwise, false\.

<a name='DiGi.Analytical.Urban.Classes.UrbanModel.Remove(DiGi.Core.Classes.GuidReference)'></a>

## UrbanModel\.Remove\(GuidReference\) Method

Removes the specified GUID reference from the urban model\.

```csharp
public bool Remove(DiGi.Core.Classes.GuidReference? guidReference);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.UrbanModel.Remove(DiGi.Core.Classes.GuidReference).guidReference'></a>

`guidReference` [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')

The GUID reference of the object to be removed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reference was successfully removed; otherwise, false\.

<a name='DiGi.Analytical.Urban.Classes.UrbanModel.Update(DiGi.Analytical.Building.Classes.BuildingModel)'></a>

## UrbanModel\.Update\(BuildingModel\) Method

Updates the specified building model within the urban model, refreshing its associated bounding box relations\.

```csharp
public bool Update(DiGi.Analytical.Building.Classes.BuildingModel? buildingModel);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.UrbanModel.Update(DiGi.Analytical.Building.Classes.BuildingModel).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model instance to be updated\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update operation was successful; otherwise, false\.

<a name='DiGi.Analytical.Urban.Classes.UrbanModelFile'></a>

## UrbanModelFile Class

Represents a file that stores and manages an [UrbanModel](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanModel 'DiGi\.Analytical\.Urban\.Classes\.UrbanModel')\.

```csharp
public class UrbanModelFile : DiGi.Core.IO.File.Classes.ValueFile<DiGi.Analytical.Urban.Classes.UrbanModel>, DiGi.Analytical.Urban.Interfaces.IUrbanObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.IO\.File\.Classes\.File](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.file 'DiGi\.Core\.IO\.File\.Classes\.File') → [DiGi\.Core\.IO\.File\.Classes\.ValueFile&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.valuefile-1 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\`1')[UrbanModel](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanModel 'DiGi\.Analytical\.Urban\.Classes\.UrbanModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.valuefile-1 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\`1') → UrbanModelFile

Implements [DiGi\.Analytical\.Urban\.Interfaces\.IUrbanObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.urban.interfaces.iurbanobject 'DiGi\.Analytical\.Urban\.Interfaces\.IUrbanObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Analytical.Urban.Classes.UrbanModelFile.UrbanModelFile(DiGi.Analytical.Urban.Classes.UrbanModelFile)'></a>

## UrbanModelFile\(UrbanModelFile\) Constructor

Initializes a new instance of the [UrbanModelFile](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanModelFile 'DiGi\.Analytical\.Urban\.Classes\.UrbanModelFile') class using the specified [UrbanModelFile](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanModelFile 'DiGi\.Analytical\.Urban\.Classes\.UrbanModelFile')\.

```csharp
public UrbanModelFile(DiGi.Analytical.Urban.Classes.UrbanModelFile? urbanModelFile);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.UrbanModelFile.UrbanModelFile(DiGi.Analytical.Urban.Classes.UrbanModelFile).urbanModelFile'></a>

`urbanModelFile` [UrbanModelFile](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanModelFile 'DiGi\.Analytical\.Urban\.Classes\.UrbanModelFile')

The [UrbanModelFile](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanModelFile 'DiGi\.Analytical\.Urban\.Classes\.UrbanModelFile') instance to copy from\.

<a name='DiGi.Analytical.Urban.Classes.UrbanModelFile.UrbanModelFile(string)'></a>

## UrbanModelFile\(string\) Constructor

Initializes a new instance of the [UrbanModelFile](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanModelFile 'DiGi\.Analytical\.Urban\.Classes\.UrbanModelFile') class using the specified file path\.

```csharp
public UrbanModelFile(string? path);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.UrbanModelFile.UrbanModelFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the urban model file\.

<a name='DiGi.Analytical.Urban.Classes.UrbanModelFile.UrbanModelFile(System.Text.Json.Nodes.JsonObject)'></a>

## UrbanModelFile\(JsonObject\) Constructor

Initializes a new instance of the [UrbanModelFile](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanModelFile 'DiGi\.Analytical\.Urban\.Classes\.UrbanModelFile') class using the specified JSON object\.

```csharp
public UrbanModelFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.UrbanModelFile.UrbanModelFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the urban model file\.

<a name='DiGi.Analytical.Urban.Classes.UrbanRelationCluster'></a>

## UrbanRelationCluster Class

Represents a cluster of urban relations associated with analytical GUID objects, implementing the urban object interface\.

```csharp
public class UrbanRelationCluster : DiGi.Core.Relation.Classes.UniqueObjectRelationCluster<DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Urban.Interfaces.IUrbanRelation>, DiGi.Analytical.Urban.Interfaces.IUrbanObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Cluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3') → [DiGi\.Core\.Classes\.ValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3') → [DiGi\.Core\.Classes\.SerializableObjectValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3') → [DiGi\.Core\.Classes\.UniqueObjectValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobjectvaluecluster-1 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\`1')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobjectvaluecluster-1 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\`1') → [DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationcluster-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\`2')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationcluster-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\`2')[DiGi\.Analytical\.Urban\.Interfaces\.IUrbanRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.urban.interfaces.iurbanrelation 'DiGi\.Analytical\.Urban\.Interfaces\.IUrbanRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationcluster-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\`2') → UrbanRelationCluster

Implements [DiGi\.Analytical\.Urban\.Interfaces\.IUrbanObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.urban.interfaces.iurbanobject 'DiGi\.Analytical\.Urban\.Interfaces\.IUrbanObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Analytical.Urban.Classes.UrbanRelationCluster.UrbanRelationCluster()'></a>

## UrbanRelationCluster\(\) Constructor

Initializes a new instance of the [UrbanRelationCluster](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanRelationCluster 'DiGi\.Analytical\.Urban\.Classes\.UrbanRelationCluster') class\.

```csharp
public UrbanRelationCluster();
```

<a name='DiGi.Analytical.Urban.Classes.UrbanRelationCluster.UrbanRelationCluster(DiGi.Analytical.Urban.Classes.UrbanRelationCluster)'></a>

## UrbanRelationCluster\(UrbanRelationCluster\) Constructor

Initializes a new instance of the [UrbanRelationCluster](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanRelationCluster 'DiGi\.Analytical\.Urban\.Classes\.UrbanRelationCluster') class using an existing [UrbanRelationCluster](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanRelationCluster 'DiGi\.Analytical\.Urban\.Classes\.UrbanRelationCluster') instance\.

```csharp
public UrbanRelationCluster(DiGi.Analytical.Urban.Classes.UrbanRelationCluster? urbanRelationCluster);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.UrbanRelationCluster.UrbanRelationCluster(DiGi.Analytical.Urban.Classes.UrbanRelationCluster).urbanRelationCluster'></a>

`urbanRelationCluster` [UrbanRelationCluster](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanRelationCluster 'DiGi\.Analytical\.Urban\.Classes\.UrbanRelationCluster')

The source [UrbanRelationCluster](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanRelationCluster 'DiGi\.Analytical\.Urban\.Classes\.UrbanRelationCluster') instance to copy from\.

<a name='DiGi.Analytical.Urban.Classes.UrbanRelationCluster.UrbanRelationCluster(System.Collections.Generic.IEnumerable_DiGi.Analytical.Interfaces.IAnalyticalGuidObject_)'></a>

## UrbanRelationCluster\(IEnumerable\<IAnalyticalGuidObject\>\) Constructor

Initializes a new instance of the [UrbanRelationCluster](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanRelationCluster 'DiGi\.Analytical\.Urban\.Classes\.UrbanRelationCluster') class using the specified collection of analytical GUID objects\.

```csharp
public UrbanRelationCluster(System.Collections.Generic.IEnumerable<DiGi.Analytical.Interfaces.IAnalyticalGuidObject>? analyticalGuidObjects);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.UrbanRelationCluster.UrbanRelationCluster(System.Collections.Generic.IEnumerable_DiGi.Analytical.Interfaces.IAnalyticalGuidObject_).analyticalGuidObjects'></a>

`analyticalGuidObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.ianalyticalguidobject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject') instances to initialize the cluster with\.

<a name='DiGi.Analytical.Urban.Classes.UrbanRelationCluster.UrbanRelationCluster(System.Text.Json.Nodes.JsonObject)'></a>

## UrbanRelationCluster\(JsonObject\) Constructor

Initializes a new instance of the [UrbanRelationCluster](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanRelationCluster 'DiGi\.Analytical\.Urban\.Classes\.UrbanRelationCluster') class using the specified JSON object\.

```csharp
public UrbanRelationCluster(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Analytical.Urban.Classes.UrbanRelationCluster.UrbanRelationCluster(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the instance\. This value can be null\.