using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }

        public DateTime PaymentDate { get; set; }= new DateTime();
        [Precision(18, 2)]

        public decimal Amount { get; set; }

        //be enum
        public string Status { get; set; } = string.Empty;
        
        public int OrderId { get; set; }
        public Order Order { get; set; } = new Order();
    
    }
}
