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
                        ConsoleHandler.WriteAt(tempTile.Symbol, point);
                        tempTile.IsExplored = true;
                        foreach (var door in gamePlayManager.GetDoorObjects())
                        {
                            if (point.Equals(door.Position))
                            {
                                ConsoleHandler.WriteAt(door.Symbol, point, door.Colour);
                            }
                        }
                        foreach (var key in gamePlayManager.GetKeyObjects())
                        {
                            if (point.Equals(key.Position))
                            {
                                ConsoleHandler.WriteAt(key.Symbol, point, key.Colour);
                            }
                        }
                        foreach (var monster in gamePlayManager.GetMonsterObjects())
                        {
                            if (point.Equals(monster.Position))
                            {
                                ConsoleHandler.WriteAt(monster.Symbol, point, monster.Color);
                            }
                        }
                    }
                }
            }
            tempTile = GetTileAtPoint(previousPlayerPosition, gamePlayManager);
            ConsoleHandler.WriteAt(tempTile.Symbol, tempTile.Position);
            foreach (var door in gamePlayManager.GetDoorObjects())
            {
                if (tempTile.Position.Equals(door.Position))
                {
                    ConsoleHandler.WriteAt(door.Symbol, tempTile.Position, door.Colour);
                }
            }
            foreach (var monster in gamePlayManager.GetMonsterObjects())
            {
                if (tempTile.Position.Equals(monster.Position))
                {
                    ConsoleHandler.WriteAt(monster.Symbol, tempTile.Position, ConsoleColor.Green);
                }
            }
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