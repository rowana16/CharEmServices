using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class ServiceProvider
    {
        public ServiceProvider()
        {
            this.LinkLocations = new HashSet<LinkServiceProvideLocation>();
            this.LinkServices = new HashSet<LinkServiceProvideService>();
            this.LinkUsers = new HashSet<LinkServiceProvideUser>();
        }
        public int Id { get; set; }
        public string OrganizationName { get; set; }

        public int AddressId { get; set; }
        public int OrganizationTypeId { get; set; }        
        public string UserId { get; set; }
        public int TeamId { get; set; }

        public virtual Address Address { get; set; }
        public virtual OrganizationType OrganizationType { get; set; }        
        public virtual User User { get; set; }
        public virtual Team Team { get; set; }

        public virtual ICollection<LinkServiceProvideLocation> LinkLocations { get; set; }
        public virtual ICollection<LinkServiceProvideService> LinkServices { get; set; }
        public virtual ICollection<LinkServiceProvideUser> LinkUsers { get; set; }

    }
}
