using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Account
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string FullName { get; set; }= string.Empty;

        public DateTime CreateAt { get; set; }= DateTime.Now;
    }
}
