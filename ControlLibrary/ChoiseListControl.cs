using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualControlLibrary
{
    public partial class ChoiseListControl: UserControl
    {
        public ChoiseListControl() => InitializeComponent();

        public string SelectedItem
        {
            set 
            {
                if (checkedListBox.SelectedIndex > -1)
                    checkedListBox.Items[checkedListBox.SelectedIndex] = value;
            }
            get
            {
                if (checkedListBox.SelectedItem != null) 
                    return checkedListBox.SelectedItem.ToString();
                return "";
            }
        }

        public void ClearList() => checkedListBox.Items.Clear();

        public void FillList(List<string> items)
        {
            foreach (string item in items)
                checkedListBox.Items.Add(item);
        }

        public void AddListener(EventHandler handler) => checkedListBox.SelectedIndexChanged += handler;
    }
}
