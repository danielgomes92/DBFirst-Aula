using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst_Aula.Model;

namespace CodeFirst_Aula.DAL
{
    public class EscolaContext : DbContext // aqui será o contexto a partir do qual o EF pode acessar o DB
    {
        public EscolaContext() : base("EscolaContext")
        {
        }
            
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
