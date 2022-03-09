using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Genero> Generos { get; set; }

    }
}
