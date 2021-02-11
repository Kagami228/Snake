using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class LineHorizontal: Figura
    {
        public LineHorizontal(int xLeft, int xRight, int y, char s)
        {
            pList = new List<Point>();
            for(int x=xLeft;x<=xRight; x++)
            {
                Point p = new Point(x, y, s);
                pList.Add(p);
            }
        }
        public override void Drowi()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach(Point f in pList)
            {
                f.Drowi();
            }//base.Drowi();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
