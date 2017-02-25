using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CharEmServices.Models
{
    public class User : IdentityUser 
    {
        public User(string userName) : base(userName)
        {
            this.LinkServiceRecipients = new HashSet<LinkServiceRecipUser>();
            this.LinkServiceProviders = new HashSet<LinkServiceProvideUser>();
        }

        public string id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int AddressId { get; set; }
        public int UserTypeId { get; set; }
        public int TeamId { get; set; }

        public virtual Address Address { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual Team Team { get; set; }

        public virtual ICollection<LinkServiceRecipUser> LinkServiceRecipients { get; set; }
        public virtual ICollection<LinkServiceProvideUser> LinkServiceProviders { get; set; }


    }
}
