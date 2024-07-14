using Microsoft.EntityFrameworkCore;

namespace TarefasAcademicas.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }

    
}
