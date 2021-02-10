using System;
using System.IO;
namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
           // Console.SetWindowSize(40, 40);
            Point p1 = new Point(1,8,'s');
            Point p2 = new Point(4,7,'c');
            p1.Drowi();
            p2.Drowi();

            LineHorizontal Hl = new LineHorizontal(0,78,0,'-');
            VerticalLine Vl = new VerticalLine(1, 24, 0, '!');
            LineHorizontal Hl2 = new LineHorizontal(0, 78, 24, '-');
            VerticalLine Vl2 = new VerticalLine(1, 24, 78, '!');
            Hl.Drowi();
            Vl.Drowi();
            Vl2.Drowi();
            Hl2.Drowi();

            Point p = new Point(2, 2,'*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Drowi();
            snake.Move();
            Console.ReadLine();
        }
    }
}
