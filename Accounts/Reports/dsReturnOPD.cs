using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifaClinic.Reports.Poco
{
    [Serializable]
    public class dsReturnOPD
    {
        public string RecieptNumber { get; set; }
        public string CopyStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedByFullname { get; set; }
        public string BillNumber { get; set; }
        public string PaymentMode { get; set; }
        public string DetailId { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public string serviceTitle { get; set; }
        public string DoctorName { get; set; }
        public string Amount { get; set;  }
    }
}
