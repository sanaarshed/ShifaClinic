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
        public string mobileNumber { get; set; }
        public string departmentTitle { get; set; }
        public string gender { get; set; }
        public string fee { get; set; }
        public string licenseNumber { get; set; }
        public string dob { get; set; }
        public string Address { get; set; }
        public string backupPhone { get; set; }
        public string CNIC { get; set; }

    }
}
