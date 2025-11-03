using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class CartItems
    {
        public int Id { get; set; }

        [Range(0,20000)]
        public long Quantity { get; set; }

        public int CartId { get; set; }
        public Cart Cart { get; set; } = new Cart();

        public int ProductId { get; set; }
        public Products? Product { get; set; }



    }
}
