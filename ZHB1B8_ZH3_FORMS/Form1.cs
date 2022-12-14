using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using ZHB1B8_ZH3_FORMS.Models;

namespace ZHB1B8_ZH3_FORMS
{
    public partial class Form1 : Form
    {
        Excel.Application xlApp;
        Excel.Workbook xlWb;
        Excel.Worksheet xlSh;
        public Form1()
        {
            InitializeComponent();
        }
        void CreateExcel() 
        {
            try
            {
                xlApp = new Excel.Application();
                xlWb = xlApp.Workbooks.Add(Missing.Value);
                xlSh = xlWb.ActiveSheet;

                CreateTable();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                xlApp.Quit();
                xlWb.Close(false, Type.Missing, Type.Missing);
                xlApp = null;
                xlWb = null;
            }
        }
        void CreateTable() 
        {
            string[] Header = new string[] { "ID", "Autó márka", "Autó modell" };

            for (int i = 0; i < Header.Count(); i++)
            {
                xlSh.Cells[1, i + 1] = Header[i];
            }

            SoftechzhContext context = new SoftechzhContext();
            var osszesAuto = context.Autok.ToList();

            object[,] Tomb = new object[osszesAuto.Count(), Header.Count()];

            for (int i = 0; i < osszesAuto.Count(); i++)
            {
                Tomb[i, 0] = osszesAuto[i].TermekKod;
                Tomb[i, 1] = osszesAuto[i].AutoNev;
                Tomb[i, 2] = osszesAuto[i].AutoModell;
            }

            int sorokSzama = Tomb.GetLength(0);
            int oszlopokSzama = Tomb.GetLength(1);

            Excel.Range adatRange = xlSh.get_Range("A2", Type.Missing).get_Resize(sorokSzama, oszlopokSzama);
            adatRange.Value2 = Tomb;
            adatRange.Columns.AutoFit();

            Excel.Range headerRange = xlSh.get_Range("A1", Type.Missing).get_Resize(1, oszlopokSzama);
            headerRange.Cells.Font.Bold = true;
            headerRange.Cells.Interior.Color = Color.Fuchsia;

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            kilepes(e);
        }
        private static void kilepes(FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Biztos benne, hogy ki szeretne lépni?", "Kilépés", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) e.Cancel = true;
            else return;
        }
        private void buttonExcel_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }
        private void buttonRendeles_Click(object sender, EventArgs e)
        {
            szerkesztoForm form = new szerkesztoForm();
            form.Show();
        }
        private void buttonUgyfel_Click(object sender, EventArgs e)
        {
            ugyfelForm form = new ugyfelForm();
            form.Show();
        }
        private void buttonAutok_Click(object sender, EventArgs e)
        {
            autoForm form = new autoForm();
            form.Show();
        }
    }
}