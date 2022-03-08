using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___Herança
{
    internal class Juridica: Pessoa
    {

        public string Cnpj { get; set; }

        public Juridica(string nome, string cnpj)
        {
            Nome = nome;
            Cnpj = cnpj;
        }

        public new Boolean validarDocumento() 
        {
            return string.IsNullOrEmpty(Cnpj) && Cnpj.Length != 18 ? false : true;
        }

    }
}
