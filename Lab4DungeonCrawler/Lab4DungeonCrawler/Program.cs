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

            while(true)
            {
                switch (currentState)
                {
                    case States.StartState:
                        var player = new Player();
                        var interActableObjectCreator = new InteractableObjectsCreator();
                        var mapCreator = new MapCreator(interActableObjectCreator);
                        
                        gamePlayManager.SetPlayer(player);
                        gamePlayManager.SetGameObjects(mapCreator.CreateMap());
                        Renderer.PrintOutMap(gamePlayManager);
                        player.PrintNumberOfMoves();
                        player.PlayerInventory.PrintInventory();
                        Instructions.PrintInstructions();
                        currentState = States.GamePlayState;
                        
                        break;
                    case States.GamePlayState:
                       
                        gamePlayManager.Update();
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

            //Kvar att göra: isOpen variabel till dörr? player inventory, interactable (door-key, door-player, key-player, monster-player)

            //skapa statemachin
            // starta StartState, skapar data spara i manager, kör igång nästa state

            // public static GameplayManager Instance, referens till det uppdaterade statet

            //gameplaymanager.GetData()




         //   var dataInitializer = new DataInitializer(); 
            
            
            
            
            //initializera map i datainitializer
            //skriv ut map i renderer

            //klass för skapa karta, innehåller data
            //

      //  while (true)
      //  {
      //      gamePlayManager.Update();
      //      //ta in input och updatera gamestate
      //      //rendera nuvarande gamestate
      //    
      //
      //     //statemachine.currentstate.update()
      //     //{
      //     //    
      //     //    directinon = inputmanager.GetDirection from input()
      //     //    player.move(directinon)
      //     //    player.interact(Player.currentposition)
      //     //    gameState = CreateGameState()
      //     //    renderer.render(gameState);
      //  }
        }     
    }
}

