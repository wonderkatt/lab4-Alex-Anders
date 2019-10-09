using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
   public class TrapTile : TileType, IInteractable
    {
        public TrapTile(Point point, bool explored) : base(point, explored)
        {
            Symbol = '_';
            Position = point;
            IsExplored = explored;
        }

        public void Interact(GamePlayManager gamePlayManager)
        {
            var tempTile = gamePlayManager.GetTileAtPoint(gamePlayManager.Player.PreviousPlayerPosition, gamePlayManager.GameObjects);
            ConsoleHandler.WriteCharAt(tempTile.Symbol, tempTile.Position);
            gamePlayManager.Player.CurrentPlayerPosition = new Point(1, 1);
        }
    }
}
