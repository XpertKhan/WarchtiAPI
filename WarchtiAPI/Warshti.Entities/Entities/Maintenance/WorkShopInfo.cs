using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WScore.Entities.Identity;

namespace Warshti.Entities.Maintenance
{
    public class WorkShopInfo
    {
        public int Id { get; set; }
        public int WorkShopId { get; set; }
        public virtual User Workshop { get; set; }

        public string Sponsor { get; set; }
        public string Department { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Facility { get; set; }
        public string CommercialRegister { get; set; }
        public string ElectonicPaymentAccount { get; set; }
        public byte[] Photo { get; set; }
    }
}
