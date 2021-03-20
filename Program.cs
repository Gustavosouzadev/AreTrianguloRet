using System;

namespace AreTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double Base;
            double Altura;
            const double Area = 2;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Calcule a área de um triângulo retângulo: ");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("---OBS: Digite o numero e Pressione \"ENTER\"----");
            Console.WriteLine("-----------------------------------------------");


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Base..: ");

            Console.ForegroundColor = ConsoleColor.White;
            Base = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Altura: ");
            
            Console.ForegroundColor = ConsoleColor.White;
            Altura = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            double resultado = (Base * Altura) / Area;

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Area..: ");
 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{resultado:N1}");

            Console.ResetColor();
        }
    }
}
