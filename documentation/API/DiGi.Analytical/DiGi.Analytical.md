#### [DiGi\.Analytical](DiGi.Analytical.Overview.md 'DiGi\.Analytical\.Overview')

## DiGi\.Analytical Namespace
### Classes

<a name='DiGi.Analytical.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Analytical.Create.DateTime(thisint,int)'></a>

## Create\.DateTime\(this int, int\) Method

Creates a [DateTime\(this int, int\)](DiGi.Analytical.md#DiGi.Analytical.Create.DateTime(thisint,int) 'DiGi\.Analytical\.Create\.DateTime\(this int, int\)') instance based on the specified year and the number of hours elapsed since the start of that year\.

```csharp
public static System.DateTime DateTime(this int year, int hourOfYear);
```
#### Parameters

<a name='DiGi.Analytical.Create.DateTime(thisint,int).year'></a>

`year` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The calendar year\.

<a name='DiGi.Analytical.Create.DateTime(thisint,int).hourOfYear'></a>

`hourOfYear` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of hours to add to January 1st of the specified year\.

#### Returns
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')  
A [DateTime\(this int, int\)](DiGi.Analytical.md#DiGi.Analytical.Create.DateTime(thisint,int) 'DiGi\.Analytical\.Create\.DateTime\(this int, int\)') object representing the calculated date and time\.

<a name='DiGi.Analytical.Create.HourRange(thisSystem.DayOfWeek,int,int)'></a>

## Create\.HourRange\(this DayOfWeek, int, int\) Method

Creates a new [HourRange\(this DayOfWeek, int, int\)](DiGi.Analytical.md#DiGi.Analytical.Create.HourRange(thisSystem.DayOfWeek,int,int) 'DiGi\.Analytical\.Create\.HourRange\(this System\.DayOfWeek, int, int\)') based on the specified day of the week, year, and number of hours\.

```csharp
public static DiGi.Analytical.Classes.HourRange HourRange(this System.DayOfWeek dayOfWeek, int year, int hours);
```
#### Parameters

<a name='DiGi.Analytical.Create.HourRange(thisSystem.DayOfWeek,int,int).dayOfWeek'></a>

`dayOfWeek` [System\.DayOfWeek](https://learn.microsoft.com/en-us/dotnet/api/system.dayofweek 'System\.DayOfWeek')

The day of the week to use as the starting point for the range\.

<a name='DiGi.Analytical.Create.HourRange(thisSystem.DayOfWeek,int,int).year'></a>

`year` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The year used to determine the initial hour index\.

<a name='DiGi.Analytical.Create.HourRange(thisSystem.DayOfWeek,int,int).hours'></a>

`hours` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of hours to include in the range\.

#### Returns
[HourRange](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.HourRange 'DiGi\.Analytical\.Classes\.HourRange')  
A new instance of [HourRange\(this DayOfWeek, int, int\)](DiGi.Analytical.md#DiGi.Analytical.Create.HourRange(thisSystem.DayOfWeek,int,int) 'DiGi\.Analytical\.Create\.HourRange\(this System\.DayOfWeek, int, int\)') representing the calculated time span\.

<a name='DiGi.Analytical.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Analytical.Query.FirstHourIndex(thisSystem.DayOfWeek,int)'></a>

## Query\.FirstHourIndex\(this DayOfWeek, int\) Method

Calculates the index of the first hour of the specified year that occurs on the given day of the week\.

```csharp
public static int FirstHourIndex(this System.DayOfWeek dayOfWeek, int year);
```
#### Parameters

<a name='DiGi.Analytical.Query.FirstHourIndex(thisSystem.DayOfWeek,int).dayOfWeek'></a>

`dayOfWeek` [System\.DayOfWeek](https://learn.microsoft.com/en-us/dotnet/api/system.dayofweek 'System\.DayOfWeek')

The day of the week to search for\.

<a name='DiGi.Analytical.Query.FirstHourIndex(thisSystem.DayOfWeek,int).year'></a>

`year` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The calendar year to evaluate\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The index of the first hour of the year that falls on the specified day of the week\.

<a name='DiGi.Analytical.Query.HourOfYear(thisSystem.DateTime)'></a>

## Query\.HourOfYear\(this DateTime\) Method

Calculates the total number of hours that have elapsed since the beginning of the year for the specified date and time\.

```csharp
public static int HourOfYear(this System.DateTime dateTime);
```
#### Parameters

<a name='DiGi.Analytical.Query.HourOfYear(thisSystem.DateTime).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') value for which to calculate the hour of the year\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') representing the total number of hours elapsed since January 1st of the current year\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Analytical.Classes.Face,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Face_,System.Collections.Generic.List_DiGi.Analytical.Classes.Face_,double)'></a>

## Query\.TrySplit\(this Face, IEnumerable\<Face\>, List\<Face\>, double\) Method

Attempts to split the specified [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') using a collection of other faces\.

Each resulting face inherits the [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference') of a coplanar cutting [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') containing it, or the [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference') of the split [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') when no coplanar cutting face matches.

```csharp
public static bool TrySplit(this DiGi.Analytical.Classes.Face? face, System.Collections.Generic.IEnumerable<DiGi.Analytical.Classes.Face>? faces, out System.Collections.Generic.List<DiGi.Analytical.Classes.Face>? result, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Analytical.Classes.Face,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Face_,System.Collections.Generic.List_DiGi.Analytical.Classes.Face_,double).face'></a>

`face` [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')

The [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') instance to be split\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Analytical.Classes.Face,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Face_,System.Collections.Generic.List_DiGi.Analytical.Classes.Face_,double).faces'></a>

`faces` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') instances used as splitting boundaries\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Analytical.Classes.Face,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Face_,System.Collections.Generic.List_DiGi.Analytical.Classes.Face_,double).result'></a>

`result` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of the resulting split faces if successful; otherwise, null\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Analytical.Classes.Face,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Face_,System.Collections.Generic.List_DiGi.Analytical.Classes.Face_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for intersection calculations\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the face was successfully split\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Analytical.Classes.Shell,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Shell_,DiGi.Analytical.Classes.Shell,double)'></a>

## Query\.TrySplit\(this Shell, IEnumerable\<Shell\>, Shell, double\) Method

Attempts to split the specified [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell') using a collection of other shells\.

The resulting [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell') inherits the [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference') of the split [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell') and each of its faces inherits the [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference') resolved for that face.

```csharp
public static bool TrySplit(this DiGi.Analytical.Classes.Shell? shell, System.Collections.Generic.IEnumerable<DiGi.Analytical.Classes.Shell>? shells, out DiGi.Analytical.Classes.Shell? result, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Analytical.Classes.Shell,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Shell_,DiGi.Analytical.Classes.Shell,double).shell'></a>

`shell` [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')

The [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell') to be split\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Analytical.Classes.Shell,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Shell_,DiGi.Analytical.Classes.Shell,double).shells'></a>

`shells` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of shells used for the splitting process\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Analytical.Classes.Shell,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Shell_,DiGi.Analytical.Classes.Shell,double).result'></a>

`result` [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')

When this method returns, contains the resulting [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell') if the operation succeeded; otherwise, null\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Analytical.Classes.Shell,System.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Shell_,DiGi.Analytical.Classes.Shell,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the split was successful\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Analytical.Classes.Face,System.Collections.Generic.List_DiGi.Analytical.Classes.Face_,double)'></a>

## Query\.TrySplit\(this Plane, Face, List\<Face\>, double\) Method

Attempts to split a [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') using the specified plane\.

Each resulting [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') inherits the [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference') of the split [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face').

```csharp
public static bool TrySplit(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Analytical.Classes.Face? face, out System.Collections.Generic.List<DiGi.Analytical.Classes.Face>? result, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Analytical.Classes.Face,System.Collections.Generic.List_DiGi.Analytical.Classes.Face_,double).plane'></a>

`plane` [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used as the splitting surface\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Analytical.Classes.Face,System.Collections.Generic.List_DiGi.Analytical.Classes.Face_,double).face'></a>

`face` [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')

The [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') instance to be split\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Analytical.Classes.Face,System.Collections.Generic.List_DiGi.Analytical.Classes.Face_,double).result'></a>

`result` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of the resulting faces if the operation succeeded; otherwise, null\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Analytical.Classes.Face,System.Collections.Generic.List_DiGi.Analytical.Classes.Face_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for intersection calculations\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the split was successful\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Analytical.Classes.Shell,System.Collections.Generic.List_DiGi.Analytical.Classes.Shell_,double)'></a>

## Query\.TrySplit\(this Plane, Shell, List\<Shell\>, double\) Method

Attempts to split a [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell') using a specified plane\.

Each resulting [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell') inherits the [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference') of the split [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell'), each resulting [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') inherits the [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference') of the [Face](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Face 'DiGi\.Analytical\.Classes\.Face') it originates from and faces created on the cutting plane are left without an [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference').

```csharp
public static bool TrySplit(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Analytical.Classes.Shell? shell, out System.Collections.Generic.List<DiGi.Analytical.Classes.Shell>? result, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Analytical.Classes.Shell,System.Collections.Generic.List_DiGi.Analytical.Classes.Shell_,double).plane'></a>

`plane` [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used to perform the split operation\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Analytical.Classes.Shell,System.Collections.Generic.List_DiGi.Analytical.Classes.Shell_,double).shell'></a>

`shell` [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')

The [Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell') that is to be split\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Analytical.Classes.Shell,System.Collections.Generic.List_DiGi.Analytical.Classes.Shell_,double).result'></a>

`result` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of the resulting shells if the operation succeeded; otherwise, null\.

<a name='DiGi.Analytical.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Analytical.Classes.Shell,System.Collections.Generic.List_DiGi.Analytical.Classes.Shell_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for intersection calculations\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the shell was successfully split\.

### Remarks
The resulting shells describe geometry only\. Writing them back into an analytical model, so that the components bounding the split spaces are rebuilt, is done by the updaters of DiGi\.Analytical\.Building \- see BuildingModelShellsUpdater and BuildingModel\.TrySplit\.

<a name='DiGi.Analytical.Query.TrySplit(thisSystem.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Shell_,System.Collections.Generic.List_DiGi.Analytical.Classes.Shell_,double)'></a>

## Query\.TrySplit\(this IEnumerable\<Shell\>, List\<Shell\>, double\) Method

Attempts to split a collection of shells by each other\.

Shells that are not split are copied to the result with their [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference') preserved.

```csharp
public static bool TrySplit(this System.Collections.Generic.IEnumerable<DiGi.Analytical.Classes.Shell>? shells, out System.Collections.Generic.List<DiGi.Analytical.Classes.Shell>? result, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Analytical.Query.TrySplit(thisSystem.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Shell_,System.Collections.Generic.List_DiGi.Analytical.Classes.Shell_,double).shells'></a>

`shells` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of shells to split\.

<a name='DiGi.Analytical.Query.TrySplit(thisSystem.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Shell_,System.Collections.Generic.List_DiGi.Analytical.Classes.Shell_,double).result'></a>

`result` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Shell](DiGi.Analytical.Classes.md#DiGi.Analytical.Classes.Shell 'DiGi\.Analytical\.Classes\.Shell')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains the [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of resulting shells if the operation succeeded; otherwise, null\.

<a name='DiGi.Analytical.Query.TrySplit(thisSystem.Collections.Generic.IEnumerable_DiGi.Analytical.Classes.Shell_,System.Collections.Generic.List_DiGi.Analytical.Classes.Shell_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used to determine splitting boundaries\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the split was successful\.