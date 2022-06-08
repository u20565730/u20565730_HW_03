using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using u20565730_HMWK03.Models;

namespace u20565730_HMWK03.Controllers
{
    public class DocumentController : Controller
    {
        // GET: Document
        public ActionResult Document()
        {

            List<FileModel> FilesObj = new List<FileModel>();
            foreach (string strfile in Directory.GetFiles(Server.MapPath("~/Media/Document")))
            {
                FileInfo fileInfo = new FileInfo(strfile);
                FileModel obj = new FileModel();
                obj.FileName = fileInfo.Name;

                FilesObj.Add(obj);
            }

            return View(FilesObj);
        }
        public FileResult DownloadFile(string fileName)
        {
            string fullPath = Path.Combine(Server.MapPath("~/Media/Document"), fileName);
            byte [] fileBytes = System.IO.File.ReadAllBytes(fullPath);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);

        }
        public ActionResult DeleteFile (string fileName)
        {
            string fullPath = Path.Combine(Server.MapPath("~/Media/Document"), fileName);
            FileInfo file = new FileInfo(fullPath);
            System.IO.File.Delete(fileName);
            file.Delete();
            return RedirectToAction("Document");
        }
    }

}