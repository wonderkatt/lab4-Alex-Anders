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
            ConsoleHandler.WriteStringAt(gamePlayManager.Player.numberOfMoves.ToString(), new Point(18, 0));
            PrintInventory(gamePlayManager);
        }

        public static void RenderMap(GamePlayManager currentGameState)
        {
            Point currentPlayerPosition = currentGameState.GetPlayer().CurrentPlayerPosition;
            Point point;
            GameObject tempTile;
            ConsoleHandler.WriteStringAt(currentGameState.Player.numberOfMoves.ToString(), new Point(18, 0));
            for (int row = currentPlayerPosition.row - 1; row < currentPlayerPosition.row + 2; row++)
            {
                for (int column = currentPlayerPosition.column - 1; column < currentPlayerPosition.column + 2; column++)
                {
                    point = new Point(row, column);
                    tempTile = currentGameState.GetTileAtPoint(point, currentGameState.GetGameObjects());
                    if(tempTile is Key)
                    {
                        ConsoleHandler.WriteCharAt(tempTile.Symbol, point, tempTile.Color);
                        tempTile.IsExplored = true;
                    }
                    else if(tempTile is Monster)
                    {
                        ConsoleHandler.WriteCharAt(tempTile.Symbol, point, tempTile.Color);
                        tempTile.IsExplored = true;
                    }
                    else if(tempTile is Door)
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
            ConsoleHandler.WriteCharAt(currentGameState.GetPlayer().Symbol, currentPlayerPosition, ConsoleColor.Gray);

            PrintInventory(currentGameState);
           
            
        }

        private static void PrintInventory(GamePlayManager currentGameState)
        {
            ConsoleHandler.WriteStringAt("Inventory: ", new Point(20, 0));
            for (int i = 0; i < 5; i++)
            {
                ConsoleHandler.WriteCharAt(' ', new Point(20, 11 + i));
            }

            for (int i = 0; i < currentGameState.Player.PlayerInventory.playerInventory.Count; i++)
            {
                ConsoleHandler.WriteCharAt(currentGameState.Player.PlayerInventory.playerInventory[i].Symbol, new Point(20, 11 + i), currentGameState.Player.PlayerInventory.playerInventory[i].Color);
            }
        }
    }
}