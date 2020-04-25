using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifaClinic.DataContext
{
    public partial class Patient
    {
        [NotMapped]
        public string GenderText
        {
            get
            {
                return this.gender.HasValue && this.gender.Value ? "Male" : "Female";
            }
        }
    }
}
