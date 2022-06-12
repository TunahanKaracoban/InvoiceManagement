﻿using InvoiceManagement.Entity.Dto;
using InvoiceManagement.Entity.IBase;
using InvoiceManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Interface
{
    public interface IUserService : IGenericService<User, DtoUser>
    {
        IResponse<DtoUserToken> Login(DtoLogin login);
        IResponse<DtoUser> AddUser(DtoUser user, bool saveChanges = true);
        IResponse<DtoNewPassword> ChangePassword(DtoNewPassword login, bool saveChanges = true);


    }
}
