using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalKendaraan_086.Models.Upload
{
    public class fileDetails
    {
        public string Name { get; set; }

        public string Path { get; set; }
    }


    public class filesViewModel
    {
        public List<FileDetails> files { get; set; }
        = new List<FileDetails>();
    }
}
