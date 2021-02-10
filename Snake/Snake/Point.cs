using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x, y;
        public char s;
        
        public void Drowi()
        {
            Console.SetCursorPosition(x, y);

            Console.Write(s);
        }
    }
}
