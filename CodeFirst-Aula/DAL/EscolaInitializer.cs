using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst_Aula.Model;

namespace CodeFirst_Aula.DAL
{
    public class EscolaInitializer :
        System.Data.Entity.DropCreateDatabaseIfModelChanges<EscolaContext>
    {
        protected override void Seed(EscolaContext context)
        {
            var Alunos = new List<Aluno>
            {
                new Aluno { Nome = "Carlos", Sobrenome = "Alcantara", DataMatricula = DateTime.Parse("2005-09-01")},
                new Aluno { Nome = "Melissa", Sobrenome = "Alves", DataMatricula = DateTime.Parse("2002-09-01")},
                new Aluno { Nome = "Arthur", Sobrenome = "Andrade", DataMatricula = DateTime.Parse("2003-09-01")},
                new Aluno { Nome = "Jessica", Sobrenome = "Bastos", DataMatricula = DateTime.Parse("2002-09-01")},
                new Aluno { Nome = "Jana", Sobrenome = "Luz", DataMatricula = DateTime.Parse("2002-09-01")},
                new Aluno { Nome = "Penelope", Sobrenome = "Justino", DataMatricula = DateTime.Parse("2001-09-01")},
                new Aluno { Nome = "Laura", Sobrenome = "Noronha", DataMatricula = DateTime.Parse("2003-09-01")},
                new Aluno { Nome = "Nilson", Sobrenome = "Oliveira", DataMatricula = DateTime.Parse("2005-09-01")}
            };
        }
    }
}
