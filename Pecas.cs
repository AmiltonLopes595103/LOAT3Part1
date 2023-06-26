using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaLista.cs
{
     class Pecas
    {


        private int  total;
        private double ValorComissao;
        private int quantVendida;



        public int getTotal()
        {
            return total;
        } 
        public void setTotal(int total)
        {
            this.total = total;
        }
        public double getValorComissao()
        {
            return ValorComissao;
        }
        public void setValorComissao(double ValorComissao)
        {
            this.ValorComissao = ValorComissao;
        }
        private string codigoPeca;
        public string getCdPeca()
        {
            return codigoPeca;
        }

        public void setCdPeca(string codigoPeca)
        {
            this.codigoPeca = codigoPeca;
        }
        private double valorUnit;

        public double getValor()
        {
            return valorUnit;
        }

        public void setValor(int valorUnit)
        {
            this.valorUnit = valorUnit;
        }
        public int getQuantVendida()
        {
            return quantVendida;
        }

        public void setQuantVend(int quantVendida)
        {
            this.quantVendida = quantVendida;
        }
        public void CodigoValor()
        {
            Pecas pec = new Pecas();
            pec.codigoPeca = "100";
            pec.valorUnit = 10;
            Pecas pec1 = new Pecas();

            pec1.codigoPeca = "200";
            pec1.valorUnit = 15;
            Pecas pec2 = new Pecas();
            pec2.codigoPeca = "300";
            pec2.valorUnit = 25;


            Console.WriteLine("===========================================");
            Console.WriteLine("|Codigo da peça: " +pec.getCdPeca()+    "| Valor unitário: " +pec.getValor().ToString  ("F2")+"|");
            Console.WriteLine("|Codigo da peça: " + pec1.getCdPeca() + "| Valor unitário: " + pec1.getValor().ToString("F2")+"|");
            Console.WriteLine("|Codigo da peça: " + pec2.getCdPeca() + "| Valor unitário: " + pec2.getValor().ToString("F2")+"|");
            Console.WriteLine("===========================================");

        }

        public Pecas preencherPeca()
        {
            



            Pecas pc = new Pecas();

            Console.WriteLine("Digite o código da peça: ");
            pc.codigoPeca = Console.ReadLine();


            Console.WriteLine("Informe a quantidade  vendida: ");
            pc.quantVendida = int.Parse(Console.ReadLine());

            pc.setTotal(quantVendida);

           
             



            return pc;


        }
        private int soma = 0;

        public void ListarPecas(List<Pecas> lpc)
        {
            foreach (Pecas p in lpc)
            {
               

                soma += p.getQuantVendida();    

                Console.WriteLine();

                Console.WriteLine("Codigo da peça: {0}", p.codigoPeca);
                Console.WriteLine("Quantidade vendida: {0} {1}", p.quantVendida,"Peça(s)");//As Chaves {0} são utilizadas
               //para exibir a posição em que  o texto ira ser exibidoi na tela.
               


            }
            Console.WriteLine();
            Console.WriteLine("Total vendido: {0}", soma);
            ValorComissao = soma*0.05;
            Console.WriteLine("Valor a ser pago de comissão R$:{0}  ", ValorComissao.ToString("F2"));



        }
    }
}
