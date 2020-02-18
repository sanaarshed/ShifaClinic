using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifaClinic.POCO
{
    class PatientInvoice
    {
        public int patientId { get; set; }
        public int patientName { get; set; }
        public int dob { get; set; }
        public int customerType { get; set; }
        public int weight{ get; set; }
        public int height{ get; set; }
        public int gender{ get; set; }
        public int catagory{ get; set; }
        public int doctor{ get; set; }
        public int fee{ get; set; }
        public int tokenNumber{ get; set; }
        public int gross { get; set; }
        public int discount { get; set; }
        public int billAmount{ get; set; }
        public int paid{ get; set; }
        public int balance{ get; set; }
        public int remarks{ get; set; }
        
    }
}
