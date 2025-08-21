using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Shared.Dtos
{
    public class TransactionDto
    {
        public double Value { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int PaymentType { get; set; }
        public int TransactionType { get; set; }
    }
}
