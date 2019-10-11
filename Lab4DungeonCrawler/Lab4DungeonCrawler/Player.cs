using System.Collections.Generic;

namespace Lab4DungeonCrawler
{
    public class Player
    {
        public int numberOfMoves = 0;
        public List<Key> playerInventory = new List<Key>();
        public Player()
        {
            Symbol = '@';
            CurrentPlayerPosition = new Point(1, 1);
        }

        public void MovePlayer(Point point)
        {
            var targetPlayerPosition = new Point(CurrentPlayerPosition.row + point.row, CurrentPlayerPosition.column + point.column);
            numberOfMoves++;
            PreviousPlayerPosition = CurrentPlayerPosition;
            CurrentPlayerPosition = targetPlayerPosition;
        }

        public bool CheckForKey(System.ConsoleColor color)
        {
            foreach (var key in playerInventory)
            {
               if (color == key.Color)
                {
                    return true;
                }
            }
            return false;
        }
        public char Symbol { get; set; }
        public Point CurrentPlayerPosition { get; set; }
        public Point PreviousPlayerPosition { get; set; }
    }
}



   

