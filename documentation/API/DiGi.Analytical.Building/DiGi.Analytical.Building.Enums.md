#### [DiGi\.Analytical\.Building](DiGi.Analytical.Building.Overview.md 'DiGi\.Analytical\.Building\.Overview')

## DiGi\.Analytical\.Building\.Enums Namespace
### Enums

<a name='DiGi.Analytical.Building.Enums.BuildingModelDetailLevel'></a>

## BuildingModelDetailLevel Enum

```csharp
public enum BuildingModelDetailLevel
```
### Fields

<a name='DiGi.Analytical.Building.Enums.BuildingModelDetailLevel.Component'></a>

`Component` 0

Each component \(wall, roof, floor, window\) becomes a separate selectable node\.

<a name='DiGi.Analytical.Building.Enums.BuildingModelDetailLevel.Envelope'></a>

`Envelope` 1

All components are merged into a single node per building, making the building selectable as a whole\.

<a name='DiGi.Analytical.Building.Enums.OpeningConstructionPart'></a>

## OpeningConstructionPart Enum

Specifies the various components that constitute an opening construction, such as panes and frames\.

```csharp
public enum OpeningConstructionPart
```
### Fields

<a name='DiGi.Analytical.Building.Enums.OpeningConstructionPart.Undefined'></a>

`Undefined` 0

The opening construction part is undefined\.

<a name='DiGi.Analytical.Building.Enums.OpeningConstructionPart.Pane'></a>

`Pane` 1

Represents the pane part of an opening construction\.

<a name='DiGi.Analytical.Building.Enums.OpeningConstructionPart.Frame'></a>

`Frame` 2

Represents the frame part of the opening construction\.

<a name='DiGi.Analytical.Building.Enums.PhysicalComponentType'></a>

## PhysicalComponentType Enum

Specifies the kind of physical building component an element represents or is to be converted into\.

The value drives the class created by [ConvertAir\(IAir, PhysicalComponentType, IPhysicalComponent\)](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.BuildingModel.ConvertAir(DiGi.Analytical.Building.Interfaces.IAir,DiGi.Analytical.Building.Enums.PhysicalComponentType,DiGi.Analytical.Building.Interfaces.IPhysicalComponent) 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.ConvertAir\(DiGi\.Analytical\.Building\.Interfaces\.IAir, DiGi\.Analytical\.Building\.Enums\.PhysicalComponentType, DiGi\.Analytical\.Building\.Interfaces\.IPhysicalComponent\)').

```csharp
public enum PhysicalComponentType
```
### Fields

<a name='DiGi.Analytical.Building.Enums.PhysicalComponentType.Undefined'></a>

`Undefined` 0

The physical component type could not be determined\. No conversion is performed for this value\.

<a name='DiGi.Analytical.Building.Enums.PhysicalComponentType.Wall'></a>

`Wall` 1

A vertical component, i\.e\. one whose normal is roughly perpendicular to the world Z axis\. Converts into a [SurfaceWall](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceWall 'DiGi\.Analytical\.Building\.Classes\.SurfaceWall')\.

<a name='DiGi.Analytical.Building.Enums.PhysicalComponentType.Roof'></a>

`Roof` 2

A horizontal component facing upwards\. Converts into a [SurfaceRoof](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.SurfaceRoof 'DiGi\.Analytical\.Building\.Classes\.SurfaceRoof')\.

<a name='DiGi.Analytical.Building.Enums.PhysicalComponentType.Floor'></a>

`Floor` 3

A horizontal component facing downwards\. Converts into a [FaceFloor](DiGi.Analytical.Building.Classes.md#DiGi.Analytical.Building.Classes.FaceFloor 'DiGi\.Analytical\.Building\.Classes\.FaceFloor')\.

<a name='DiGi.Analytical.Building.Enums.SpaceParameter'></a>

## SpaceParameter Enum

Defines the set of parameters associated with a space in the analytical building model\.

```csharp
public enum SpaceParameter
```
### Fields

<a name='DiGi.Analytical.Building.Enums.SpaceParameter.CalculatedArea'></a>

`CalculatedArea` 0

Represents the calculated area of the space in square meters \(m2\)\.

<a name='DiGi.Analytical.Building.Enums.SpaceParameter.CalculatedVolume'></a>

`CalculatedVolume` 1

Represents the calculated volume of a space, typically measured in cubic meters \(m3\)\.

<a name='DiGi.Analytical.Building.Enums.StructurePosition'></a>

## StructurePosition Enum

Specifies the relative position of a structural element within a building\.

```csharp
public enum StructurePosition
```
### Fields

<a name='DiGi.Analytical.Building.Enums.StructurePosition.Undefined'></a>

`Undefined` 0

Undefined

<a name='DiGi.Analytical.Building.Enums.StructurePosition.Center'></a>

`Center` 1

Indicates that the structure position is at the center\.

<a name='DiGi.Analytical.Building.Enums.StructurePosition.External'></a>

`External` 2

Represents the external structure position\.

<a name='DiGi.Analytical.Building.Enums.StructurePosition.Internal'></a>

`Internal` 3

Represents the internal structure position\.