using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Value { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public int PaymentType { get; set; }
        [Required]
        public int TransactionType { get; set; }

    }
}
