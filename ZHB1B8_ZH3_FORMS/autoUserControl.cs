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
    public partial class autoUserControl : UserControl
    {
        SoftechzhContext context = new SoftechzhContext();
        public autoUserControl()
        {
            InitializeComponent();
        }
        private void textBoxAuto_TextChanged(object sender, EventArgs e)
        {
            szurAuto();
        }
        void szurAuto()
        {
            var auto = (from x in context.Autok
                        where x.AutoNev.Contains(textBoxAuto.Text)
                        select x).ToList();

            listBoxAuto.DisplayMember = "AutoNev";
            listBoxAuto.DataSource = auto;

            autokBindingSource.DataSource = auto.ToList();
        }
        private void autoUserControl_Load(object sender, EventArgs e)
        {
            szurAuto();
        }
    }
}
