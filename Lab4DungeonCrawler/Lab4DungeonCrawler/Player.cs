using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Player
    {
        public int numberOfMoves = 0;

        public Player()
        {
            CurrentPlayerPosition = new Point(1, 1);
        }

        public void MovePlayer(Point point, List<TileType> gameObjects)
        {
            var targetPosition = new Point(CurrentPlayerPosition.row + point.row, CurrentPlayerPosition.column + point.column);

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

        public char Symbol { get { return '@'; } }

        public Point CurrentPlayerPosition { get; set; }

        public Point PreviousPlayerPosition { get; set; }
       

       
    }
}



   

