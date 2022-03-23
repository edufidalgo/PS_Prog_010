using System;

namespace ExFacil1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o item a ser spammado, seguido do número do spam");
            string item = Console.ReadLine();
            int vezes = Int32.Parse(Console.ReadLine());

            int j = 1;
            foreach (string palavra in repeat(item, vezes))
            {
                Console.WriteLine($"{j}:{palavra}");
                j++;
            }
                                    

            static string[] repeat(string item, int vezes)
            {
                string[] lista = new string[vezes];
                for (int i = 0; i < vezes; i++)
                    lista[i] = item;
                return lista;
            }
        }
    }
}
