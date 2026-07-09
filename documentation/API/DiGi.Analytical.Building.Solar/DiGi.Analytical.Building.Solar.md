#### [DiGi\.Analytical\.Building\.Solar](DiGi.Analytical.Building.Solar.Overview.md 'DiGi\.Analytical\.Building\.Solar\.Overview')

## DiGi\.Analytical\.Building\.Solar Namespace
### Classes

<a name='DiGi.Analytical.Building.Solar.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.Analytical.Building.Solar.Convert.ToSolar(thisDiGi.Analytical.Building.Classes.BuildingModel)'></a>

## Convert\.ToSolar\(this BuildingModel\) Method

Converts a building model into a shading model for solar analysis\.

```csharp
public static DiGi.Solar.Classes.ShadingModel? ToSolar(this DiGi.Analytical.Building.Classes.BuildingModel? buildingModel);
```
#### Parameters

<a name='DiGi.Analytical.Building.Solar.Convert.ToSolar(thisDiGi.Analytical.Building.Classes.BuildingModel).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model to convert\.

#### Returns
[DiGi\.Solar\.Classes\.ShadingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.classes.shadingmodel 'DiGi\.Solar\.Classes\.ShadingModel')  
A [DiGi\.Solar\.Classes\.ShadingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.classes.shadingmodel 'DiGi\.Solar\.Classes\.ShadingModel') if the conversion is successful; otherwise, `null`\.