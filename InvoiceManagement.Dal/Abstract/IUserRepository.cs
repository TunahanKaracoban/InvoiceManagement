using InvoiceManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Dal.Abstract
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User Login(User login);
    }
}
