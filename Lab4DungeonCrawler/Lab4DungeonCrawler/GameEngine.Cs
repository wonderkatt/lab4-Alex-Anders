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

        public void Update(GamePlayManager gamePlayManager) 
        {
            var direction = InputManager.GetInput();
            var canWalk = CheckForCollision(direction, gamePlayManager);
            if(canWalk)
            {
            gamePlayManager.Player.MovePlayer(direction, gamePlayManager); 
            }
            CheckForInteraction(gamePlayManager);

            gamePlayManager = gamePlayManager.GetGameState();
            gamePlayManager.Renderer.RenderMap(gamePlayManager);
            
        }

        public bool CheckForCollision(Point point, GamePlayManager gamePlayManager)
        {
            var targetPosition = new Point(gamePlayManager.Player.CurrentPlayerPosition.row + point.row, gamePlayManager.Player.CurrentPlayerPosition.column + point.column);
            var targetTile = gamePlayManager.GetTileAtPoint(targetPosition, gamePlayManager.GameObjects);
            if (targetTile is WallTile)
            {
                return false;
            }
            if (targetTile is Door && !gamePlayManager.Player.CheckForKey(targetTile)) 
            {
                return false;
            }
            return true;
        }
        public void CheckForInteraction(GamePlayManager gamePlayManager)
        {
            var tempTile = gamePlayManager.GetTileAtPoint(gamePlayManager.Player.CurrentPlayerPosition, gamePlayManager.GameObjects);

                if (tempTile is IInteractable interactable)
                {
                 interactable.Interact(gamePlayManager);
                }
        }

    }
}
