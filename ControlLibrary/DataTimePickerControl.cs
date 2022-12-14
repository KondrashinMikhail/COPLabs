using System;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class DataTimePickerControl : UserControl
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        
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
                if (From != null && To != null)
                {
                    if (value > To || value < From)
                        TextErrorValue = "Date is out of bounds";
                    else
                        dateTimePicker.Value = (DateTime)value;
                }
                else 
                    TextErrorValue = "'From' or 'To' are null";
            }
            get 
            {
                if (From != null && To != null)
                {
                    if (dateTimePicker.Value > To || dateTimePicker.Value < From)
                    {
                        TextErrorValue = "Date is out of bounds";
                        return null;
                    }
                    else
                        return dateTimePicker.Value;
                }
                else 
                    return null;
            }
        }

        public void AddListener(EventHandler handler) => dateTimePicker.ValueChanged += handler;
    }
}
