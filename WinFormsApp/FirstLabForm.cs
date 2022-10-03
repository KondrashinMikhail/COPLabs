using VisualControlLibrary;

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
        private readonly List<Example> objects = new() { new Example { Id = 1, Name = "Иванов", Profession = "Инженер", Division = "Департамент 1"},
            new Example { Id = 2, Name = "Петров", Profession = "Инженер", Division = "Департамент 1"},
            new Example { Id = 3, Name = "Сергеев", Profession = "Руководитель", Division = "Департамент 1"},
            new Example { Id = 4, Name = "Иванова", Profession = "Бухгалтер", Division = "Бухгалтерия"},
            new Example { Id = 5, Name = "Петрова", Profession = "Ст. бухгалтер", Division = "Бухгалтерия"},
            new Example { Id = 5, Name = "Сергеева", Profession = "Бухгалтер", Division = "Бухгалтерия"} };
        private readonly List<string> hierarchy = new() { "Division", "Profession", "Name" };

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

        private void Form1_Load(object sender, EventArgs e)
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