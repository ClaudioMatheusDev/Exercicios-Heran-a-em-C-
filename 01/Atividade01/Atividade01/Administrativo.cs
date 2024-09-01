using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    internal class Administrativo : Assistente
    {

        public string Turno {  get; set; }
        public double AdicionalNoturno { get; set; }

        public Administrativo(string nome, double salario, int matricula, string turno, double adicionalNoturno) : base (nome, salario, matricula)
        {
            Turno = turno;
            AdicionalNoturno = adicionalNoturno;
        }


        public override double GanhoAnual()
        {
            if (Turno.ToLower() == "noite")
            {
                return (Salario + AdicionalNoturno) * 12;
            }
            else
            {
                return Salario * 12;
            }
        }

        public override void exibeDados()
        {
            base.exibeDados();
            Console.WriteLine($"Turno: {Turno}");
            if (Turno.ToLower() == "noite") {
                Console.WriteLine($"Adicional Noturno: {AdicionalNoturno}");
            }
        }
    }
}
