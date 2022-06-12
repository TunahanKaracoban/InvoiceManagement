﻿using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Entity.Dto
{
    public class DtoLogin : DtoBase
    {
        
        public string Email { get; set; }

        public string Password { get; set; }

    }
}
