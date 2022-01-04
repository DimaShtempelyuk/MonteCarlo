using System;

namespace MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random nc;
            int xPoint;
            double xFloat;
            int yPoint;
            double yFloat;
            double FunY;
            double OutlineRatio = 0;
            double InlineRatio = 0;
            int pocOpak;
            for (pocOpak = 0; pocOpak < 10000; pocOpak++)
            {
                nc = new Random();
                xPoint = nc.Next(1, 3);
                xFloat = nc.NextDouble();
                yPoint = nc.Next(2, 9);
                yFloat = nc.NextDouble();
                FunY = Math.Pow(2, xPoint + xFloat);
                if (yPoint + yFloat > FunY)
                {
                    OutlineRatio++;
                }
                else if (yPoint + yFloat < FunY)
                {
                    InlineRatio++;
                }
                else if (yPoint + yFloat == FunY)
                {
                    InlineRatio++;
                }
            }
            double GlobalRatio = OutlineRatio / InlineRatio;
            double SpaceOnInline = 16.0 / pocOpak * InlineRatio * GlobalRatio ;
            Console.WriteLine(SpaceOnInline);
            Console.WriteLine("Prazdna cast: " + OutlineRatio);
            Console.WriteLine("Plna cast: " + InlineRatio);
            Console.ReadLine();
        }
    }
}