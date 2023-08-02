using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.models
{
    public class Aluno : Pessoa
    {
        //Proriedades

        public DateTime DataMatricula { get; set; }
        public bool Ativo { get; set; }
        
    }
}
