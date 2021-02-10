using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;
        public VerticalLine(int yUp, int yDown, int x, char s)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, s);
                pList.Add(p);
            }
        }
        public void Drowi()
        {
            foreach (Point p_i in pList)
            {
                p_i.Drowi();
            }
        }
    }
}
