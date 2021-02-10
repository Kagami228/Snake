using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class LineHorizontal
    {
        List<Point> pList;
        public LineHorizontal(int xLeft, int xRight, int y, char s)
        {
            pList = new List<Point>();
            for(int x=xLeft;x<=xRight; x++)
            {
                Point p = new Point(x, y, s);
                pList.Add(p);
            }
        }
        public void Drowi()
        {
            foreach(Point p_i in pList)
            {
                p_i.Drowi();            }
        }
    }
}
