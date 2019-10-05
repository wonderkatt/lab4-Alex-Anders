using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class FloorTile : TileType
    {
        public FloorTile(Point point, bool explored) : base(point, explored)
        {
            Position = point;
            IsExplored = explored;
            Symbol = '-';
        }
    }
}
