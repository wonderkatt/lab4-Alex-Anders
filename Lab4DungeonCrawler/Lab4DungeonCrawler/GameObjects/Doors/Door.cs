using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Door : GameObject, IInteractable
    {
        public Door()
        {
            Symbol = 'D';
        }

        public void Interact(GamePlayManager instance)
        {
            instance.GameObjects.Remove(this);
            instance.GameObjects.Add(new FloorTile(this.Position, true));
            foreach (var key in instance.Player.playerInventory)
            {
                if(key.Color == this.Color)
                {
                    key.NumberOfUses--;
                    if (key.NumberOfUses == 0)
                    {
                    instance.Player.playerInventory.Remove(key);
                    }
                }
            }
        }
    }
}
