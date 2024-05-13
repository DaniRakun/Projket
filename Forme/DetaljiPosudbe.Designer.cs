
namespace Knjiznica.Forme
{
    partial class DetaljiPosudbe
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUcenici = new System.Windows.Forms.ListBox();
            this.lbKnjige = new System.Windows.Forms.ListBox();
            this.dtpDatumPosudbe = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudBrojDana = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojDana)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUcenici
            // 
            this.lbUcenici.FormattingEnabled = true;
            this.lbUcenici.Location = new System.Drawing.Point(23, 41);
            this.lbUcenici.Margin = new System.Windows.Forms.Padding(2);
            this.lbUcenici.Name = "lbUcenici";
            this.lbUcenici.Size = new System.Drawing.Size(204, 121);
            this.lbUcenici.TabIndex = 0;
            // 
            // lbKnjige
            // 
            this.lbKnjige.FormattingEnabled = true;
            this.lbKnjige.Location = new System.Drawing.Point(290, 41);
            this.lbKnjige.Margin = new System.Windows.Forms.Padding(2);
            this.lbKnjige.Name = "lbKnjige";
            this.lbKnjige.Size = new System.Drawing.Size(204, 121);
            this.lbKnjige.TabIndex = 1;
            this.lbKnjige.SelectedIndexChanged += new System.EventHandler(this.lbKnjige_SelectedIndexChanged);
            // 
            // dtpDatumPosudbe
            // 
            this.dtpDatumPosudbe.Location = new System.Drawing.Point(76, 209);
            this.dtpDatumPosudbe.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatumPosudbe.Name = "dtpDatumPosudbe";
            this.dtpDatumPosudbe.Size = new System.Drawing.Size(151, 20);
            this.dtpDatumPosudbe.TabIndex = 2;
            this.dtpDatumPosudbe.ValueChanged += new System.EventHandler(this.dtpDatumPosudbe_ValueChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(203, 303);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(124, 37);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Učenik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Knjiga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datum posudbe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Broj dana";
            // 
            // nudBrojDana
            // 
            this.nudBrojDana.Location = new System.Drawing.Point(293, 208);
            this.nudBrojDana.Name = "nudBrojDana";
            this.nudBrojDana.Size = new System.Drawing.Size(47, 20);
            this.nudBrojDana.TabIndex = 9;
            // 
            // DetaljiPosudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.nudBrojDana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtpDatumPosudbe);
            this.Controls.Add(this.lbKnjige);
            this.Controls.Add(this.lbUcenici);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DetaljiPosudbe";
            this.Text = "DetaljiPosudbe";
            this.Load += new System.EventHandler(this.DetaljiPosudbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojDana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUcenici;
        private System.Windows.Forms.ListBox lbKnjige;
        private System.Windows.Forms.DateTimePicker dtpDatumPosudbe;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudBrojDana;
    }
}