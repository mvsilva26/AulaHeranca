using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___Herança
{
    class Pessoa
    {

        public string Nome { get; set; }

        public void escreverNome()
        {
            Console.WriteLine(this.Nome);

        }

        public virtual Boolean validarDocumento()
        {
            return true;
        }


    }
}
