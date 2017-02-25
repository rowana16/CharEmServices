using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class Location
    {
        public Location()
        {
            this.LinkServiceProviders = new HashSet<LinkServiceProvideLocation>();
            this.LinkServiceRecipients = new HashSet<LinkServiceRecipLocation>();
        }

        public int Id { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }

        public virtual ICollection<LinkServiceProvideLocation> LinkServiceProviders { get; set; }
        public virtual ICollection<LinkServiceRecipLocation> LinkServiceRecipients { get; set; }
    }
}
