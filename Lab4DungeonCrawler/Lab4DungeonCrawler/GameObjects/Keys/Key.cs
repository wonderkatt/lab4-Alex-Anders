
namespace Lab4DungeonCrawler
{
    public class Key : GameObject, IInteractable
    {
        public Key(Point point)
        {
            Position = point;
            Symbol = 'k';
        }

        public void Interact(GamePlayManager gamePlayManager)
        {
            gamePlayManager.Player.playerInventory.Add(this);
            gamePlayManager.GameObjects.Remove(this);
            gamePlayManager.GameObjects.Add(new FloorTile(this.Position, true));
        }
        public string Name { get; set; }
        public int NumberOfUses { get; set; }
    }
}
