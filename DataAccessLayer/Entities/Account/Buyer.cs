using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Account
{
    public class Buyer:ApplicationUser
    {
        public string CompanyName { get; set; } = string.Empty;
    }
}
