#### [DiGi\.Analytical\.Urban](DiGi.Analytical.Urban.Overview.md 'DiGi\.Analytical\.Urban\.Overview')

## DiGi\.Analytical\.Urban\.Interfaces Namespace
### Interfaces

<a name='DiGi.Analytical.Urban.Interfaces.IUrbanGuidObject'></a>

## IUrbanGuidObject Interface

Interface for urban objects that combine urban object functionality with GUID identification\.

```csharp
public interface IUrbanGuidObject : DiGi.Analytical.Urban.Interfaces.IUrbanObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [UrbanModel](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanModel 'DiGi\.Analytical\.Urban\.Classes\.UrbanModel')

Implements [IUrbanObject](DiGi.Analytical.Urban.Interfaces.md#DiGi.Analytical.Urban.Interfaces.IUrbanObject 'DiGi\.Analytical\.Urban\.Interfaces\.IUrbanObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.Analytical.Urban.Interfaces.IUrbanObject'></a>

## IUrbanObject Interface

Base interface for all urban objects in the analytical framework\.

```csharp
public interface IUrbanObject : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [BuildingModelBoundingBoxRelation](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation 'DiGi\.Analytical\.Urban\.Classes\.BuildingModelBoundingBoxRelation')  
↳ [UrbanModel](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanModel 'DiGi\.Analytical\.Urban\.Classes\.UrbanModel')  
↳ [UrbanModelFile](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanModelFile 'DiGi\.Analytical\.Urban\.Classes\.UrbanModelFile')  
↳ [UrbanRelationCluster](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.UrbanRelationCluster 'DiGi\.Analytical\.Urban\.Classes\.UrbanRelationCluster')  
↳ [IUrbanGuidObject](DiGi.Analytical.Urban.Interfaces.md#DiGi.Analytical.Urban.Interfaces.IUrbanGuidObject 'DiGi\.Analytical\.Urban\.Interfaces\.IUrbanGuidObject')  
↳ [IUrbanRelation](DiGi.Analytical.Urban.Interfaces.md#DiGi.Analytical.Urban.Interfaces.IUrbanRelation 'DiGi\.Analytical\.Urban\.Interfaces\.IUrbanRelation')

Implements [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Analytical.Urban.Interfaces.IUrbanRelation'></a>

## IUrbanRelation Interface

Interface for urban relations that associate urban objects with relational data\.

```csharp
public interface IUrbanRelation : DiGi.Analytical.Urban.Interfaces.IUrbanObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [BuildingModelBoundingBoxRelation](DiGi.Analytical.Urban.Classes.md#DiGi.Analytical.Urban.Classes.BuildingModelBoundingBoxRelation 'DiGi\.Analytical\.Urban\.Classes\.BuildingModelBoundingBoxRelation')

Implements [IUrbanObject](DiGi.Analytical.Urban.Interfaces.md#DiGi.Analytical.Urban.Interfaces.IUrbanObject 'DiGi\.Analytical\.Urban\.Interfaces\.IUrbanObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')