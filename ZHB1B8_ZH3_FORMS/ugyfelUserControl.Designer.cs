namespace ZHB1B8_ZH3_FORMS
{
    partial class ugyfelUserControl
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
            this.dataGridViewUgyfel = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugyfelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxUgyfel = new System.Windows.Forms.ListBox();
            this.textBoxUgyfel = new System.Windows.Forms.TextBox();
            this.dateTimePicker1RegDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUgyfel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUgyfel
            // 
            this.dataGridViewUgyfel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUgyfel.AutoGenerateColumns = false;
            this.dataGridViewUgyfel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUgyfel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.regDatumDataGridViewTextBoxColumn});
            this.dataGridViewUgyfel.DataSource = this.ugyfelBindingSource;
            this.dataGridViewUgyfel.Location = new System.Drawing.Point(240, 3);
            this.dataGridViewUgyfel.Name = "dataGridViewUgyfel";
            this.dataGridViewUgyfel.RowTemplate.Height = 25;
            this.dataGridViewUgyfel.Size = new System.Drawing.Size(446, 411);
            this.dataGridViewUgyfel.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // regDatumDataGridViewTextBoxColumn
            // 
            this.regDatumDataGridViewTextBoxColumn.DataPropertyName = "RegDatum";
            this.regDatumDataGridViewTextBoxColumn.HeaderText = "RegDatum";
            this.regDatumDataGridViewTextBoxColumn.Name = "regDatumDataGridViewTextBoxColumn";
            // 
            // ugyfelBindingSource
            // 
            this.ugyfelBindingSource.DataSource = typeof(ZHB1B8_ZH3_FORMS.Models.Ugyfel);
            // 
            // listBoxUgyfel
            // 
            this.listBoxUgyfel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxUgyfel.FormattingEnabled = true;
            this.listBoxUgyfel.ItemHeight = 15;
            this.listBoxUgyfel.Location = new System.Drawing.Point(3, 32);
            this.listBoxUgyfel.Name = "listBoxUgyfel";
            this.listBoxUgyfel.Size = new System.Drawing.Size(231, 379);
            this.listBoxUgyfel.TabIndex = 6;
            this.listBoxUgyfel.SelectedIndexChanged += new System.EventHandler(this.listBoxUgyfel_SelectedIndexChanged);
            // 
            // textBoxUgyfel
            // 
            this.textBoxUgyfel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxUgyfel.Location = new System.Drawing.Point(3, 3);
            this.textBoxUgyfel.Name = "textBoxUgyfel";
            this.textBoxUgyfel.Size = new System.Drawing.Size(231, 23);
            this.textBoxUgyfel.TabIndex = 5;
            this.textBoxUgyfel.TextChanged += new System.EventHandler(this.textBoxUgyfel_TextChanged);
            // 
            // dateTimePicker1RegDate
            // 
            this.dateTimePicker1RegDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1RegDate.Enabled = false;
            this.dateTimePicker1RegDate.Location = new System.Drawing.Point(692, 140);
            this.dateTimePicker1RegDate.Name = "dateTimePicker1RegDate";
            this.dateTimePicker1RegDate.Size = new System.Drawing.Size(231, 23);
            this.dateTimePicker1RegDate.TabIndex = 8;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFullName.Enabled = false;
            this.textBoxFullName.Location = new System.Drawing.Point(692, 32);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(231, 23);
            this.textBoxFullName.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(692, 85);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(231, 23);
            this.textBoxEmail.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ügyfél teljes neve";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email címe";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Regisztrációs dátum";
            // 
            // ugyfelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.dateTimePicker1RegDate);
            this.Controls.Add(this.dataGridViewUgyfel);
            this.Controls.Add(this.listBoxUgyfel);
            this.Controls.Add(this.textBoxUgyfel);
            this.Name = "ugyfelUserControl";
            this.Size = new System.Drawing.Size(930, 467);
            this.Load += new System.EventHandler(this.ugyfelUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUgyfel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewUgyfel;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regDatumDataGridViewTextBoxColumn;
        private BindingSource ugyfelBindingSource;
        private ListBox listBoxUgyfel;
        private TextBox textBoxUgyfel;
        private DateTimePicker dateTimePicker1RegDate;
        private TextBox textBoxFullName;
        private TextBox textBoxEmail;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
