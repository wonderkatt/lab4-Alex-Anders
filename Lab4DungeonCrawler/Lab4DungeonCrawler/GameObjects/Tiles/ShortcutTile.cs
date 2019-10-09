using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class ShortcutTile : TileType, IInteractable
    {
        public ShortcutTile(Point point, bool isExplored) : base(point, isExplored)
        {
            IsExplored = isExplored;
            Symbol = '*';
            Position = point;
        }

        public void Interact(GamePlayManager gamePlayerManager)
        {
            var tempTile = gamePlayerManager.GetTileAtPoint(new Point(6, 31), gamePlayerManager.GameObjects);
            if (!tempTile.IsExplored)
            {
                gamePlayerManager.GameObjects.Remove(tempTile);
                gamePlayerManager.GameObjects.Add(new FloorTile(tempTile.Position, false));
            }
            else if (tempTile.IsExplored)
            {
                gamePlayerManager.GameObjects.Remove(tempTile);
                gamePlayerManager.GameObjects.Add(new FloorTile(tempTile.Position, true));
                ConsoleHandler.WriteCharAt(tempTile.Symbol, tempTile.Position);
            }
        }
    }
}
