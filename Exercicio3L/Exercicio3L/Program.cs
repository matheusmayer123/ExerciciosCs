using System.Runtime.Intrinsics.X86;

namespace Exercicio3L
{
    //Faça um algoritmo em que efetue a leitura do nome e do sexo de uma pessoa,
    //apresentando como saída uma das seguintes mensagens: “Ilmo Sr.”, para o sexo informado
    //como masculino, ou a mensagem “Ilma Sra.”, para o sexo informado como feminino.
    //Apresente na sequência da mensagem impressa o nome da pessoa.
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, sexo;

            Console.WriteLine("Insira seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe seu gênero: M-Masculino F-Feminino");
            sexo = Console.ReadLine();

            if (sexo == null)
            {
                Console.WriteLine("Erro, gênero não selecionado.");
                
            }
            else if (sexo == "M")
            {
                Console.WriteLine("Ilmo Sr." + nome);
            }
            else
            {
                Console.WriteLine("Ilma Sra." + nome);
            }
        }
    }
}