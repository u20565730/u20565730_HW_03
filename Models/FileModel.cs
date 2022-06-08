using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace u20565730_HMWK03.Models
{
    public class FileModel
    {
        public IEnumerable<HttpPostedFileBase> Files { get; set; }

        public string FileName { get; set; }

        public string Type { get; set; }

        public string fType { get; set; }
    }
}