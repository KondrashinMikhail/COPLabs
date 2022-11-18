using InternetStoreBusinessLogic.BusinessLogics;
using InternetStoreContracts.BusinessLogicsContracts;
using InternetStoreContracts.ViewModels;
using InternetStoreDatabaseImplement.Models;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using PluginsConvention;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualComponents;

namespace WinForms
{
    public partial class OrderForm : Form
    {
        private readonly UserControlTextBox textBoxEmail;
        private bool DataChanged;
        private readonly IOrderLogic _orderLogic;
        private readonly IProductLogic _productLogic;

        public int Id { set { id = value; } }
        private int? id;

        private string[] products = new string[10];

        public OrderForm(IOrderLogic orderLogic, IProductLogic productLogic)
        {
            InitializeComponent();
            textBoxEmail = new()
            {
                Location = new Point(161, 67),
                Size = new Size(200, 300),
                Pattern = new Regex("")
            };

            _orderLogic = orderLogic;
            _productLogic = productLogic;

            DataChanged = false;
            textBox1.TextChanged += DataChange;
            textBoxEmail.SetChangeValueEvent += DataChange;
            
            List<ProductViewModel> allProducts = _productLogic.Read(null);
            if (allProducts != null)
            {
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
                comboBox1.DataSource = allProducts;
                comboBox1.SelectedItem = null;
            }

            dataGridView1.Columns.Add("Product Name", "Product Name");

        }

        private void LoadData() 
        {
            //dataGridView1.DataSource = products;
            dataGridView1.Rows.Clear();
            foreach (var product in products) 
            {
                dataGridView1.Rows.Add(product);
            }
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonSave_Click(object sender, EventArgs e) => Save();

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (DataChanged)
                if (MessageBox.Show("Сохранить изменения перед закрытием?", "Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Save();
            Close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            Controls.Add(textBoxEmail);

            if (id != null) 
            {
                try
                {
                    var order = _orderLogic.Read(new InternetStoreContracts.BindingModels.OrderBindingModel { Id = id })?[0];
                    products = order.Products;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(products);

                    textBox1.Text = order.CustomerName;

                    string str = "";
                    foreach (var path in order.Photos)
                        str += path + " ";
                    textBoxPhotoPaths.Text = str;

                    textBoxEmail.Text = order.CustomerEmail;
                    textBoxEmail.Content = textBoxEmail.Text;
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //dataGridView1.Columns.Add("Product Name", "Product Name");
            LoadData();
        }

        private void DataChange(object sender, EventArgs e) => DataChanged = true;

        private void Save()
        {
            textBoxEmail.Pattern = new Regex("[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}");
            if (textBox1.Text == "")
                MessageBox.Show("Вы не заполнили поле с именем", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            try
            {
                string[] photoPaths = textBoxPhotoPaths.Text.Split(" ");
                if (id != null) 
                    _orderLogic.CreateOrUpdate(new InternetStoreContracts.BindingModels.OrderBindingModel
                    {
                        Id = id,
                        CustomerName = textBox1.Text,
                        CustomerEmail = textBoxEmail.Content,
                        Photo = photoPaths,
                        Products = products
                    });
                else 
               
                    _orderLogic.CreateOrUpdate(new InternetStoreContracts.BindingModels.OrderBindingModel
                    {
                        CustomerName = textBox1.Text,
                        CustomerEmail = textBoxEmail.Content,
                        Photo = photoPaths,
                        Products = products
                    });
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < products.Length; i++)
                if (products[i] == null)
                {
                    products[i] = comboBox1.Text;
                    break;
                }

            LoadData();
            //dataGridView1.Rows.Clear();
            //dataGridView1.Rows.Add(products);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        for (int i = 0; i < products.Length; i++)
                            if (products[i] == (dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
                                products[i].Remove(i);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            LoadData();
            //dataGridView1.DataSource = products;
            //dataGridView1.Rows.Clear();
            //dataGridView1.Rows.Add(products);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    textBoxPhotoPaths.Text = textBoxPhotoPaths.Text + " " + dialog.FileName;
                else
                    MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
