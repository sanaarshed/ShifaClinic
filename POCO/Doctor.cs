using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifaClinic.POCO
{
    public class Doctor
    {
        public int id { get; set; }
        public string name { get; set; }
        public int mobileNumber { get; set; }
        public string departmentTitle { get; set; }
        public string gender { get; set; }
        public int fee { get; set; }
        public int share { get; set; }
        public int licenseNumber { get; set; }
        public int age { get; set; }
        public string Address { get; set; }
        public int backupPhone { get; set; }
        public int CNIC { get; set; }

    }
}
