using System;
using System.Collections.Generic;

namespace Lab4DungeonCrawler
{
    public class Renderer
    {
        public Renderer()
        {
            
        }

        public void PrintInstructions()
        {
            var point = new Point(2, 60);
            ConsoleHandler.WriteStringAt(" __________________________", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|    *** FIND EXIT ***     |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|                          |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|Move @ with a,s,d and w,  |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|collect keys(k),          |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|move through doors(D),    |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|watch out for monsters(M),|", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|they give you extra steps,|", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|find exit(E) with as few, |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|steps as possible.        |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|__________________________|", point);
        }

        public void PrintOutMap(GamePlayManager instance)
        {
            foreach (var Tile in instance.GameObjects)
            {
                if (Tile.IsExplored == true)
                {
                ConsoleHandler.WriteCharAt(Tile.Symbol, Tile.Position);
                }
            }
            
            ConsoleHandler.WriteCharAt(instance.Player.Symbol, instance.Player.CurrentPlayerPosition, ConsoleColor.Gray);
            ConsoleHandler.WriteStringAt($"Number of steps: {instance.Player.numberOfMoves.ToString()}", new Point(18, 0));
            PrintInventory(instance);
        }

        public void RenderMap(GamePlayManager instance)
        {
            Point currentPlayerPosition = instance.Player.CurrentPlayerPosition;

            ConsoleHandler.WriteStringAt(instance.Player.numberOfMoves.ToString(), new Point(18, 17));
            ExploreTilesAroundPlayer(instance, currentPlayerPosition);
            ConsoleHandler.WriteCharAt(instance.Player.Symbol, currentPlayerPosition, ConsoleColor.Gray);
            PrintInventory(instance);  
        }

        private void ExploreTilesAroundPlayer(GamePlayManager instance, Point currentPlayerPosition)
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

        private void PrintInventory(GamePlayManager instance)
        {
            var point = new Point(20, 0);
            ConsoleHandler.WriteStringAt("Inventory: ", point);
            foreach (var key in instance.Player.playerInventory)
            {
                point.row++;
                ConsoleHandler.WriteStringAt(new string(' ', Console.WindowWidth), point);
                ConsoleHandler.WriteStringAt(key.Name, point);
            }
            point.row++;
            ConsoleHandler.WriteStringAt(new string(' ', Console.WindowWidth), point);
        }
    }
}