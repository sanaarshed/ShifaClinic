using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using ShifaClinic.DataContext;

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
            //using (var db = new clinicDbContext())
            //{
                // For insert record, create new object of model, add to collection into db.<T>.add(). Then db.savechanges
                //var docDept = new DoctorDepartment()
                //{
                //    title = "Pathology",
                //    createdBy = 1,
                //    createDate = DateTime.Now
                //};
                //db.DoctorDepartments.Add(docDept);
                //db.SaveChanges();


                // For update record, first find the record then update properties and db.savechanges
                //var docDept = db.DoctorDepartments.Where(p => p.id == 1).FirstOrDefault();
                //if (docDept != null)
                //{
                //    docDept.title += " -- Updated";
                //    db.SaveChanges();
                //}


                // For deletion of record in db, find the record remove the object and save changes
                //var docDept = db.DoctorDepartments.Where(c => c.title.Equals("Pathology")).FirstOrDefault();
                //if (docDept != null) {
                //    db.DoctorDepartments.Remove(docDept);
                //    db.SaveChanges();
                //}

                // SELECTION
                //var d = db.DoctorDepartments.Where(c => c.title.Equals("Pediatrician")).FirstOrDefault();
                //var u = db.Users.Where(c => c.id == 1).FirstOrDefault();
                //var doc = db.Doctors.Where(c => c.departmentId == d.id).ToList()

            //}
            //return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Patient.InvoiceForm());
        }
    }
}
