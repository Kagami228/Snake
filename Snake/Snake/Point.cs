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
        public Point(int x,int y, char s) {
            this.x = x;  this.y = y;  this.s = s;
        }


        public void Move(int offset, Direction dir){
            if (dir == Direction.RIGHT){
                x = x + offset;
            }else if(dir== Direction.LEFT){
                x = x - offset;
            }else if (dir == Direction.UP){
                y = y - offset;
            }else if (dir == Direction.DOWN){
                y = y + offset;
            }
        }

        internal void Clear(){
            s = ' ';
            Drowi();
        }

        public void Drowi(){
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        public bool IsHit(Point p){
            return p.x == this.x && p.y == this.y;
        }
        public override string ToString()
        {
            return x + ", " + y + ", " + s;
        }
    }
}
