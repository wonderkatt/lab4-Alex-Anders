using System.Collections.Generic;

namespace Lab4DungeonCrawler
{
    public class GamePlayManager
    {
        public Player Player;
        public List<GameObject> GameObjects;
        public Renderer Renderer { get; set; }

        // public GamePlayManager GetGameState()
        // {
        //     Instance = this;
        //     return Instance;
        // }

        public GameObject GetTileAtPoint(Point point, List<GameObject> gameObjects)
        {
            var returnObject = gameObjects.Find(gameObject => gameObject.Position.Equals(point));
            return returnObject;
        }
    }
}