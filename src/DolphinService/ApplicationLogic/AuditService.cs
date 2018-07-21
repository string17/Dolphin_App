﻿using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DolphinService.ApplicationLogic
{
    public class AuditService:BaseService
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        
        public string DetermineIPAddress()
        {
            return HttpContext.Current.Request.UserHostAddress;
        }

        public string DetermineCompName(string IP)
        {
            List<string> compName = null;
            string ocompName = "";
            try
            {
                IPAddress myIP = IPAddress.Parse(IP);
                IPHostEntry GetIPHost = Dns.GetHostEntry(myIP);
                compName = GetIPHost.HostName.ToString().Split('.').ToList();
                ocompName = compName.First();

            }
            catch (Exception ex)
            {
                log.WarnFormat("retrieval of DNS entry for {0} failed", IP,ex);
                ocompName = IP;
            }

            return ocompName;
        }


        public string GetMacAddress()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration where IPEnabled=true");
            IEnumerable<ManagementObject> objects = searcher.Get().Cast<ManagementObject>();
            string mac = (from o in objects orderby o["IPConnectionMetric"] select o["MACAddress"].ToString()).FirstOrDefault();
            return mac;
        }

    }
}
