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

            var redDoor = new RedDoor();
            var yellowDoor = new YellowDoor(new Point(9, 20));
            var yellowDoorTwo = new YellowDoor(new Point(15, 27));
            var cyanDoor = new CyanDoor();
            var magentaDoor = new MagentaDoor();

            List<Door> doors = new List<Door>();
            doors.Add(redDoor);
            doors.Add(yellowDoor);
            doors.Add(yellowDoorTwo);
            doors.Add(cyanDoor);
            doors.Add(magentaDoor);

            return doors;
        }

        public List<Key> CreateKeys()
        {
            var redKey = new RedKey();
            var yellowKey = new YellowKey();
            var cyanKey = new CyanKey();
            var magentaKey = new MagentaKey();

            List<Key> keys = new List<Key>();
            keys.Add(redKey);
            keys.Add(yellowKey);
            keys.Add(cyanKey);
            keys.Add(magentaKey);

            return keys;
        }
    }
}
