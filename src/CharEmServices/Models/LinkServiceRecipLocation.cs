using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class LinkServiceRecipLocation
    {
        public int ServiceRecipientId { get; set; }
        public virtual ServiceRecipient ServiceRecipient { get; set; }

        public int LocationId {get; set;}
        public virtual Location Location {get; set;}
    }
}
