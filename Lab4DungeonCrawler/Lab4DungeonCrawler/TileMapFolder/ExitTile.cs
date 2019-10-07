using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class ExitTile : TileType
    {
        public ExitTile(Point point, bool explored) : base(point, explored)
        {
            IsExplored = explored;
            Position = point;
            Symbol = 'E';
        }
    }
}
