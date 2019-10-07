using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public interface IInteract
    {
        void Interact(GamePlayManager currentGameState);
        Point Position { get; set; }
        ConsoleColor Colour { get; set; }
        char Symbol { get; set; }
    }
}
