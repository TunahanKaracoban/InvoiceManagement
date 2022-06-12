using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Entity.Dto
{
    public class DtoMessage:DtoBase
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Contents { get; set; }
        public bool IsRead { get; set; }
        public int? SenderId { get; set; }
        public int? ReceiverId { get; set; }
        public DateTime? SendingDate { get; set; }
    }
}
