using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_arv
{
    class Triangel: IShape
    {
        int width, height;
        public Triangel(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Area()
        {
            return (width * height) / 2;
        }

        public int Omkrets()
        {
            int hypotenusa = (int)Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            return (width + height + hypotenusa);
        }
    }
}
