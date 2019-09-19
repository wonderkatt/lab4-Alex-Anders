using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public struct Point
    {
        public int column, row;

        public Point(int x, int y)
        {
            row = x;
             this.column = y;
        }
    } 
}
