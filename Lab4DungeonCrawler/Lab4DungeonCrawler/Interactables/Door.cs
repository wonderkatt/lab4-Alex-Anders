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
            Symbol = 'D';
        }

        public Point Position { get; set; }
        public ConsoleColor Colour { get; set; }
        public char Symbol { get; set; }

        
    }
}
