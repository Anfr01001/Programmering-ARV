using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp_arv
{
    class Program
    {
        static void Main(string[] args)
        {

            string form;
            int Höjd, djup, radie;
            IShape shape;



            Console.WriteLine("Skriv in rektangel eller triangel eller till och med Cirkel");
            form = Console.ReadLine();

            if (form == "Cirkel")
            {
                Console.WriteLine("Skriv in Radien på din cirkel");
                radie = int.Parse(Console.ReadLine()); 

                shape = new Cirkel(radie);

                Console.WriteLine("Din area är: " + shape.Area());
                Console.WriteLine("Din Omkrets är: " + shape.Omkrets());
            }
            else
            {
                Console.WriteLine("Skriv in höjd");
                Höjd = int.Parse(Console.ReadLine());

                Console.WriteLine("Skriv in djup");
                djup = int.Parse(Console.ReadLine());

                if (form == "Rektangel")
                {
                    shape = new Rektangel(Höjd, djup);
                }
                else //if (form == "Triangel")
                {
                    shape = new Triangel(djup, Höjd);
                }
                Console.WriteLine("Din area är: " + shape.Area());
                Console.WriteLine("Din Omkrets är: " + shape.Omkrets());
            }


            Console.ReadLine();
        }
    }
}
