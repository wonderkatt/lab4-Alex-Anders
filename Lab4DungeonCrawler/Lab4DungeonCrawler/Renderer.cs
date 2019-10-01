using System;
namespace Lab4DungeonCrawler
{
    internal class Renderer
    {
        


        public Renderer()
        {
            
        }

         public static void PrintOutMap(char[,] map)
        {
            Console.Clear();
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int column = 0; column < map.GetLength(1); column++)
                {
                    Console.Write(map[row, column]);
                }
                Console.WriteLine();
            }

            //PrintPlayerStartingPosition(stateMachine);
        }

        private static void PrintPlayerStartingPosition(GamePlayManager stateMachine)
        {
            ConsoleHandler.WriteAt(stateMachine.GetPlayer().Symbol, Player.CurrentPlayerPosition);
        }

        public static void RenderMap(GamePlayManager gameState)
        {
            ConsoleHandler.WriteAt(gameState.GetPlayer().Symbol, gameState.GetCurrentPlayerPosition());
            
            ConsoleHandler.WriteAt(TileMap.GetTileMap()[Player.PreviousPlayerPosition.column, Player.PreviousPlayerPosition.row].TileGraphic, Player.PreviousPlayerPosition);
        }
    }
}