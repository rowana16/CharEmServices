using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class Team
    {
        public int Id { get; set; }
        
        public virtual ICollection<AppUser> Users { get; set; }

    }
}
