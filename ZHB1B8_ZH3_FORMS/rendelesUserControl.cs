using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZHB1B8_ZH3_FORMS.Models;

namespace ZHB1B8_ZH3_FORMS
{
    public partial class rendelesUserControl : UserControl
    {
        SoftechzhContext context = new SoftechzhContext();
        public rendelesUserControl()
        {
            InitializeComponent();
        }
        void szurAuto() 
        {
            var auto = (from x in context.Autok
                        where x.AutoNev.Contains(textBoxAuto.Text)
                        select x).ToList();

            listBoxAuto.DisplayMember = "AutoNev";
            listBoxAuto.DataSource = auto;
        }
        void szurUgyfel() 
        {
            var ugyfel = (from x in context.Ugyfel
                          where x.Nev.Contains(textBoxUgyfel.Text)
                          select x).ToList();

            listBoxUgyfel.DisplayMember = "Nev";
            listBoxUgyfel.DataSource = ugyfel;
        }
        void frissites() 
        {
            var valasztott = (Ugyfel)listBoxUgyfel.SelectedItem;

            var frissul = from x in context.Rendeles
                          where x.Ugyfel == valasztott.Id
                          select x;

            rendelesBindingSource.DataSource = frissul.ToList();
        }
        bool textChecker(string n) 
        {
            Regex r = new Regex("[0-9]");
            return r.IsMatch(n);
        }
        private void rendelesUserControl_Load(object sender, EventArgs e)
        {
            szurAuto();
            szurUgyfel();
            frissites();
        }
        private void textBoxUgyfel_TextChanged(object sender, EventArgs e)
        {
            szurUgyfel();
        }
        private void textBoxAuto_TextChanged(object sender, EventArgs e)
        {
            szurAuto();
        }
        private void listBoxUgyfel_SelectedIndexChanged(object sender, EventArgs e)
        {
            frissites();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Felveszi ezt az új rekordot a táblára?", "Mentés", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    var adottUgyfel = ((Ugyfel)listBoxUgyfel.SelectedItem).Id;
                    var adottAuto = ((Autok)listBoxAuto.SelectedItem).TermekKod;

                    Rendeles r = new Rendeles();

                    r.Ugyfel = adottUgyfel;
                    r.TermekKod = adottAuto;
                    int m;
                    if (int.TryParse(textBoxMennyiseg.Text, out m)) r.Mennyiseg = m;

                    context.Rendeles.Add(r);
                    context.SaveChanges();
                    frissites();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else return;
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Felveszi ezt az új rekordot a táblára?", "Mentés", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    var valasztott = (Rendeles)rendelesBindingSource.Current;

                    var torlendo = (from x in context.Rendeles
                                    where x.Ugyfel == valasztott.Ugyfel
                                    select x).FirstOrDefault();

                    context.Rendeles.Remove(torlendo);
                    context.SaveChanges();
                    frissites();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else return;
        }
        private void textBoxMennyiseg_Validating(object sender, CancelEventArgs e)
        {
            if (!(textChecker(textBoxMennyiseg.Text)) && !(string.IsNullOrEmpty(textBoxMennyiseg.Text)))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxMennyiseg, "Számbeli értéket adj meg!");
                buttonAdd.Enabled = false;
                buttonRemove.Enabled = false;
            }
        }
        private void textBoxMennyiseg_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxMennyiseg,"");
            buttonAdd.Enabled = true;
            buttonRemove.Enabled = true;
        }
    }
}
