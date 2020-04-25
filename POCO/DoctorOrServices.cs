using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifaClinic.POCO
{
    public class BillDetail
    {
        public int id { get; set; }
        public string title { get; set; }
        public int serviceId { get; set; }
        public int doctorId { get; set; }
        public string doctorName { get; set; }

        public int visitType { get; set; }
        public double price { get; set; }
        public double total { get; set; }

        public string discount { get; set; }
        public double discountRate { get; set; }


        //public int serviceCharges { get; set; }

    }
}
