using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Monster : GameObject, IInteractable
    {
        public Monster(Point point, bool explored)
        {
            Position = point;
            IsExplored = explored;
            Color = ConsoleColor.Green;
            Symbol = 'M';
        }

        public void Interact(GamePlayManager instance)
        {
            instance.Player.numberOfMoves += 3;
        }
    }
}
