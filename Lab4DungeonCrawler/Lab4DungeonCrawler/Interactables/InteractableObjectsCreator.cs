﻿using System;
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
            List<Door> doors = new List<Door>();
            var redDoor = new Door(10, 8, ConsoleColor.Red);
            var yellowDoorOne = new Door(9, 19, ConsoleColor.Yellow);
            var yellowDoorTwo = new Door(15, 27, ConsoleColor.Yellow);
            var cyanDoor = new Door(13, 31, ConsoleColor.Cyan);
            var magentaDoor = new Door(5, 31, ConsoleColor.Magenta);

            doors.Add(redDoor);
            doors.Add(yellowDoorOne);
            doors.Add(yellowDoorTwo);
            doors.Add(cyanDoor);
            doors.Add(magentaDoor);
       
            return doors;
        }

        public List<Monster> CreateMonsters()
        {
            List<Monster> monsters = new List<Monster>
            {
                new Monster(13, 4),
                new Monster(6, 19),
                new Monster(15, 22),
                new Monster(5, 28),
                new Monster(4, 41)
            };

            return monsters;
        }

        public List<Key> CreateKeys()
        {
            List<Key> keys = new List<Key>();
            var redKey = new Key("Red key", 5, 2, ConsoleColor.Red, 1);
            var yellowKey = new Key("Yellow key", 2, 14, ConsoleColor.Yellow, 2);
            var cyanKey = new Key("Cyan key", 14, 10, ConsoleColor.Cyan, 1);
            var magentaKey = new Key("Magenta key", 10, 43, ConsoleColor.Magenta, 1);

            keys.Add(redKey);
            keys.Add(yellowKey);
            keys.Add(cyanKey);
            keys.Add(magentaKey);
            return keys;
        }
    }

   
}
