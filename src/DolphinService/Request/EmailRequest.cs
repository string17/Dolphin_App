﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolphinService.Request
{
    public class EmailRequest
    {
        public string EmailAddress { get; set; }
        public string FromEmail { get; set; }
        public string Message { get; set; }
    }
}
