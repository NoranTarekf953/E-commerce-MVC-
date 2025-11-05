using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Account
{
    public class Customer:ApplicationUser
    {
        public int Points { get; set; }

        public ICollection<Addresses> Addresss { get; set; }= new HashSet<Addresses>();

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        [ForeignKey(nameof(Cart))]
        public int CartId { get; set; }
        public Cart? Cart { get; set; }
        //[ForeignKey(nameof(Payment))]

        //public int PaymentId { get; set; }

        //public Payment? Payment { get; set; }
    }
}
