using System.Diagnostics.CodeAnalysis;

namespace Exercicio7L
{
    //Fazer um algoritmo em para ler o ano de nascimento de uma pessoa, calcular e mostrar
    //sua idade e, também, verificar e mostrar se ela já tem idade para votar(16 anos ou mais)
    //e para conseguir a Carteira de Habilitação(18 anos ou mais).

    internal class CalculaIdade
    {
        static void Main(string[] args)
        {
            DateTime DataAniversario = new DateTime();  //insere uma data nova, deixei aberto por será um input do usuario
            Console.WriteLine("Insira sua data de nascimento: (yyyy/mm/dd) ");  //input
            DataAniversario = Convert.ToDateTime(Console.ReadLine());  //leitura do input, colocando na variavel e transformando em data
            DateTime DataHoje = DateTime.Now;  //pegando a data atual do dia que for utilizado

            int DataAniversarioDia = DataAniversario.Day, DataAniversarioMes = DataAniversario.Month, DataAniversarioAno = DataAniversario.Year;  //separando dia/mes/ano do input
            int DataHojeDia = DataHoje.Day, DataHojeMes = DataHoje.Month, DataHojeAno = DataHoje.Year;  //separando dia/mes/ano atual

            int add = -1; //adidiona -1

            if (DataAniversarioMes < DataHojeMes) //se o mes de nascimento for menor que o mes de atual
            {
                add = 0; //adicione 0
            }
            else if (DataAniversarioMes == DataHojeMes) //se mes do nascimento for igual mes atual
            {
                if (DataAniversarioDia < DataHojeDia) //segunda verificação se a primeira for true 
                                                      //se dia do nascimento for menor que dia atual
                {                                               //apenas efetuando if dos dias se o mes for igual, para ser mais especifico
                    add = 0;  //nao adiciona nada pois ja fez aniversario
                }
                else
                {
                    add = -1; //menos um pois ainda nao fiz aniversario, sendo no dia seguinte
                }

            }
            else //se tudo aquilo for false, ou seja, se o mes nao for menor nem igual
            {
                add = -1; //retira 1 ano, pois ainda nao fez aniversario, sendo no mes seguinte
            }

            int idade = (DataHojeAno - DataAniversarioAno) + add; //idade é o ano de hoje menos o de nascimento, acrescentando o add para correção em questão
                                                                  //de mes e dias.
            Console.WriteLine($"A sua idade é {idade}");

            if (idade >= 16) //se idade for maior ou igual a 16 
            {
                Console.WriteLine("Você ja pode votar, pois tem " + idade + " anos ,portanto, já possui 16 ou mais!"); //print


                if (idade >= 18) //se alem de >= a 16 tambem for >= a 18
                {
                    Console.WriteLine("E além de poder votar, também pode tirar sua carteira e motorista"); //print
                }
            }
            else //se for false ou seja ter menos que 16 anos
            {
                Console.WriteLine("Você possui apenas " + idade + " anos ainda não pode votar, muito menos tirar a carteira de motorista :C"); //print
            }



        }
    }
}