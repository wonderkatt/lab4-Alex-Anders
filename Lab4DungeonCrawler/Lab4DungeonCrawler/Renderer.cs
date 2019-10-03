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

        public static void RenderMap(GamePlayManager gameState)
        {
          ConsoleHandler.WriteAt(gameState.GetPlayer().Symbol, gameState.GetPlayer().CurrentPlayerPosition);
            Point point;
            for (int i = gameState.GetPlayer().CurrentPlayerPosition.column-1; i < gameState.GetPlayer().CurrentPlayerPosition.column+2; i++)
            {
                for (int j = gameState.GetPlayer().CurrentPlayerPosition.row - 1; j < gameState.GetPlayer().CurrentPlayerPosition.row + 2; j++)
                {
                    point = new Point(i, j);
                    foreach (var Tile in gameState.GetGameObjects())
                    {
                        if (Tile.Position.Equals(point) && Tile.IsExplored == false)
                        {
                            Tile.IsExplored = true;
                            ConsoleHandler.WriteAt(Tile.Symbol, Tile.Position);
                        }
                    }

                }
            }

            foreach (var Tile in gameState.GetGameObjects())
            {
                if(Tile.Position.Equals(gameState.GetPlayer().PreviousPlayerPosition))
                {
                    ConsoleHandler.WriteAt(Tile.Symbol, Tile.Position);
                }
            }
        }

       
    }
}