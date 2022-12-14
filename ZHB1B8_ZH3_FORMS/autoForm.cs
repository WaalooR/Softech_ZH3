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
    public partial class autoForm : Form
    {
        public autoForm()
        {
            InitializeComponent();
        }
        private void autoForm_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            autoUserControl uc = new autoUserControl();
            uc.Dock = DockStyle.Fill;

            panelMain.Controls.Add(uc);
        }
        private static void kilepes(FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Biztos benne, hogy bezárja az ablakot?", "Kilépés", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) e.Cancel = true;
            else return;
        }
        private void autoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            kilepes(e);
        }
    }
}
