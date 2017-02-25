using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class UserType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<AppUser> Users { get; set; }
    }
}
