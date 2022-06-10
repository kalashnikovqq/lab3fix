using System;
using System.Windows.Forms;

namespace lab3fix
{
    public partial class Type : Form
    {
        public Type()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TypeAdd newForm = new TypeAdd();
            newForm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TypeEdit newForm = new TypeEdit();
            newForm.Show();
        }
    }
}
