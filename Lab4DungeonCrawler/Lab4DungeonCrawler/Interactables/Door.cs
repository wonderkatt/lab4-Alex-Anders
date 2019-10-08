﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Door : IInteract
    {
        public Door(int x, int y, ConsoleColor colour)
        {
            Position = new Point(x, y);
            Colour = colour;
            Symbol = 'D';
        }
        public void Interact(GamePlayManager currentGameState)
        {
            foreach (var floortile in currentGameState.GetGameObjects())
            {
                if (floortile.Position.Equals(currentGameState.Player.CurrentPlayerPosition))
                {
                    currentGameState.Player.PlayerInventory.RemoveKeyFromInventory(floortile.Door.Colour);
                    floortile.Door = null;
                }
            }
            currentGameState.Player.PlayerInventory.PrintInventory();
        }

        public Point Position { get; set; }
        public ConsoleColor Colour { get; set; }
        public char Symbol { get; set; }
    }
}
