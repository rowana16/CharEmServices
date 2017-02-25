using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class LinkServiceProvideLocation
    {
        public int ServiceProviderId { get; set; }
        public virtual ServiceProvider ServiceProvider { get; set; }

        public int LocationId {get; set;}
        public virtual  Location Location {get; set;}
    }
}
