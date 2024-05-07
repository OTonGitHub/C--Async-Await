Using .NET version `8.0.300-preview.24203.14`

#### Commands

- `dotnet new gitignore`
= `dotnet new sln`
- `dotnet new console -lang "c#" -n "One" -f "net8.0" -o src/First/one -d -v diag`
- `dotnet new console -lang "c#" -n "Twi" -f "net8.0" -o src/First/two -d -v diag`
- `dotnet new console -lang "c#" -n "Three" -f "net8.0" -o src/First/three -d -v diag`
- `dotnet new web -lang "c#" -n "Second" -f "net8.0" -o src/Second -d -v diag`
- `dotnet sln add src/First/one`
- `dotnet sln add src/First/two`
- `dotnet sln add src/First/three`
- `dotnet sln add src/Second`
- `dotnet run --project src/Second`

#### Notes
- asynchrony process itself invovles letting another process handle it while doing some of its own work.
