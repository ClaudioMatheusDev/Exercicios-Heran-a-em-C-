using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03.Entidades
{
    internal class Imovel
    {
        public string Endereco { get; set; }
        public double Preco { get; set; }

        public Imovel()
        {

        }
        public Imovel(string endereco, double preco)
        {
            Endereco = endereco;
            Preco = preco;
        }

        public virtual double PrecoImovel()
        {
            return Preco;
        }

    }
}
