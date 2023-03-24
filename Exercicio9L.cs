using System.Net;

namespace Exercicio9L
{
    internal class Program
    {
        //Faça um algoritmo para ler a quantidade de horas/aula de dois professores e o valor por
        //hora recebido por cada um.Mostrar na tela qual dos professores tem salário total maior.
        static void Main(string[] args)
        {
            int valorAula = 80, HoraAula1, HoraAula2, valor1, valor2;
            string p1, p2;

            Console.WriteLine("Insira seu email comporativo: ");
            p1 = Console.ReadLine();
            Console.WriteLine("Insira a quantidade de aulas do mes: ");
            HoraAula1 = Convert.ToInt32(Console.ReadLine());
            valor1 = (HoraAula1 * 3) * valorAula;

            Console.WriteLine("Insira seu email comporativo: ");
            p2 = Console.ReadLine();
            Console.WriteLine("Insira a quantidade de aulas do mes: ");
            HoraAula2 = Convert.ToInt32(Console.ReadLine());
            valor2 = (HoraAula2 * 3) * valorAula;

            if (valor1 > valor2)
            {
                Console.WriteLine($"O professor {p1} recebe R${valor1}, mais que o professor {p2}");
            }
            if (valor2 > valor1)
            {
                Console.WriteLine($"O professor {p2} recebe R${valor2}, mais que o professor {p1}");
            }


        }
    }
}