using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class ExitTile : Tile
    {
        public ExitTile(Point point, bool explored) : base(point, explored)
        {
            Symbol = 'E';
        }
    }
}
