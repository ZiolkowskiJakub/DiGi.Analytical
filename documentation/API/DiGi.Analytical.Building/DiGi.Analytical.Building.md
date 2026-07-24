#### [DiGi\.Analytical\.Building](DiGi.Analytical.Building.Overview.md 'DiGi\.Analytical\.Building\.Overview')

## DiGi\.Analytical\.Building Namespace
### Classes

<a name='DiGi.Analytical.Building.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Analytical.Building.Create.BuildingModel(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolyhedron_)'></a>

## Create\.BuildingModel\(this IEnumerable\<IPolyhedron\>\) Method

Creates a [BuildingModel\(this IEnumerable&lt;IPolyhedron&gt;\)](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Create.BuildingModel(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolyhedron_) 'DiGi\.Analytical\.Building\.Create\.BuildingModel\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron\>\)') from the specified collection of polyhedrons\.

```csharp
public static DiGi.Analytical.Building.Classes.BuildingModel? BuildingModel(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Interfaces.IPolyhedron> polyhedrons);
```
#### Parameters

<a name='DiGi.Analytical.Building.Create.BuildingModel(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolyhedron_).polyhedrons'></a>

`polyhedrons` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron') objects to be used for creating the building model\.

#### Returns
[BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')  
A new instance of [BuildingModel\(this IEnumerable&lt;IPolyhedron&gt;\)](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Create.BuildingModel(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolyhedron_) 'DiGi\.Analytical\.Building\.Create\.BuildingModel\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron\>\)') if the provided collection is not null; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Create.CurveWall(thisDiGi.Geometry.Spatial.Classes.Segment3D,double,DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Create\.CurveWall\(this Segment3D, double, Vector3D, double\) Method

Creates a new [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall') based on the provided segment, height, and direction\.

```csharp
public static DiGi.Analytical.Building.Classes.CurveWall? CurveWall(this DiGi.Geometry.Spatial.Classes.Segment3D? segment3D, double height, DiGi.Geometry.Spatial.Classes.Vector3D? direction, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Building.Create.CurveWall(thisDiGi.Geometry.Spatial.Classes.Segment3D,double,DiGi.Geometry.Spatial.Classes.Vector3D,double).segment3D'></a>

`segment3D` [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') that defines the base of the wall\.

<a name='DiGi.Analytical.Building.Create.CurveWall(thisDiGi.Geometry.Spatial.Classes.Segment3D,double,DiGi.Geometry.Spatial.Classes.Vector3D,double).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the wall\.

<a name='DiGi.Analytical.Building.Create.CurveWall(thisDiGi.Geometry.Spatial.Classes.Segment3D,double,DiGi.Geometry.Spatial.Classes.Vector3D,double).direction'></a>

`direction` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the direction in which the wall is extruded\.

<a name='DiGi.Analytical.Building.Create.CurveWall(thisDiGi.Geometry.Spatial.Classes.Segment3D,double,DiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for geometric validation\.

#### Returns
[CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall')  
A new [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall') instance if the parameters are valid; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Create.CurveWall(thisDiGi.Geometry.Spatial.Classes.Segment3D,double,double)'></a>

## Create\.CurveWall\(this Segment3D, double, double\) Method

Creates a curved wall based on a 3D segment using the world Z\-axis as the default direction\.

```csharp
public static DiGi.Analytical.Building.Classes.CurveWall? CurveWall(this DiGi.Geometry.Spatial.Classes.Segment3D? segment3D, double height, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Building.Create.CurveWall(thisDiGi.Geometry.Spatial.Classes.Segment3D,double,double).segment3D'></a>

`segment3D` [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The 3D segment that defines the base of the curve wall\.

<a name='DiGi.Analytical.Building.Create.CurveWall(thisDiGi.Geometry.Spatial.Classes.Segment3D,double,double).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the wall to be created\.

<a name='DiGi.Analytical.Building.Create.CurveWall(thisDiGi.Geometry.Spatial.Classes.Segment3D,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for geometric validation\.

#### Returns
[CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall')  
A new [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall') instance if the creation is successful; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Create.FaceFloor(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double)'></a>

## Create\.FaceFloor\(this IPolygonalFace3D, double\) Method

Creates a [FaceFloor\(this IPolygonalFace3D, double\)](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Create.FaceFloor(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double) 'DiGi\.Analytical\.Building\.Create\.FaceFloor\(this DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D, double\)') from the specified polygonal face, provided its area is valid and exceeds the given tolerance\.

```csharp
public static DiGi.Analytical.Building.Classes.FaceFloor? FaceFloor(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Building.Create.FaceFloor(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The polygonal face to be converted into a face floor\.

<a name='DiGi.Analytical.Building.Create.FaceFloor(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum area threshold required to create the face floor\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor')  
A new [FaceFloor\(this IPolygonalFace3D, double\)](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Create.FaceFloor(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double) 'DiGi\.Analytical\.Building\.Create\.FaceFloor\(this DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D, double\)') instance if the face is not null and its area is greater than or equal to the tolerance; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Create.StructureLayer(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Enums.OpeningConstructionPart,DiGi.Analytical.Interfaces.IMaterial,double)'></a>

## Create\.StructureLayer\(this ConstructionRelationCluster, IOpeningConstruction, OpeningConstructionPart, IMaterial, double\) Method

Creates a new structure layer and associates it with an opening construction part and a material within the specified relation cluster\.

```csharp
public static DiGi.Analytical.Classes.StructureLayer? StructureLayer(this DiGi.Analytical.Building.Classes.ConstructionRelationCluster? constructionRelationCluster, DiGi.Analytical.Building.Interfaces.IOpeningConstruction? openinigConstruction, DiGi.Analytical.Building.Enums.OpeningConstructionPart openingConstructionPart, DiGi.Analytical.Interfaces.IMaterial? material, double thickness);
```
#### Parameters

<a name='DiGi.Analytical.Building.Create.StructureLayer(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Enums.OpeningConstructionPart,DiGi.Analytical.Interfaces.IMaterial,double).constructionRelationCluster'></a>

`constructionRelationCluster` [ConstructionRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionRelationCluster 'DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster')

The construction relation cluster to which the structure layer and its relations are added\.

<a name='DiGi.Analytical.Building.Create.StructureLayer(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Enums.OpeningConstructionPart,DiGi.Analytical.Interfaces.IMaterial,double).openinigConstruction'></a>

`openinigConstruction` [IOpeningConstruction](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IOpeningConstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')

The opening construction associated with the new structure layer\.

<a name='DiGi.Analytical.Building.Create.StructureLayer(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Enums.OpeningConstructionPart,DiGi.Analytical.Interfaces.IMaterial,double).openingConstructionPart'></a>

`openingConstructionPart` [OpeningConstructionPart](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.OpeningConstructionPart 'DiGi\.Analytical\.Building\.Enums\.OpeningConstructionPart')

The specific part of the opening construction for the structure layer\.

<a name='DiGi.Analytical.Building.Create.StructureLayer(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Enums.OpeningConstructionPart,DiGi.Analytical.Interfaces.IMaterial,double).material'></a>

`material` [DiGi\.Analytical\.Interfaces\.IMaterial](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.imaterial 'DiGi\.Analytical\.Interfaces\.IMaterial')

The material to be assigned to the structure layer\.

<a name='DiGi.Analytical.Building.Create.StructureLayer(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Enums.OpeningConstructionPart,DiGi.Analytical.Interfaces.IMaterial,double).thickness'></a>

`thickness` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The thickness of the structure layer\.

#### Returns
[StructureLayer](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.StructureLayer 'DiGi\.Analytical\.Classes\.StructureLayer')  
The created [DiGi\.Analytical\.Building\.Classes\.StructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.structurelayer 'DiGi\.Analytical\.Building\.Classes\.StructureLayer') if successful; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Create.StructureLayer(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,DiGi.Analytical.Interfaces.IMaterial,double)'></a>

## Create\.StructureLayer\(this ConstructionRelationCluster, IPhysicalComponentConstruction, IMaterial, double\) Method

Creates and adds a new [DiGi\.Analytical\.Building\.Classes\.StructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.structurelayer 'DiGi\.Analytical\.Building\.Classes\.StructureLayer') to the specified construction relation cluster\.

```csharp
public static DiGi.Analytical.Classes.StructureLayer? StructureLayer(this DiGi.Analytical.Building.Classes.ConstructionRelationCluster? constructionRelationCluster, DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction? physicalComponentConstruction, DiGi.Analytical.Interfaces.IMaterial? material, double thickness);
```
#### Parameters

<a name='DiGi.Analytical.Building.Create.StructureLayer(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,DiGi.Analytical.Interfaces.IMaterial,double).constructionRelationCluster'></a>

`constructionRelationCluster` [ConstructionRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionRelationCluster 'DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster')

The construction relation cluster where the structure layer will be created and stored\.

<a name='DiGi.Analytical.Building.Create.StructureLayer(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,DiGi.Analytical.Interfaces.IMaterial,double).physicalComponentConstruction'></a>

`physicalComponentConstruction` [IPhysicalComponentConstruction](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')

The physical component construction associated with the structure layer\.

<a name='DiGi.Analytical.Building.Create.StructureLayer(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,DiGi.Analytical.Interfaces.IMaterial,double).material'></a>

`material` [DiGi\.Analytical\.Interfaces\.IMaterial](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.interfaces.imaterial 'DiGi\.Analytical\.Interfaces\.IMaterial')

The material to be assigned to the structure layer\.

<a name='DiGi.Analytical.Building.Create.StructureLayer(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction,DiGi.Analytical.Interfaces.IMaterial,double).thickness'></a>

`thickness` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The thickness of the structure layer\.

#### Returns
[StructureLayer](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.StructureLayer 'DiGi\.Analytical\.Classes\.StructureLayer')  
A new [DiGi\.Analytical\.Building\.Classes\.StructureLayer](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.structurelayer 'DiGi\.Analytical\.Building\.Classes\.StructureLayer') instance if successfully created and added; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Create.SurfaceAir(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double)'></a>

## Create\.SurfaceAir\(this IPolygonalFace3D, double\) Method

Creates a [SurfaceAir\(this IPolygonalFace3D, double\)](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Create.SurfaceAir(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double) 'DiGi\.Analytical\.Building\.Create\.SurfaceAir\(this DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D, double\)') from the specified polygonal face, provided its area is valid and exceeds the given tolerance\.

```csharp
public static DiGi.Analytical.Building.Classes.SurfaceAir? SurfaceAir(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Building.Create.SurfaceAir(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The polygonal face to be converted into a surface air\.

<a name='DiGi.Analytical.Building.Create.SurfaceAir(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum area threshold required to create the surface air\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir')  
A new [SurfaceAir\(this IPolygonalFace3D, double\)](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Create.SurfaceAir(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double) 'DiGi\.Analytical\.Building\.Create\.SurfaceAir\(this DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D, double\)') instance if the face is not null and its area is greater than or equal to the tolerance; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Create.SurfaceRoof(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double)'></a>

## Create\.SurfaceRoof\(this IPolygonalFace3D, double\) Method

Creates a [SurfaceRoof\(this IPolygonalFace3D, double\)](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Create.SurfaceRoof(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double) 'DiGi\.Analytical\.Building\.Create\.SurfaceRoof\(this DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D, double\)') from the specified polygonal face, provided its area is valid and exceeds the given tolerance\.

```csharp
public static DiGi.Analytical.Building.Classes.SurfaceRoof? SurfaceRoof(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Building.Create.SurfaceRoof(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The polygonal face to be converted into a surface roof\.

<a name='DiGi.Analytical.Building.Create.SurfaceRoof(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum area threshold required to create the surface roof\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[SurfaceRoof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceRoof 'DiGi\.Analytical\.Building\.Classes\.SurfaceRoof')  
A new [SurfaceRoof\(this IPolygonalFace3D, double\)](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Create.SurfaceRoof(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double) 'DiGi\.Analytical\.Building\.Create\.SurfaceRoof\(this DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D, double\)') instance if the face is not null and its area is greater than or equal to the tolerance; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Create.SurfaceWall(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double)'></a>

## Create\.SurfaceWall\(this IPolygonalFace3D, double\) Method

Creates a [SurfaceWall\(this IPolygonalFace3D, double\)](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Create.SurfaceWall(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double) 'DiGi\.Analytical\.Building\.Create\.SurfaceWall\(this DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D, double\)') from the specified polygonal face, provided its area is valid and exceeds the given tolerance\.

```csharp
public static DiGi.Analytical.Building.Classes.SurfaceWall? SurfaceWall(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Building.Create.SurfaceWall(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The polygonal face to be converted into a surface wall\.

<a name='DiGi.Analytical.Building.Create.SurfaceWall(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum area threshold required to create the surface wall\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[SurfaceWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceWall 'DiGi\.Analytical\.Building\.Classes\.SurfaceWall')  
A new [SurfaceWall\(this IPolygonalFace3D, double\)](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Create.SurfaceWall(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double) 'DiGi\.Analytical\.Building\.Create\.SurfaceWall\(this DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D, double\)') instance if the face is not null and its area is greater than or equal to the tolerance; otherwise, `null`\.

<a name='DiGi.Analytical.Building.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Analytical.Building.Modify.ConvertAirs_TAir_(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_TAir_,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Enums.PhysicalComponentType_,double)'></a>

## Modify\.ConvertAirs\<TAir\>\(this BuildingModel, IEnumerable\<TAir\>, IEnumerable\<PhysicalComponentType\>, double\) Method

Replaces the given airs of the [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') by physical components matching their geometry\.

Each air is classified by [PhysicalComponentType\(this IComponent, double\)](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Query.PhysicalComponentType(thisDiGi.Analytical.Building.Interfaces.IComponent,double) 'DiGi\.Analytical\.Building\.Query\.PhysicalComponentType\(this DiGi\.Analytical\.Building\.Interfaces\.IComponent, double\)') and, when the resulting type passes the [physicalComponentTypes](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Modify.ConvertAirs_TAir_(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_TAir_,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Enums.PhysicalComponentType_,double).physicalComponentTypes 'DiGi\.Analytical\.Building\.Modify\.ConvertAirs\<TAir\>\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<TAir\>, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\>, double\)\.physicalComponentTypes') filter, replaced by [ConvertAir\(IAir, PhysicalComponentType, IPhysicalComponent\)](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.ConvertAir(DiGi.Analytical.Building.Interfaces.IAir,DiGi.Analytical.Building.Enums.PhysicalComponentType,DiGi.Analytical.Building.Interfaces.IPhysicalComponent) 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.ConvertAir\(DiGi\.Analytical\.Building\.Interfaces\.IAir, DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType, DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent\)'). Airs classified as [Undefined](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType.Undefined 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\.Undefined') and airs whose geometry does not suit the classified type are left untouched.

```csharp
public static System.Collections.Generic.List<DiGi.Analytical.Building.Interfaces.IPhysicalComponent>? ConvertAirs<TAir>(this DiGi.Analytical.Building.Classes.BuildingModel? buildingModel, System.Collections.Generic.IEnumerable<TAir>? airs=null, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Enums.PhysicalComponentType>? physicalComponentTypes=null, double tolerance=0.0349066)
    where TAir : DiGi.Analytical.Building.Interfaces.IAir;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Modify.ConvertAirs_TAir_(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_TAir_,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Enums.PhysicalComponentType_,double).TAir'></a>

`TAir`

The type of the air components to be converted\.
#### Parameters

<a name='DiGi.Analytical.Building.Modify.ConvertAirs_TAir_(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_TAir_,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Enums.PhysicalComponentType_,double).buildingModel'></a>

`buildingModel` [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') to be modified\. The model is modified in place\.

<a name='DiGi.Analytical.Building.Modify.ConvertAirs_TAir_(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_TAir_,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Enums.PhysicalComponentType_,double).airs'></a>

`airs` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TAir](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Modify.ConvertAirs_TAir_(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_TAir_,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Enums.PhysicalComponentType_,double).TAir 'DiGi\.Analytical\.Building\.Modify\.ConvertAirs\<TAir\>\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<TAir\>, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\>, double\)\.TAir')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The airs to be converted\. When null all airs of type [TAir](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Modify.ConvertAirs_TAir_(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_TAir_,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Enums.PhysicalComponentType_,double).TAir 'DiGi\.Analytical\.Building\.Modify\.ConvertAirs\<TAir\>\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<TAir\>, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\>, double\)\.TAir') of the [buildingModel](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Modify.ConvertAirs_TAir_(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_TAir_,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Enums.PhysicalComponentType_,double).buildingModel 'DiGi\.Analytical\.Building\.Modify\.ConvertAirs\<TAir\>\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<TAir\>, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\>, double\)\.buildingModel') are taken\.

<a name='DiGi.Analytical.Building.Modify.ConvertAirs_TAir_(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_TAir_,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Enums.PhysicalComponentType_,double).physicalComponentTypes'></a>

`physicalComponentTypes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[PhysicalComponentType](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The physical component types the conversion is restricted to\. When null no restriction is applied\.

<a name='DiGi.Analytical.Building.Modify.ConvertAirs_TAir_(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_TAir_,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Enums.PhysicalComponentType_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle tolerance, in radians, used to classify the geometry of an air, within which its normal still counts as horizontal, i\.e\. as belonging to a wall\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IPhysicalComponent](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IPhysicalComponent 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The physical components the airs were replaced with, an empty list when no air was converted, or null when the [buildingModel](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Modify.ConvertAirs_TAir_(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_TAir_,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Enums.PhysicalComponentType_,double).buildingModel 'DiGi\.Analytical\.Building\.Modify\.ConvertAirs\<TAir\>\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<TAir\>, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\>, double\)\.buildingModel') is null or holds no airs of type [TAir](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Modify.ConvertAirs_TAir_(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_TAir_,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Enums.PhysicalComponentType_,double).TAir 'DiGi\.Analytical\.Building\.Modify\.ConvertAirs\<TAir\>\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<TAir\>, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\>, double\)\.TAir')\.

### Remarks
Every converted air is REMOVED from the model together with all its relations and the physical component is stored under the SAME identifier, therefore every [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference') held for the air becomes stale \- a reference carries the type of the object it points to, so it no longer resolves once the type changes\.

The space binding of an air is preserved, but the openings it hosts are NOT re-hosted and its parameters are NOT carried over.

The returned components are the CLONES returned by [ConvertAir\(IAir, PhysicalComponentType, IPhysicalComponent\)](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.ConvertAir(DiGi.Analytical.Building.Interfaces.IAir,DiGi.Analytical.Building.Enums.PhysicalComponentType,DiGi.Analytical.Building.Interfaces.IPhysicalComponent) 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.ConvertAir\(DiGi\.Analytical\.Building\.Interfaces\.IAir, DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType, DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent\)') - modifying them does not affect the model, pass them through [Update\(IComponent\)](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.Update(DiGi.Analytical.Building.Interfaces.IComponent) 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.Update\(DiGi\.Analytical\.Building\.Interfaces\.IComponent\)') to store the changes.

### See Also
- [PhysicalComponentType\(this IComponent, double\)](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Query.PhysicalComponentType(thisDiGi.Analytical.Building.Interfaces.IComponent,double) 'DiGi\.Analytical\.Building\.Query\.PhysicalComponentType\(this DiGi\.Analytical\.Building\.Interfaces\.IComponent, double\)')

<a name='DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,double,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double)'></a>

## Modify\.TrySplit\(this BuildingModel, double, double, IFloorConstruction, IEnumerable\<ISpace\>, double\) Method

Attempts to split the spaces of the given [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') by a horizontal plane placed on the given elevation\.

Each space crossed by the plane is replaced by a lower and an upper space. The part containing the internal point of the original space keeps the original [ISpace](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.ISpace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace'), the remaining parts become new spaces carrying the name, description, internal conditions and zone assignments of the original space.

Components bounding those spaces are rebuilt out of the split faces: the first part of a component keeps the identifier of the original component, the remaining parts are created as new components of the same type, all of them keeping the construction of the original component. Faces created on the cutting plane become a single [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor') assigned to [floorConstruction](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,double,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).floorConstruction 'DiGi\.Analytical\.Building\.Modify\.TrySplit\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, double, double, DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Interfaces\.ISpace\>, double\)\.floorConstruction') (or a single [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir') when [floorConstruction](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,double,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).floorConstruction 'DiGi\.Analytical\.Building\.Modify\.TrySplit\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, double, double, DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Interfaces\.ISpace\>, double\)\.floorConstruction') is null) shared by both spaces; any other face without a source component becomes a [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir').

```csharp
public static bool TrySplit(this DiGi.Analytical.Building.Classes.BuildingModel? buildingModel, double elevation, double minHeight=1.0, DiGi.Analytical.Building.Interfaces.IFloorConstruction? floorConstruction=null, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Interfaces.ISpace>? spaces=null, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,double,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).buildingModel'></a>

`buildingModel` [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') to be split\. The model is modified in place\.

<a name='DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,double,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).elevation'></a>

`elevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The elevation the horizontal cutting plane is placed on\.

<a name='DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,double,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).minHeight'></a>

`minHeight` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimal height of the part of a space above the cutting plane\. Spaces with a smaller part above the plane are not split and stay combined\.

<a name='DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,double,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).floorConstruction'></a>

`floorConstruction` [IFloorConstruction](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IFloorConstruction 'DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction')

The [IFloorConstruction](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IFloorConstruction 'DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction') assigned to the floors created on the cutting plane\. When null a [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir') is created instead of a [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor')\.

<a name='DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,double,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).spaces'></a>

`spaces` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISpace](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.ISpace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The spaces to be split\. When null all spaces of the [buildingModel](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,double,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).buildingModel 'DiGi\.Analytical\.Building\.Modify\.TrySplit\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, double, double, DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Interfaces\.ISpace\>, double\)\.buildingModel') are taken\.

<a name='DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,double,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether at least one space was split\.

### Remarks
Openings \(windows and doors\) hosted by a split component are NOT re\-hosted onto the component fragment that geometrically contains them \- they stay assigned to the fragment that inherits the identifier of the original component\. Re\-hosting requires a public counterpart of the currently private BuildingModel\.Assign\(IComponent, IOpening\) method\.

### See Also
- [BuildingModelShellsUpdater](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModelShellsUpdater 'DiGi\.Analytical\.Building\.Classes\.BuildingModelShellsUpdater')
- [BuildingModelFloorUpdater](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModelFloorUpdater 'DiGi\.Analytical\.Building\.Classes\.BuildingModelFloorUpdater')

<a name='DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_double_,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double)'></a>

## Modify\.TrySplit\(this BuildingModel, IEnumerable\<double\>, double, IFloorConstruction, IEnumerable\<ISpace\>, double\) Method

Attempts to split the spaces of the given [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') by horizontal planes placed on the given elevations\.

The elevations are sorted ascending and the cuts are applied one by one, each of them behaving exactly like the single elevation overload. Spaces created by an earlier cut are candidates for the following cuts, so a space crossed by all the given elevations is split into as many parts as there are cuts increased by one.

```csharp
public static bool TrySplit(this DiGi.Analytical.Building.Classes.BuildingModel? buildingModel, System.Collections.Generic.IEnumerable<double> elevations, double minHeight=1.0, DiGi.Analytical.Building.Interfaces.IFloorConstruction? floorConstruction=null, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Interfaces.ISpace>? spaces=null, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_double_,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).buildingModel'></a>

`buildingModel` [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The [BuildingModel](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') to be split\. The model is modified in place\.

<a name='DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_double_,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).elevations'></a>

`elevations` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The elevations the horizontal cutting planes are placed on\.

<a name='DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_double_,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).minHeight'></a>

`minHeight` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimal height of the part of a space above a cutting plane and the minimal distance between two consecutive cutting planes\.

<a name='DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_double_,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).floorConstruction'></a>

`floorConstruction` [IFloorConstruction](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IFloorConstruction 'DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction')

The [IFloorConstruction](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IFloorConstruction 'DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction') assigned to the floors created on the cutting planes\. When null a [SurfaceAir](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceAir 'DiGi\.Analytical\.Building\.Classes\.SurfaceAir') is created instead of a [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor')\.

<a name='DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_double_,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).spaces'></a>

`spaces` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISpace](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.ISpace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The spaces to be split\. When null all spaces of the [buildingModel](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_double_,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).buildingModel 'DiGi\.Analytical\.Building\.Modify\.TrySplit\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<double\>, double, DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Interfaces\.ISpace\>, double\)\.buildingModel') are taken\.

<a name='DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_double_,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether at least one space was split by at least one of the cutting planes\.

### Remarks
Openings \(windows and doors\) hosted by a split component are NOT re\-hosted onto the component fragment that geometrically contains them \- they stay assigned to the fragment that inherits the identifier of the original component\.

The elevations are deduplicated and filtered before the cuts are applied: an elevation closer than [minHeight](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_double_,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).minHeight 'DiGi\.Analytical\.Building\.Modify\.TrySplit\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<double\>, double, DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Interfaces\.ISpace\>, double\)\.minHeight') to the previously accepted elevation is dropped, so that no space smaller than [minHeight](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_double_,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).minHeight 'DiGi\.Analytical\.Building\.Modify\.TrySplit\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<double\>, double, DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Interfaces\.ISpace\>, double\)\.minHeight') is created between two consecutive cuts. The filter works on the given elevations only, the distance from the bottom of a particular space to the first cut crossing it is guarded by [tolerance](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_double_,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double).tolerance 'DiGi\.Analytical\.Building\.Modify\.TrySplit\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<double\>, double, DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Interfaces\.ISpace\>, double\)\.tolerance') alone.

### See Also
- [TrySplit\(this BuildingModel, double, double, IFloorConstruction, IEnumerable&lt;ISpace&gt;, double\)](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Modify.TrySplit(thisDiGi.Analytical.Building.Classes.BuildingModel,double,double,DiGi.Analytical.Building.Interfaces.IFloorConstruction,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Interfaces.ISpace_,double) 'DiGi\.Analytical\.Building\.Modify\.TrySplit\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, double, double, DiGi\.Analytical\.Building\.Interfaces\.IFloorConstruction, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Interfaces\.ISpace\>, double\)')

<a name='DiGi.Analytical.Building.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Analytical.Building.Query.Geometry3D_TGeometry3D_(thisDiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject)'></a>

## Query\.Geometry3D\<TGeometry3D\>\(this IBuildingGeometry3DObject\) Method

Extracts the 3D geometry from the specified building geometry object as a specific type\.

```csharp
public static TGeometry3D? Geometry3D<TGeometry3D>(this DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject? buildingGeometry3DObject)
    where TGeometry3D : DiGi.Geometry.Spatial.Interfaces.IGeometry3D;
```
#### Type parameters

<a name='DiGi.Analytical.Building.Query.Geometry3D_TGeometry3D_(thisDiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject).TGeometry3D'></a>

`TGeometry3D`

The type of 3D geometry to return, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')\.
#### Parameters

<a name='DiGi.Analytical.Building.Query.Geometry3D_TGeometry3D_(thisDiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject).buildingGeometry3DObject'></a>

`buildingGeometry3DObject` [IBuildingGeometry3DObject](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject')

The building geometry object from which the 3D geometry is extracted\.

#### Returns
[TGeometry3D](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Query.Geometry3D_TGeometry3D_(thisDiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject).TGeometry3D 'DiGi\.Analytical\.Building\.Query\.Geometry3D\<TGeometry3D\>\(this DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject\)\.TGeometry3D')  
The extracted 3D geometry of type [TGeometry3D](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Query.Geometry3D_TGeometry3D_(thisDiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject).TGeometry3D 'DiGi\.Analytical\.Building\.Query\.Geometry3D\<TGeometry3D\>\(this DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject\)\.TGeometry3D'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the object is null or the geometry cannot be converted\.

<a name='DiGi.Analytical.Building.Query.Inside(thisDiGi.Geometry.Spatial.Classes.Sphere,DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject,double)'></a>

## Query\.Inside\(this Sphere, IBuildingGeometry3DObject, double\) Method

Determines whether the specified sphere is located inside the given building geometry object\.

```csharp
public static bool Inside(this DiGi.Geometry.Spatial.Classes.Sphere? sphere, DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject? buildingGeometry3DObject, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Building.Query.Inside(thisDiGi.Geometry.Spatial.Classes.Sphere,DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject,double).sphere'></a>

`sphere` [DiGi\.Geometry\.Spatial\.Classes\.Sphere](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere')

The sphere to check for containment\.

<a name='DiGi.Analytical.Building.Query.Inside(thisDiGi.Geometry.Spatial.Classes.Sphere,DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject,double).buildingGeometry3DObject'></a>

`buildingGeometry3DObject` [IBuildingGeometry3DObject](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject')

The 3D building geometry object to evaluate against\.

<a name='DiGi.Analytical.Building.Query.Inside(thisDiGi.Geometry.Spatial.Classes.Sphere,DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for the geometric operation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the sphere is inside the building geometry; otherwise, false\.

<a name='DiGi.Analytical.Building.Query.Mesh3D(thisDiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject,double)'></a>

## Query\.Mesh3D\(this IBuildingGeometry3DObject, double\) Method

Creates a [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') from the specified building geometry object by triangulating it\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Mesh3D? Mesh3D(this DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject? buildingGeometryObject, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Building.Query.Mesh3D(thisDiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject,double).buildingGeometryObject'></a>

`buildingGeometryObject` [IBuildingGeometry3DObject](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject')

The building geometry object to convert into a mesh\.

<a name='DiGi.Analytical.Building.Query.Mesh3D(thisDiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during the triangulation process\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') representing the triangulated geometry, or `null` if the object is null or cannot be triangulated\.

<a name='DiGi.Analytical.Building.Query.NextStructureLayerIndex(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Enums.OpeningConstructionPart)'></a>

## Query\.NextStructureLayerIndex\(this ConstructionRelationCluster, IOpeningConstruction, OpeningConstructionPart\) Method

Calculates the next available structure layer index for a specific part of an opening construction\.

```csharp
public static int NextStructureLayerIndex(this DiGi.Analytical.Building.Classes.ConstructionRelationCluster? constructionRelationCluster, DiGi.Analytical.Building.Interfaces.IOpeningConstruction? openingConstruction, DiGi.Analytical.Building.Enums.OpeningConstructionPart openingConstructionPart);
```
#### Parameters

<a name='DiGi.Analytical.Building.Query.NextStructureLayerIndex(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Enums.OpeningConstructionPart).constructionRelationCluster'></a>

`constructionRelationCluster` [ConstructionRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionRelationCluster 'DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster')

The relation cluster used to retrieve the structure layer relations\.

<a name='DiGi.Analytical.Building.Query.NextStructureLayerIndex(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Enums.OpeningConstructionPart).openingConstruction'></a>

`openingConstruction` [IOpeningConstruction](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IOpeningConstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')

The opening construction instance\.

<a name='DiGi.Analytical.Building.Query.NextStructureLayerIndex(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IOpeningConstruction,DiGi.Analytical.Building.Enums.OpeningConstructionPart).openingConstructionPart'></a>

`openingConstructionPart` [OpeningConstructionPart](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.OpeningConstructionPart 'DiGi\.Analytical\.Building\.Enums\.OpeningConstructionPart')

The part of the opening construction \(e\.g\., pane or frame\) for which the index is calculated\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The next available structure layer index; 0 if no relations are found, or \-1 if any input parameter is null or undefined\.

<a name='DiGi.Analytical.Building.Query.NextStructureLayerIndex(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction)'></a>

## Query\.NextStructureLayerIndex\(this ConstructionRelationCluster, IPhysicalComponentConstruction\) Method

Calculates the next structure layer index for a specified physical component construction within the provided construction relation cluster\.

```csharp
public static int NextStructureLayerIndex(this DiGi.Analytical.Building.Classes.ConstructionRelationCluster? constructionRelationCluster, DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction? physicalComponentConstruction);
```
#### Parameters

<a name='DiGi.Analytical.Building.Query.NextStructureLayerIndex(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction).constructionRelationCluster'></a>

`constructionRelationCluster` [ConstructionRelationCluster](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.ConstructionRelationCluster 'DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster')

The construction relation cluster used to retrieve relations and structure layers\.

<a name='DiGi.Analytical.Building.Query.NextStructureLayerIndex(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction).physicalComponentConstruction'></a>

`physicalComponentConstruction` [IPhysicalComponentConstruction](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')

The physical component construction for which the next structure layer index is determined\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The maximum structure layer index found; 0 if no associated structure layers exist; or \-1 if either the [constructionRelationCluster](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Query.NextStructureLayerIndex(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction).constructionRelationCluster 'DiGi\.Analytical\.Building\.Query\.NextStructureLayerIndex\(this DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster, DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction\)\.constructionRelationCluster') or [physicalComponentConstruction](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Query.NextStructureLayerIndex(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction).physicalComponentConstruction 'DiGi\.Analytical\.Building\.Query\.NextStructureLayerIndex\(this DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster, DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction\)\.physicalComponentConstruction') is null\.

<a name='DiGi.Analytical.Building.Query.PhysicalComponentType(thisDiGi.Analytical.Building.Interfaces.IComponent,double)'></a>

## Query\.PhysicalComponentType\(this IComponent, double\) Method

Determines the [PhysicalComponentType](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType') of the given [IComponent](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IComponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')\.

Components already carrying a physical type are classified by their interface: an [IWall](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IWall 'DiGi\.Analytical\.Building\.Interfaces\.IWall') gives [Wall](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType.Wall 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\.Wall'), an [IFloor](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IFloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor') gives [Floor](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType.Floor 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\.Floor') and an [IRoof](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IRoof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof') gives [Roof](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType.Roof 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\.Roof').

An [IAir](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IAir 'DiGi\.Analytical\.Building\.Interfaces\.IAir') carries no physical type, therefore it is classified geometrically: the normal of the plane of its [DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D') geometry is passed to [PhysicalComponentType\(this Vector3D, double\)](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Query.PhysicalComponentType(thisDiGi.Geometry.Spatial.Classes.Vector3D,double) 'DiGi\.Analytical\.Building\.Query\.PhysicalComponentType\(this DiGi\.Geometry\.Spatial\.Classes\.Vector3D, double\)'). An air of any other geometry cannot be classified.

```csharp
public static DiGi.Analytical.Building.Enums.PhysicalComponentType PhysicalComponentType(this DiGi.Analytical.Building.Interfaces.IComponent? component, double tolerance=0.0349066);
```
#### Parameters

<a name='DiGi.Analytical.Building.Query.PhysicalComponentType(thisDiGi.Analytical.Building.Interfaces.IComponent,double).component'></a>

`component` [IComponent](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IComponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The component to be classified\.

<a name='DiGi.Analytical.Building.Query.PhysicalComponentType(thisDiGi.Analytical.Building.Interfaces.IComponent,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle tolerance, in radians, within which the normal of an [IAir](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IAir 'DiGi\.Analytical\.Building\.Interfaces\.IAir') still counts as horizontal, i\.e\. as belonging to a wall\. Not used for components classified by their interface\.

#### Returns
[PhysicalComponentType](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType')  
The [PhysicalComponentType](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType') of the component, or [Undefined](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType.Undefined 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\.Undefined') when the component is null or cannot be classified\.

### See Also
- [ConvertAirs&lt;TAir&gt;\(this BuildingModel, IEnumerable&lt;TAir&gt;, IEnumerable&lt;PhysicalComponentType&gt;, double\)](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Modify.ConvertAirs_TAir_(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_TAir_,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Enums.PhysicalComponentType_,double) 'DiGi\.Analytical\.Building\.Modify\.ConvertAirs\<TAir\>\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<TAir\>, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\>, double\)')

<a name='DiGi.Analytical.Building.Query.PhysicalComponentType(thisDiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Query\.PhysicalComponentType\(this Vector3D, double\) Method

Determines the [PhysicalComponentType](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType') represented by the given normal\.

The normal is normalized and its dot product with [DiGi\.Geometry\.Spatial\.Constants\.Vector3D\.WorldZ](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.constants.vector3d.worldz 'DiGi\.Geometry\.Spatial\.Constants\.Vector3D\.WorldZ') is taken, which equals the sine of the tilt of the surface away from vertical. A normal lying within [tolerance](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Query.PhysicalComponentType(thisDiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance 'DiGi\.Analytical\.Building\.Query\.PhysicalComponentType\(this DiGi\.Geometry\.Spatial\.Classes\.Vector3D, double\)\.tolerance') of horizontal gives [Wall](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType.Wall 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\.Wall'), a normal pointing downwards gives [Floor](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType.Floor 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\.Floor') and a normal pointing upwards gives [Roof](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType.Roof 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\.Roof').

```csharp
public static DiGi.Analytical.Building.Enums.PhysicalComponentType PhysicalComponentType(this DiGi.Geometry.Spatial.Classes.Vector3D? normal, double tolerance=0.0349066);
```
#### Parameters

<a name='DiGi.Analytical.Building.Query.PhysicalComponentType(thisDiGi.Geometry.Spatial.Classes.Vector3D,double).normal'></a>

`normal` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The normal of the surface to be classified\.

<a name='DiGi.Analytical.Building.Query.PhysicalComponentType(thisDiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle tolerance, in radians, within which the normal still counts as horizontal, i\.e\. as belonging to a wall\.

#### Returns
[PhysicalComponentType](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType')  
The [PhysicalComponentType](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType') represented by the normal, or [Undefined](DiGi.Analytical.Building.Enums.md#DiGi.Analytical.Building.Enums.PhysicalComponentType.Undefined 'DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType\.Undefined') when the normal is null or has no unit vector\.

<a name='DiGi.Analytical.Building.Query.Surface3D(thisDiGi.Analytical.Building.Interfaces.IComponent)'></a>

## Query\.Surface3D\(this IComponent\) Method

Extracts the 3D surface representation of the specified building component\.

Surface based components (e.g. [SurfaceRoof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceRoof 'DiGi\.Analytical\.Building\.Classes\.SurfaceRoof'), [SurfaceWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceWall 'DiGi\.Analytical\.Building\.Classes\.SurfaceWall')) return their geometry directly, face based components (e.g. [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor')) return their planar face and curve based walls (e.g. [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall')) return the surface created by extruding the base curve by the wall vector.

```csharp
public static DiGi.Geometry.Spatial.Interfaces.ISurface3D? Surface3D(this DiGi.Analytical.Building.Interfaces.IComponent? component);
```
#### Parameters

<a name='DiGi.Analytical.Building.Query.Surface3D(thisDiGi.Analytical.Building.Interfaces.IComponent).component'></a>

`component` [IComponent](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IComponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The building component\. This value can be null\.

#### Returns
[DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')  
The [DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D') representing the component, or null if the component has no supported surface geometry\.

<a name='DiGi.Analytical.Building.Query.Triangulate(thisDiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject,double)'></a>

## Query\.Triangulate\(this IBuildingGeometry3DObject, double\) Method

Triangulates the specified 3D building geometry object into a set of triangles\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Triangle3D>? Triangulate(this DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject? buildingGeometry3DObject, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Building.Query.Triangulate(thisDiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject,double).buildingGeometry3DObject'></a>

`buildingGeometry3DObject` [IBuildingGeometry3DObject](DiGi.Analytical.Building.Interfaces.md#DiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject')

The building geometry object to triangulate\.

<a name='DiGi.Analytical.Building.Query.Triangulate(thisDiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') objects representing the triangulated geometry, or null if the object is null or cannot be triangulated\.