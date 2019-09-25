﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{

    public class PlayerInventory
    {
        private static List<KeyType> playerInventory = new List<KeyType>();

        public PlayerInventory()
        {

        }
        public void AddItemToPlayerInventory(KeyType key)
        {
            playerInventory.Add(key);
        }

        public void RemoveItemFromPlayerInventory(KeyType key)
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
        public bool CheckItemInInventory(KeyType key)
        {
            if (playerInventory.Contains(key)
            {
                return true;
            }
            return false;
        }
    }
}
