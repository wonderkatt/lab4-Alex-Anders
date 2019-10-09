using System;

namespace Lab4DungeonCrawler
{
    public class Key : GameObject, IInteractable
    {
        public Key()
        {
            Symbol = 'k';
        }

        public void Interact(GamePlayManager instance)
        {
            instance.Player.playerInventory.Add(this);
            instance.GameObjects.Remove(this);
            instance.GameObjects.Add(new FloorTile(this.Position, true));
        }
        public int NumberOfUses { get; set; }
    }
}
