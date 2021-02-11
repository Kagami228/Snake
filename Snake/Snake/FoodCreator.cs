using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{

    class FoodCreator
    {
        int h, w;
        char s;
        Random random = new Random();
        public FoodCreator(int w,int  h,char s)
        {
            this.w = w;
            this.h = h;
            this.s = s;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, w - 2);
            int y = random.Next(2, h - 2);
            return new Point(x, y, s);
        }
    }
}