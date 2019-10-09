using System.Collections.Generic;

namespace Lab4DungeonCrawler
{
    public class Player
    {
        public int numberOfMoves;
        public List<Key> playerInventory = new List<Key>();
        public Player()
        {
            Symbol = '@';
            CurrentPlayerPosition = new Point(1, 1);
            numberOfMoves = 0;
        }

        public void MovePlayer(Point point, GamePlayManager instance)
        {
            var targetPosition = new Point(CurrentPlayerPosition.row + point.row, CurrentPlayerPosition.column + point.column);
            var targetTile = instance.GetTileAtPoint(targetPosition, instance.GameObjects);
           
            numberOfMoves++;
            CurrentPlayerPosition = targetPosition;
        }

        public bool CheckForKey(GameObject targetTile)
        {
            foreach (var key in playerInventory)
            {
               if (targetTile.Color == key.Color)
                {
                    return true;
                }
            }
            return false;
        }
        public char Symbol { get; set; }
        public Point CurrentPlayerPosition { get; set; }
    }
}



   

