using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Player
    {
        public Point currentPosition = new Point(1, 1);
        public Player()
        {
            PlayerInventory inventory = new PlayerInventory();
        }
    }
}
