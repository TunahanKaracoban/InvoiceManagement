using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Entity.Dto
{
    public class DtoApartment :DtoBase
    {
        public DtoApartment()
        {
          
        }
        public int ApartmentId { get; set; }
        public int BlockId { get; set; }
        public int RoomTypeId { get; set; }
        public int UserId { get; set; }
        public byte FloorNumber { get; set; }
        public byte ApartmentNumber { get; set; }
        public bool? IsEmpty { get; set; }
        public string ApartmentStatus { get; set; }

  
    }
}

