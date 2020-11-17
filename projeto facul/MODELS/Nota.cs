using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_facul.MODELS
{
    class Nota
    {
        int id_nota = 0;
        int id_aluno = 0;
        int id_curso = 0;
        int id_disciplina = 0;
        float notaAluno = 0;

        public int Id_nota { get; set; }
        public int Id_aluno { get; set; }
        public int Id_curso { get; set; }
        public int Id_discplina { get; set; }
        public float NotaAluno { get; set; }
    }
}
