using CursoASPNetCoreMVC.Data;
using CursoASPNetCoreMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoASPNetCoreMVC.Services
{
    public class DepartmentService
    {
        private readonly CursoASPNetCoreMVCContext _context;

        public DepartmentService(CursoASPNetCoreMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(d => d.Name).ToListAsync();
        }
    }
}
