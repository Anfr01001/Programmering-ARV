using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_arv
{
    abstract class Shape
    {
        protected int width, height;

        public Shape(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public abstract int Area();

        public abstract int Omkrets();

    }
}
