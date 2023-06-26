using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaLista.cs
{
     class Vendedor:Pecas
    {
        private string id;

        private string codPeca;

        //private int quantVendida;

        private double total;


        public string getId()
        {
            return id;
        }

        /*No método set() precisamos utilizar uma variavel local para receber uma informção
            vinda do codigo principal atraves da variavel local e passamos essa informação para o atributo ao qual esse
            método pertence.*/
        public void setId(string id)
        {
            this.id = id;
        }

        public string getCodigoPeca(string codPeca)
        {
            return codPeca;
        }
        public void setCodPeca(string codPeca)
        {
            this.codPeca = codPeca;
        }

        /* public int getQuantVendidas()
         {
             return quantVendida;
         }
         public void setQuantVendida(int quantVendida)
         {
             this.quantVendida = quantVendida ;   
         }*/

        public double getTotal()
        {
            return total;
        }
        public void setTotal(double total)
        {
            this.total = total;
        }

        public Vendedor Preencher()
        {

            Vendedor objVendedor = new Vendedor();
            Console.WriteLine();


            Console.WriteLine("Informe o ID do vendedor: ");
            objVendedor.id = Console.ReadLine();
            Pecas obj = new Pecas();
            obj.CodigoValor();






            return objVendedor;

        }

        public void ListarVendedores(List<Vendedor> vend)
        {
            foreach (Vendedor v in vend)
            {
                Console.WriteLine("ID do vendedor: {0} ", v.id);

            }



        }

    }
}
