using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifaClinic.POCO
{
    public class BillProcedureDetail
    {
		public int billProcedureId { get; set; }
		public int procedureId { get; set; }
		public double actualPrice { get; set; }
		public string discount { get; set; }
		public double discountRate { get; set; }
		
		
		public int Id { get; set; }
		public double Price { get; set; }
		public int DoctorId { get; set; }
		public string DoctorName { get; set; }
		public string ProcedureTitle { get; set; }
		public bool isReturnFiled { get; set; }
	}
}
