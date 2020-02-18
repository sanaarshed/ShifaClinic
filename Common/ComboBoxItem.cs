using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifaClinic.Common
{
    public class ComboBoxItem
    {
        public object Value { get; set; }
        public string Text { get; set; }

        public ComboBoxItem() { }

        public ComboBoxItem(object value, string text)
        {
            this.Value = value;
            this.Text = text;
        }
    }
}
