using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ControlLibrary
{
    public partial class DataTimePickerControl : UserControl
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        
        public DataTimePickerControl() => InitializeComponent();
    
        public string TextErrorValue 
        {
            private set => textBox.Text = value;
            get 
            {
                return textBox.Text;
            }
        }

        public DateTime? Date
        {
            set
            {
                if (value > To || value < From)
                   TextErrorValue = "Date is out of bounds";
                else
                    dateTimePicker.Value = (DateTime) value; 
            }
            get 
            {
                if (dateTimePicker.Value > To || dateTimePicker.Value < From)
                {
                    TextErrorValue = "Date is out of bounds";
                    return null;
                }
                else
                    return dateTimePicker.Value;
            }
        }

        public void AddListener(EventHandler handler) => dateTimePicker.ValueChanged += handler;
        
    }
}
