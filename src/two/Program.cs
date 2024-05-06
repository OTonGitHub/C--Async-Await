Console.WriteLine("Console App (One)\n-----------------\n");

async Task<string> MakeTeaAsync() {
    var boilingWaterTask = BoilWaterAsync();

    Console.WriteLine($"Take Cups Out: {Thread.CurrentThread.ManagedThreadId}");
    Console.WriteLine($"Put Tea in Cups: {Thread.CurrentThread.ManagedThreadId}");
    
    var water = await boilingWaterTask;
    var tea = $"Pour {water} In Cups: {Thread.CurrentThread.ManagedThreadId}";
    return tea;
}

async Task<string> BoilWaterAsync() {
    Console.WriteLine($"Start The Kettle: {Thread.CurrentThread.ManagedThreadId}");

    Console.WriteLine($"Waiting For Kettle: {Thread.CurrentThread.ManagedThreadId}");
    // Thread Came From MakeTeaAsync() Will Go Back & Resume It's Function
    // Another Thread Will Take Over Here and Continue It's Task As Wekk,
    await Task.Delay(2000);
    Console.WriteLine($"Finished Boiling!: {Thread.CurrentThread.ManagedThreadId}");

    return $"*Boiled Water: {Thread.CurrentThread.ManagedThreadId}*";
}

// Console.WriteLine(MakeTeaAsync()); -- Returns Task Itself If Not Awaited?
Console.WriteLine(await MakeTeaAsync() + $": {Thread.CurrentThread.ManagedThreadId}");