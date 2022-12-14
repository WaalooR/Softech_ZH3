using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZHB1B8_ZH3_FORMS
{
    public partial class szerkesztoForm : Form
    {
        public szerkesztoForm()
        {
            InitializeComponent();
        }
        private void szerkesztoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            kilepes(e);
        }
        private static void kilepes(FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Biztos benne, hogy bezárja az ablakot?", "Kilépés", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) e.Cancel = true;
            else return;
        }
        private void szerkesztoForm_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            rendelesUserControl uc = new rendelesUserControl();
            uc.Dock = DockStyle.Fill;

            panelMain.Controls.Add(uc);
        }
    }
}
