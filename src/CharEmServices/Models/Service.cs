using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class Service
    {
        public Service()
        {
            this.LinkServiceProviders = new HashSet<LinkServiceProvideService>();
            this.LinkServiceRecipients = new HashSet<LinkServiceRecipService>();
        }

        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDetails { get; set; }

        public int ServiceTypeId { get; set; }
        public virtual ServiceType ServiceType { get; set; }
                
        public virtual ICollection<LinkServiceProvideService> LinkServiceProviders { get; set; }
        public virtual ICollection<LinkServiceRecipService> LinkServiceRecipients { get; set; }
    }
}
