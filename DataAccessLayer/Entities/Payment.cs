using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public int TransactionId { get; set; }

        public DateTime PaymentDate { get; set; }= new DateTime();
        [Precision(18, 2)]

        public decimal Amount { get; set; }

        //be enum
        public string Status { get; set; } = string.Empty;

        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        public Order Order { get; set; } = new Order();
    
    }
}
