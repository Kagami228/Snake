using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x, y;
        public char s;
        
        public Point(Point p){
            x = p.x;
            y = p.y;
            s = p.s;
        }
        public Point()
        {

        }
        public Point(int xx,int yy, char ss) {
            x = xx;y = yy;  s = ss;
        }
        public void Move(int offset, Direction dir)
        {
            if (dir == Direction.Right){
                x = x + offset;
            }else if(dir== Direction.LEFT){
                x = x - offset;
            }else if (dir == Direction.UP){
                y = y - offset;
            }else if (dir == Direction.DOWN){
                y = y + offset;
            }
        }

        internal void Clear()
        {
            s = ' ';
            Drowi();
        }

        public void Drowi()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
    }
}
