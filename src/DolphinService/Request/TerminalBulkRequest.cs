﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolphinService.Request
{
    public class TerminalBulkRequest
    {
        public int TerminalId { get; set; }
        public string TerminalNo { get; set; }
        public string TerminalRef { get; set; }
        public string SerialNo { get; set; }
        public string RegionName { get; set; }
        public string ClientName { get; set; }
        public int ClientId { get; set; }
        public string BrandName { get; set; }
        public string Engineer { get; set; }
        public bool IsUnderSupport { get; set; }
        public bool IsTerminalActive { get; set; }
        public string Support { get; set; }
        public string Location { get; set; }
        public string TerminalAlias { get; set; }
        public int StateId { get; set; }
        public string State { get; set; }
        public int RegionId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string Computername { get; set; }
        public string SystemIp { get; set; }
    }
}
