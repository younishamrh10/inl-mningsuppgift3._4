using System;

namespace Inlämingsuppgift3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt är din låt i muniter?");
            int minuter = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt är din låt i sekunder?");
            int sekunder = int.Parse(Console.ReadLine());
            int totaltid = minuter * 60 + sekunder;

            if (totaltid <= 260 && totaltid >= 165)
            {
                Console.WriteLine("Din låt får spelas på radion!");
            }
            else
            {
                Console.WriteLine("Din låt får inte spelas på radion!");
            }
        }
    }
}