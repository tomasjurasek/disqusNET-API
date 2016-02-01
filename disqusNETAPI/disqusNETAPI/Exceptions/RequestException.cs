using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.Exceptions
{
    public class RequestException : Exception
    {
        public RequestException(string message, int code) : base(message)
        {
            this.Code = code;
        }
        public int Code { get; set; }
    }

   
}
