using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Aula.Model
{
    public class Matricula
    {
        //MatriculaID, CursoID, ALunoID, Nota
        public int MatriculaID { get; set; }
        public int CursoID { get; set; }           //chave estrangeira
        public int AlunoID { get; set; }           //chave estrangeira
        public Nota? Nota { get; set; }

        public virtual Curso Curso { get; set; } // vai ajudar a navegar a partir de um objeto matricula.curso(virtual)
        public virtual Aluno Aluno { get; set; }
    }
}
