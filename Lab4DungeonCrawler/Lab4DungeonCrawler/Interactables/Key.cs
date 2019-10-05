using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Key : IInteractable
    {
        // Införa en färgproperty?

        public Key()
        {

        }
        public Key(int x, int y, ConsoleColor colour)
        {
            Position = new Point(x, y);
            Colour = colour;
        }

        public Point Position { get; set; }
        public ConsoleColor Colour { get; set; }
        public char Symbol { get { return 'k'; } }

        public List<Key> CreateKeys()
        {
            List<Key> keys = new List<Key>
            {
                new Key(5, 2, ConsoleColor.Red),
                new Key(2, 14, ConsoleColor.Yellow),
                new Key(14, 10, ConsoleColor.Cyan),
                new Key(10, 43, ConsoleColor.Magenta)
            };

            return keys;
        }
    }
}
