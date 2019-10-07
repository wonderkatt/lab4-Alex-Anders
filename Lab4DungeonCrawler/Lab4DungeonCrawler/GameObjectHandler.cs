using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public static class GameObjectHandler
    {
        public static TileType GetTileAtPoint(Point point, List<TileType> gameObjects)
        {
            var returnTile = gameObjects.Find(tile => tile.Position.Equals(point));
            return returnTile;
        }
        public static void InteractWith(GamePlayManager currentGameState)
        {
            var tempTile = GetTileAtPoint(currentGameState.Player.CurrentPlayerPosition, currentGameState.GetGameObjects());
            if (tempTile.Symbol.Equals('E'))
            {
                Program.currentState = States.EndState;
                return;
            }

            tempTile = (FloorTile)tempTile;
            if (tempTile.Door is Door)
            {
                tempTile.Door.Interact(currentGameState);
            }
            if (tempTile.Key is Key)
            {
                tempTile.Key.Interact(currentGameState);
            }
            if (tempTile.Monster is Monster)
            {
                tempTile.Monster.Interact(currentGameState);
            }
        }
    }
}
