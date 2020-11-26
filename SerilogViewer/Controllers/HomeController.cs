using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SerilogViewer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger logger;
        public HomeController()
        {
            logger = Common.GetLogger<HomeController>();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public int SomeTask()
        {
            try
            {
                var type = (100*10) - 1000;
                var val = 10;
                return val / type;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error occured in SomeTask");
                throw;
            }
        }
    }
}