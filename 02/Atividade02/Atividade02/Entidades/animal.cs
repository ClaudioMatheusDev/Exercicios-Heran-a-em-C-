using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Entidades
{
    internal class animal
    {
        public string nome;
        private string raca;
        public animal()
        {
            this.nome = "Desconhecido";
            this.raca = "Desconhecida";
        }

        public animal(string nome)
        {
            this.nome = nome;
            this.raca = "Desconhecida";
        }

        public string Caminha()
        {
            return $"{nome} está caminhando.";
        }


    }
}
