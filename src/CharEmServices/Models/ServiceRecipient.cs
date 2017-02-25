using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class ServiceRecipient
    {
        public ServiceRecipient()
        {
            this.LinkLocations = new HashSet<LinkServiceRecipLocation>();
            this.LinkServices = new HashSet<LinkServiceRecipService>();
            this.LinkUsers = new HashSet<LinkServiceRecipUser>();
        }

        public int Id { get; set; }
        public string OrganizationName { get; set; }

        public int AddressId { get; set; }
        public int OrganizationTypeId { get; set; }
        public string UserId { get; set; }
        public int TeamId { get; set; }

        public virtual Address Address { get; set; }
        public virtual OrganizationType OrganizationType { get; set; }
        public virtual AppUser User { get; set; }
        public virtual Team Team { get; set; }

        public virtual ICollection<LinkServiceRecipLocation> LinkLocations { get; set; }
        public virtual ICollection<LinkServiceRecipService> LinkServices { get; set; }
        public virtual ICollection<LinkServiceRecipUser> LinkUsers { get; set; }
    }
}
