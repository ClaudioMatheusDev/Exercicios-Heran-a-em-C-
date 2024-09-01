using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03.Entidades
{
    internal class Novo : Imovel
    {
        public double AdicionalPreco {  get; set; }

        public Novo() { }

        public Novo(string endereco, double preco, double adicionalPreco) : base ( endereco, preco)
        {
            AdicionalPreco = adicionalPreco;
        }

        public override double PrecoImovel()
        {
            return base.PrecoImovel() + AdicionalPreco;
        }
    }
}
