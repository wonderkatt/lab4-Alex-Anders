using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Player player = new Player();
            TileMap map = new TileMap(player);
            PlayerController playerController = new PlayerController(player);
            map.InitiateMap();
            while(true)
            {
            map.PrintOutMap();
                playerController.MovePlayer();

            }
            
            Console.ReadKey();
        }
    }
}
