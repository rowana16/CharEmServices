using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class LinkServiceProvideUser
    {
        public int ServiceProviderId { get; set; }
        public virtual ServiceProvider ServiceProvider { get; set; }

        public string UserId  {get; set;}
        public virtual AppUser User  {get; set;}
    }
}
