using System;

namespace Med_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(crossBots(Int32.Parse(Console.ReadLine())));

            static string crossBots(int numero)
            {
                if (numero % 15 == 0)
                    return "CrossBots";
                else if (numero % 5 == 0)
                    return "Bots";
                else if (numero % 3 == 0)
                    return "Cross";
                else
                    return numero.ToString();
            }
        }
    }
}
