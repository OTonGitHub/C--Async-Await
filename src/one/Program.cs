Console.WriteLine("Console App (One)\n-----------------\n");

string MakeTea() {
    var water = BoilWater();

    Console.WriteLine("Take Cups Out");
    Console.WriteLine("Put Tea in Cups");
    
    var tea = $"Pour {water} In Cups";
    return tea;
}

string BoilWater() {
    Console.WriteLine("Start The Kettle");

    Console.WriteLine("Waiting For Kettle");
    Task.Delay(2000).GetAwaiter().GetResult();
    Console.WriteLine("Finished Boiling!");

    return "*Boiled Water*";
}

Console.WriteLine(MakeTea());