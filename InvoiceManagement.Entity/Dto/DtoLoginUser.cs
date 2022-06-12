using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Entity.Dto
{
    public class DtoLoginUser:DtoBase
    {

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
