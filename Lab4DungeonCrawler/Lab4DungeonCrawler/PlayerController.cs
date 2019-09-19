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
                    Move(-1, 0);
                    break;
                case 's':
                    Move(1, 0);
                    break;
                case 'a':
                    Move(0, -1);
                    break;
                case 'd':
                    Move(0, 1);
                    break;
            }
        }
         
        private void Move(int row, int column)
        {
            map.map[player.currentPosition.row, player.currentPosition.column] = new FloorTile();
            player.currentPosition = new Point(player.currentPosition.row + row, player.currentPosition.column + column);
            map.map[player.currentPosition.row, player.currentPosition.column] = new PlayerTile();
        }
        
    }
}
