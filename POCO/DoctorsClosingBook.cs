using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifaClinic.POCO
{
    class DoctorsClosingBook
    {
        public int doctorId { get; set; }
        public string doctorName { get; set; }
        public double paidAmount { get; set; }
        public double totalAmount { get; set; }
    }
}
