using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class LinkServiceProvideService
    {
        public int ServiceProviderId { get; set; }
        public virtual ServiceProvider ServiceProvider { get; set; }

        public int ServiceId  {get; set;}
        public virtual Service Service {get; set;}
    }
}
