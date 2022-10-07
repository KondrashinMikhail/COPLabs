using NonVisualComponentLibriary;
using WinFormsApp;

namespace WinForms
{
    public partial class SecondLabForm : Form
    {
        private readonly DocumentWithContext documentWithContext = new();
        private readonly DocumentWithDiagram documentWithDiagram = new();
        private readonly DocumentWithTable documentWithTable = new();

        private readonly List<Example> objects = new()
        {
            new Example { Id = 1, Status = false, Name = "Иван", Surname = "Иванов", Age = 34, hasChildren = false, hasCar = true, Profession = "Инженер", Division = "Департамент 1", Expirience = 6, Prize = 2000.1 },
            new Example { Id = 2, Status = false, Name = "Петр", Surname = "Петров", Age = 44, hasChildren = true, hasCar = true, Profession = "Инженер", Division = "Департамент 1", Expirience = 12, Prize = 2000.1 },
            new Example { Id = 3, Status = true, Name = "Сергей", Surname = "Сергеев", Age = 55, hasChildren = false, hasCar = true, Profession = "Руководитель", Division = "Департамент 1", Expirience = 34, Prize = 5000.5 },
            new Example { Id = 4, Status = false, Name = "Ольга", Surname = "Иванова", Age = 34, hasChildren = true, hasCar = false, Profession = "Бухгалтер", Division = "Бухгалтерия", Expirience = 8, Prize = 2000.1 },
            new Example { Id = 5, Status = true, Name = "Татьяна", Surname = "Петрова", Age = 44, hasChildren = false, hasCar = false, Profession = "Ст. бухгалтер", Division = "Бухгалтерия", Expirience = 14, Prize = 2000.6 }
        };

        private readonly Dictionary<string, List<string>> mergingCells = new() {
                { "Личные данные", new List<string>() { "Name", "Surname", "Age" } },
                { "Работа", new List<string>() { "Profession", "Division" } }
        };

        public SecondLabForm() => InitializeComponent();

        private void ButtonDocumentWithImages_Click(object sender, EventArgs e) => documentWithContext.SaveImagesToExcel("D:/Images.xlsx", "Images", new FileInfo[] { new FileInfo("D:/TrainingField.png"), new FileInfo("D:/HokageRock.jpg") });
        private void ButtonDocumentWithTable_Click(object sender, EventArgs e) => documentWithTable.CreateTableExcel("D:/Table.xlsx", objects, mergingCells, new Dictionary<int, int>() { { 1, 100 }, { 5, 100 } }, "Table", new List<string>() { "Id", "Status", "Name", "Surname", "hasChildren", "hasCar", "Profession", "Division", "Prize" });
        private void ButtonDocumentWithDiagrams_Click(object sender, EventArgs e) => documentWithDiagram.CreateCircleDiagrammExcel("D:/Diagram.xlsx", "Diagram", "diagram", new Dictionary<string, int>() { { "value 1", 1 }, { "value 2", 4 }, { "value 3", 2 }, { "value 4", 5 }, { "value 5", 3 } }, LegendPosition.Bottom);
    }
}
