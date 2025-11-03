using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Enums
{
    public enum OrderStatusEnum
    {
        Pending = 1,       // order placed, waiting for confirmation
        Processing = 2,    // being prepared or packaged
        Shipped = 3,       // on the way to customer
        Delivered = 4,     // successfully delivered
        Cancelled = 5
    }
}
