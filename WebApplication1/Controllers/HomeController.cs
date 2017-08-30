using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       public ActionResult ProductsList()
        {
            return View();
        }

        public ActionResult DownloadFile()
        {
            string filepath = Server.MapPath("/Content/ForDownload.pdf");
            string contentType = "application/pdf";
            string downloadName = "PDF File";
            downloadName = null;
            return File(filepath, contentType, downloadName);
        }

      
    }
}