using _1st_lab_kop;
using _2nd_lab_kop;
using ControlLibrary;
using InternetStoreBusinessLogic.BusinessLogics;
using InternetStoreContracts.BindingModels;
using InternetStoreContracts.BusinessLogicsContracts;
using InternetStoreContracts.ViewModels;
using NonVisualComponentLibriary;
using NonVisualComponents.models;
using PluginsConvention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using UnvisualComponents;
using WinFormsApp;

namespace WinForms.Plugins
{
    public class AppPluginConvention : IPluginsConvention
    {
        private readonly IOrderLogic _orderLogic;
        private readonly IProductLogic _productLogic;

        private UserControl1 dataGridView = new UserControl1();

        public string PluginName => "Orders";

        public UserControl GetControl => dataGridView;
        public PluginsConventionElement GetElement => (PluginsConventionElement) dataGridView.GetObjByIndex<OrderConvensionElement>(dataGridView.CurrentIndex);

        public AppPluginConvention(IOrderLogic orderLogic, IProductLogic productLogic)
        {
            _orderLogic = orderLogic;
            _productLogic = productLogic;
        }

        public Form GetForm(PluginsConventionElement? element)
        {
            OrderForm orderForm = Program.Container.Resolve<OrderForm>();
            if (element != null) orderForm.Id = element.Id;
            return orderForm;
        }

        public bool DeleteElement(PluginsConventionElement element)
        {
            try
            {
                _orderLogic.Delete(new OrderBindingModel() { Id = element.Id });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void ReloadData()
        {
            List<GridColumnConfig> configs = new List<GridColumnConfig>();

            configs.Add(new GridColumnConfig { Header = "Id", FieldName = "Id", Visible = false, Width = 1 });
            configs.Add(new GridColumnConfig { Header = "Имя заказчика", FieldName = "CustomerName", Visible = true, Width = 243 });
            configs.Add(new GridColumnConfig { Header = "Почта заказчика", FieldName = "CustomerEmail", Visible = true, Width = 245 });

            var data = _orderLogic.Read(null);
            dataGridView.Clear();
            dataGridView.ConfigureGrid(configs);
            dataGridView.InsertData(data);
            dataGridView.Refresh();
        }

        public bool CreateSimpleDocument(PluginsConventionSaveDocument saveDocument)
        {
            DocumentWithContext dcwc = new DocumentWithContext();

            FileInfo[] fileInfo = new FileInfo[(_orderLogic.Read(null).Count * 10)];

            foreach (var order in _orderLogic.Read(null))
                foreach (var photo in order.Photos)
                    if (photo != "")
                        for (int i = 0; i < fileInfo.Length; i++)
                            if (fileInfo[i] == null)
                            {
                                fileInfo[i] = new FileInfo(photo);
                                break;
                            }

            dcwc.SaveImagesToExcel(saveDocument.FileName, "Header", fileInfo);
            return true;
        }

        public bool CreateTableDocument(PluginsConventionSaveDocument saveDocument)
        {
            TableDocument<OrderModel> tableDocument = new TableDocument<OrderModel>();

            List<OrderModel> orders = new();

            foreach (var order in _orderLogic.Read(null)) 
            {
                string str = "";

                foreach (var product in order.Products) 
                    str += product + " ";

                orders.Add(new OrderModel
                {
                    Id = order.Id, 
                    CustomerName = order.CustomerName,
                    CustomerEmail = order.CustomerEmail,
                    Products = str
                });
            }

            List<CellInfo> keyValues = new List<CellInfo>
            {
                new CellInfo("Личные данные", 1, 2),
                new CellInfo("Выбранный товар", 3),
                new CellInfo("Id", 4),
                new CellInfo("ФИО заказчика", 5),
                new CellInfo("Email заказчика", 6)
            };
            tableDocument.CreateTableDocument(saveDocument.FileName,
                "title",
                keyValues,
                new int[] { 200, 200, 200, 500 },
                new string[] { "Id", "CustomerName", "CustomerEmail", "Products" },
                orders.ToArray());
            return true;
        }

        public bool CreateChartDocument(PluginsConventionSaveDocument saveDocument)
        {
            SavePdfWithPlot pdfwPlot = new SavePdfWithPlot();

            double[] doubles = new double[_productLogic.Read(null).Count];
            int i = 0;

            foreach (var product in _productLogic.Read(null)) 
            {
                foreach (var order in _orderLogic.Read(null)) 
                    if (order.Products.Contains(product.Name))
                        doubles[i]++;
                i++;
            }
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            pdfwPlot.CreatePdf(saveDocument.FileName, "Header", "Histogramm", LegendPostion.Left, "Serie 1", doubles);
            return true;
        }
    }
}
