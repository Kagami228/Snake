﻿using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,1,'s');
            p1.Drowi();
            Point p2 = new Point();
            p2.x = 4;p2.y = 5;p2.s = '$';
            p2.Drowi();
            Console.ReadLine();
        }
    }
}
