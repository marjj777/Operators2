using System;

namespace Operators2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle ?");
            var radius = double.Parse(Console.ReadLine());

            AreaOfCircle(radius);
        }
        public static double AreaOfCircle(double radius)
        {
            radius = (Math.PI * radius * radius);
            Console.WriteLine($"This is your AreaofCirle {radius}");
            return radius;
            
        }
    }
}
