using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    public class ConsoleHandler
    {
        public static void WriteCharAt(char s, Point point, ConsoleColor color)
        {
            Console.SetCursorPosition(point.column,point.row);
            Console.ForegroundColor = color;
            Console.Write(s);
            Console.ResetColor();
        }

        public static void WriteStringAt(string s, Point point, ConsoleColor color = ConsoleColor.White)
        {
            Console.SetCursorPosition(point.column, point.row);
            Console.ForegroundColor = color;
            Console.Write(s);
            Console.ResetColor();
        }
    }
}
