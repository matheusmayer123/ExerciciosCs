namespace Exercicio6L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precoEtiqueta, precoFinal;
            char opcaoPagamento;

            Console.WriteLine("Informe o preço normal de etiqueta do produto:");
            precoEtiqueta = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a opção de pagamento (a - à vista em dinheiro ou cheque; b - à vista no cartão de crédito; c - em duas vezes sem juros; d - em duas vezes com juros):");
            opcaoPagamento = char.Parse(Console.ReadLine());

            switch (opcaoPagamento)
            {
                case 'a':
                    precoFinal = precoEtiqueta * 0.9;
                    Console.WriteLine("O valor final a ser pago é: R$" + precoFinal);
                    break;

                case 'b':
                    precoFinal = precoEtiqueta * 0.85;
                    Console.WriteLine("O valor final a ser pago é: R$" + precoFinal);
                    break;

                case 'c':
                    precoFinal = precoEtiqueta;
                    Console.WriteLine("O valor final a ser pago é: R$" + precoFinal + " em duas vezes sem juros.");
                    break;

                case 'd':
                    precoFinal = precoEtiqueta * 1.1;
                    Console.WriteLine("O valor final a ser pago é: R$" + precoFinal + " em duas vezes com juros.");
                    break;

                default:
                    Console.WriteLine("Opção de pagamento inválida!");
                    break;
            }
        }
    }
}