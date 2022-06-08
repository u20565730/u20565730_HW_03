using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using u20565730_HMWK03.Models;

namespace u20565730_HMWK03.Controllers
{
    public class HomeController : Controller
    {
        public string FileRadio;
        public ActionResult Index()
        {
            return View();
        }

        public string RetrieveFileType(FormCollection x)
        {
            FileRadio = x["FileType"].ToString();
            return FileRadio;
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
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase uploadedFile, FormCollection frm)
        {
            FileRadio = frm["FileType"].ToString();
            string fileName = Path.GetFileName(uploadedFile.FileName);
            string FilePath = Path.Combine(Server.MapPath("~/Media/" + FileRadio), fileName);
            uploadedFile.SaveAs(FilePath);
            return RedirectToAction("Index");
        }
    }
}
  

