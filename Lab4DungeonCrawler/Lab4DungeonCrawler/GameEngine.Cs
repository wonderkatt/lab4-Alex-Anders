using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class GameEngine
    {
        private GamePlayManager GamePlayManager;
        public GameEngine(GamePlayManager gamePlayManager)
        {
            GamePlayManager = gamePlayManager;
        }

        public void Update() 
        {
            var direction = InputManager.GetInput();
            var canWalk = CheckForCollision(direction);
            if(canWalk)
            {
                GamePlayManager.Player.MovePlayer(direction, GamePlayManager); 
            }
            CheckForInteraction();
            GamePlayManager.Renderer.RenderMap(GamePlayManager);
            CheckWinCondition();
           
            
        }

        public bool CheckForCollision(Point point)
        {
            var targetPosition = new Point(GamePlayManager.Player.CurrentPlayerPosition.row + point.row, GamePlayManager.Player.CurrentPlayerPosition.column + point.column);
            var targetTile = GamePlayManager.GetTileAtPoint(targetPosition, GamePlayManager.GameObjects);
            if (targetTile is WallTile)
            {
                return false;
            }
            if (targetTile is Door && !GamePlayManager.Player.CheckForKey(targetTile.Color)) 
            {
                return false;
            }
            return true;
        }

        public void CheckForInteraction()
        {
            var tempTile = GamePlayManager.GetTileAtPoint(GamePlayManager.Player.CurrentPlayerPosition, GamePlayManager.GameObjects);
            if (tempTile is IInteractable interactable)
            {
                interactable.Interact(GamePlayManager);
            }
        }

        private void CheckWinCondition()
        {
            if (GamePlayManager.GetTileAtPoint(GamePlayManager.Player.CurrentPlayerPosition, GamePlayManager.GameObjects) is ExitTile)
            {
                Program.currentState = States.EndState;
            }
        }
    }
}
