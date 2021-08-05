using CursoASPNetCoreMVC.Data;
using CursoASPNetCoreMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace CursoASPNetCoreMVC.Services
{
    public class DepartmentService
    {
        private readonly CursoASPNetCoreMVCContext _context;

        public DepartmentService(CursoASPNetCoreMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(d => d.Name).ToList();
        }
    }
}
