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
            ConsoleHandler.WriteAt(gamePlayManager.GetPlayer().Symbol, gamePlayManager.GetPlayer().CurrentPlayerPosition, ConsoleColor.Gray);
            Point point;
            TileType tempTile;
            for (int x = gamePlayManager.GetPlayer().CurrentPlayerPosition.row-1; x < gamePlayManager.GetPlayer().CurrentPlayerPosition.row+2; x++)
            {
                for (int y = gamePlayManager.GetPlayer().CurrentPlayerPosition.column -1; y < gamePlayManager.GetPlayer().CurrentPlayerPosition.column + 2; y++)
                {
                    if(x != gamePlayManager.GetPlayer().CurrentPlayerPosition.row || y != gamePlayManager.GetPlayer().CurrentPlayerPosition.column)
                    {
                        point = new Point(x, y);
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
                                ConsoleHandler.WriteAt(monster.Symbol, point, ConsoleColor.Green);
                            }
                        }
                    }
                }
            }
            tempTile = GetTileAtPoint(gamePlayManager.GetPlayer().PreviousPlayerPosition, gamePlayManager);
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