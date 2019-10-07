using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Key : IInteract
    {
        public Key(string name, int numberOfUsesLeft, int x, int y, ConsoleColor colour)
        {
            Name = name;
            NumberOfUsesLeft = numberOfUsesLeft;
            Position = new Point(x, y);
            Colour = colour;
            Symbol = 'k';
        }
        public void Interact(GamePlayManager currentGameState)
        {
            foreach (var floortile in currentGameState.GetGameObjects())
            {
                if (floortile.Position.Equals(currentGameState.Player.CurrentPlayerPosition))
                {
                    currentGameState.Player.PlayerInventory.AddKeyToInventory(floortile.Key);
                    floortile.Key = null;
                }
            }
            currentGameState.Player.PlayerInventory.PrintInventory();

        }

        public string Name { get; set; }
        public int NumberOfUsesLeft { get; set; }
        public Point Position { get; set; }
        public ConsoleColor Colour { get; set; }
        public char Symbol { get; set; }
    }
}
