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
            
            var dataInitializer = new DataInitializer(); 
            
            var stateMachine = new StateMachine(dataInitializer);
            Renderer.PrintOutMap(TileMap.GetTileMap(), stateMachine);
            
            //initializera map i datainitializer
            //skriv ut map i renderer



            while (true)
            {
                stateMachine.Update();
                //ta in input och updatera gamestate
                //rendera nuvarande gamestate
              

               //statemachine.currentstate.update()
               //{
               //    
               //    directinon = inputmanager.GetDirection from input()
               //    player.move(directinon)
               //    player.interact(Player.currentposition)
               //    gameState = CreateGameState()
               //    renderer.render(gameState);
            }
        }     
    }
}

