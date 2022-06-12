using InvoiceManagement.Entity.Dto;
using InvoiceManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Interface
{
    public interface IInvoiceService : IGenericService<Invoice, DtoInvoice>
    {
    }
}
