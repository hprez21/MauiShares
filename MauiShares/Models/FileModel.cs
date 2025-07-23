using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiShares.Models
{

    public class FileModel
    {
        public bool success { get; set; }
        public int status { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public DateTime expires { get; set; }
        public string expiry { get; set; }
        public int downloads { get; set; }
        public int maxDownloads { get; set; }
        public bool autoDelete { get; set; }
        public int size { get; set; }
        public string mimeType { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
    }

}
