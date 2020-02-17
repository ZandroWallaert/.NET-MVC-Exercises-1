using System;

namespace math_vkv_master
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("C: ");
            int c = Int32.Parse(Console.ReadLine());

            Console.WriteLine(a+"xÂ² + "+b+"x + "+c+" = 0");

            int d = (b*b)-(4*(a*c));

            Console.WriteLine("Discriminant: "+d);

            double x1 = (-b+Math.Sqrt(d))/(2*a);
            double x2 = (-b-Math.Sqrt(d))/(2*a);

            Console.WriteLine("X1: "+x1);
            Console.WriteLine("X2: "+x2);
        }
    }
}
