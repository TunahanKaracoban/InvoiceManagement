using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Entity.Dto
{
   public class DtoRoomType:DtoBase
    {
        public DtoRoomType()
        {
           
        }

        public int RoomTypeId { get; set; }
        public string RoomType1 { get; set; }
    }
}
