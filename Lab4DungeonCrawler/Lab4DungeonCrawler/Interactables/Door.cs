using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Door : IInteractable
    {
        // Införa en färgproperty?

        public Door()
        {

        }
        public Door(int x, int y, ConsoleColor colour)
        {
            Position = new Point(x, y);
            Colour = colour;
        }

        public Point Position { get; set; }
        public ConsoleColor Colour { get; set; }
        public char Symbol { get { return 'D'; } }

        public List<Door> CreateDoors()
        {
            List<Door> doors = new List<Door>
            {
                new Door(10, 8, ConsoleColor.Red),
                new Door(9, 19, ConsoleColor.Yellow),
                new Door(15, 27, ConsoleColor.Yellow),
                new Door(13, 31, ConsoleColor.Cyan),
                new Door(5, 31, ConsoleColor.Magenta)
            };

            return doors;
        }
    }
}
