using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class OrderItems
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = new Order();
        public int ProductId { get; set; }
        public Products Product { get; set; } = new Products();
        public int Quantity { get; set; }
        [Precision(18, 2)]

        public decimal UnitPrice { get; set; }
        [Precision(18, 2)]

        public decimal SubTotal { get; set; }
    }
}
