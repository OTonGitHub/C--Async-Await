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

- Asynchrony process itself invovles letting another process handle it while doing some of its own work.
- To Run in VSCode, just press F5, if you have C# Extension Installed, and Have a working solution, should work.
- When Tasks and Async Awaits are needed are really when you need to do I/O bound tasks
  - like networking,
  - disk / database.
- As soon as async is called, a state machine is created, this can be seen in the IL code or use ILSpy to see the difference.
- Statemachine is like a class, and has points where code is awaited in the function, the variables become properties / states, and is saved in memory and not GC-ed.
- Don't make first reaction to change function async even if returning a Task/Promise.
  - Instead use something like `Task.FromResult` or `Task.CompletedTask`.
- As soon as tasks or async is used, it is propagated throughout the code.
  - I guess mostly if you are just waiting for something from a Task.
