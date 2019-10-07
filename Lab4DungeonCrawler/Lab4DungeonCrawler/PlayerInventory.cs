using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{

    public class PlayerInventory
    {
        private static List<Key> playerInventory = new List<Key>();

        public PlayerInventory()
        {

        }
        public void AddKeyToInventory(Key key)
        {
            playerInventory.Add(key);
        }
        public void RemoveKeyFromInventory(ConsoleColor color)
        {
            foreach (var key in playerInventory)
            {
                if (key.Color.Equals(color) && key.NumberOfUsesLeft == 2)
                {
                    key.NumberOfUsesLeft--;
                    break;
                }
                else if(key.Color.Equals(color))
                {
                    playerInventory.Remove(key);
                    break;
                }
            }
        }
        public static bool IsKeyInInventory(ConsoleColor color)
        {
            if (playerInventory.Any(key => key.Color.Equals(color)))
            {
                return true;
            }
            return false;
        }
        public void PrintInventory()
        {
            var point = new Point(20, 0);
            ConsoleHandler.WriteStringAt("Inventory:", point);
            point.row++;
            ConsoleHandler.WriteStringAt(new string(' ', Console.WindowWidth), point);
            foreach (var key in playerInventory)
            {
                ConsoleHandler.WriteStringAt(key.Name, point);
                point.row++;
            }
            ConsoleHandler.WriteStringAt(new string(' ', Console.WindowWidth), point);
        }
    }
}
