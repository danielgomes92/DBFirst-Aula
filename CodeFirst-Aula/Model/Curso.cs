using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Aula.Model
{
    public class Curso
    {
        //CursoID, Titulo e Creditos
        public int CursoID { get; set; }
        public string Titulo { get; set; }
        public int Creditos { get; set; }

        public virtual ICollection<Matricula> Matriculas { get; set; } // propriedade de navegação
    }
}
