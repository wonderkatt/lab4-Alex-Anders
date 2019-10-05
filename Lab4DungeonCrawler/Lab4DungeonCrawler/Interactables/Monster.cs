using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Monster : IInteractable
    {
       
        public Monster(int x, int y)
        {
            Position = new Point(x, y);
            Symbol = 'M';
            Color = ConsoleColor.Green;
        }

        public Point Position { get; set; }
        public char Symbol { get; set; }
        public ConsoleColor Color { get; set; }
        
    }
}
