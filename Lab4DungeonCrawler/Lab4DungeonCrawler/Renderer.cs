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
            
            ConsoleHandler.WriteAt(gamePlayManager.GetPlayer().Symbol, gamePlayManager.GetPlayer().CurrentPlayerPosition, ConsoleColor.Gray);

        }

        public static void RenderMap(GamePlayManager gamePlayManager)
        {
            Point currentPlayerPosition = gamePlayManager.GetPlayer().CurrentPlayerPosition;
            Point previousPlayerPosition = gamePlayManager.GetPlayer().PreviousPlayerPosition;

            ConsoleHandler.WriteAt(gamePlayManager.GetPlayer().Symbol, currentPlayerPosition, ConsoleColor.Gray);
            Point point;
            TileType tempTile;
            for (int row = currentPlayerPosition.row - 1; row < currentPlayerPosition.row + 2; row++)
            {
                for (int column = currentPlayerPosition.column - 1; column < currentPlayerPosition.column + 2; column++)
                {
                    if (row != currentPlayerPosition.row || column != currentPlayerPosition.column)
                    {
                        point = new Point(row, column);
                        tempTile = GetTileAtPoint(point, gamePlayManager);
                        if(tempTile.Key != null)
                        {
                            ConsoleHandler.WriteAt(tempTile.Key.Symbol, point, tempTile.Key.Color);
                            tempTile.IsExplored = true;
                        }
                        else if(tempTile.Monster != null)
                        {
                            ConsoleHandler.WriteAt(tempTile.Monster.Symbol, point, tempTile.Monster.Color);
                            tempTile.IsExplored = true;
                        }
                        else if(tempTile.Door != null)
                        {
                            ConsoleHandler.WriteAt(tempTile.Door.Symbol, point, tempTile.Door.Color);
                            tempTile.IsExplored = true;
                        }
                        else
                        { 
                        ConsoleHandler.WriteAt(tempTile.Symbol, point);
                        tempTile.IsExplored = true;
                        }
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