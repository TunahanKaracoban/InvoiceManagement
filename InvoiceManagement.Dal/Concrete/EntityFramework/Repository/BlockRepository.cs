using InvoiceManagement.Dal.Abstract;
using InvoiceManagement.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Dal.Concrete.EntityFramework.Repository
{
    public class BlockRepository : GenericRepository<Invoice>, IInvoiceRepository
    {
        public BlockRepository(DbContext context) : base(context)
        {

        }
    }
}
