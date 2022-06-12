using InvoiceManagement.Entity.Base;
using InvoiceManagement.Entity.Dto;
using InvoiceManagement.Entity.IBase;
using InvoiceManagement.Interface;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace InvoiceManagement.Bll
{
    public class EmailManager:IEmailService
    {
        private readonly DtoEmailSetting _mailSetting;
        IConfiguration _configuration;
        public EmailManager(IOptions<DtoEmailSetting> mailSetting, IConfiguration configuration)
        {
            _mailSetting = mailSetting.Value;
            _configuration = configuration;
        }



        public async Task<IResponse<DtoUser>> SendEmailAsync(DtoUser mailRequest)
        {
            try
            {
                var email = new MimeMessage();
                email.Sender = MailboxAddress.Parse(_configuration["EmailSetting:Mail"]);
                email.To.Add(MailboxAddress.Parse(mailRequest.Email));
                email.Subject = "Yeni Personel Kaydı";
                var builder = new BodyBuilder();

                Random random = new Random();
                int randomNumber = random.Next(100000, 999999);

                byte[] data = Encoding.UTF8.GetBytes(randomNumber.ToString());
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_configuration["PasswordHash:Hash"]));
                    using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripleDES.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        mailRequest.Password = Convert.ToBase64String(results, 0, results.Length);
                    }
                };


                builder.HtmlBody = "Your Password : " + randomNumber;
                email.Body = builder.ToMessageBody();
                using var smtp = new SmtpClient();
                smtp.Connect(_mailSetting.Host, _mailSetting.Port, SecureSocketOptions.StartTls);
                smtp.Authenticate(_configuration["EmailSetting:Mail"], _configuration["EmailSetting:Password"]);

                var result = await smtp.SendAsync(email);
                smtp.Disconnect(true);

                return new Response<DtoUser>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = mailRequest
                };

            }
            catch (Exception ex)
            {
                return new Response<DtoUser>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        
    }
}
