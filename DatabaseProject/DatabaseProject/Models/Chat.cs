using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseProject.Models
{
    public class Chat
    {
        public int ChatId { get; set; }
        public int TenantId { get; set; }
        public int PropertyOwnerId { get; set; }
        public int PropertyId { get; set; }
        public string Sender { get; set; }
        public string MessageContent { get; set; }
        public DateTime Timestamp { get; set; }
    }

}