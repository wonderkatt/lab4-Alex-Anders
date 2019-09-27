using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class InputManager
    {

        public static void GetInput()
        {
            var input = Console.ReadKey(true);
           
            switch (input.KeyChar)
            {
                case 'w':
                    Player.PreviousPlayerPosition = Player.CurrentPlayerPosition;
                    Player.CurrentPlayerPosition = new Point(Player.CurrentPlayerPosition.column, Player.CurrentPlayerPosition.row - 1);
                    break;
                case 's':
                    Player.PreviousPlayerPosition = Player.CurrentPlayerPosition;
                    Player.CurrentPlayerPosition = new Point(Player.CurrentPlayerPosition.column, Player.CurrentPlayerPosition.row + 1);
                    break;
                
                case 'a':
                    Player.PreviousPlayerPosition = Player.CurrentPlayerPosition;
                    Player.CurrentPlayerPosition = new Point(Player.CurrentPlayerPosition.column - 1, Player.CurrentPlayerPosition.row);
                    break;
                
                case 'd':
                    Player.PreviousPlayerPosition = Player.CurrentPlayerPosition;
                    Player.CurrentPlayerPosition = new Point(Player.CurrentPlayerPosition.column + 1, Player.CurrentPlayerPosition.row);
                    break;
               
                default:
                    Player.PreviousPlayerPosition = Player.CurrentPlayerPosition;
                    Player.CurrentPlayerPosition = new Point(Player.CurrentPlayerPosition.column, Player.CurrentPlayerPosition.row);
                    break;
            }
        }
    }
    
}
