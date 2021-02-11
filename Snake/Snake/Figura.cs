using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figura
    {
        protected List<Point> pList;
        public Figura()
        {
          
        }
        public virtual void Drowi()
        {
            foreach (Point p_i in pList)
            {
                p_i.Drowi();
            }
        }

        internal bool IsHit(Figura figure)
        {
            foreach(var i in pList)
            {
                if (figure.IsHit(i))
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsHit(Point p)
        {
            foreach(var p_i in pList)
            {
                if (p_i.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
