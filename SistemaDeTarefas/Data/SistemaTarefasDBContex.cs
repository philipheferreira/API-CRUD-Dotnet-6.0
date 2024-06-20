using Microsoft.EntityFrameworkCore;

namespace SistemaDeTarefas.Data{
    public class SistemaTarefasDBContex : DbContext {

        public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> options) : base(options){ 
        
        }

        public DbSet<Models.UsuarioModel> Usuarios { get; set; }
        public DbSet<Models.TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
        }

    }
}
