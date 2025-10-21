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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string[] person_strings = txtPerson.Text.Split('\n');
            string[] context_strings = txtContext.Text.Split('\n');

            for (int i = 0; i < person_strings.Length; i++)
            {
                persons.Add(new Person(person_strings[i]));
            }

            for (int i = 0; i < context_strings.Length; i++)
            {
                contexts.Add(new Context(context_strings[i]));
            }

            MessageBox.Show(persons.LastOrDefault().Person_Definition + " " + contexts.LastOrDefault().Context_Definition);            
        }
    }
}
