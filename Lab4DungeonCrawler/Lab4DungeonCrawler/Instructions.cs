using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DungeonCrawler
{
    class Instructions
    {
        public static void PrintInstructions()
        {
            var point = new Point(2, 60);
            ConsoleHandler.WriteStringAt(" __________________________", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|    *** FIND EXIT ***     |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|                          |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|Move @ with a,s,d and w,  |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|collect keys(k),          |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|move through doors(D),    |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|watch out for monsters(M),|", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|they give you extra steps,|", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|find exit(E) with as few, |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|steps as possible.        |", point);
            point.row++;
            ConsoleHandler.WriteStringAt("|__________________________|", point);
        }
    }
}
