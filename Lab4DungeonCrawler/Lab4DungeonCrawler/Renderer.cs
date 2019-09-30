using System;
namespace Lab4DungeonCrawler
{
    internal class Renderer
    {
        


        public Renderer()
        {
            
        }

         public static void PrintOutMap(TileType[,] map, StateMachine stateMachine)
        {
            Console.Clear();
            for (int column = 0; column < map.GetLength(0); column++)
            {
                for (int row = 0; row < map.GetLength(1); row++)
                {
                    Console.Write(map[column, row].TileGraphic);
                }
                Console.WriteLine();
            }

            PrintPlayerStartingPosition(stateMachine);
        }

        private static void PrintPlayerStartingPosition(StateMachine stateMachine)
        {
            ConsoleHandler.WriteAt(stateMachine.GetPlayer().Symbol, Player.CurrentPlayerPosition);
        }

        public static void RenderMap(StateMachine gameState)
        {
            ConsoleHandler.WriteAt(gameState.GetPlayer().Symbol, gameState.GetCurrentPlayerPosition());
            ConsoleHandler.WriteAt(TileMap.GetTileMap()[Player.PreviousPlayerPosition.column, Player.PreviousPlayerPosition.row].TileGraphic, Player.PreviousPlayerPosition);
        }
    }
}