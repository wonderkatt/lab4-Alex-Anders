﻿namespace Lab4DungeonCrawler
{
    public class RedKey : Key
    {
        public RedKey(Point point) : base(point)
        {
            Name = "Red key";
            NumberOfUses = 1;
            Color = System.ConsoleColor.Red;
            
        }
    }
}