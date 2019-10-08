
using System.Collections.Generic;

namespace Lab4DungeonCrawler
{
    public class InteractableObjectsCreator
    {
        public List<Door> CreateDoors()
        {
            List<Door> doors = new List<Door>
            {
                new RedDoor(),
                new YellowDoor(new Point(9, 20)),
                new YellowDoor(new Point(15, 27)),
                new YellowDoor(new Point(15, 27)),
                new MagentaDoor()
            };
            return doors;
        }

        public List<Key> CreateKeys()
        {
            List<Key> keys = new List<Key>
            {
            new RedKey(),
            new YellowKey(),
            new CyanKey(),
            new MagentaKey()
            };
            return keys;
        }
    }
}
