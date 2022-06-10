using System.Windows.Forms;

namespace lab3fix
{
    public partial class Work : Form
    {
        public Work()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, System.EventArgs e)
        {
            WorkAdd newForm = new WorkAdd();
            newForm.Show();
        }

        private void Button4_Click(object sender, System.EventArgs e)
        {
            WorkEdit newForm = new WorkEdit();
            newForm.Show();
        }
    }
}
