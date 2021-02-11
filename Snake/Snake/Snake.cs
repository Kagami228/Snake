using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake: Figura
    {
        Direction dir;
        public Snake(Point tail,int length, Direction _direction){
            dir = _direction;
            pList = new List<Point>();
            for(int i = 0; i < length; i++){
                Point p = new Point(tail);
                p.Move(i, dir);
                pList.Add(p);
            }
        }

        internal void Move(){
            //throw new NotImplementedException();
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);
            tail.Clear();
            head.Drowi();
        }

        public Point GetNextPoint(){
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, dir);
            return nextPoint;
        }

        public void Snake_Move(ConsoleKey key){
            if (key== ConsoleKey.LeftArrow){
                dir = Direction.LEFT;
            }else if (key== ConsoleKey.RightArrow){
                dir = Direction.RIGHT;
            }else if (key == ConsoleKey.UpArrow){
                dir = Direction.UP;
            }else if (key == ConsoleKey.DownArrow){
                dir = Direction.DOWN;
            }
        }

        internal bool Eat(Point food){
            Point head = GetNextPoint();
            if (head.IsHit(food)){
                food.s = head.s;
                pList.Add(food);
                return true;
            }else{
                return false;
            }
        }
    }
}
