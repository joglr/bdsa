# Analysis, Design and Software Architecture (Autumn 2020)

Setup
```
dotnet new sln -o unit-testing-using-dotnet-test
cd unit-testing-using-dotnet-test
dotnet new console -o LeapYear
ren .\LeapYear\Program.cs LeapYear.cs
dotnet sln add ./LeapYear/LeapYear.csproj
dotnet new xunit -o LeapYear.Tests
dotnet add ./LeapYear.Tests/LeapYear.Tests.csproj reference ./LeapYear/LeapYear.csproj
dotnet sln add ./LeapYear.Tests/LeapYear.Tests.csproj
```

## Development

From project dir
```
dotnet run
```

From test dir
```
dotnet test
```
