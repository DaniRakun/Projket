
namespace Knjiznica.Forme
{
    partial class frmKnjiznica
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
            this.lbPosudbe = new System.Windows.Forms.ListBox();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnVrati = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uceniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usporedbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poDatumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poUčenikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poKnjiziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPosudbe
            // 
            this.lbPosudbe.FormattingEnabled = true;
            this.lbPosudbe.Location = new System.Drawing.Point(11, 49);
            this.lbPosudbe.Margin = new System.Windows.Forms.Padding(2);
            this.lbPosudbe.Name = "lbPosudbe";
            this.lbPosudbe.Size = new System.Drawing.Size(357, 238);
            this.lbPosudbe.TabIndex = 0;
            this.lbPosudbe.SelectedIndexChanged += new System.EventHandler(this.lbPosudbe_SelectedIndexChanged);
            // 
            // btnPosudi
            // 
            this.btnPosudi.Location = new System.Drawing.Point(418, 49);
            this.btnPosudi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(100, 52);
            this.btnPosudi.TabIndex = 1;
            this.btnPosudi.Text = "Posudi";
            this.btnPosudi.UseVisualStyleBackColor = true;
            this.btnPosudi.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(418, 126);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(2);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(100, 52);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(418, 202);
            this.btnVrati.Margin = new System.Windows.Forms.Padding(2);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(100, 52);
            this.btnVrati.TabIndex = 3;
            this.btnVrati.Text = "Vrati";
            this.btnVrati.UseVisualStyleBackColor = true;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Posuđene knjige:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uceniciToolStripMenuItem,
            this.knjigeToolStripMenuItem,
            this.usporedbaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uceniciToolStripMenuItem
            // 
            this.uceniciToolStripMenuItem.Name = "uceniciToolStripMenuItem";
            this.uceniciToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.uceniciToolStripMenuItem.Text = "Ucenici";
            this.uceniciToolStripMenuItem.Click += new System.EventHandler(this.uceniciToolStripMenuItem_Click);
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            this.knjigeToolStripMenuItem.Click += new System.EventHandler(this.knjigeToolStripMenuItem_Click);
            // 
            // usporedbaToolStripMenuItem
            // 
            this.usporedbaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poDatumuToolStripMenuItem,
            this.poUčenikuToolStripMenuItem,
            this.poKnjiziToolStripMenuItem});
            this.usporedbaToolStripMenuItem.Name = "usporedbaToolStripMenuItem";
            this.usporedbaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.usporedbaToolStripMenuItem.Text = "Usporedba";
            this.usporedbaToolStripMenuItem.Click += new System.EventHandler(this.usporedbaToolStripMenuItem_Click);
            // 
            // poDatumuToolStripMenuItem
            // 
            this.poDatumuToolStripMenuItem.Name = "poDatumuToolStripMenuItem";
            this.poDatumuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poDatumuToolStripMenuItem.Text = "Po datumu";
            this.poDatumuToolStripMenuItem.Click += new System.EventHandler(this.poDatumuToolStripMenuItem_Click);
            // 
            // poUčenikuToolStripMenuItem
            // 
            this.poUčenikuToolStripMenuItem.Name = "poUčenikuToolStripMenuItem";
            this.poUčenikuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poUčenikuToolStripMenuItem.Text = "Po učeniku";
            this.poUčenikuToolStripMenuItem.Click += new System.EventHandler(this.poUčenikuToolStripMenuItem_Click);
            // 
            // poKnjiziToolStripMenuItem
            // 
            this.poKnjiziToolStripMenuItem.Name = "poKnjiziToolStripMenuItem";
            this.poKnjiziToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poKnjiziToolStripMenuItem.Text = "Po knjizi";
            this.poKnjiziToolStripMenuItem.Click += new System.EventHandler(this.poKnjiziToolStripMenuItem_Click);
            // 
            // frmKnjiznica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnPosudi);
            this.Controls.Add(this.lbPosudbe);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKnjiznica";
            this.Text = "Knjižnica";
            this.Load += new System.EventHandler(this.frmKnjiznica_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPosudbe;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uceniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usporedbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poDatumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poUčenikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poKnjiziToolStripMenuItem;
    }
}