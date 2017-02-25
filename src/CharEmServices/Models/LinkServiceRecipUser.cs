using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class LinkServiceRecipUser
    {
        public int ServiceRecipientId { get; set; }
        public virtual ServiceRecipient ServiceRecipient{ get; set; }

        public string UserId {get; set;}
        public virtual AppUser User {get; set;}
    }
}
