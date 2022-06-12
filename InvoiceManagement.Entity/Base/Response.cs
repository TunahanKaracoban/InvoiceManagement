using InvoiceManagement.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Entity.Base
{
    public class Response:IResponse
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public object Data { get; set; }
    }
    public class Response<T> : IResponse<T>
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public object Data { get; set; }
    }
}
