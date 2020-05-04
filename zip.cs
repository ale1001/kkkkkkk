using System;

namespace zip
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;
            Console.WriteLine("Informe o primeiro número:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número;");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 + n2;

            Console.WriteLine("O resultado é: " + resultado);
            Console.ReadKey(); ;

        }
    }
}
