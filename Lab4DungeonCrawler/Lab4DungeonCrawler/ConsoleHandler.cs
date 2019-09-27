using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class ConsoleHandler
    {
        
        

        public ConsoleHandler()
        {
        }

        public static void WriteAt(string s, Point point)
        {
            Console.SetCursorPosition(point.column, point.row);
            Console.Write(s);
        }
        
       
    }


}
