using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warshti.Entities.Maintenance;

namespace Warshti.Entities.Car
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Service> CarServices { get; set; }
        public Company()
        {
            CarServices = new HashSet<Service>();
        }
    }
}