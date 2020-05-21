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
        public string RecievedAmount { get; set; }
        public string CreatedByFullname { get; set; }
        public string CreatedDate { get; set; }
    }
}
