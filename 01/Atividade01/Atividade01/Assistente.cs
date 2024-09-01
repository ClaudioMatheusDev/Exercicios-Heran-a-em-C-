using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    internal class Assistente : Funcionario
    {

        public int Matricula { get; set; }

        public Assistente()
        {
        }

        public Assistente(string nome, double salario, int matricula) : base(nome, salario)
        {
            Matricula = matricula;
        }

        public override void exibeDados()
        {
             base.exibeDados();
            Console.WriteLine($"Número da matricula: {Matricula}");
        }



    }
}
