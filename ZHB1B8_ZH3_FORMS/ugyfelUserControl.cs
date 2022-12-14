using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZHB1B8_ZH3_FORMS.Models;

namespace ZHB1B8_ZH3_FORMS
{
    public partial class ugyfelUserControl : UserControl
    {
        SoftechzhContext context = new SoftechzhContext();
        public ugyfelUserControl()
        {
            InitializeComponent();
        }
        void szurUgyfel()
        {
            var ugyfel = (from x in context.Ugyfel
                          where x.Nev.Contains(textBoxUgyfel.Text)
                          select x).ToList();

            listBoxUgyfel.DisplayMember = "Nev";
            listBoxUgyfel.DataSource = ugyfel;

            ugyfelBindingSource.DataSource = ugyfel.ToList();
        }
        void frissites()
        {
            var valasztott = (Ugyfel)listBoxUgyfel.SelectedItem;

            textBoxFullName.Text = valasztott.Nev.ToString();

            textBoxEmail.Text = valasztott.Email.ToString();

            dateTimePicker1RegDate.Value = valasztott.RegDatum.Value;
        }
        private void ugyfelUserControl_Load(object sender, EventArgs e)
        {
            szurUgyfel();
        }
        private void textBoxUgyfel_TextChanged(object sender, EventArgs e)
        {
            szurUgyfel();
        }
        private void listBoxUgyfel_SelectedIndexChanged(object sender, EventArgs e)
        {
            frissites();
        }
    }
}
