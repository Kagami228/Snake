using System.Collections.Generic;

namespace Snake
{
    internal class Wall
    {
        List<Figura> walllist;
        public Wall(int w, int h)
        {
            walllist = new List<Figura>(); 
            LineHorizontal UpL = new LineHorizontal(0, w-2, 0, '+');
            VerticalLine LeftL = new VerticalLine(0, h-1, 0, '+');
            LineHorizontal DownL = new LineHorizontal(0, w-2, h-1, '+');
            VerticalLine RightL = new VerticalLine(0, h-1, w-2, '+');

            walllist.Add(UpL);
            walllist.Add(LeftL);
            walllist.Add(DownL);
            walllist.Add(RightL);
        }
        internal bool IsHit(Figura figure)
        {
            foreach(var wall in walllist)
            {
                if (wall.IsHit(figure)){
                    return true;
                }
            }
            return false;
        }
        public void Drowi()
        {
            foreach(var w in walllist)
            {
                w.Drowi();
            }
        }
    }
}