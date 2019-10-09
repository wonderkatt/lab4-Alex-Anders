using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Monster : GameObject, IInteractable
    {
        public Monster(Point point, bool isExplored)
        {
            Color = ConsoleColor.Green;
            IsExplored = isExplored;
            Symbol = 'M';
            Position = point;
        }

        public void Interact(GamePlayManager instance)
        {
            instance.Player.numberOfMoves = instance.Player.numberOfMoves + 4;
        }
    }
}
