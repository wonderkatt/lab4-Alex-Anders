using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class Program
    {
        public static States currentState;

        public static void Main(string[] args)
        {
            Console.CursorVisible = false;
            var gamePlayManager = new GamePlayManager();
            var gameEngine = new GameEngine(gamePlayManager); //var gameEngine = new GameEngine(gamePlayManager);
            

            while (true)
            {
                switch (currentState)
                {
                    case States.StartState:
                        var player = new Player();
                        
                        var mapCreator = new MapCreator();
                        var renderer = new Renderer();
                        gamePlayManager.Renderer = renderer;
                        gamePlayManager.Player = player;
                        gamePlayManager.GameObjects =  mapCreator.CreateMap();
                        renderer.PrintOutMap(gamePlayManager);
                        
                        renderer.PrintInstructions();
                        currentState = States.GamePlayState;
                        
                        break;
                    case States.GamePlayState:
                       
                        gameEngine.Update();
                        //gameEngine.Update();
                        // Om målet nås, kör endstate
                        //get tile på player pos, om det är exit tile. sätt currentState = EndState
                        break;
                    case States.EndState:
                        Console.Clear();
                        Console.WriteLine("Game Over!");
                        Console.WriteLine($"You finnished the game with {gamePlayManager.Player.numberOfMoves} moves! ");
                        Console.ReadKey(true);
                        break;
                    
                }
            }
        }     
    }
}

