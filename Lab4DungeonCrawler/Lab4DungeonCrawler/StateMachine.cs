namespace Lab4DungeonCrawler
{
    internal class StateMachine
    {
        private readonly DataInitializer dataInitializer;
        private Player player;
        private static Point currentPlayerPosition;
        private PlayerController playerController;
        


        public StateMachine(DataInitializer dataInitializer)
        {
            this.dataInitializer = dataInitializer;
            playerController = dataInitializer.GetPlayerController();
            SetPlayer();
            Player.CurrentPlayerPosition = new Point(1, 1);
        }

        private void SetPlayer()
        {
            player = dataInitializer.GetPlayer();
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

        public StateMachine CreatGameState()
        {
            return this;
        }

        public void Update()
        {
            InputManager.GetInput();
            SetPlayerPosition();
            //player interaction here
            var gameState = CreatGameState();
            Renderer.RenderMap(gameState);
            

        }
    }
}