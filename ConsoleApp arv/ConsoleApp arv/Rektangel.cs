using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_arv
{
    class Rektangel: Shape
    {
        public Rektangel(int width, int height) : base(width, height)
        {

        }

        public int Area()
        {
            return (width * height);
        }

        public int Omkrets()
        {
            return (width * 2) + (height * 2);
        }
    }
}
