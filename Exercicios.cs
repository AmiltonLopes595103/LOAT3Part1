using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaLista.cs
{
    internal class Exercicios
    {

        //Nivel 1: Entrada, Processamento e saida.

        /*Na definição dos métodos eu não posso utilizar a classe  Exercicios() fazendo referencia a classe a qual esses métodos pertencem 
        pois essa classe não possue nenhum atributo portanto não há como utilizar atributos nos métodos pois nessa classe eles não
        existem */

        /*Nessa classe podemos definir todos os objetos do tippo void (Vazio) pois não há necessidade de retornar nada para a classe
         * principal, apenas chamaremos os metos() atraves da intanciação de um objeto da classe Exerxicios(); */

        /*Os metodos são declarados como void (vazio, sem retorno) pois não iremos retornar nada ao codigo principal
          apenas chamamos o metodo() é o que esta dentro do metodo() será executado.*/




        public void EstoqueMedio()
        {
            int quantMinima;
            int quantMaxima;
            int estoqueMedio;
            Console.WriteLine("Infome a quantoidade minima de peças: ");
            quantMinima = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade máxima de peças: ");
            quantMaxima = int.Parse(Console.ReadLine());
            estoqueMedio = (quantMinima + quantMaxima) / 2;
            Console.WriteLine("A média da quantidade de peças em estoque é de: " + estoqueMedio + " Peças");
        }

        public void ConverterDollarReal()
        {
            double valorDollar;
            double valorReal;
            double cotDollar;
            double resulado;

            cotDollar = 4.78;

            Console.WriteLine("Digite um valor em dollar: ");
            valorDollar = double.Parse(Console.ReadLine());
            Console.WriteLine();
            valorReal = valorDollar * cotDollar;
            Console.WriteLine("O valor de US$: " + valorDollar + " dollares \n" +
                              "convertido para real com uma cotação de: \n" + cotDollar +
                              " é de: " + valorReal.ToString("F2"));

        }


        public void CalculoComissão()
        {
            string opcao;
            string op;


            List<Pecas> listapeca = new List<Pecas>();//Poulando a lista de objetos.


            List<Vendedor> listavendedor = new List<Vendedor>();//Populando a lista de vendedores.

            Vendedor objVend1 = new Vendedor();


            List<Vendedor> listaVend = new List<Vendedor>();
            List<Pecas> listpeca = new List<Pecas>();



            listaVend.Add(new Vendedor().Preencher());//Preencher um objeto interno.
            listapeca.Add(new Pecas().preencherPeca());//Preencher codigo, valore e adicionar a lista.
            Console.WriteLine("DESEJA INFORMAR A VENDA DE OUTRA PECA DIFERENTE: (S)SIM  (N)NÃO: ");
            opcao = Console.ReadLine().ToUpper();



            do
            {
                if (opcao == "S")
                {
                    listapeca.Add(new Pecas().preencherPeca());
                    Console.WriteLine("DESEJA INFORMAR A VENDA DE OUTRA PECA DIFERENTE: (S)SIM  (N)NÃO");
                    opcao = Console.ReadLine().ToUpper();





                }

            } while (opcao != "N");






            new Vendedor().ListarVendedores(listaVend);//Listar o ID do vendedor.

            new Pecas().ListarPecas(listapeca);//Listar o codigo, valor etc.

            do
            {

                Console.WriteLine();
                Console.WriteLine("DESEJA CALCULAR UMA ANOVA COMISSÃO: (S)SIM (N)NÃO");
                op = (Console.ReadLine().ToUpper());

                if (op == "S")
                {
                    listaVend.Clear();//Lipar a lista para receber um novo objeto ID.
                    listapeca.Clear();//Limpar a lista para receber um novo objeto Pecas.

                    listaVend.Add(new Vendedor().Preencher());//Preencher um objeto interno.
                    listapeca.Add(new Pecas().preencherPeca());//Preencher codigoe valore e adicionar a lista.
                    Console.WriteLine("DESEJA INFORMAR A VENDA DE OUTRA PECA DIFERENTE: (S)SIM  (N)NÃO: ");
                    opcao = Console.ReadLine().ToUpper();



                    do
                    {
                        if (opcao == "S")
                        {
                            listapeca.Add(new Pecas().preencherPeca());
                            Console.WriteLine("DESEJA INFORMAR A VENDA DE OUTRA PECA DIFERENTE: (S)SIM  (N)NÃO");
                            opcao = Console.ReadLine().ToUpper();





                        }

                    } while (opcao != "N");
                    new Vendedor().ListarVendedores(listaVend);//Listar o ID do vendedor.

                    new Pecas().ListarPecas(listapeca);//Listar o codigo, valor etc.

                }

            } while (op != "N");


        }

        public void CalculoNumeros()
        {
            int A;
            int B;
            int C;
            int D;
            int AB = 0;
            int AC = 0;
            int AD = 0;
            int BC = 0;
            int BD = 0;
            int CD = 0;




            Console.WriteLine("Informe o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de D: ");
            D = int.Parse(Console.ReadLine());
            Console.WriteLine();
            AB = A + B;
            AC = A + C;
            AD = A + D;
            BC = B + C;
            BD = B + D;
            CD = C + D;





            Console.WriteLine("A soma de A + B é : " + AB);
            Console.WriteLine("A soma de A + C é : " + AC);
            Console.WriteLine("A soma de A + D é : " + AD);
            Console.WriteLine("A soma de B + C é : " + BC);
            Console.WriteLine("A soma de B + D é : " + BD);
            Console.WriteLine("A soma de C + D é : " + CD);

            AB = A * B;
            AC = A * C;
            AD = A * D;
            BC = B * C;
            BD = B * D;
            CD = C * D;

            Console.WriteLine();

            Console.WriteLine("A soma de A x B é : " + AB);
            Console.WriteLine("A soma de A x C é : " + AC);
            Console.WriteLine("A soma de A x D é : " + AD);
            Console.WriteLine("A soma de B x C é : " + AD);
            Console.WriteLine("A soma de B x D é : " + BC);
            Console.WriteLine("A soma de C x D é : " + BD);




        }

        public void CalculoCombustivel()
        { 
        

            decimal tempoGasto;
            decimal velMedia;
            decimal distancia;
            decimal litrosGastos;

            Console.WriteLine();
            Console.WriteLine("INFORME O TEMPO GASTO NA VIAGEM: ");
            tempoGasto = decimal.Parse(Console.ReadLine());

            Console.WriteLine("INFORME A VELOCIDADE MÉDIA:");
            velMedia = decimal.Parse(Console.ReadLine());
            distancia = tempoGasto * velMedia;
            litrosGastos = distancia / 12;
            Console.WriteLine();
            Console.WriteLine("VELOCIDADE MÉDIA:"+velMedia+" KILOMETRO(S) POR HORA");
            Console.WriteLine("TEMPO GASTO NA VIAGEM:"+ tempoGasto+" HORA(S)");
            Console.WriteLine("DISTÂNCIA PERCORRIDA:"+distancia.ToString("F2") + " KILOMETRO(S)");
            Console.WriteLine("QUANTIDADE DE LITROS GASTO NA VIAGEM:" + litrosGastos.ToString("F2")+" LITROS") ;




        }
      
        public void ConverterCelsiusFahrenheit()
        {
            double tempCelsius = 0;
            double grausFahrenheit = 0;
           

            Console.WriteLine("INFORME A TEMPERATURA EM GRAUS CELSIUS: ");
            tempCelsius = double.Parse(Console.ReadLine());
            grausFahrenheit = (9 * tempCelsius + 160) / 5;
            Console.WriteLine();
            Console.WriteLine("A TEMPERATURA EM GRAUS CELSIUS: " +tempCelsius+" GRAUS CELSIUS C°");
            Console.WriteLine("EQUIVALE A: "+grausFahrenheit+" GRAUS FAHRENHEIT F°");

            

        }

        public void CoverterFahrenheitCelsius()
        {

            double tempCelsius = 0;
            double grausFahrenheit = 0;


            Console.WriteLine("INFORME A TEMPERATURA EM GRAUS FHRENHEIT: ");
            grausFahrenheit = double.Parse(Console.ReadLine());
            tempCelsius = (grausFahrenheit - 32) * 5 / 9;
            Console.WriteLine();
            Console.WriteLine("A TEMPERATURA EM GRAUS FAHRENHEIT: " + grausFahrenheit+ "F° GRAUS FAHRENHEIT");
            Console.WriteLine("EQUIVALE A: " + tempCelsius + "C° GRAUS CELSIUS ");


        }
        public void VolumeLataOleo()
        {
            const double pi = 3.14159;

            double volume;
            double raio;
            double altura;

            Console.WriteLine("INFORME O VALOR DO RAIO DA LATA DE OLEO:");
            raio = double.Parse(Console.ReadLine());
            Console.WriteLine("INFORME A ALTURA DA LATA DE OLEO:");
            altura = double.Parse(Console.ReadLine());

            volume = pi * raio * raio *altura;

            Console.WriteLine("O VOLUME DA LATA DE OLEO É: "+volume.ToString("F2")+"ML");

        }

        public void AnosMesesDias()
        {
            int idade;
            int calculoMes;
            int calculoDias;
            Console.WriteLine("INFORME UMA IDADE: ");
            idade = int.Parse(Console.ReadLine());
            calculoMes = idade * 12;
            calculoDias = 365 * idade;

            Console.WriteLine();
            Console.WriteLine("A IDADE INFORMADA: "+idade+" ANOS"+"\n"+
                               "EQUIVLHE A:"+calculoMes+" MESES"+"\n"+
                                          "E: " +calculoDias+" DIAS");

        }

        public void ComparandoNumeros()
        {
            int num1;
            int num2;
            bool numIguais;
            bool numDiferentes;
            bool maiorNum;
            bool menorNum;
            bool maiorOuIgual;
            bool menorOuIgua;
            Console.WriteLine("INFORME O PRIMEIRO NÚMERO: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INFORME O SEGUNDO NUMERO: ");
            num2 = int.Parse(Console.ReadLine());



            if (num1==num2)
            {
                numIguais = true;
                Console.WriteLine("NUMEROS IGUAIS:  SIM!");
               
            }
            else
            {
                Console.WriteLine("NUMEROS IGUAIS:  NÃO!");
                
            }


            if (num1 != num2)
            {
                numDiferentes = true;
                Console.WriteLine("NUMEROS DIFERENTES: SIM!");

            }
            else
            {
                Console.WriteLine("NUMEROS DIFERENTES: NÃO!");

            }

            if (num1>num2)
            {
                maiorNum = true;
                Console.WriteLine("O PRIMEIRO NÚMERO É MAIOR QUE O SEGUNDO: SIM!");
            }
            else
            {
                Console.WriteLine("O PRIMEIRO NÚMERO É MAIOR QUE O SEGUNDO: NÃO!");
            }


            if (num1 < num2)
            {
                menorNum = true;
                Console.WriteLine("O PRIMEIRO NÚMERO É MENOR QUE O SEGUNDO: SIM!");
            }
            else
            {
                Console.WriteLine("O PRIMEIRO NÚMERO É MENOR QUE O SEGUNDO: NÃO!");
            }

            if (num1 > num2 )
            {
                maiorOuIgual = true;
               
                Console.WriteLine("O PRIMEIRO NÚMERO É MAIOR OU IGUAL O SEGUNDO: MAIOR!");
            }
            else if (num1 == num2)
            {
                maiorOuIgual = true;

                Console.WriteLine("O PRIMEIRO NÚMERO É MAIOR OU IGUAL O SEGUNDO: IGUAL!");

            }
            else
            {
                Console.WriteLine("O PRIMEIRO NÚMERO É MAIOR OU IGUAL O SEGUNDO: NÃO!");
            }

            if (num1 < num2)
            {
                maiorOuIgual = true;

                Console.WriteLine("O PRIMEIRO NÚMERO É MENOR OU IGUAL O SEGUNDO: MENOR!");
            }
            else if (num1 == num2)
            {
                maiorOuIgual = true;

                Console.WriteLine("O PRIMEIRO NÚMERO É MENOR OU IGUAL O SEGUNDO: IGUAL!");

            }
            else
            {
                Console.WriteLine("O PRIMEIRO NÚMERO É MENOR OU IGUAL O SEGUNDO: NÃO!");
            }





        }







        }
}
