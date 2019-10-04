using System.Collections.Generic;

namespace Lab4DungeonCrawler
{
    public class GamePlayManager
    {
        
        public Player Player; 
        List<TileType> GameObjects;
        List<Door> DoorObjects;
        List<Key> KeyObjects;
        List<Monster> MonsterObjects;

        public GamePlayManager Instance { get; set; }


        public GamePlayManager()
        {    
        }

       public List<TileType> GetGameObjects()
        {
            return GameObjects;
        }

        public void SetGameObjects(List<TileType> gameObjects)
        {
            GameObjects = gameObjects;
        }

        public List<Door> GetDoorObjects()
        {
            return DoorObjects;
        }
        public void SetDoorObjects(List<Door> doorObjects)
        {
            DoorObjects = doorObjects;
        }
        public List<Key> GetKeyObjects()
        {
            return KeyObjects;
        }
        public void SetKeyObjects(List<Key> keyObjects)
        {
            KeyObjects = keyObjects;
        }
        public List<Monster> GetMonsterObjects()
        {
            return MonsterObjects;
        }
        public void SetMonsterObjects(List<Monster> monsterObjects)
        {
            MonsterObjects = monsterObjects;
        }
        public void SetPlayer(Player newPlayer)
        {
            Player = newPlayer;
        }

        public Player GetPlayer()
        {
            return Player;
        }

        public void GetGameState()
        {
            Instance = this; 
        }

        public void Update()
        {
            var direction = InputManager.GetInput();

            Player.MovePlayer(direction, GameObjects);
            //player interaction here

            GetGameState();
           // SetPlayerPosition();
            
            Renderer.RenderMap(Instance);
        }
    }
}