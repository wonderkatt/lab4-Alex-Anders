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
            var gameEngine = new GameEngine(gamePlayManager);

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
                        break;

                    case States.EndState:
                        Console.Clear();
                        ConsoleHandler.WriteStringAt("***** Game Over! *****", new Point(3, 22));
                        ConsoleHandler.WriteStringAt($"You finnished the game with {gamePlayManager.Player.numberOfMoves} moves!", new Point(6, 14));
                        var input = Console.ReadKey(true);
                        if (input.Key == ConsoleKey.Escape)
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            }
        }     
    }
}

//High scores:
//Daniel: 282
//John: 408
//Sofia: 516
//Emil: 700

