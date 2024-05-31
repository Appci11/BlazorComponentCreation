# Manual lists sorter for razor

Componen is used to sort string type lists manually.
Component created for learning purposes. Usage in actual projects not recommended

[Code Repository](https://github.com/Appci11/BlazorComponentCreation)
[Nuget Repository](https://www.nuget.org/packages/RolandasM.Laboratorinis.ManualListSorter#readme-body-tab)

## Requirements
.NET8 or later.

## Installation

Using cli 

```bash
nuget install RolandasM.Laboratorinis.ManualListSorter
```
Using package manager 

```bash
NuGet\Install-Package RolandasM.Laboratorinis.ManualListSorter
```

Package reference

```html
<PackageReference Include="RolandasM.Laboratorinis.ManualListSorter" Version="1.0.3" />
```

Or using VisualStudio nuget mannager

## Usage

```c#

// place component in html part of you razor file

<MyComponent ColNames=Pavadinimai StringValues=Eilutes OnLabelPositionChanged="LabelChanged" />

@code{
  //provide headers for collumns (max 10)
  List<String> Pavadinimai = new List<String>();
  //provide label names in string format
  //List<List<String>> - collumns
  //List<String> - collumn values
  List<List<String>> Eilutes = new List<List<String>>();
}
```
```c#
// Size changing (small/medium/big)
<MyComponent Size=small" />

```

## Contributing

No contributions are possible. This is mainly used as a  practice to learn about component making and uploading.

## License

[Apacha-2.0](http://www.apache.org/licenses/LICENSE-2.0 )
