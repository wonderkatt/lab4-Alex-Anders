using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class WallTile : TileType, IInteractable
    {
        public WallTile(Point point, bool explored) : base(point, explored) 
        {
            IsExplored = explored;
            Position = point;
            Symbol = '#';
        }
    }
}
