using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifaClinic.Common
{
    public static class Utility
    {
        public static Int32 GetAge(this DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }

        public static void onlyAllowNumericValue(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                    !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                (sender as TextBox).Text = "0";
                (sender as TextBox).SelectAll();
            }
        }
        public static void validate()
        {

            //bool _result = false;
            //formError.Clear();
            //if (string.IsNullOrEmpty(txtPatientName.Text))
            //{
            //    this.formError.SetError(txtPatientName, "this field is required");
            //}
            //else
            //{
            //    this.formError.SetError(txtPatientName, "");
            //}
            //return _result;

        }

        public static System.Data.DataTable MapToDataTable<T>(T classObject) where T : class
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                dt.TableName = "localTableName";

                foreach (System.Reflection.PropertyInfo property in classObject.GetType().GetProperties())
                {
                    if (property.PropertyType == typeof(List<string>))
                        dt.Columns.Add(new System.Data.DataColumn(property.Name, typeof(string)));
                    else
                        dt.Columns.Add(new System.Data.DataColumn(property.Name, property.PropertyType));
                }
                

                System.Data.DataRow newRow = dt.NewRow();
                foreach (System.Reflection.PropertyInfo property in classObject.GetType().GetProperties())
                {
                    newRow[property.Name] = classObject.GetType().GetProperty(property.Name).GetValue(classObject, null);
                }

                
                dt.Rows.Add(newRow);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
