using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class DoorTile : TileType
    {
        public DoorTile()
        {
            this.TileGraphic = "D";
        }

        public bool UnlockDoor();
    }
}
