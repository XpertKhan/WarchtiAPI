using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WScore.Models
{
    public class NotificationModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string User { get; set; }
        public string Message { get; set; }
        public DateTime NotificationTime { get; set; }
    }
}
