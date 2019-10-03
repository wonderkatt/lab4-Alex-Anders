using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class FloorTile : TileType, IInteractable
    {
        
        public FloorTile(Point point) : base(point)
        {
            this.Position = point;

            this.Symbol = '-';
        }
    }
}
