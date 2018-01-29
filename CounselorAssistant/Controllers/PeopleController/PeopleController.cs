using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CounselorAssistant.Models;

namespace CounselorAssistant.Controllers.PeopleController
{
    public class PeopleController : Controller
    {
        private AssistantContext DB = new AssistantContext();
        // GET: People
        public ActionResult Index()
        {
            return View();      
        }
    }
}