using DataAccessLayer.Entities.Account;
using DataAccessLayer.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public string ShippingAddress { get; set; }= string.Empty;
        /// <summary>
        /// should be Enum
        /// </summary>
        public OrderStatusEnum Status { get; set; } 
        //should be enum
       public PaymentMethodEnum PaymentMethod {  get; set; }
        [Precision(18, 2)]

        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public DateTime CreateAt { get; set; } = DateTime.Now;

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public Payment? Payment { get; set; }
    
        public ICollection<OrderItems> OrderItems { get; set; }= new HashSet<OrderItems>();
    }
}
