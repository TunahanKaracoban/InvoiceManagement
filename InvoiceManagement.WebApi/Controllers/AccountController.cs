using InvoiceManagement.Entity.Base;
using InvoiceManagement.Entity.Dto;
using InvoiceManagement.Entity.IBase;
using InvoiceManagement.Interface;
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
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;

        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public IResponse<DtoUserToken> Login(DtoLogin login)
        {
            try
            {
                return _userService.Login(login);
            }
            catch (Exception ex)
            {

                return new Response<DtoUserToken>()
                {
                    Message = "Error" + ex.Message,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null

                };
            }
        }



    }
}
