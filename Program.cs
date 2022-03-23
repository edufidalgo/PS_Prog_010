using System;


namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número o radiano a ser convertido e arredondado:");

            Console.WriteLine($"O Ângulo em graus é: {RadToDeg(double.Parse(Console.ReadLine()))}");
            Console.Read();
            static double RadToDeg(double rad)
            {
                double answer = Math.Round((double)(rad * 180/3.1415), 1);
                return answer;

            }
        }
    }
}
