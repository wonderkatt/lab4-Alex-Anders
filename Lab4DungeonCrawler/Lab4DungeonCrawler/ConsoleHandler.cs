using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class ConsoleHandler
    {
        static TileType[,] map;
        private readonly DataInitializer dataInitializer;

        public ConsoleHandler(DataInitializer dataInitializer)
        {
            map = TileMap.GetTileMap();
            this.dataInitializer = dataInitializer ?? throw new ArgumentNullException(nameof(dataInitializer));
        }
        
       static public void PrintOutMap(Player player)
        {

           
            Console.Clear();
            for (int column = 0; column < map.GetLength(0); column++)
            {
                for (int row = 0; row < map.GetLength(1); row++)
                {
                    Console.Write(map[column, row].TileGraphic);
                }
                Console.WriteLine();
            }
            

            Console.SetCursorPosition(Player.GetCurrentPlayerPosition().column, Player.GetCurrentPlayerPosition().row);
            Console.Write(player.Symbol);
        }
    }


}
