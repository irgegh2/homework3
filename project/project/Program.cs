using RPGGame;

Console.WriteLine("=== RPG Dungeon ===\n");

Dungeon dungeon = new Dungeon();
dungeon.ShowRooms();

Console.WriteLine("\n=== Testing Interval Structure ===");
Interval damageInterval = new Interval(10, 20);
Console.WriteLine($"Damage interval: {damageInterval.Min} - {damageInterval.Max}");
Console.WriteLine($"Random value: {damageInterval.Get}");
Console.WriteLine($"Another random value: {damageInterval.Get}");

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();