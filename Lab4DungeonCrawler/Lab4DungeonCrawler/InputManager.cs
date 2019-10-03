using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class InputManager
    {
      private static Point targetPosition;
      private static TileType[,] map;
      
      public InputManager()
      {
        // map = TileMap.GetTileMap();
      }
      
      public static Point GetInput()
      {
          var input = Console.ReadKey(true);
            Point point;
          switch (input.KeyChar)
          {
              case 'w':
                    point = new Point(0, -1);
                    return point;
                  
              case 's':
                    point = new Point(0, 1);
                    return point;
              case 'a':
                    point = new Point(-1,0);
                    return point;
              case 'd':
                    point = new Point(1,0);
                    return point;
              default:
                    point = new Point(0, 0);
                    return point;
          }
      }
      
    


    }
    
}
