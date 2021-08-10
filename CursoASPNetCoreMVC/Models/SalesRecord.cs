using CursoASPNetCoreMVC.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CursoASPNetCoreMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [EnumDataType(typeof(SaleStatus))]
        public SaleStatus Status { get; set; }

        public Seller Seller { get; set; }
        public int SellerId { get; set; }

        public SalesRecord() { }
        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
