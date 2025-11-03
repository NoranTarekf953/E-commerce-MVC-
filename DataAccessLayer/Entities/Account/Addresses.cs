using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Account
{
    public class Addresses
    {
        [Key]
        public int AddressId { get; set; }
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = String.Empty;

        public string Street {  get; set; } = String.Empty;

        public int Zip {  get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }= new Customer();
    }
}
