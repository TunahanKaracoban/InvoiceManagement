using InvoiceManagement.Entity.Dto;
using InvoiceManagement.Entity.Models;
using InvoiceManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Bll
{
    public class MessageManager : GenericManager<Message, DtoMessage>, IMessageService
    {
        public MessageManager(IServiceProvider service) : base(service)
        {

        }
    }
}
