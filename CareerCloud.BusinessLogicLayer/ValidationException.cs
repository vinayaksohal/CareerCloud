using System;
using System.Collections.Generic;
using System.Text;

namespace CareerCloud.BusinessLogicLayer
{
    public class ValidationException: Exception
    {
        public int Code { get; set; }
        public ValidationException(int Code,string message):base(message)
        {
            this.Code = Code;
        }
    }
}
