using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class LinkServiceRecipService
    {
        public int ServiceRecipientId { get; set; }
        public virtual ServiceRecipient ServiceRecipient { get; set; }

        public int ServiceId {get; set;}
        public virtual Service Service {get; set;}
    }
}
