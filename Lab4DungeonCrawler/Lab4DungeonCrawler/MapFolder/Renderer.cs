using System;
using System.Collections.Generic;

namespace Lab4DungeonCrawler
{
    public class Renderer
    {
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
            ConsoleHandler.WriteStringAt("|find exit(E) with as few  |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|steps as possible.        |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|__________________________|", point);
        }

        public void PrintOutMap(GamePlayManager gamePlayManager)
        {
            foreach (var Tile in gamePlayManager.GameObjects)
            {
                if (Tile.IsExplored == true)
                {
                    ConsoleHandler.WriteCharAt(Tile.Symbol, Tile.Position, Tile.Color);
                }
            }
            
            ConsoleHandler.WriteCharAt(gamePlayManager.Player.Symbol, gamePlayManager.Player.CurrentPlayerPosition, ConsoleColor.Gray);
            ConsoleHandler.WriteStringAt($"Number of steps: {gamePlayManager.Player.numberOfMoves.ToString()}", new Point(18, 0));
            PrintInventory(gamePlayManager);
        }

        public void RenderMap(GamePlayManager gamePlayManager)
        {
            Point currentPlayerPosition = gamePlayManager.Player.CurrentPlayerPosition;

            ExploreTilesAroundPlayer(gamePlayManager, currentPlayerPosition);
            ConsoleHandler.WriteCharAt(gamePlayManager.Player.Symbol, currentPlayerPosition, ConsoleColor.Gray);
            ConsoleHandler.WriteStringAt(gamePlayManager.Player.numberOfMoves.ToString(), new Point(18, 17));
            PrintInventory(gamePlayManager);
        }

        private void ExploreTilesAroundPlayer(GamePlayManager gamePlayManager, Point currentPlayerPosition)
        {
            Point point;
            GameObject tempTile;
            for (int row = currentPlayerPosition.row - 1; row < currentPlayerPosition.row + 2; row++)
            {
                for (int column = currentPlayerPosition.column - 1; column < currentPlayerPosition.column + 2; column++)
                {
                    point = new Point(row, column);
                    tempTile = gamePlayManager.GetTileAtPoint(point);
                    
                    ConsoleHandler.WriteCharAt(tempTile.Symbol, point, tempTile.Color);
                    tempTile.IsExplored = true;
                }
            }
        }

        private void PrintInventory(GamePlayManager gamePlayManager)
        {
            var point = new Point(20, 0);
            ConsoleHandler.WriteStringAt("Inventory: ", point);
            foreach (var key in gamePlayManager.Player.playerInventory)
            {
                point.row++;
                ConsoleHandler.WriteStringAt(new string(' ', Console.WindowWidth), point);
                ConsoleHandler.WriteStringAt(key.Name, point, key.Color);
            }
            point.row++;
            ConsoleHandler.WriteStringAt(new string(' ', Console.WindowWidth), point);
        }
    }
}