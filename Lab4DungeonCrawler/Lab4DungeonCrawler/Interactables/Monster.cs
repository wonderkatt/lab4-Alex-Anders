using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Monster : IInteract
    {
        public Monster(int x, int y)
        {
            Position = new Point(x, y);
            Colour = ConsoleColor.Green;
            Symbol = 'M';
        }
        public void Interact(GamePlayManager currentGameState)
        {
            currentGameState.Player.numberOfMoves += 3;
        }

        public Point Position { get; set; }
        public ConsoleColor Colour { get; set; }
        public char Symbol { get; set; }
    }
}
