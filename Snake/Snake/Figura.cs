using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figura
    {
        public List<Point> pList;
        public Figura()
        {
          
        }
        public void Drowi()
        {
            foreach (Point p_i in pList)
            {
                p_i.Drowi();
            }
        }
    }
}
