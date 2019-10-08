using System;
using System.Collections.Generic;

namespace Lab4DungeonCrawler
{
    internal class Renderer
    {

        public Renderer()
        {
            
        }

         public static void PrintOutMap(GamePlayManager instance)
        {
            foreach (var Tile in instance.GameObjects)
            {
                if (Tile.IsExplored == true)
                {
                ConsoleHandler.WriteCharAt(Tile.Symbol, Tile.Position);
                }
            }
            
            ConsoleHandler.WriteCharAt(instance.Player.Symbol, instance.Player.CurrentPlayerPosition, ConsoleColor.Gray);
            ConsoleHandler.WriteStringAt(instance.Player.numberOfMoves.ToString(), new Point(18, 0));
            PrintInventory(instance);
        }

        public static void RenderMap(GamePlayManager instance)
        {
            Point currentPlayerPosition = instance.Player.CurrentPlayerPosition;

            ConsoleHandler.WriteStringAt(instance.Player.numberOfMoves.ToString(), new Point(18, 0));
            ExploreTilesAroundPlayer(instance, currentPlayerPosition);
            ConsoleHandler.WriteCharAt(instance.Player.Symbol, currentPlayerPosition, ConsoleColor.Gray);
            PrintInventory(instance);  
        }

        private static void ExploreTilesAroundPlayer(GamePlayManager instance, Point currentPlayerPosition)
        {
            Point point;
            GameObject tempTile;
            for (int row = currentPlayerPosition.row - 1; row < currentPlayerPosition.row + 2; row++)
            {
                for (int column = currentPlayerPosition.column - 1; column < currentPlayerPosition.column + 2; column++)
                {
                    point = new Point(row, column);
                    tempTile = instance.GetTileAtPoint(point, instance.GameObjects);
                    if (tempTile is Key)
                    {
                        ConsoleHandler.WriteCharAt(tempTile.Symbol, point, tempTile.Color);
                        tempTile.IsExplored = true;
                    }
                    else if (tempTile is Monster)
                    {
                        ConsoleHandler.WriteCharAt(tempTile.Symbol, point, tempTile.Color);
                        tempTile.IsExplored = true;
                    }
                    else if (tempTile is Door)
                    {
                        ConsoleHandler.WriteCharAt(tempTile.Symbol, point, tempTile.Color);
                        tempTile.IsExplored = true;
                    }
                    else
                    {
                        ConsoleHandler.WriteCharAt(tempTile.Symbol, point);
                        tempTile.IsExplored = true;
                    }
                }
            }
        }

        private static void PrintInventory(GamePlayManager instance)
        {
            ConsoleHandler.WriteStringAt("Inventory: ", new Point(20, 0));
            for (int i = 0; i < 5; i++)
            {
                ConsoleHandler.WriteCharAt(' ', new Point(20, 11 + i));
            }

            for (int i = 0; i < instance.Player.playerInventory.Count; i++)
            {
                ConsoleHandler.WriteCharAt(instance.Player.playerInventory[i].Symbol, new Point(20, 11 + i), instance.Player.playerInventory[i].Color);
            }
        }
    }
}