using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_facul.MODELS
{
   public class Professor
    {
        private int id = 0;
        private string nome = "";
        private string usuario = "";
        private string senha = "";

        public int Id { get; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        
            
    }
}
