
using SegundaLista.cs;

namespace Lista2
{
    class Principal
    {
        static void Main(String[] args)

        {
            int opcao;
            do
            {
                Console.WriteLine();
                Console.WriteLine("==========================================================");
                Console.WriteLine("|(1)Calculo do estoque médio                              |");
                Console.WriteLine("|(2)Converter Dollar para Real                            |");
                Console.WriteLine("|(3)Comição de vendas                                     |");
                Console.WriteLine("|(4)Calculo dos valores                                   |");
                Console.WriteLine("|(5)Quantidade de combustivel gasto na viagem             |");
                Console.WriteLine("|(7)Conveter de fahrenheit para celsius                   |");
                Console.WriteLine("|(8)Calculo do volume de uma lata de óleo                 |");
                Console.WriteLine("|(9)Calculo da iadae de um pessoa em dias                 |");
                Console.WriteLine("|(10)Relacionamentos possiveis entre dois numeros inteiros|");
                Console.WriteLine("|(0)SAIR                                                  |");
                Console.WriteLine("==========================================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {


                    case 1:
                        Exercicios objexercicio1 = new Exercicios();//Instanciando um objeto da classe Exercicios.

                        objexercicio1.EstoqueMedio();/*Chamendo um método que pertence a Classe Exercicios()
                                                 atraves da intancia dessa classe*/

                        break;

                    case 2:


                        Exercicios objexercicios2 = new Exercicios();

                        objexercicios2.ConverterDollarReal();




                        break;

                    case 3:

                        Exercicios objexercicio3 = new Exercicios();
                        objexercicio3.CalculoComissão();
                        break;


                    case 4:
                        Exercicios objexercicio4 = new Exercicios();
                        objexercicio4.CalculoNumeros();
                        break;

                    case 5:

                        Exercicios objexercicio5 = new Exercicios();
                        objexercicio5.CalculoCombustivel();
                        break;

                    case 6:
                        Exercicios objexercicio6 = new Exercicios();
                        objexercicio6.ConverterCelsiusFahrenheit();

                        break;

                    case 7:
                        Exercicios objexercicio7 = new Exercicios();
                        objexercicio7.CoverterFahrenheitCelsius();
                        break;

                    case 8:
                        Exercicios objexercicio8 = new Exercicios();
                        objexercicio8.VolumeLataOleo();


                        break;
                    case 9:
                        Exercicios objexercio9 = new Exercicios();
                        objexercio9.AnosMesesDias();

                        break;

                    case 10:

                        Exercicios objexercicio10 = new Exercicios();
                        objexercicio10.ComparandoNumeros();
                        break;
                    case 0:
                        Console.WriteLine("SAIR!");
                        break;

                    default:

                        Console.WriteLine("OPÇÃO INVALIDA!");

                        break;








                }



            } while (opcao!=0);

            
        }
    }
}