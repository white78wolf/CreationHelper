namespace CreationHelper
{
    public partial class MainForm : Form
    {
        List<Person> persons = new List<Person>();
        List<Context> contexts = new List<Context>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void txtPerson_Enter(object sender, EventArgs e)
        {
            txtPerson.SelectionStart = txtPerson.Text.Length;
            txtPerson.SelectionLength = 0;
            txtPerson.ScrollToCaret();
        }

        private void txtContext_Enter(object sender, EventArgs e)
        {
            txtContext.SelectionStart = txtContext.Text.Length;
            txtContext.SelectionLength = 0;
            txtContext.ScrollToCaret();
        }

        private void txtPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                                
                string currentLine = txtPerson.Lines.Length > 0
                    ? txtPerson.Lines[txtPerson.Lines.Length - 1]
                    : string.Empty;
               
                MessageBox.Show($"Текущая строка: {currentLine}");                
            }
        }

        private void txtContext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string currentLine = txtContext.Lines.Length > 0
                    ? txtContext.Lines[txtContext.Lines.Length - 1]
                    : string.Empty;

                MessageBox.Show($"Текущая строка: {currentLine}");
            }
        }
    }
}
