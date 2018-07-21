using DolphinService.ApplicationLogic;
using DolphinService.Common;
using DolphinService.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DolphinWeb.Controllers
{
    public class IncidentController : Controller
    {
        private readonly Infrastructure _dolphinApi;
        private readonly AuditService _auditService;
        private readonly EncodingCharacters _encodingService;
        private readonly UploadAttachment _uploadFile;
        private static string ipaddress = new AuditService().DetermineIPAddress();
        private readonly string ComputerDetails = new AuditService().DetermineCompName(ipaddress);

        public IncidentController()
        {
            _dolphinApi = new Infrastructure();
            _auditService = new AuditService();
            _encodingService = new EncodingCharacters();
            _uploadFile = new UploadAttachment();
        }

        // GET: Incident
        public ActionResult NewIncident()
        {
            ViewBag.Message = "Incident";
            return View();
        }

        [HttpPost]
        public ActionResult NewIncident(IncidentLogRequest request)
        {
            ViewBag.Message = "Incident";
            try
            {
                var result = _dolphinApi;
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMsg = ex.Message;
            }
            return View();
        }
    }
}