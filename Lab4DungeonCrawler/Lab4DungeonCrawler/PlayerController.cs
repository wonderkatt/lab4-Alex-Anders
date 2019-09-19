using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class PlayerController
    {
        
        public readonly TileMap map;
        private readonly Player player;

        public PlayerController(TileMap map, Player player)
        {
            this.map = map;
            this.player = player;
        }

        public void MovePlayer()
        {
            var input = Console.ReadKey();

            switch(input.KeyChar)
            {
                case 'w':
                    Move(0, -1);
                    break;
                case 's':
                    Move(0, 1);
                    break;
                case 'a':
                    Move(-1, 0);
                    break;
                case 'd':
                    Move(1, 0);
                    break;
            }
        }
         
        private void Move(int row, int column)
        {
            map.map[player.currentPosition.column, player.currentPosition.row] = new FloorTile();
            player.currentPosition = new Point(player.currentPosition.row + row, player.currentPosition.column + column);
            map.map[player.currentPosition.column, player.currentPosition.row] = new PlayerTile();
        }
        
    }
}
