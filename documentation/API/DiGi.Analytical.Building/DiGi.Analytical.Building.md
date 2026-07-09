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

`openinigConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')

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

`physicalComponentConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')

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

`buildingGeometry3DObject` [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject')

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

`buildingGeometry3DObject` [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject')

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

`buildingGeometryObject` [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject')

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

`openingConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopeningconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IOpeningConstruction')

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

`physicalComponentConstruction` [DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iphysicalcomponentconstruction 'DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction')

The physical component construction for which the next structure layer index is determined\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The maximum structure layer index found; 0 if no associated structure layers exist; or \-1 if either the [constructionRelationCluster](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Query.NextStructureLayerIndex(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction).constructionRelationCluster 'DiGi\.Analytical\.Building\.Query\.NextStructureLayerIndex\(this DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster, DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction\)\.constructionRelationCluster') or [physicalComponentConstruction](DiGi.Analytical.Building.md#DiGi.Analytical.Building.Query.NextStructureLayerIndex(thisDiGi.Analytical.Building.Classes.ConstructionRelationCluster,DiGi.Analytical.Building.Interfaces.IPhysicalComponentConstruction).physicalComponentConstruction 'DiGi\.Analytical\.Building\.Query\.NextStructureLayerIndex\(this DiGi\.Analytical\.Building\.Classes\.ConstructionRelationCluster, DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponentConstruction\)\.physicalComponentConstruction') is null\.

<a name='DiGi.Analytical.Building.Query.Surface3D(thisDiGi.Analytical.Building.Interfaces.IComponent)'></a>

## Query\.Surface3D\(this IComponent\) Method

Extracts the 3D surface representation of the specified building component\.

Surface based components (e.g. [SurfaceRoof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceRoof 'DiGi\.Analytical\.Building\.Classes\.SurfaceRoof'), [SurfaceWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceWall 'DiGi\.Analytical\.Building\.Classes\.SurfaceWall')) return their geometry directly, face based components (e.g. [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor')) return their planar face and curve based walls (e.g. [CurveWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.CurveWall 'DiGi\.Analytical\.Building\.Classes\.CurveWall')) return the surface created by extruding the base curve by the wall vector.

```csharp
public static DiGi.Geometry.Spatial.Interfaces.ISurface3D? Surface3D(this DiGi.Analytical.Building.Interfaces.IComponent? component);
```
#### Parameters

<a name='DiGi.Analytical.Building.Query.Surface3D(thisDiGi.Analytical.Building.Interfaces.IComponent).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

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

`buildingGeometry3DObject` [DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ibuildinggeometry3dobject 'DiGi\.Analytical\.Building\.Interfaces\.IBuildingGeometry3DObject')

The building geometry object to triangulate\.

<a name='DiGi.Analytical.Building.Query.Triangulate(thisDiGi.Analytical.Building.Interfaces.IBuildingGeometry3DObject,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') objects representing the triangulated geometry, or null if the object is null or cannot be triangulated\.