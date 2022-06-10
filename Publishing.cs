using System.Windows.Forms;

namespace lab3fix
{
    public partial class Publishing : Form
    {
        public Publishing()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, System.EventArgs e)
        {
            PublishingAdd newForm = new PublishingAdd();
            newForm.Show();
        }

        private void Button4_Click(object sender, System.EventArgs e)
        {
            PublishingEdit newForm = new PublishingEdit();
            newForm.Show();
        }
    }
}
