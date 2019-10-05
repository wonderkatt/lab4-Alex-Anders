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
        public Key(int x, int y, ConsoleColor colour, int numberOfUsesLeft)
        {
            Position = new Point(x, y);
            Color = colour;
            NumberOfUsesLeft = numberOfUsesLeft;
            Symbol = 'k';
        }

        public Point Position { get; set; }
        public ConsoleColor Color { get; set; }
        public int NumberOfUsesLeft { get; }
        public char Symbol { get; set; }

    }
}
