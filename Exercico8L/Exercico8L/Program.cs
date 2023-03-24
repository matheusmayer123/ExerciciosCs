namespace Exercico8L
{
    internal class Program
    //8.Escreva um programa que receba dois números inteiros e que disponibilize as opções
    //abaixo e imprima o resultado da operação:
    //• A - retornar o soma de dois números;
    //• S - retornar a subtração de dois números;
    //• M - retornar a multiplicação de dois números;
    //• Q - retornar o quociente inteiro de uma divisão;
    //• E - retornar mensagem de erro(opção inválida).
    {
        static void Main(string[] args)
        {
            int num1, num2, opcao;

            Console.WriteLine("Insira o primeiro numero (inteiro): ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero (inteiro): ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha 1 - retornar o soma de dois números");
            Console.WriteLine("Escolha 2 - retornar a subtração de dois números");
            Console.WriteLine("Escolha 3 - retornar a multiplicação de dois números");
            Console.WriteLine("Escolha 4 - retornar o quociente inteiro de uma divisão");
            opcao = int.Parse(Console.ReadLine());




            switch (opcao) 
            {
                case 1:
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"{num1} X {num2} = {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }


        }
    }
}