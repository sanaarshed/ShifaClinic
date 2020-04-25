using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShifaClinic.Accounts;
using ShifaClinic.DataContext;
using ShifaClinic.Patient;
using ShifaClinic.POCO;
using ShifaClinic.Session;

namespace ShifaClinic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Session.frmDashboardForm());
            //Application.Run(new frmPatientInvoiceForm());
            //Application.Run(new frmDailyCashBookClose());
            //Application.Run(new frmDailyCashBookClose());
            //Application.Run(new frmEntryForm());
            //Application.Run(new frmClosingBookForm());
            //Application.Run(new Accounts.frmBill());
            //Application.Run(new Accounts.frmReturnServiceOPD());
            //Application.Run(new Accounts.frmReturnServiceConsultant());
            //Application.Run(new Accounts.frmReturnServices());
            //Application.Run(new Accounts.frmProcedureBill());
            //Application.Run(new Accounts.frmReturnProcedures());
            //Application.Run(new Doctors.frmDoctor());
        }
    }
}
