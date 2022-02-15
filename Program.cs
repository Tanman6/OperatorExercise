using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            //if statement
            if (a == 17 && b == 4)
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");


            Console.WriteLine("What is the radius of your circle");
            var r = double.Parse(Console.ReadLine());
            var calculateArea = AreaOfCircle(r);

            Console.WriteLine($"The area of a circle with raidus of {r} is {calculateArea}");

        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
