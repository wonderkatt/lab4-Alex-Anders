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
           map = TileMap.GetTileMap();
        }

        public static void GetInput()
        {
            var input = Console.ReadKey(true);
           
            switch (input.KeyChar)
            {
                case 'w':
                   targetPosition = new Point(Player.CurrentPlayerPosition.column, Player.CurrentPlayerPosition.row - 1);
                   if (map[targetPosition.column, targetPosition.row].TileGraphic == "#")
                    {
                        break;
                    }

                    MovePlayer(0, -1);
                    break;
                case 's':
                    targetPosition = new Point(Player.CurrentPlayerPosition.column, Player.CurrentPlayerPosition.row + 1);
                    if (map[targetPosition.column, targetPosition.row].TileGraphic == "#")
                    {
                        break;
                    }
                    MovePlayer(0, 1);
                    break;
                
                case 'a':
                    targetPosition = new Point(Player.CurrentPlayerPosition.column - 1, Player.CurrentPlayerPosition.row);
                    if (map[targetPosition.column, targetPosition.row].TileGraphic == "#")
                    {
                        break;
                    }
                    MovePlayer(-1, 0);
                    break;
                
                case 'd':
                    targetPosition = new Point(Player.CurrentPlayerPosition.column + 1, Player.CurrentPlayerPosition.row);
                    if (map[targetPosition.column, targetPosition.row].TileGraphic == "#")
                    {
                        break;
                    }
                    MovePlayer(1, 0);
                    break;
               
                default:
                    Player.PreviousPlayerPosition = Player.CurrentPlayerPosition;
                    Player.CurrentPlayerPosition = new Point(Player.CurrentPlayerPosition.column, Player.CurrentPlayerPosition.row);
                    break;
            }
        }

        public static void MovePlayer(int addColumn, int addRow)
        {
            Player.PreviousPlayerPosition = Player.CurrentPlayerPosition;
            Player.CurrentPlayerPosition = new Point(Player.CurrentPlayerPosition.column + addColumn, Player.CurrentPlayerPosition.row + addRow);
            Player.numberOfMoves++;
        }


    }
    
}
