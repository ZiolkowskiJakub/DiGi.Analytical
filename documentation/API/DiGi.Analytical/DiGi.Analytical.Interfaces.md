#### [DiGi\.Analytical](DiGi.Analytical.Overview.md 'DiGi\.Analytical\.Overview')

## DiGi\.Analytical\.Interfaces Namespace
### Interfaces

<a name='DiGi.Analytical.Interfaces.IAnalyticalGeometry'></a>

## IAnalyticalGeometry Interface

Interface for analytical geometry objects that inherit GUID\-based identification\.

```csharp
public interface IAnalyticalGeometry : DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IGuidObject
```

Derived  
↳ [BoundingBox](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.BoundingBox 'DiGi\.Analytical\.Classes\.BoundingBox')  
↳ [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')  
↳ [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')

Implements [IAnalyticalGuidObject](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IAnalyticalGuidObject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [IAnalyticalUniqueObject](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IAnalyticalUniqueObject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [IAnalyticalObject](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IAnalyticalObject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')

<a name='DiGi.Analytical.Interfaces.IAnalyticalGuidObject'></a>

## IAnalyticalGuidObject Interface

Interface for analytical objects that require both unique object identification and GUID support\.

```csharp
public interface IAnalyticalGuidObject : DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IGuidObject
```

Derived  
↳ [BoundingBox](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.BoundingBox 'DiGi\.Analytical\.Classes\.BoundingBox')  
↳ [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')  
↳ [Material](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Material 'DiGi\.Analytical\.Classes\.Material')  
↳ [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')  
↳ [IAnalyticalGeometry](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IAnalyticalGeometry 'DiGi\.Analytical\.Interfaces\.IAnalyticalGeometry')  
↳ [IMaterial](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IMaterial 'DiGi\.Analytical\.Interfaces\.IMaterial')

Implements [IAnalyticalUniqueObject](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IAnalyticalUniqueObject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [IAnalyticalObject](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IAnalyticalObject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')

<a name='DiGi.Analytical.Interfaces.IAnalyticalObject'></a>

## IAnalyticalObject Interface

Base interface for all analytical objects in the DiGi framework\.

```csharp
public interface IAnalyticalObject : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [BoundingBox](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.BoundingBox 'DiGi\.Analytical\.Classes\.BoundingBox')  
↳ [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')  
↳ [Material](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Material 'DiGi\.Analytical\.Classes\.Material')  
↳ [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')  
↳ [SurfaceValue](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.SurfaceValue 'DiGi\.Analytical\.Classes\.SurfaceValue')  
↳ [IAnalyticalGeometry](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IAnalyticalGeometry 'DiGi\.Analytical\.Interfaces\.IAnalyticalGeometry')  
↳ [IAnalyticalGuidObject](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IAnalyticalGuidObject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')  
↳ [IAnalyticalUniqueObject](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IAnalyticalUniqueObject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject')  
↳ [IMaterial](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IMaterial 'DiGi\.Analytical\.Interfaces\.IMaterial')

Implements [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Analytical.Interfaces.IAnalyticalRelation'></a>

## IAnalyticalRelation Interface

Base interface for all analytical relations in the DiGi framework\.

```csharp
public interface IAnalyticalRelation : DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Implements [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Analytical.Interfaces.IAnalyticalUniqueObject'></a>

## IAnalyticalUniqueObject Interface

Interface for analytical objects that combine analytical functionality with unique object identification\.

```csharp
public interface IAnalyticalUniqueObject : DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [BoundingBox](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.BoundingBox 'DiGi\.Analytical\.Classes\.BoundingBox')  
↳ [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')  
↳ [Material](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Material 'DiGi\.Analytical\.Classes\.Material')  
↳ [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')  
↳ [IAnalyticalGeometry](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IAnalyticalGeometry 'DiGi\.Analytical\.Interfaces\.IAnalyticalGeometry')  
↳ [IAnalyticalGuidObject](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IAnalyticalGuidObject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject')  
↳ [IMaterial](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IMaterial 'DiGi\.Analytical\.Interfaces\.IMaterial')

Implements [IAnalyticalObject](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IAnalyticalObject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.Analytical.Interfaces.IMaterial'></a>

## IMaterial Interface

Interface for materials that combine analytical GUID identification with naming and description capabilities\.

```csharp
public interface IMaterial : DiGi.Analytical.Interfaces.IAnalyticalGuidObject, DiGi.Analytical.Interfaces.IAnalyticalUniqueObject, DiGi.Analytical.Interfaces.IAnalyticalObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.INamedObject, DiGi.Core.Interfaces.IDescribableObject
```

Derived  
↳ [Material](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Material 'DiGi\.Analytical\.Classes\.Material')

Implements [IAnalyticalGuidObject](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IAnalyticalGuidObject 'DiGi\.Analytical\.Interfaces\.IAnalyticalGuidObject'), [IAnalyticalUniqueObject](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IAnalyticalUniqueObject 'DiGi\.Analytical\.Interfaces\.IAnalyticalUniqueObject'), [IAnalyticalObject](DiGi.Analytical.Interfaces.md#DiGi.Analytical.Interfaces.IAnalyticalObject 'DiGi\.Analytical\.Interfaces\.IAnalyticalObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject')