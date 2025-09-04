using RPGGame;

Console.WriteLine("=== Тестирование класса Unit ===\n");

Unit unknownUnit = new Unit();
Console.WriteLine($"Юнит по умолчанию: {unknownUnit.Name}");
Console.WriteLine($"Здоровье: {unknownUnit.Health}");
Console.WriteLine($"Урон: {unknownUnit.Damage}");
Console.WriteLine($"Броня: {unknownUnit.Armor}");
Console.WriteLine($"Фактическое здоровье: {unknownUnit.GetRealHealth():F2}\n");

Unit warrior = new Unit("Воин");
Console.WriteLine($"Юнит: {warrior.Name}");
Console.WriteLine($"Здоровье: {warrior.Health}");
Console.WriteLine($"Урон: {warrior.Damage}");
Console.WriteLine($"Броня: {warrior.Armor}");
Console.WriteLine($"Фактическое здоровье: {warrior.GetRealHealth():F2}\n");

Console.WriteLine("=== Тестирование получения урона ===");
float damageValue = 50f;
bool isDead = warrior.SetDamage(damageValue);
Console.WriteLine($"Нанесен урон: {damageValue}");
Console.WriteLine($"Текущее здоровье: {warrior.Health:F2}");
Console.WriteLine($"Фактическое здоровье: {warrior.GetRealHealth():F2}");
Console.WriteLine($"Юнит погиб: {isDead}\n");

damageValue = 200f;
isDead = warrior.SetDamage(damageValue);
Console.WriteLine($"Нанесен критический урон: {damageValue}");
Console.WriteLine($"Текущее здоровье: {warrior.Health:F2}");
Console.WriteLine($"Фактическое здоровье: {warrior.GetRealHealth():F2}");
Console.WriteLine($"Юнит погиб: {isDead}\n");

Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();

