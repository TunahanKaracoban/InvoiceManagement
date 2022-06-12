using InvoiceManagement.Dal.Abstract;
using InvoiceManagement.Entity.Dto;

using InvoiceManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using InvoiceManagement.Entity.Models;

namespace InvoiceManagement.Bll
{
    public class RoleManager : GenericManager<Role, DtoRole>, IRoleService
    {

        public readonly IRoleRepository _roleRepository;
        public RoleManager(IServiceProvider service) : base(service)
        {
            _roleRepository = service.GetService<IRoleRepository>();
        }
    }
}
