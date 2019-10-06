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
        public void AddItemToPlayerInventory(Key key)
        {
            playerInventory.Add(key);
        }

        public void RemoveItemFromPlayerInventory(Key key)
        {
            playerInventory.Remove(key);
        }
        public void PrintPlayerInventory()
        {
            foreach (var key in playerInventory)
            {
                Console.WriteLine(key);
            }
        }
        public bool IsKeyInInventory(Key key)
        {
            if (playerInventory.Contains(key))
            {
                return true;
            }
            return false;
        }
    }
}
