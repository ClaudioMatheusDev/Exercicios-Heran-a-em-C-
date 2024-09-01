using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    internal class Tecnico : Assistente
    {

        public double BonusSalarial { get; set; }

        public Tecnico(string nome, double salario, int matricula, double bonusSalarial) : base(nome, salario, matricula)
        { 
            BonusSalarial = bonusSalarial;
        }

        public override double GanhoAnual()
        {
            return (Salario + BonusSalarial) * 12;
        }

        public override void exibeDados()
        {
            base.exibeDados();
            Console.WriteLine($"Bônus Salarial: {BonusSalarial}");
        }

    }
}
