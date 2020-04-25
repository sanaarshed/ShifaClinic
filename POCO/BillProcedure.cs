using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifaClinic.POCO
{
    public class BillProcedure
    {
		int id { get; set; }
		int billId { get; set; }
		int patientId { get; set; }
		double gross { get; set; }
		double discount { get; set; }
		double billAmount { get; set; }
		double paid { get; set; }
		double balance { get; set; }

	}
}
