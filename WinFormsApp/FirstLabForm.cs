using VisualControlLibrary;

namespace WinFormsApp
{
    public partial class FirstLabForm : Form
    {
        //���� ��� ������ � ��������.
        private readonly ChoiseListControl list;
        private readonly List<string> items = new() { "�������� 1", "�������� 2", "�������� 3", "�������� 4", "�������� 5", "�������� 6" };

        //���� ��� ����.
        private readonly DataTimePickerControl dataTimePicker;

        //���� ��� ������.
        private readonly TreeViewControl tree;
        private readonly List<Example> objects = new() { new Example { Id = 1, Name = "������", Profession = "�������", Division = "����������� 1"},
            new Example { Id = 2, Name = "������", Profession = "�������", Division = "����������� 1"},
            new Example { Id = 3, Name = "�������", Profession = "������������", Division = "����������� 1"},
            new Example { Id = 4, Name = "�������", Profession = "���������", Division = "�����������"},
            new Example { Id = 5, Name = "�������", Profession = "��. ���������", Division = "�����������"},
            new Example { Id = 5, Name = "��������", Profession = "���������", Division = "�����������"} };
        private readonly List<string> hierarchy = new() { "Division", "Profession", "Name" };

        public FirstLabForm()
        {
            InitializeComponent();

            //������ � �������. ������ ����������� ����� �����, ���������� ������ �����.
            list = new()
            {
                Location = new Point(25, 50),
                Size = new Size(200, 275)
            };

            //���� ��� ���������� ���� � ���������, ��� ���� ��������� � ������������ ���������.
            dataTimePicker = new()
            {
                Location = new Point(250, 50),
                Size = new Size(200, 55),
                From = new DateTime(2022, 9, 20),
                To = new DateTime(2022, 9, 22),
            };

            //������ ��������. ������ ����������� ����� �����, ���������� ������ ��������.
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

        //������ ��� ������ � �������.
        private void ButtonFillList_Click(object sender, EventArgs e) => list.FillList(items);
        private void ButtonClearList_Click(object sender, EventArgs e) => list.ClearList();
        private void ButtonGetItem_Click(object sender, EventArgs e) => textBoxSelectedItem.Text = list.SelectedItem;
        private void ButtonSetItem_Click(object sender, EventArgs e) => list.SelectedItem = textBoxNewItem.Text;
        //������ ��� ����.
        private void ButtonGetDate_Click(object sender, EventArgs e) => textBoxDate.Text = dataTimePicker.Date.ToString();
        //������ ��� ������.
        private void ButtonObject_Click(object sender, EventArgs e) => textBoxObject.Text = tree.ToStr(tree.GetSelectedObject(objects));
        private void ButtonGetIndex_Click(object sender, EventArgs e) => textBoxGetIndex.Text = tree.Index.ToString();
        private void ButtonSetIndex_Click(object sender, EventArgs e) => tree.Index = Convert.ToInt32(textBoxSetIndex.Text);
    }
}