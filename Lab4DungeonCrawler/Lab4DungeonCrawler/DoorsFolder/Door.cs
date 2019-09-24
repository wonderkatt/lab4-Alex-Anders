using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Door : IInteract
    {
        private Point position;

        public Door(int x, int y)
        {
            position = new Point(x, y);
        }
        public Point GetPosition { get { return position; } set { position = value} }  
    }
}
