using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class PlayerController
    {
        public Point currentPosition = new Point(1,1);
        TileMap map = new TileMap();
        public PlayerController()
        {

        }

        public void MovePlayer()
        {
            var input = Console.ReadKey();

            switch(input.KeyChar)
            {
                case 'w':
                    Move(-1, 0);
                    break;
                case 's':
                    Move(1, 0);
                    break;
                case 'a':
                    Move(0, -1);
                    break;
                case 'd':
                    Move(0, 1);
                    break;
            }
        }
         
        public void Move(int row, int column)
        {
            map.map[currentPosition.row, currentPosition.column] = new FloorTile();
            currentPosition = new Point(currentPosition.row + row, currentPosition.column + column);
        }
        
    }
}
