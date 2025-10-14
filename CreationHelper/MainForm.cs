namespace CreationHelper
{
    public partial class MainForm : Form
    {
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
    }
}
