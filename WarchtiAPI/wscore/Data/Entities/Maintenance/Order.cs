using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WScore.Entities.Identity;

namespace WScore.Data.Entities.Maintenance
{
    public class Order
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }
        public int WorkshopId { get; set; }
        public virtual User Workshop { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpectedCompletionDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string OrderNumber { get; set; }
        public decimal EstimatedPrice { get; set; }
        public int OrderStatusId { get; set; }
        public int OrderProgress { get; set; }

        public virtual ICollection<OrderStep> OrderSteps { get; set; }

        public Order()
        {
            OrderSteps = new HashSet<OrderStep>();
        }
    }
}
