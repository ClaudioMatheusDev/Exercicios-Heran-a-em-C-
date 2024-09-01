using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    internal class Funcionario
    {

        public string Nome { get; set; }
        public double Salario { get; set; }


        public Funcionario()
        {
        }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }


        public void addAumento(double valor)
        {
            Salario += valor;
        }

        public virtual double GanhoAnual()
        {
            return Salario * 12;
        }

        public virtual void exibeDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salario: {Salario}");
        }


    }
}
