using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class ShortcutTile : Tile, IInteractable
    {
        public ShortcutTile(Point point, bool explored) : base(point, explored)
        {
            Symbol = ' ';
            Color = ConsoleColor.Black;
        }

        public void Interact(GamePlayManager gamePlayerManager)
        {
            var tempTile = gamePlayerManager.GetTileAtPoint(new Point(6, 31));
            if (!tempTile.IsExplored)
            {
                gamePlayerManager.GameObjects.Remove(tempTile);
                gamePlayerManager.GameObjects.Add(new FloorTile(tempTile.Position, false));
            }
            else if (tempTile.IsExplored)
            {
                gamePlayerManager.GameObjects.Remove(tempTile);
                gamePlayerManager.GameObjects.Add(new FloorTile(tempTile.Position, true));
                ConsoleHandler.WriteCharAt(tempTile.Symbol, tempTile.Position, tempTile.Color);
            }
        }
    }
}
