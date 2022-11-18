using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private List<string> fields;

        public void ConfigureGrid(List<GridColumnConfig> columns)
        {
            if (columns == null)
            {
                throw new Exception("Входной список не имеет значения. Проверьте данные для списка!");
            }
            if (columns.Count < 0)
            {
                throw new Exception("Входной список пуст. Проверьте данные для списка!");
            }
            fields = new List<string>();
            foreach (var column in columns)
            {
                var columnToAdd = new DataGridViewTextBoxColumn
                {
                    Name = column.FieldName,
                    ReadOnly = true,
                    HeaderText = column.Header,
                    Visible = column.Visible,
                    Width = column.Width
                };
                fields.Add(column.FieldName);
                dataGridView.Columns.Add(columnToAdd);
            }
        }

        public void InsertData<T>(List<T> data)
        {
            foreach (var elem in data)
            {
                var objs = new List<object>();
                foreach (var conf in fields)
                {
                    var value = elem.GetType().GetProperty(conf).GetValue(elem);
                    objs.Add(value);
                }
                dataGridView.Rows.Add(objs.ToArray());
            }
        }

        public object GetObjByIndex<T>(int index)
        {
            if (index <= dataGridView.Rows.Count)
            {
                DataGridViewRow curRow = dataGridView.Rows[index];
                Type myType = typeof(T);
                object ret = myType.GetConstructor(new Type[] { }).Invoke(new object[] { });
                for (int i = 0; i < fields.Count; i++)
                {
                    var field = fields[i];
                    var fieldInType = myType.GetProperty(field, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                    fieldInType?.SetValue(ret, curRow.Cells[i].Value);
                }
                return ret;
            }
            return null;
        }

        public void Clear()
        {
            dataGridView.Rows.Clear();
        }

        public int CurrentIndex
        {
            get
            {
                if (dataGridView.SelectedRows.Count > 0) return dataGridView.SelectedRows[0].Index;
                return -1;
            }
            set
            {
                if (value <= dataGridView.Rows.Count)
                {
                    dataGridView.Rows[value].Selected = true;
                }
            }
        }
    }
}
