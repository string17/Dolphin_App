﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolphinService.Response
{
    public class UserMenuResponse
    {
        public string ResponseCode { get; set; }
        public  string ResponseMessage { get; set; }
        public  List<MenuDetailsObj> UserMenuDetails { get; set;}    
    }
}
