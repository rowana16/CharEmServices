using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class OrganizationType
    {
        public OrganizationType()
        {
            this.ServiceProviders = new HashSet<ServiceProvider>();
            this.ServiceRecipients = new HashSet<ServiceRecipient>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }

        public virtual ICollection<ServiceProvider> ServiceProviders { get; set; }
        public virtual ICollection<ServiceRecipient> ServiceRecipients { get; set; }

    }
}
