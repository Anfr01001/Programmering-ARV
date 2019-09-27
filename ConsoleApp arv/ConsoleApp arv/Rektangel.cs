using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_arv
{
    class Rektangel: IShape
    {
        int width, height;
        public Rektangel(int width, int height)
        {
            this.width = width;
            this.height = height;
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
