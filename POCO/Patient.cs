using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifaClinic.POCO
{
    public class Patient
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string mobileNumber { get; set; }
        public string gender { get; set; }
        public string CNIC { get; set; }
        public string bloodGroup { get; set; }
    }
}
