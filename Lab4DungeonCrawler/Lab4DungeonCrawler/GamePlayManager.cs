using System.Collections.Generic;

namespace Lab4DungeonCrawler
{
    public class GamePlayManager
    {
        public Player Player;
        public List<GameObject> GameObjects;

        public GamePlayManager Instance { get; set; }

        public List<GameObject> GetGameObjects()
        {
            return GameObjects;
        }

        public void SetGameObjects(List<GameObject> gameObjects)
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

        public GamePlayManager GetGameState()
        {
            Instance = this;
            return Instance;
        }

        
    }
}