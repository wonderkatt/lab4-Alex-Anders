using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class GameEngine
    {
        public GameEngine()
        {
        }

        public void Update(GamePlayManager instance)
        {
            var direction = InputManager.GetInput();
            instance.Player.MovePlayer(direction, instance);
            CheckForInteraction(instance);

            instance = instance.GetGameState();
            Renderer.RenderMap(instance);
            
        }

        public void CheckForInteraction(GamePlayManager instance)
        {
            var tempTile = instance.GetTileAtPoint(instance.Player.CurrentPlayerPosition, instance.GameObjects);
            
            try
            {
                var interactable = (IInteractable)tempTile;
                if (interactable != null)
                {
                    interactable.Interact(instance);
                }
            }
            catch
            {

            }
         
           
        }

    }
}
