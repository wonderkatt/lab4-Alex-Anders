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

        public static void WriteAt(char s, Point point)
        {
            Console.SetCursorPosition(point.row,point.column);
            Console.Write(s);
        }
        
       
    }


}
