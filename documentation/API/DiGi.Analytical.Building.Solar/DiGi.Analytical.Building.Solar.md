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

Every component is a receiver and every shade is shading-only. Equivalent to [ToSolar\(this BuildingModel, IEnumerable&lt;BuildingModel&gt;, Func&lt;IComponent,bool&gt;\)](DiGi.Analytical.Building.Solar.md#DiGi.Analytical.Building.Solar.Convert.ToSolar(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,System.Func_DiGi.Analytical.Building.Interfaces.IComponent,bool_) 'DiGi\.Analytical\.Building\.Solar\.Convert\.ToSolar\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Classes\.BuildingModel\>, System\.Func\<DiGi\.Analytical\.Building\.Interfaces\.IComponent,bool\>\)') with no surroundings and no receiver filter.

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

<a name='DiGi.Analytical.Building.Solar.Convert.ToSolar(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,System.Func_DiGi.Analytical.Building.Interfaces.IComponent,bool_)'></a>

## Convert\.ToSolar\(this BuildingModel, IEnumerable\<BuildingModel\>, Func\<IComponent,bool\>\) Method

Converts a building and its surroundings into a shading model for solar analysis\.

Receivers are the components of [buildingModel](DiGi.Analytical.Building.Solar.md#DiGi.Analytical.Building.Solar.Convert.ToSolar(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,System.Func_DiGi.Analytical.Building.Interfaces.IComponent,bool_).buildingModel 'DiGi\.Analytical\.Building\.Solar\.Convert\.ToSolar\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Classes\.BuildingModel\>, System\.Func\<DiGi\.Analytical\.Building\.Interfaces\.IComponent,bool\>\)\.buildingModel') accepted by [receiverFilter](DiGi.Analytical.Building.Solar.md#DiGi.Analytical.Building.Solar.Convert.ToSolar(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,System.Func_DiGi.Analytical.Building.Interfaces.IComponent,bool_).receiverFilter 'DiGi\.Analytical\.Building\.Solar\.Convert\.ToSolar\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Classes\.BuildingModel\>, System\.Func\<DiGi\.Analytical\.Building\.Interfaces\.IComponent,bool\>\)\.receiverFilter') (all components when it is null). Every other component of the analysed building, every shade of the analysed building, and every component and shade of [buildingModels\_Surrounding](DiGi.Analytical.Building.Solar.md#DiGi.Analytical.Building.Solar.Convert.ToSolar(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,System.Func_DiGi.Analytical.Building.Interfaces.IComponent,bool_).buildingModels_Surrounding 'DiGi\.Analytical\.Building\.Solar\.Convert\.ToSolar\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Classes\.BuildingModel\>, System\.Func\<DiGi\.Analytical\.Building\.Interfaces\.IComponent,bool\>\)\.buildingModels\_Surrounding') is shading-only: it casts shade on the receivers, is never shaded itself and gets no results.

No distance or height culling is applied - the caller chooses the surroundings (search radius). A surrounding model with the [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') guid of the analysed model, or one already added, is skipped.

Each component or shade with polygonal face geometry yields one element carrying its [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference'); one without it is skipped. The model is returned even when it holds no receiver.

Openings ([DiGi\.Analytical\.Building\.Interfaces\.IOpening](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iopening 'DiGi\.Analytical\.Building\.Interfaces\.IOpening')) are not components and are not converted: the host component's face goes in whole, so windows and doors neither get results of their own nor punch holes in the receiver. Terrain is not added.

```csharp
public static DiGi.Solar.Classes.ShadingModel? ToSolar(this DiGi.Analytical.Building.Classes.BuildingModel? buildingModel, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Classes.BuildingModel>? buildingModels_Surrounding, System.Func<DiGi.Analytical.Building.Interfaces.IComponent,bool>? receiverFilter=null);
```
#### Parameters

<a name='DiGi.Analytical.Building.Solar.Convert.ToSolar(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,System.Func_DiGi.Analytical.Building.Interfaces.IComponent,bool_).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The analysed building model; its [DiGi\.Analytical\.Building\.Classes\.BuildingModel\.BuildingInformation](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel.buildinginformation 'DiGi\.Analytical\.Building\.Classes\.BuildingModel\.BuildingInformation') supplies the time zone and coordinates\.

<a name='DiGi.Analytical.Building.Solar.Convert.ToSolar(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,System.Func_DiGi.Analytical.Building.Interfaces.IComponent,bool_).buildingModels_Surrounding'></a>

`buildingModels_Surrounding` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The surrounding building models added as shade casters only, or null for none\.

<a name='DiGi.Analytical.Building.Solar.Convert.ToSolar(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,System.Func_DiGi.Analytical.Building.Interfaces.IComponent,bool_).receiverFilter'></a>

`receiverFilter` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

Selects the components of [buildingModel](DiGi.Analytical.Building.Solar.md#DiGi.Analytical.Building.Solar.Convert.ToSolar(thisDiGi.Analytical.Building.Classes.BuildingModel,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,System.Func_DiGi.Analytical.Building.Interfaces.IComponent,bool_).buildingModel 'DiGi\.Analytical\.Building\.Solar\.Convert\.ToSolar\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, System\.Collections\.Generic\.IEnumerable\<DiGi\.Analytical\.Building\.Classes\.BuildingModel\>, System\.Func\<DiGi\.Analytical\.Building\.Interfaces\.IComponent,bool\>\)\.buildingModel') that receive results, or null to select all of them\.

#### Returns
[DiGi\.Solar\.Classes\.ShadingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.classes.shadingmodel 'DiGi\.Solar\.Classes\.ShadingModel')  
A [DiGi\.Solar\.Classes\.ShadingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.classes.shadingmodel 'DiGi\.Solar\.Classes\.ShadingModel') if the conversion is successful; otherwise, `null`\.