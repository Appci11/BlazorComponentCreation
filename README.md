# Manual list sorter for razor

Component created for learning purposes. Usage in actual projects not recommended
Componen is used to sort string type lists manually. To be used in all .NET8 and newer projects.

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
<PackageReference Include="RolandasM.Laboratorinis.ManualListSorter" Version="1.0.0" />
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

## Contributing

No contributions are possible. This is mainly used as a  practice to learn about component making and uploading for other people to see.

## License

[Apacha-2.0](http://www.apache.org/licenses/LICENSE-2.0 )