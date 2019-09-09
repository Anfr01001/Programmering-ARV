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
            int Höjd, djup;
            Triangel triangel;
            Rektangel rektangel;



            Console.WriteLine("Skriv in rektangel eller triangel");
            form = Console.ReadLine();

            Console.WriteLine("Skriv in höjd");
            Höjd = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in djup");
            djup = int.Parse(Console.ReadLine());

            if (form == "Rektangel")
            {
                rektangel = new Rektangel(Höjd, djup);
                Console.WriteLine("Din rekrangels area är: " + rektangel.Area());
                Console.WriteLine("Din rekrangels omkrets är: " + rektangel.Omkrets());
            }
            else if (form == "Triangel")
            {
                triangel = new Triangel(djup, Höjd);
                Console.WriteLine("Din Triangel area är: " + triangel.Area());
                Console.WriteLine("Din rektangel Omkrets är: " + triangel.Omkrets());
            }

            Console.ReadLine();
        }
    }
}
