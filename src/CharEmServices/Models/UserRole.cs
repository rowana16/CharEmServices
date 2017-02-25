using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class UserRole : IdentityRole
    {
        public String Description { get; set; }
    }
}
