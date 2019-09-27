using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class DataInitializer
    {
        private Player player;
        private TileMap map;
        private PlayerController playerController;
        private ConsoleHandler consoleHandler;

        public DataInitializer()
        {
             player = new Player();
             map = new TileMap();
             playerController = new PlayerController();
             consoleHandler = new ConsoleHandler(this);
             door1 = new Door(5, 5);
             door2 = new Door(5, 10);
             door3 = new Door(5, 15);
             door4 = new Door(5, 20);
             door5 = new Door(5, 25);

            map.InitiateMap();
        }

        public Player GetPlayer()
        {
            return player;
        }
    }
}
