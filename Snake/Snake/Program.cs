using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,8,'s');
            Point p2 = new Point();
            p2.x = 4;p2.y = 5;p2.s = '$';
            p1.Drowi();
            p2.Drowi();

            LineHorizontal Hl = new LineHorizontal(0,50,0,'-');
            VerticalLine Vl = new VerticalLine(1, 50, 0, '!');
            Hl.Drowi();
            Vl.Drowi(); 
            Console.ReadLine();
        }
    }
}
