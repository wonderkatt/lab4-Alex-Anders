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
                ConsoleHandler.WriteCharAt(Tile.Symbol, Tile.Position);
                }
            }
            
            ConsoleHandler.WriteCharAt(gamePlayManager.GetPlayer().Symbol, gamePlayManager.GetPlayer().CurrentPlayerPosition, ConsoleColor.Gray);

        }

        public static void RenderMap(GamePlayManager currentGameState)
        {
            Point currentPlayerPosition = currentGameState.GetPlayer().CurrentPlayerPosition;
            Point point;
            TileType tempTile;

            for (int row = currentPlayerPosition.row - 1; row < currentPlayerPosition.row + 2; row++)
            {
                for (int column = currentPlayerPosition.column - 1; column < currentPlayerPosition.column + 2; column++)
                {
                    point = new Point(row, column);
                    tempTile = GameObjectHandler.GetTileAtPoint(point, currentGameState.GetGameObjects());
                    if(tempTile.Key != null)
                    {
                        ConsoleHandler.WriteCharAt(tempTile.Key.Symbol, point, tempTile.Key.Color);
                        tempTile.IsExplored = true;
                    }
                    else if(tempTile.Monster != null)
                    {
                        ConsoleHandler.WriteCharAt(tempTile.Monster.Symbol, point, tempTile.Monster.Color);
                        tempTile.IsExplored = true;
                    }
                    else if(tempTile.Door != null)
                    {
                        ConsoleHandler.WriteCharAt(tempTile.Door.Symbol, point, tempTile.Door.Color);
                        tempTile.IsExplored = true;
                    }
                    else
                    { 
                    ConsoleHandler.WriteCharAt(tempTile.Symbol, point);
                    tempTile.IsExplored = true;
                    }
                }
            }
            ConsoleHandler.WriteCharAt(currentGameState.GetPlayer().Symbol, currentPlayerPosition, ConsoleColor.Gray);
        }
    }
}