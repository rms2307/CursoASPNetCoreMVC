using Microsoft.EntityFrameworkCore;
using CursoASPNetCoreMVC.Models;

namespace CursoASPNetCoreMVC.Data
{
    public class CursoASPNetCoreMVCContext : DbContext
    {
        public CursoASPNetCoreMVCContext (DbContextOptions<CursoASPNetCoreMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
