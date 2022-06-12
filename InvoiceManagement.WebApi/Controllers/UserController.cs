using InvoiceManagement.Entity.Base;
using InvoiceManagement.Entity.Dto;
using InvoiceManagement.Entity.IBase;
using InvoiceManagement.Entity.Models;
using InvoiceManagement.Interface;
using InvoiceManagement.WebApi.Base;
using MailKit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagement.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ApiBaseController<IUserService, User, DtoUser>
    {
        private readonly IUserService _userService;
        private readonly IEmailService _mailService;
        public UserController(IUserService userService, IEmailService mailService) : base(userService)
        {
            _userService = userService;
            _mailService = mailService;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("AddUser")]
        public IResponse<DtoUser> AddUser(DtoUser entity)
        {
            try
            {
                _mailService.SendEmailAsync(entity);
                return _userService.Add(entity);
            }
            catch (Exception ex)
            {
                return new Response<DtoUser>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error : {ex.Message}",
                    Data = null
                };
            }
        }


        [Authorize(Roles = "Admin,Kullanıcı")]
        [HttpPost("ChangePassword")]
        public IResponse<DtoNewPassword> ChangePassword(DtoNewPassword login)
        {
            try
            {
                login.UserId = Int32.Parse(User.Claims.First(i => i.Type == "jti").Value);
                return _userService.ChangePassword(login);
            }
            catch (System.Exception ex)
            {
                return new Response<DtoNewPassword>
                {
                    Message = "Error : " + ex.Message,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }
    }
}
