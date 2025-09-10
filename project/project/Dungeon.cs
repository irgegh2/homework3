using System;

namespace RPGGame
{
    public class Dungeon
    {
        private Room[] rooms;

        public Dungeon()
        {
            rooms = new Room[]
            {
                new Room(new Unit("Воин"), new Weapon("Меч", 10, 20)),
                new Room(new Unit("Маг"), new Weapon("Посох", 15, 25)),
                new Room(new Unit("Лучник"), new Weapon("Лук", 8, 18)),
                new Room(new Unit("Рыцарь"), new Weapon("Копье", 12, 22))
            };
        }

        public void ShowRooms()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                var room = rooms[i];
                Console.WriteLine("Unit of room " + room.Unit);
                Console.WriteLine("Weapon of room " + room.Weapon);
                Console.WriteLine("—");
            }
        }
    }
}
