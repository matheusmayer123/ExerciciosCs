namespace Exercicio4L
{
    //Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um algoritmo
    //em que calcule peso ideal, utilizando as seguintes fórmulas:
    //• Para homens: (72.7* h) –58
    //• Para mulheres: (62.1* h) -44.7
    //• Onde h equivale à altura da pessoa.

    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, pesoM, pesoF;
            string sexo;

            Console.WriteLine("Insira o gênero desejado: M-Masculino F-Feminino");
            sexo = Console.ReadLine();

            Console.WriteLine("Insira a sua altura:(em centímetros){apenas números} ");
            altura = Convert.ToDouble(Console.ReadLine());

            pesoM = (72.7 * altura) / 58;  //formula aplicada
            pesoF = (62.1 * altura) / 44.7;  //formula aplicada

            if (sexo == "M") //se for homem
            {
                Console.WriteLine("O peso ideal para você é " + pesoM + "!");

            }
            else if (sexo == "F")  //se for mulher
            {
                Console.WriteLine("O peso ideal para você é " + pesoF + "!");

            }


        }
    }
}