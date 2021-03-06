﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class ServiceType
    {
        public ServiceType()
        {
            this.Services = new HashSet<Service>();
        }

        public int Id { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        
        public virtual ICollection<Service> Services { get; set; }
    }
}
