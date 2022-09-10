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
        public int CursoID { get; set; }
        public int AlunoID { get; set; }
        public Nota? Nota { get; set; }
    }
}
