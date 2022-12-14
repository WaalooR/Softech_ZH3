namespace ZHB1B8_ZH3_FORMS
{
    partial class rendelesUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxUgyfel = new System.Windows.Forms.TextBox();
            this.listBoxUgyfel = new System.Windows.Forms.ListBox();
            this.textBoxAuto = new System.Windows.Forms.TextBox();
            this.listBoxAuto = new System.Windows.Forms.ListBox();
            this.dataGridViewRendeles = new System.Windows.Forms.DataGridView();
            this.termekKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugyfelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyisegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxMennyiseg = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRendeles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUgyfel
            // 
            this.textBoxUgyfel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxUgyfel.Location = new System.Drawing.Point(3, 3);
            this.textBoxUgyfel.Name = "textBoxUgyfel";
            this.textBoxUgyfel.Size = new System.Drawing.Size(231, 23);
            this.textBoxUgyfel.TabIndex = 0;
            this.textBoxUgyfel.TextChanged += new System.EventHandler(this.textBoxUgyfel_TextChanged);
            // 
            // listBoxUgyfel
            // 
            this.listBoxUgyfel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxUgyfel.FormattingEnabled = true;
            this.listBoxUgyfel.ItemHeight = 15;
            this.listBoxUgyfel.Location = new System.Drawing.Point(3, 32);
            this.listBoxUgyfel.Name = "listBoxUgyfel";
            this.listBoxUgyfel.Size = new System.Drawing.Size(231, 304);
            this.listBoxUgyfel.TabIndex = 1;
            this.listBoxUgyfel.SelectedIndexChanged += new System.EventHandler(this.listBoxUgyfel_SelectedIndexChanged);
            // 
            // textBoxAuto
            // 
            this.textBoxAuto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuto.Location = new System.Drawing.Point(694, 3);
            this.textBoxAuto.Name = "textBoxAuto";
            this.textBoxAuto.Size = new System.Drawing.Size(231, 23);
            this.textBoxAuto.TabIndex = 2;
            this.textBoxAuto.TextChanged += new System.EventHandler(this.textBoxAuto_TextChanged);
            // 
            // listBoxAuto
            // 
            this.listBoxAuto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAuto.FormattingEnabled = true;
            this.listBoxAuto.ItemHeight = 15;
            this.listBoxAuto.Location = new System.Drawing.Point(694, 32);
            this.listBoxAuto.Name = "listBoxAuto";
            this.listBoxAuto.Size = new System.Drawing.Size(231, 304);
            this.listBoxAuto.TabIndex = 3;
            // 
            // dataGridViewRendeles
            // 
            this.dataGridViewRendeles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRendeles.AutoGenerateColumns = false;
            this.dataGridViewRendeles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRendeles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.termekKodDataGridViewTextBoxColumn,
            this.ugyfelDataGridViewTextBoxColumn,
            this.egysegarDataGridViewTextBoxColumn,
            this.mennyisegDataGridViewTextBoxColumn});
            this.dataGridViewRendeles.DataSource = this.rendelesBindingSource;
            this.dataGridViewRendeles.Location = new System.Drawing.Point(240, 0);
            this.dataGridViewRendeles.Name = "dataGridViewRendeles";
            this.dataGridViewRendeles.RowTemplate.Height = 25;
            this.dataGridViewRendeles.Size = new System.Drawing.Size(448, 341);
            this.dataGridViewRendeles.TabIndex = 4;
            // 
            // termekKodDataGridViewTextBoxColumn
            // 
            this.termekKodDataGridViewTextBoxColumn.DataPropertyName = "TermekKod";
            this.termekKodDataGridViewTextBoxColumn.HeaderText = "TermekKod";
            this.termekKodDataGridViewTextBoxColumn.Name = "termekKodDataGridViewTextBoxColumn";
            // 
            // ugyfelDataGridViewTextBoxColumn
            // 
            this.ugyfelDataGridViewTextBoxColumn.DataPropertyName = "Ugyfel";
            this.ugyfelDataGridViewTextBoxColumn.HeaderText = "Ugyfel";
            this.ugyfelDataGridViewTextBoxColumn.Name = "ugyfelDataGridViewTextBoxColumn";
            // 
            // egysegarDataGridViewTextBoxColumn
            // 
            this.egysegarDataGridViewTextBoxColumn.DataPropertyName = "Egysegar";
            this.egysegarDataGridViewTextBoxColumn.HeaderText = "Egysegar";
            this.egysegarDataGridViewTextBoxColumn.Name = "egysegarDataGridViewTextBoxColumn";
            // 
            // mennyisegDataGridViewTextBoxColumn
            // 
            this.mennyisegDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg";
            this.mennyisegDataGridViewTextBoxColumn.HeaderText = "Mennyiseg";
            this.mennyisegDataGridViewTextBoxColumn.Name = "mennyisegDataGridViewTextBoxColumn";
            // 
            // rendelesBindingSource
            // 
            this.rendelesBindingSource.DataSource = typeof(ZHB1B8_ZH3_FORMS.Models.Rendeles);
            // 
            // textBoxMennyiseg
            // 
            this.textBoxMennyiseg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMennyiseg.Location = new System.Drawing.Point(784, 365);
            this.textBoxMennyiseg.Name = "textBoxMennyiseg";
            this.textBoxMennyiseg.Size = new System.Drawing.Size(100, 23);
            this.textBoxMennyiseg.TabIndex = 5;
            this.textBoxMennyiseg.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMennyiseg_Validating);
            this.textBoxMennyiseg.Validated += new System.EventHandler(this.textBoxMennyiseg_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hozzáadott autók száma:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(850, 394);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Hozzáadás";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(769, 394);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Törlés";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // rendelesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMennyiseg);
            this.Controls.Add(this.dataGridViewRendeles);
            this.Controls.Add(this.listBoxAuto);
            this.Controls.Add(this.textBoxAuto);
            this.Controls.Add(this.listBoxUgyfel);
            this.Controls.Add(this.textBoxUgyfel);
            this.Name = "rendelesUserControl";
            this.Size = new System.Drawing.Size(928, 509);
            this.Load += new System.EventHandler(this.rendelesUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRendeles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxUgyfel;
        private ListBox listBoxUgyfel;
        private TextBox textBoxAuto;
        private ListBox listBoxAuto;
        private DataGridView dataGridViewRendeles;
        private DataGridViewTextBoxColumn termekKodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ugyfelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyisegDataGridViewTextBoxColumn;
        private BindingSource rendelesBindingSource;
        private TextBox textBoxMennyiseg;
        private ErrorProvider errorProvider1;
        private Button buttonRemove;
        private Button buttonAdd;
        private Label label1;
    }
}
