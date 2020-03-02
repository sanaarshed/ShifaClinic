using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifaClinic.POCO
{
    public class BillDetail
    {
        public string title { get; set; }
        //public String doctorName { get; set; }
        public bool visitType { get; set; }
        public int id { get; set; }
        public int fees { get; set; }
        //public int serviceCharges { get; set; }

    }
}
