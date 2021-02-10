using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1, y1 = 3;
            char simbol = '*';

            Drowi(x1, y1, simbol);
            int x2 = 5, y2 = 5;
            char sim = '&';
            Drowi(x2, y2, sim);
            Console.ReadLine();
        }
        static void Drowi(int x,int y, char s)
        {
            Console.SetCursorPosition(x, y);

            Console.Write(s);
        }
    }
}
