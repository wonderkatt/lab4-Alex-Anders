
namespace Lab4DungeonCrawler
{
   public class TrapTile : Tile, IInteractable
    {
        public TrapTile(Point point, bool explored) : base(point, explored)
        {
            Symbol = '!';
        }

        public void Interact(GamePlayManager gamePlayManager)
        {
            var tempTile = gamePlayManager.GetTileAtPoint(gamePlayManager.Player.PreviousPlayerPosition, gamePlayManager.GameObjects);
            ConsoleHandler.WriteCharAt(tempTile.Symbol, tempTile.Position, tempTile.Color);
            gamePlayManager.Player.CurrentPlayerPosition = new Point(1, 1);
        }
    }
}
