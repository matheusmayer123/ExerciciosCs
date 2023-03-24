using System;

namespace Exercicio2L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Digite o valor do lado A: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C: ");
            c = double.Parse(Console.ReadLine());

            // Verifica se é um triângulo válido
            if (a <= 0 || b <= 0 || c <= 0 || a >= b + c || b >= a + c || c >= a + b)
            {
                Console.WriteLine("Triângulo inválido.");
            }
            else
            {
                a = Math.Pow(a, 2);
                b = Math.Pow(b, 2);
                c = Math.Pow(c, 2);

                // Verifica se é um triângulo equilátero
                if (a == b && b == c)
                {
                    Console.WriteLine("Triângulo equilátero.");
                }
                // Verifica se é um triângulo isósceles
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Triângulo isósceles.");
                }
                // Se não for equilátero nem isósceles, é escaleno
                else
                {
                    Console.WriteLine("Triângulo escaleno.");
                }
            }
        }
    }
}