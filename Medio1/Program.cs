using System;

namespace Medio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            static double hipotenusa(int x1, int y1, int x2, int y2)
            {
                double answer = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                return answer;
            }
            Console.WriteLine("Insira, respectivamente, os valores de x1,y1,x2,y2");
            int x1 = Int32.Parse(Console.ReadLine());
            int y1 = Int32.Parse(Console.ReadLine());
            int x2 = Int32.Parse(Console.ReadLine());
            int y2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(hipotenusa(x1, y1, x2, y2).ToString());

        }
    }
}
