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
          ConsoleHandler.WriteAt(gamePlayManager.GetPlayer().Symbol, gamePlayManager.GetPlayer().CurrentPlayerPosition);
            Point point;
            TileType tempTile;
            for (int i = gamePlayManager.GetPlayer().CurrentPlayerPosition.column-1; i < gamePlayManager.GetPlayer().CurrentPlayerPosition.column+2; i++)
            {
                for (int j = gamePlayManager.GetPlayer().CurrentPlayerPosition.row -1; j < gamePlayManager.GetPlayer().CurrentPlayerPosition.row + 2; j++)
                {
                    if(i != gamePlayManager.GetPlayer().CurrentPlayerPosition.column || j != gamePlayManager.GetPlayer().CurrentPlayerPosition.row)
                    {

                    point = new Point(i, j);
                    tempTile = GetTileAtPoint(point, gamePlayManager);
                    ConsoleHandler.WriteAt(tempTile.Symbol, tempTile.Position);
                    tempTile.IsExplored = true;
                    }
                }
            }
            tempTile = GetTileAtPoint(gamePlayManager.GetPlayer().PreviousPlayerPosition, gamePlayManager);
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