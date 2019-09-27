using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_arv
{
    class Cirkel: IShape
    {
        int radie;
        public Cirkel(int radie)
        {
            this.radie = radie;

        }

        public int Area()
        {
            return (int)(Math.Pow(radie,2) * Math.PI);
        }

        public int Omkrets()
        {
            return (int)(radie * 2 * Math.PI);
        }
    }
}
