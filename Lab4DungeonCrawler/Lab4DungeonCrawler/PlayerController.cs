using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class PlayerController
    {

        private TileType[,] map;
        private readonly Player player;

        public PlayerController(Player player)
        {
            this.map = TileMap.GetTileMap();
            this.player = player ?? throw new ArgumentNullException(nameof(player));
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
            
        }
        
    }
}
