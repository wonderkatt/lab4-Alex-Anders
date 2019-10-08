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
            var gameEngine = new GameEngine();

            while(true)
            {
                switch (currentState)
                {
                    case States.StartState:
                        var player = new Player();
                        var interActableObjectCreator = new InteractableObjectsCreator();
                        var mapCreator = new MapCreator(interActableObjectCreator);
                        gamePlayManager.Player = player;
                        gamePlayManager.GameObjects =  mapCreator.CreateMap();
                        Renderer.PrintOutMap(gamePlayManager);
                        
                        Instructions.PrintInstructions();
                        currentState = States.GamePlayState;
                        
                        break;
                    case States.GamePlayState:
                        var instance = gamePlayManager.GetGameState();
                        gameEngine.Update(instance);
                        // Om målet nås, kör endstate
                        break;
                    case States.EndState:
                        Console.Clear();
                        Console.WriteLine("Spelet är slut!");
                        Console.ReadKey(true);
                        //visa game over screen, välj starta om eller stänga av
                        break;
                    
                }
            }
        }     
    }
}

