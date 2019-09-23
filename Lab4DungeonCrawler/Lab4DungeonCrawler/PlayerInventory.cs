using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{

    class PlayerInventory
    {
        private List<KeyType> playerInventory = new List<KeyType>();

        public PlayerInventory()
        {

        }
        public void AddToPlayerInventory(KeyType key)
        {
            playerInventory.Add(key);
        }

        public void RemoveFromPlayerInventory(KeyType key)
        {
            playerInventory.Remove(key);
        }
        public void PrintPlayerInventory()
        {
            for (int i = 0; i < playerInventory.Count; i++)
            {
                Console.WriteLine(playerInventory[i]);
            }
        }
        public bool CheckInventory()
        {
            return true;
        }
    }
}
