using ControlLibrary;
using NonVisualComponentLibriary;

namespace WinFormsApp
{
    public partial class FirstLabForm : Form
    {
        //Поля для списка с выблором.
        private readonly ChoiseListControl list;
        private readonly List<string> items = new() { "Значение 1", "Значение 2", "Значение 3", "Значение 4", "Значение 5", "Значение 6" };

        //Поля для даты.
        private readonly DataTimePickerControl dataTimePicker;

        //Поля для дерева.
        private readonly TreeViewControl tree;
        private readonly List<Example> objects = new() 
        {
            new Example 
            { 
                Id = 1, 
                Status = false, 
                Name = "Иван", 
                Surname = "Иванов", 
                Age = 34, 
                hasChildren = false, 
                hasCar = true, 
                Profession = "Инженер", 
                Division = "Департамент 1", 
                Expirience = 6, 
                Prize = 2000.1
            },
            new Example
            {
                Id = 2,
                Status = false,
                Name = "Петр",
                Surname = "Петров",
                Age = 44,
                hasChildren = true,
                hasCar = true,
                Profession = "Инженер",
                Division = "Департамент 1",
                Expirience = 12,
                Prize = 2000.1
            },
            new Example
            {
                Id = 3,
                Status = true,
                Name = "Сергей",
                Surname = "Сергеев",
                Age = 55,
                hasChildren = false,
                hasCar = true,
                Profession = "Руководитель",
                Division = "Департамент 1",
                Expirience = 34,
                Prize = 5000.5
            },
            new Example
            {
                Id = 4,
                Status = false,
                Name = "Ольга",
                Surname = "Иванова",
                Age = 34,
                hasChildren = true,
                hasCar = false,
                Profession = "Бухгалтер",
                Division = "Бухгалтерия",
                Expirience = 8,
                Prize = 2000.1
            },
            new Example
            {
                Id = 5,
                Status = true,
                Name = "Татьяна",
                Surname = "Петрова",
                Age = 44,
                hasChildren = false,
                hasCar = false,
                Profession = "Ст. бухгалтер",
                Division = "Бухгалтерия",
                Expirience = 14,
                Prize = 2000.6
            }
        };

        private readonly List<string> hierarchy = new() { "Division", "Profession", "Surname" };


        public FirstLabForm()
        {
            InitializeComponent();

            //Список с выбором. Список заполняется через метод, передающий список строк.
            list = new()
            {
                Location = new Point(25, 50),
                Size = new Size(200, 275)
            };

            //Поле для заполнения даты с проверкой, что дата находится в определенном диапазоне.
            dataTimePicker = new()
            {
                Location = new Point(250, 50),
                Size = new Size(200, 55),
                From = new DateTime(2022, 9, 20),
                To = new DateTime(2022, 9, 22),
            };

            //Дерево значений. Дерево заполняется через метод, передающий список объектов.
            tree = new(hierarchy)
            {
                Location = new Point(475, 50),
                Size = new Size(200, 275)
            };
        }

        private void FirstLabForm_Load(object sender, EventArgs e)
        {
            tree.RecursiveFill(tree.GetCollection(), objects);

            Controls.Add(list);
            Controls.Add(dataTimePicker);
            Controls.Add(tree);
        }

        //Кнопки для списка с выбором.
        private void ButtonFillList_Click(object sender, EventArgs e) => list.FillList(items);
        private void ButtonClearList_Click(object sender, EventArgs e) => list.ClearList();
        private void ButtonGetItem_Click(object sender, EventArgs e) => textBoxSelectedItem.Text = list.SelectedItem;
        private void ButtonSetItem_Click(object sender, EventArgs e) => list.SelectedItem = textBoxNewItem.Text;
        //Кнопки для даты.
        private void ButtonGetDate_Click(object sender, EventArgs e) => textBoxDate.Text = dataTimePicker.Date.ToString();
        //Кнопки для дерева.
        private void ButtonObject_Click(object sender, EventArgs e) => textBoxObject.Text = tree.ToStr(tree.GetSelectedObject(objects));
        private void ButtonGetIndex_Click(object sender, EventArgs e) => textBoxGetIndex.Text = tree.Index.ToString();
        private void ButtonSetIndex_Click(object sender, EventArgs e) => tree.Index = Convert.ToInt32(textBoxSetIndex.Text);

       
    }
}