using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<CursoASPNetCoreMVC.Models.Department> Department { get; set; }
    }
}
