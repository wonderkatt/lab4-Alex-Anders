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

        public static void WriteCharAt(char s, Point point, ConsoleColor colour = ConsoleColor.White)
        {
            Console.SetCursorPosition(point.column,point.row);
            Console.ForegroundColor = colour;
            Console.Write(s);
            Console.ResetColor();
        }
        public static void WriteStringAt(string s, Point point)
        {
            Console.SetCursorPosition(point.column, point.row);
            Console.Write(s);
        }
       
    }


}
