using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Door : GameObject, IInteractable
    {
        public Door(Point point)
        {
            Position = point;
            Symbol = 'D';
        }

        public void Interact(GamePlayManager gamePlayManager)
        {
            gamePlayManager.GameObjects.Remove(this);
            gamePlayManager.GameObjects.Add(new FloorTile(this.Position, true));
            foreach (var key in gamePlayManager.Player.playerInventory)
            {
                if(key.Color == this.Color)
                {
                    key.NumberOfUses--;
                    if (key.NumberOfUses == 0)
                    {
                        gamePlayManager.Player.playerInventory.Remove(key);
                        break;
                    }
                }
            }

        }
    }
}
