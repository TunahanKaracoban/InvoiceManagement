﻿using InvoiceManagement.Entity.Dto;
using InvoiceManagement.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Interface
{
    public interface IEmailService
    {
        Task<IResponse<DtoUser>> SendEmailAsync(DtoUser mailRequest);
    }
}
