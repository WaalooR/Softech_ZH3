namespace ZHB1B8_ZH3_FORMS
{
    partial class autoUserControl
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
            this.listBoxAuto = new System.Windows.Forms.ListBox();
            this.textBoxAuto = new System.Windows.Forms.TextBox();
            this.dataGridViewAuto = new System.Windows.Forms.DataGridView();
            this.autokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.termekKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoModellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAuto
            // 
            this.listBoxAuto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxAuto.FormattingEnabled = true;
            this.listBoxAuto.ItemHeight = 15;
            this.listBoxAuto.Location = new System.Drawing.Point(3, 32);
            this.listBoxAuto.Name = "listBoxAuto";
            this.listBoxAuto.Size = new System.Drawing.Size(231, 304);
            this.listBoxAuto.TabIndex = 5;
            // 
            // textBoxAuto
            // 
            this.textBoxAuto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAuto.Location = new System.Drawing.Point(3, 3);
            this.textBoxAuto.Name = "textBoxAuto";
            this.textBoxAuto.Size = new System.Drawing.Size(231, 23);
            this.textBoxAuto.TabIndex = 4;
            this.textBoxAuto.TextChanged += new System.EventHandler(this.textBoxAuto_TextChanged);
            // 
            // dataGridViewAuto
            // 
            this.dataGridViewAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAuto.AutoGenerateColumns = false;
            this.dataGridViewAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.termekKodDataGridViewTextBoxColumn,
            this.autoNevDataGridViewTextBoxColumn,
            this.autoModellDataGridViewTextBoxColumn});
            this.dataGridViewAuto.DataSource = this.autokBindingSource;
            this.dataGridViewAuto.Location = new System.Drawing.Point(240, 3);
            this.dataGridViewAuto.Name = "dataGridViewAuto";
            this.dataGridViewAuto.RowTemplate.Height = 25;
            this.dataGridViewAuto.Size = new System.Drawing.Size(448, 341);
            this.dataGridViewAuto.TabIndex = 6;
            // 
            // autokBindingSource
            // 
            this.autokBindingSource.DataSource = typeof(ZHB1B8_ZH3_FORMS.Models.Autok);
            // 
            // termekKodDataGridViewTextBoxColumn
            // 
            this.termekKodDataGridViewTextBoxColumn.DataPropertyName = "TermekKod";
            this.termekKodDataGridViewTextBoxColumn.HeaderText = "TermekKod";
            this.termekKodDataGridViewTextBoxColumn.Name = "termekKodDataGridViewTextBoxColumn";
            // 
            // autoNevDataGridViewTextBoxColumn
            // 
            this.autoNevDataGridViewTextBoxColumn.DataPropertyName = "AutoNev";
            this.autoNevDataGridViewTextBoxColumn.HeaderText = "AutoNev";
            this.autoNevDataGridViewTextBoxColumn.Name = "autoNevDataGridViewTextBoxColumn";
            // 
            // autoModellDataGridViewTextBoxColumn
            // 
            this.autoModellDataGridViewTextBoxColumn.DataPropertyName = "AutoModell";
            this.autoModellDataGridViewTextBoxColumn.HeaderText = "AutoModell";
            this.autoModellDataGridViewTextBoxColumn.Name = "autoModellDataGridViewTextBoxColumn";
            // 
            // autoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewAuto);
            this.Controls.Add(this.listBoxAuto);
            this.Controls.Add(this.textBoxAuto);
            this.Name = "autoUserControl";
            this.Size = new System.Drawing.Size(819, 522);
            this.Load += new System.EventHandler(this.autoUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxAuto;
        private TextBox textBoxAuto;
        private DataGridView dataGridViewAuto;
        private DataGridViewTextBoxColumn termekKodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autoNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autoModellDataGridViewTextBoxColumn;
        private BindingSource autokBindingSource;
    }
}
