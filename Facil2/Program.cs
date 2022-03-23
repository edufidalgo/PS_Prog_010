using System;

namespace Facil_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" Numero de 1's: {ContaUns(Console.ReadLine())}");

            static int ContaUns(string numero)
            {
                int value = Int32.Parse(numero);
                string binary = Convert.ToString(value, 2);
                
                int count = 0;
                foreach (char c in binary)
                    if (c == '1') count++;
                return count;
            }
        }
    }
}
