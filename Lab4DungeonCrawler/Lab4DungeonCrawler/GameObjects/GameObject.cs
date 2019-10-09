using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public abstract class GameObject
    {
        public Point Position { get; set; }
        public char Symbol { get; set; }
        public ConsoleColor Color { get; set; }
        public bool IsExplored { get; set; }
    }
}
