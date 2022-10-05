using WinFormsApp;

namespace WinForms
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void ButtonFirstLab_Click(object sender, EventArgs e) => new FirstLabForm().ShowDialog();

        private void ButtonSecondLab_Click(object sender, EventArgs e) => new SecondLabForm().ShowDialog();
    }
}
