using System;
using System.Windows.Forms;

namespace lab3fix
{
    public partial class Authors : Form
    {
        public Authors()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AuthorsAdd newForm = new AuthorsAdd();
            newForm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AuthorsEdit newForm = new AuthorsEdit();
            newForm.Show();
        }
    }
}
