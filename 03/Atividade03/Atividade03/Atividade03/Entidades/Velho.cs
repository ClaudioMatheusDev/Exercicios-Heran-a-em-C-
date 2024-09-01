using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03.Entidades
{
    internal class Velho : Imovel
    {
        public double DescontoPreco { get; set; }

        public Velho() { }

        public Velho(string endereco, double preco, double descontoPreco) : base(endereco, preco)
        {
            DescontoPreco = descontoPreco;
        }

        public override double PrecoImovel()
        {
            return base.PrecoImovel() - DescontoPreco;
        }
    }
}
