using System;
using System.Collections.Generic;

namespace Lab4DungeonCrawler
{
    internal class Renderer
    {

        public Renderer()
        {
            
        }

         public static void PrintOutMap(GamePlayManager gamePlayManager)
        {
            foreach (var Tile in gamePlayManager.GetGameObjects())
            {
                if (Tile.IsExplored == true)
                {
                ConsoleHandler.WriteAt(Tile.Symbol, Tile.Position);
                }
            }
            
            ConsoleHandler.WriteAt(gamePlayManager.GetPlayer().Symbol, gamePlayManager.GetPlayer().CurrentPlayerPosition);

        }

        public static void RenderMap(GamePlayManager gamePlayManager)
        {
            Point currentPlayerPosition = gamePlayManager.GetPlayer().CurrentPlayerPosition;
            Point previousPlayerPosition = gamePlayManager.GetPlayer().PreviousPlayerPosition;

          ConsoleHandler.WriteAt(gamePlayManager.GetPlayer().Symbol, currentPlayerPosition);
            Point point;
            TileType tempTile;
            for (int i = currentPlayerPosition.column-1; i < currentPlayerPosition.column+2; i++)
            {
                for (int j = currentPlayerPosition.row -1; j < currentPlayerPosition.row + 2; j++)
                {
                    if(i != currentPlayerPosition.column || j != currentPlayerPosition.row)
                    {

                    point = new Point(i, j);
                    tempTile = GetTileAtPoint(point, gamePlayManager);
                    ConsoleHandler.WriteAt(tempTile.Symbol, tempTile.Position);
                    tempTile.IsExplored = true;
                    }
                }
            }
            tempTile = GetTileAtPoint(previousPlayerPosition, gamePlayManager);
            ConsoleHandler.WriteAt(tempTile.Symbol, tempTile.Position);
        }

        public static TileType GetTileAtPoint(Point point, GamePlayManager gamePlayManager)
        {
            foreach (var Tile in gamePlayManager.GetGameObjects())
            {
                if (Tile.Position.Equals(point))
                {
                    return Tile;
                }
            }
            return null;
        }

       
    }
}