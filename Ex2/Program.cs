using System;
using System.Collections.Generic;
namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira as horas: ");
            converter(UInt32.Parse(Console.ReadLine()));
            Console.Read();
            static void converter(uint horas)
            {
                List<uint> lista = new List<uint>();
                if (horas >= 720)
                    lista.Add(horas / 720);
                else lista.Add(0);
                if (horas >= 168)
                    lista.Add(horas / 168);
                else lista.Add(0);
                lista.Add(horas * 60);
                lista.Add(horas * 60 * 60);
                lista.Add(horas * 60 * 60 * 1000);

                string[] unidade = {"MESES" ,"SEMANAS","MINUTOS","SEGUNDOS","MILISEGUNDOS"};

                int counter = 0;
                foreach (uint elemento in lista)
                {
                    Console.WriteLine($"{unidade[counter]} : {elemento}");
                    counter++;
                }
            }
        }
    }
}
