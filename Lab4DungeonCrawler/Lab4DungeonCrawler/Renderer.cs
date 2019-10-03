using System;
namespace Lab4DungeonCrawler
{
    internal class Renderer
    {

        public Renderer()
        {
            
        }

         public static void PrintOutMap(char[,] map, GamePlayManager gamePlayManager)
        {
            Console.Clear();
            for (int column = 0; column < map.GetLength(0); column++)
            {
                for (int row = 0; row < map.GetLength(1); row++)
                {
                    Console.Write(map[column, row]);
                }
                Console.WriteLine();
            }
            ConsoleHandler.WriteAt(gamePlayManager.GetPlayer().Symbol, gamePlayManager.GetPlayer().CurrentPlayerPosition);

        }

        public static void RenderMap(GamePlayManager gameState)
        {
          ConsoleHandler.WriteAt(gameState.GetPlayer().Symbol, gameState.GetPlayer().CurrentPlayerPosition);

            ConsoleHandler.WriteAt('-', gameState.GetPlayer().PreviousPlayerPosition);
        }
    }
}