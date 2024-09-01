using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Entidades
{
    internal class Cachorro : animal
    {

        public Cachorro() : base()
        {
        }
     
        public Cachorro(string nome) : base(nome)
        {
        }
        public string Late()
        {
            return $"Cachorro {nome} está latindo: Au Au!";
        }


    }

}