using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummerPractice4119
{
    internal class Dot
    {
        private int x;
        private int y;
        public Dot(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void Move(int dx, int dy)
        {
            x += dx;
            y += dy;
        }

        public int GetX()
        {
            return x;
        }

        public void SetX(int _x)
        {
            x = _x;
        }

        public int GetY()
        {
            return y;
        }

        public void SetY(int _y)
        {
            y = _y;
        }
    }
}
