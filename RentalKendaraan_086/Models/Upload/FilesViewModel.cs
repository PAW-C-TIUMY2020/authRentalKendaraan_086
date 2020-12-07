using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalKendaraan_086.Models.Upload
{
    public class FileDetails
    {
        public string name { get; set; }

        public string path { get; set; }
    }


    public class FilesViewModel
    {
        public List<FileDetails> Files { get; set; }
        = new List<FileDetails>();
    }
}


