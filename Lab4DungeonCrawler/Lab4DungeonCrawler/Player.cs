using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Player
    {
        private char symbol = '@';
        public int numberOfMoves = 0;

        public Player()
        {
            PlayerInventory inventory = new PlayerInventory();
            CurrentPlayerPosition = new Point(1, 1);
        }

        public void MovePlayer(Point point, List<TileType> gameObjects)
        {
            var targetPosition = new Point(CurrentPlayerPosition.column + point.column, CurrentPlayerPosition.row + point.row);

            foreach (var Tile in gameObjects)
            {
                if(Tile.Position.Equals(targetPosition) && Tile is WallTile)
                {
                    return;
                }
            }
            PreviousPlayerPosition = CurrentPlayerPosition;
            CurrentPlayerPosition = targetPosition;
        }

        public TileType GetTileType(List<TileType> gameObjects, Point point)
        {
            foreach (var Tile in gameObjects)
            {
                if (Tile.Position.Equals(point))
                {
                    return Tile;
                }

            }
            return null;
        }

        public char Symbol { get { return symbol; } private set { } }

        public Point CurrentPlayerPosition { get; set; }

        public Point PreviousPlayerPosition { get; set; }
       

       
    }
}



   

