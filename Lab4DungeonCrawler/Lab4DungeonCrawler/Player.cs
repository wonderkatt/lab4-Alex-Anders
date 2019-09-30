using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Player
    {
        private string symbol = "@";
        public static int numberOfMoves = 0;

        public Player()
        {
            PlayerInventory inventory = new PlayerInventory();
        }

        public string Symbol { get { return symbol; } private set { } }

        public static Point CurrentPlayerPosition { get; set; }

        public static Point PreviousPlayerPosition { get; set; }
       

       
    }
}



   

