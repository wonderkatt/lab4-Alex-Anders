using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Key : IInteract
    {
        // Införa en färgproperty?

        public Key()
        {

        }
        public Key(string name, int x, int y, ConsoleColor colour, int numberOfUsesLeft)
        {
            Name = name;
            Position = new Point(x, y);
            Color = colour;
            NumberOfUsesLeft = numberOfUsesLeft;
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
        public Point Position { get; set; }
        public ConsoleColor Color { get; set; }
        public int NumberOfUsesLeft { get; set; }
        public char Symbol { get; set; }

    }
}
