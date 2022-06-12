using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace InvoiceManagement.Entity.Models
{
    public partial class Message : EntityBase
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Contents { get; set; }
        public bool IsRead { get; set; }
        public int? SenderId { get; set; }
        public int? ReceiverId { get; set; }
        public DateTime? SendingDate { get; set; }

        public virtual User Receiver { get; set; }
        public virtual User Sender { get; set; }
    }
}
