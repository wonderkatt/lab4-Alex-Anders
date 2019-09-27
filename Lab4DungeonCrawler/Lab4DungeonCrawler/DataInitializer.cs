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
        private TileMap tileMap;
        private PlayerController playerController;
        private ConsoleHandler consoleHandler;
        private InputManager inputManager;
        private Renderer renderer;

        public DataInitializer()
        {
            player = new Player();
            tileMap = new TileMap();
            playerController = new PlayerController();
            consoleHandler = new ConsoleHandler();
            inputManager = new InputManager();
            renderer = new Renderer();
            
           
        }

       public Player GetPlayer()
        {
            return player;
        }

        public PlayerController GetPlayerController()
        {
            return playerController;
        }
        
        public TileMap GetMap()
        {
            return tileMap;
        }
        
    }
}
