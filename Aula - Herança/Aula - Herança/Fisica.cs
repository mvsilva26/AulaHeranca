using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___Herança
{
    internal class Fisica: Pessoa
    {
        public string Cpf { get; set; }

        public Fisica(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
                    
        }


        public override Boolean validarDocumento() // new oculta o metodo da classe base 
        { 
            //Console.WriteLine("Cpf: " + Cpf);
            return string.IsNullOrEmpty(Cpf) || Cpf.Length != 14 ? false : true;
        }


    }
}
