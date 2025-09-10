using RPGGame;

Console.WriteLine("=== RPG Dungeon ===\n");

Dungeon dungeon = new Dungeon();
dungeon.ShowRooms();

Console.WriteLine("\n=== Тестирование структуры Interval ===");
Interval damageInterval = new Interval(10, 20);
Console.WriteLine($"Интервал урона: {damageInterval.Min} - {damageInterval.Max}");
Console.WriteLine($"Случайное значение: {damageInterval.Get}");
Console.WriteLine($"Еще одно случайное значение: {damageInterval.Get}");

Console.WriteLine("\nНажмите любую клавишу для выхода...");
Console.ReadKey();