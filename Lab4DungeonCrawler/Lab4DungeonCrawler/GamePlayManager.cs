using System.Collections.Generic;

namespace Lab4DungeonCrawler
{
    public class GamePlayManager
    {
        public Player Player;
        public List<GameObject> GameObjects;
        public Renderer Renderer { get; set; }

        public GameObject GetTileAtPoint(Point point)
        {
            var returnObject = GameObjects.Find(gameObject => gameObject.Position.Equals(point));
            return returnObject;
        }
    }
}