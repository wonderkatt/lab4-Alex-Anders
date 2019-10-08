using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public static class GameObjectHandler
    {
        public static GameObject GetTileAtPoint(Point point, List<GameObject> gameObjects)
        {
           
            var returnObject = gameObjects.Find(gameObject => gameObject.Position.Equals(point));
            return returnObject;
        }
       
        
    }
}
