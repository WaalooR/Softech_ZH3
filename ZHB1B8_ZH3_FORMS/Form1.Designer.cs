namespace ZHB1B8_ZH3_FORMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonRendeles = new System.Windows.Forms.Button();
            this.buttonUgyfel = new System.Windows.Forms.Button();
            this.buttonAutok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExcel
            // 
            this.buttonExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcel.Location = new System.Drawing.Point(12, 12);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(297, 69);
            this.buttonExcel.TabIndex = 0;
            this.buttonExcel.Text = "Autóadatok megnyitása Excelben";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonRendeles
            // 
            this.buttonRendeles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRendeles.Location = new System.Drawing.Point(12, 369);
            this.buttonRendeles.Name = "buttonRendeles";
            this.buttonRendeles.Size = new System.Drawing.Size(297, 69);
            this.buttonRendeles.TabIndex = 1;
            this.buttonRendeles.Text = "Rendelésszerkesztő megnyitása";
            this.buttonRendeles.UseVisualStyleBackColor = true;
            this.buttonRendeles.Click += new System.EventHandler(this.buttonRendeles_Click);
            // 
            // buttonUgyfel
            // 
            this.buttonUgyfel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUgyfel.Location = new System.Drawing.Point(12, 145);
            this.buttonUgyfel.Name = "buttonUgyfel";
            this.buttonUgyfel.Size = new System.Drawing.Size(297, 69);
            this.buttonUgyfel.TabIndex = 2;
            this.buttonUgyfel.Text = "Ügyfelek listázása";
            this.buttonUgyfel.UseVisualStyleBackColor = true;
            this.buttonUgyfel.Click += new System.EventHandler(this.buttonUgyfel_Click);
            // 
            // buttonAutok
            // 
            this.buttonAutok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAutok.Location = new System.Drawing.Point(12, 220);
            this.buttonAutok.Name = "buttonAutok";
            this.buttonAutok.Size = new System.Drawing.Size(297, 69);
            this.buttonAutok.TabIndex = 3;
            this.buttonAutok.Text = "Autók listázása";
            this.buttonAutok.UseVisualStyleBackColor = true;
            this.buttonAutok.Click += new System.EventHandler(this.buttonAutok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.buttonAutok);
            this.Controls.Add(this.buttonUgyfel);
            this.Controls.Add(this.buttonRendeles);
            this.Controls.Add(this.buttonExcel);
            this.Name = "Form1";
            this.Text = "ZHB1B8 - ZH3 Adatbázis Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonExcel;
        private Button buttonRendeles;
        private Button buttonUgyfel;
        private Button buttonAutok;
    }
}