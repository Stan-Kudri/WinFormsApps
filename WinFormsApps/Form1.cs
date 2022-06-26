namespace WinFormsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToString("dd MMMM yyyy HH:MM:ss");
            MessageBox.Show($"Дата на это время: {time}");
        }
    }
}