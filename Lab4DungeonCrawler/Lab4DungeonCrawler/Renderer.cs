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
                ConsoleHandler.WriteAt(Tile.Symbol, Tile.Position);
            }
            
            ConsoleHandler.WriteAt(gamePlayManager.GetPlayer().Symbol, gamePlayManager.GetPlayer().CurrentPlayerPosition);

        }

        public static void RenderMap(GamePlayManager gameState)
        {
          ConsoleHandler.WriteAt(gameState.GetPlayer().Symbol, gameState.GetPlayer().CurrentPlayerPosition);

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