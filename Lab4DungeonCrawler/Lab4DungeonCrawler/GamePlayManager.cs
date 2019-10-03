using System.Collections.Generic;

namespace Lab4DungeonCrawler
{
    public class GamePlayManager
    {
        
        public Player Player;
        
        public char[,] Map;
        List<TileType> GameObjects;
        
        public GamePlayManager Instance { get; set; }


        public GamePlayManager()
        {    
        }

        public void SetMap(char[,] tileMap)
        {
            Map = tileMap;
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

       // public Point GetCurrentPlayerPosition()
       // {
       //     return CurrentPlayerPosition;
       // }
       //
       // public void SetPlayerPosition()
       // {
       //     CurrentPlayerPosition = Player.CurrentPlayerPosition;
       // }

        public void GetGameState()
        {
            Instance = this; 
        }

        public void Update()
        {
            var direction = InputManager.GetInput();

            Player.MovePlayer(direction, Map);
            GetGameState();
           // SetPlayerPosition();
            //player interaction here
            
            Renderer.RenderMap(Instance);
            

        }
    }
}