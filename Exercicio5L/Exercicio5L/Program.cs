namespace Exercicio5L
{
    //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é
    //menor que C.
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, soma;

            Console.WriteLine("Insira o valor do primeiro número: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o valor do segundo número: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o valor do terceiro número: ");
            num3 = Convert.ToSingle(Console.ReadLine());

            soma = num1 + num2;

            if (soma < num3)
            {
                Console.WriteLine("A + B é menor que C" + soma);

            }

        }
    }
}