﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Player
    {
        private string symbol = "@";
        private static Point currentPosition = new Point(1, 1);

        public Player()
        {
            PlayerInventory inventory = new PlayerInventory();
        }

        public string Symbol { get { return symbol; } private set { } }

        public static Point GetCurrentPlayerPosition()
        {
                return currentPosition;
        }

       
    }
}



   
