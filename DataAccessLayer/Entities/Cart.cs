using DataAccessLayer.Entities.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Cart
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = new Customer();

        public ICollection<CartItems> Items { get; set; } = new HashSet<CartItems>();
    }
}
