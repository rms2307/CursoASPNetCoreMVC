using System.Collections.Generic;

namespace CursoASPNetCoreMVC.Models.ViewModels
{
    public class SalesRecordViewModel
    {
        public SalesRecord SalesRecord { get; set; }
        public ICollection<Seller> Sellers { get; set; }
    }
}