using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TarefasAPI.Data
{
    public class TarefasApiContext: DbContext 
    {
        public TarefasApiContext(DbContextOptions<TarefasApiContext> opt) : base (opt)
        {
        }  
    public DbSet<Categoria> Categorias {get;set;}
    public DbSet<Tarefa> Tarefas {get;set;}
    
        // protected override void OnModelCreating(ModelBuilder modelo)
        // {
        //     base.OnModelCreating(modelo);
        // }
    }

}