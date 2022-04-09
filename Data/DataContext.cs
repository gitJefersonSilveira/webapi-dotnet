using Microsoft.EntityFrameworkCore;
using ProjetoEscola.Models;

namespace ProjetoEscola.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}        

        public DbSet<Aluno> Alunos{get; set;}
        public DbSet<Professor> Professores{get;set;}

        protected override void OnModelCreating(ModelBuilder builder){
                builder.Entity<Professor>()
                .HasData(
                    new List<Professor>(){
                        new Professor(){
                            Id = 1,
                            Nome = "Joao Paulo",                            
                        },
                        new Professor(){
                            Id = 2,
                            Nome = "Ana Maria",                            
                        },
                        new Professor(){
                            Id = 3,
                            Nome = "Cintia",                            
                        },
                    }  
                );

                builder.Entity<Aluno>()
                .HasData(
                    new List<Aluno>(){
                        new Aluno(){
                            Id = 1,
                            Nome = "Carlos",
                            Sobrenome = "Silva",
                            DataNasc = "34/12/2009",
                            ProfessorId = 1                            
                        },
                        new Aluno(){
                            Id = 2,
                            Nome = "Juliana",      
                            Sobrenome = "Silva",
                            DataNasc = "34/12/2009",
                            ProfessorId = 2                   
                        },
                        new Aluno(){
                            Id = 3,
                            Nome = "Zulmira",      
                            Sobrenome = "Silva",
                            DataNasc = "34/12/2009",
                            ProfessorId = 3                       
                        },
                    }  
                );
        }

    }
}