using CursoASPNetCoreMVC.Data;
using CursoASPNetCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoASPNetCoreMVC.Services
{
    public class SellerService
    {
        private readonly CursoASPNetCoreMVCContext _context;

        public SellerService(CursoASPNetCoreMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }


    }
}
