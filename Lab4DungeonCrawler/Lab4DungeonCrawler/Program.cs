using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            //skapa data här och skicka till gamestate
            var dataInitializer = new DataInitializer(); // byt till gamestate

            
            
         
            while(true)
            {

                //ta in input och updatera gamestate
                //rendera nuvarande gamestate
                ConsoleHandler.PrintOutMap(dataInitializer.GetPlayer());

                statemachine.currentstate.update()
                {
                    directinon = inputmanager.GetDirection from input()
                    player.move(directinon)
                    player.interact(Player.currentposition)
                    gameState = CreateGameState()
                    renderer.render(gameState);
                }
                

            }
            
            Console.ReadKey();
        }
    }
}
