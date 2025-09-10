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
                new Room(new Unit("Warrior"), new Weapon("Sword", 10, 20)),
                new Room(new Unit("Mage"), new Weapon("Staff", 15, 25)),
                new Room(new Unit("Archer"), new Weapon("Bow", 8, 18)),
                new Room(new Unit("Knight"), new Weapon("Spear", 12, 22))
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
