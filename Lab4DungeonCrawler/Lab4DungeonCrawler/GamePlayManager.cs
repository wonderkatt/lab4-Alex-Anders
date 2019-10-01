namespace Lab4DungeonCrawler
{
    internal class GamePlayManager
    {
        
        private Player player;
        private static Point currentPlayerPosition;
        private PlayerController playerController;
        private char[,] map;


        public GamePlayManager()
        {
           
          
            Player.CurrentPlayerPosition = new Point(1, 1);
        }

        public void SetMap(char[,] tileMap)
        {
            map = tileMap;
        }

        public void SetPlayer(Player newPlayer)
        {
            player = newPlayer;
        }

        public Player GetPlayer()
        {
            return player;
        }

        public Point GetCurrentPlayerPosition()
        {
            return currentPlayerPosition;
        }

        public static void SetPlayerPosition()
        {
            currentPlayerPosition = Player.CurrentPlayerPosition;
        }

        public GamePlayManager GetGameState()
        {
            return this;
        }

        public void Update()
        {
            //InputManager.GetInput();
            SetPlayerPosition();
            //player interaction here
            var gameState = GetGameState();
            Renderer.RenderMap(gameState);
            

        }
    }
}