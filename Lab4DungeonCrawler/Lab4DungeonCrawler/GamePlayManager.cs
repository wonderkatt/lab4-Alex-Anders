using System.Collections.Generic;

namespace Lab4DungeonCrawler
{
    public class GamePlayManager
    {
        
        public Player Player;
        List<TileType> GameObjects;
     

        public GamePlayManager Instance { get; set; }


        public GamePlayManager()
        {    
        }

       public List<TileType> GetGameObjects()
        {
            return GameObjects;
        }

        public void SetGameObjects(List<TileType> gameObjects)
        {
            GameObjects = gameObjects;
        }

        public void SetPlayer(Player newPlayer)
        {
            Player = newPlayer;
        }

        public Player GetPlayer()
        {
            return Player;
        }

        public void GetGameState()
        {
            Instance = this; 
        }

        public void Update()
        {
            var direction = InputManager.GetInput();

            Player.MovePlayer(direction, GameObjects);

            GetGameState();
            GameObjectHandler.InteractWith(Instance);

            GetGameState();
           // SetPlayerPosition();
            
            Renderer.RenderMap(Instance);
            Player.PrintNumberOfMoves();
        }
    }
}