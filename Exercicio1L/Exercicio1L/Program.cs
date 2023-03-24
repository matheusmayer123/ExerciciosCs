using System;

//1.Elabore um algoritmo em que efetue a leitura de um valor que esteja entre a faixa de 1 a
//9. Após a leitura do valor fornecido pelo usuário, o programa deverá indicar uma de duas
//mensagens: “O valor está na faixa permitida”, caso o usuário forneça o valor nesta faixa,
//ou a mensagem “O valor está fora da faixa permitida”, caso o usuário forneça valores
//menores que 1 ou maiores que 9.

namespace Exercicio1L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num; //variavel definida como um numero inteiro

            Console.WriteLine("Insra o valor desejado: ");  //entrada do numero
            num = Convert.ToInt32(Console.ReadLine());  //leitura do numero, adicionando ele a variavel num e transformando ele em int

            if ((num < 1) && (num > 9)) //se o  numero digitado for menor que 1 e mais que 9 print
            {
                Console.WriteLine("O valor está fora da faixa permitida");
            }

            else  //se nao, print.
            {
                Console.WriteLine("O valor está na faixa permitida");
            }


        }
    }
}