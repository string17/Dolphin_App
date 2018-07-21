using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolphinService.Request
{
    public class IncidentLogRequest
    {
        public int IncidentId { get; set; }
        public string TerminalNo { get; set; }
        public string IncidentTitle { get; set; }
        public string IncidentDesc { get; set; }
        public string IncidentPriority { get; set; }
        public string LoggedBy { get; set; }
        public DateTime LoggedOn { get; set; }
    }
}
