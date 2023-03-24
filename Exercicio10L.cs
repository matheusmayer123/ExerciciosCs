namespace Exercicio10L
{
    internal class Program
    {
        //Fazer um algoritmo em para ler o código de um determinado produto e mostrar a sua
        //classificação.Utilize a seguinte tabela como referência:
        static void Main(string[] args)
        {
            Console.Write("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Alimento não-perecível");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Alimento perecível");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Vestuário");
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    Console.WriteLine("Higiene Pessoal");
                    break;
                default:
                    Console.WriteLine("Código inválido");
                    break;
            }
        }
    }
}