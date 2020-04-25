using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifaClinic.Reports.Poco
{
    /// <summary>
    /// POCO class for RDLC printing
    /// </summary>
    [Serializable]
    public class dsBillFormInvoice
    {
        public string BillID { get; set; }
        public string fullName { get; set; }
        public string mobileNumber { get; set; }
        public string age { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string bloodGroup { get; set; }
        public string bloodPressureUpper { get; set; }
        public string bloodPressureLower { get; set; }

        public string OPDDoctor { get; set; }
        public string OPDDoctorCredientials { get; set; }
        public string Consultant { get; set; }
        public string ConsultantCredientials { get; set; }

        public string CreatedByFullname { get; set; }
        public DateTime CreatedDate { get; set; }


        public List<string> ServiceTitle { get; set; }

        public string GetList()
        { return ""; }
    }
}
