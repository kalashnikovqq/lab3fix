using System;
using System.Windows.Forms;

namespace lab3fix
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void АвторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authors newForm = new Authors();
            newForm.Show();
        }

        private void УчёныеСтепениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Degree newForm = new Degree();
            newForm.Show();
        }

        private void ИздательстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publishing newForm = new Publishing();
            newForm.Show();
        }

        private void ТипПубликацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type newForm = new Type();
            newForm.Show();
        }

        private void МестаРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Work newForm = new Work();
            newForm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MainAdd newForm = new MainAdd();
            newForm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MainEdit newForm = new MainEdit();
            newForm.Show();
        }
    }
}
