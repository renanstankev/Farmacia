using farmacia.api.Models;
using Microsoft.EntityFrameworkCore;

namespace farmacia.api.Data
{
    public class FarmaciaDbContext : DbContext
    {
        public FarmaciaDbContext(DbContextOptions<FarmaciaDbContext> options) : base(options) { }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }

}
