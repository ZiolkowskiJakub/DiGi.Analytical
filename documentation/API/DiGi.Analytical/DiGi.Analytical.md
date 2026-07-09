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