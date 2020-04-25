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
    public class dsDailyDoctorBookClose
    {
        public string RecieverFullname { get; set; }
        public double RecievedAmount { get; set; }
        public string ConsultancyPercentage { get; set; }
        public string ConsultancyTotalVisits { get; set; }
        public string ConsultancyIncome { get; set; }
        public string MiscellaneousPercentage { get; set; }
        public string MiscellaneousIncome { get; set; }
        public string CreatedByFullname { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
