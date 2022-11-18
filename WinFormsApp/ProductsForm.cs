using InternetStoreContracts.BindingModels;
using InternetStoreContracts.BusinessLogicsContracts;
using InternetStoreContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class ProductsForm : Form
    {
        private readonly IProductLogic _productLogic;
        List<ProductViewModel> data;

        public ProductsForm(IProductLogic productLogic)
        {
            InitializeComponent();
            _productLogic = productLogic;
        }

        private void LoadData() 
        {
            try
            {
                data = _productLogic.Read(null);
                if (data != null)
                {
                    dataGridView1.DataSource = data;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var typeName = (string)dataGridView1.CurrentRow.Cells[1].Value;
            if (!string.IsNullOrEmpty(typeName))
            {
                if ((int)dataGridView1.CurrentRow.Cells[0].Value != 0)
                {
                    _productLogic.CreateOrUpdate(new ProductBindingModel()
                    {
                        Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                        Name = (string)dataGridView1.CurrentRow.Cells[1].EditedFormattedValue
                    });
                }
                else
                {
                    _productLogic.CreateOrUpdate(new ProductBindingModel()
                    {
                        Name = (string)dataGridView1.CurrentRow.Cells[1].EditedFormattedValue
                    });
                }
            }
            else
            {
                MessageBox.Show("Введена пустая строка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Insert)
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    data.Add(new ProductViewModel());
                    dataGridView1.DataSource = new List<ProductViewModel>(data);
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
                    return;
                }
                if (dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value != null)
                {
                    data.Add(new ProductViewModel());
                    dataGridView1.DataSource = new List<ProductViewModel>(data);
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
                    return;
                }
            }
            if (e.KeyData == Keys.Delete)
            {
                if (MessageBox.Show("Удалить выбранный элемент", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _productLogic.Delete(new ProductBindingModel() { Id = (int)dataGridView1.CurrentRow.Cells[0].Value });
                    LoadData();
                }
            }
        }

        private void ProductsForm_Load(object sender, EventArgs e) => LoadData();
    }
}
