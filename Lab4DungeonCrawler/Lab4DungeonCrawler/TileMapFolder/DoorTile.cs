using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class DoorTile : TileType, IInteractable
    {
        public DoorTile(Point point) : base(point)
        {
            this.Position = point;
            this.Symbol = 'D';
        }
    }
}
