using System;
using System.Windows.Forms;

namespace lab3fix
{
    public partial class Degree : Form
    {
        public Degree()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DegreeAdd newForm = new DegreeAdd();
            newForm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DegreeEdit newForm = new DegreeEdit();
            newForm.Show();
        }
    }
}
