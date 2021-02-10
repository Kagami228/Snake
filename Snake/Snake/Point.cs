using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x, y;
        public char s;
        
        public Point(){}
        public Point(int xx,int yy, char ss) {
            x = xx;y = yy;  s = ss;
        }
        public void Drowi()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
    }
}
