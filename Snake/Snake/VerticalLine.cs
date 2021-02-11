using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine: Figura
    {
        public VerticalLine(int yUp, int yDown, int x, char s)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, s);
                pList.Add(p);
            }
        }
        public override void Drowi()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach (Point f in pList)
            {
                f.Drowi();
            }//base.Drowi();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
