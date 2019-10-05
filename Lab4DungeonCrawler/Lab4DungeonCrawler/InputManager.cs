using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class InputManager
    {
<<<<<<< HEAD
      
     
      
      public InputManager()
      {
        
      }
=======
        public InputManager()
        {
        // map = TileMap.GetTileMap();
        }
>>>>>>> f02851ba148617507f5b206bc1ff60a998939e1c
      
        public static Point GetInput()
        {
            var input = Console.ReadKey(true);
            Point point;
            switch (input.KeyChar)
            {
                case 'w':
                    point = new Point(-1, 0);
                    return point;
                case 's':
                    point = new Point(1, 0);
                    return point;
                case 'a':
                    point = new Point(0, -1);
                    return point;
                case 'd':
                    point = new Point(0, 1);
                    return point;
                default:
                    if (input.Key == ConsoleKey.Escape)
                    {
                        System.Environment.Exit(0);
                    }
                    point = new Point(0, 0);
                    return point;
            }
        }
    }
}
