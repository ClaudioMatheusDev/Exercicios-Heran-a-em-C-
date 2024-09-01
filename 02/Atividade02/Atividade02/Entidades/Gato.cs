using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Entidades
{
    internal class Gato : animal
    {
        public Gato() : base()
        {
        }

        public Gato(string nome) : base(nome)
        {
        }

        public string Mia()
        {
            return $"Gato {nome} está miando: Miau!";
        }
        
    }
}
