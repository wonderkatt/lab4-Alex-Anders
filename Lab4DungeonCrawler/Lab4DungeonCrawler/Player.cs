using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Player
    {
        public int numberOfMoves;

        public Player()
        {
            Symbol = '@';
            CurrentPlayerPosition = new Point(1, 1);
            PlayerInventory = new PlayerInventory();
            numberOfMoves = 0;
        }

        public void MovePlayer(Point point, List<TileType> gameObjects)
        {
            var targetPosition = new Point(CurrentPlayerPosition.row + point.row, CurrentPlayerPosition.column + point.column);
            var targetTile = GameObjectHandler.GetTileAtPoint(targetPosition, gameObjects);
            if (targetTile is WallTile || (targetTile.Door is Door && !PlayerInventory.IsKeyInInventory(targetTile.Door.Color)))
            {
                return;
            }
            numberOfMoves++;
            PreviousPlayerPosition = CurrentPlayerPosition;
            CurrentPlayerPosition = targetPosition;
        }

        public void PrintNumberOfMoves()
        {
            var point = new Point(18, 0);
            ConsoleHandler.WriteStringAt($"Number of steps: {numberOfMoves}", point);
        }

        public char Symbol { get; set; }

        public Point CurrentPlayerPosition { get; set; }

        public Point PreviousPlayerPosition { get; set; }

        public PlayerInventory PlayerInventory { get; set; }
       

       
    }
}



   

