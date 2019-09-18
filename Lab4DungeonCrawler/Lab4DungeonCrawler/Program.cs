using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            TileMap map = new TileMap();
            PlayerController player = new PlayerController();
            while(true)
            {
                map.PrintOutMap();
                player.MovePlayer();
            }
            Console.ReadKey();
        }
    }
}
