using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class Monster : IInteractable
    {
        public Monster()
        {

        }
        public Monster(int x, int y)
        {
            Position = new Point(x, y);
            Symbol = 'M';
        }

        public Point Position { get; set; }
        public char Symbol { get; set; }

        public List<Monster> CreateMonsters()
        {
            List<Monster> monsters = new List<Monster>
            {
                new Monster(13, 4),
                new Monster(6, 19),
                new Monster(15, 22),
                new Monster(5, 28),
                new Monster(4, 41)
            };

            return monsters;
        }
    }
}
