using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class InteractableObjectsCreator
    {
        public List<Door> CreateDoors()
        {
            List<Door> doors = new List<Door>
            {
                new Door(10, 8, ConsoleColor.Red),
                new Door(9, 20, ConsoleColor.Yellow),
                new Door(15, 27, ConsoleColor.Yellow),
                new Door(13, 31, ConsoleColor.Cyan),
                new Door(5, 31, ConsoleColor.Magenta)
            };
            return doors;
        }

        public List<Monster> CreateMonsters()
        {
            List<Monster> monsters = new List<Monster>
            {
                new Monster(13, 4),
                new Monster(5, 20),
                new Monster(15, 24),
                new Monster(5, 28),
                new Monster(4, 41)
            };
            return monsters;
        }

        public List<Key> CreateKeys()
        {
            List<Key> keys = new List<Key>
            {
                new Key("Red key", 1, 5, 2, ConsoleColor.Red),
                new Key("Yellow key", 2, 2, 14, ConsoleColor.Yellow),
                new Key("Cyan key", 1, 14, 10, ConsoleColor.Cyan),
                new Key("Magenta key", 1, 10, 44, ConsoleColor.Magenta)
            };
            return keys;
        }
    }
}
