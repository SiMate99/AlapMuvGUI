
namespace Feladat0407
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbEredmeny = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btEllenoriz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFeladat = new System.Windows.Forms.TextBox();
            this.lbStatisztika = new System.Windows.Forms.ListBox();
            this.cbMuveletek = new System.Windows.Forms.ComboBox();
            this.btMegoldas = new System.Windows.Forms.Button();
            this.btUjKerdes = new System.Windows.Forms.Button();
            this.lKerdes = new System.Windows.Forms.Label();
            this.tbValasz = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbEredmeny);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btEllenoriz);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbFeladat);
            this.panel1.Controls.Add(this.lbStatisztika);
            this.panel1.Controls.Add(this.cbMuveletek);
            this.panel1.Controls.Add(this.btMegoldas);
            this.panel1.Controls.Add(this.btUjKerdes);
            this.panel1.Controls.Add(this.lKerdes);
            this.panel1.Controls.Add(this.tbValasz);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 307);
            this.panel1.TabIndex = 0;
            // 
            // tbEredmeny
            // 
            this.tbEredmeny.Location = new System.Drawing.Point(194, 88);
            this.tbEredmeny.Name = "tbEredmeny";
            this.tbEredmeny.ReadOnly = true;
            this.tbEredmeny.Size = new System.Drawing.Size(120, 23);
            this.tbEredmeny.TabIndex = 17;
            this.tbEredmeny.TextChanged += new System.EventHandler(this.tbEredmeny_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Eredmény:";
            // 
            // btEllenoriz
            // 
            this.btEllenoriz.Location = new System.Drawing.Point(8, 117);
            this.btEllenoriz.Name = "btEllenoriz";
            this.btEllenoriz.Size = new System.Drawing.Size(78, 23);
            this.btEllenoriz.TabIndex = 15;
            this.btEllenoriz.Text = "Ellenőriz";
            this.btEllenoriz.UseVisualStyleBackColor = true;
            this.btEllenoriz.Click += new System.EventHandler(this.btEllenoriz_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Statisztika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Műveletek:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Válaszod:";
            // 
            // tbFeladat
            // 
            this.tbFeladat.Location = new System.Drawing.Point(9, 31);
            this.tbFeladat.Name = "tbFeladat";
            this.tbFeladat.ReadOnly = true;
            this.tbFeladat.Size = new System.Drawing.Size(120, 23);
            this.tbFeladat.TabIndex = 11;
            // 
            // lbStatisztika
            // 
            this.lbStatisztika.FormattingEnabled = true;
            this.lbStatisztika.ItemHeight = 15;
            this.lbStatisztika.Items.AddRange(new object[] {
            "Összeadás: 0",
            "Kivonás: 0",
            "Szorzás: 0",
            "Osztás: 0"});
            this.lbStatisztika.Location = new System.Drawing.Point(8, 192);
            this.lbStatisztika.Name = "lbStatisztika";
            this.lbStatisztika.Size = new System.Drawing.Size(120, 94);
            this.lbStatisztika.TabIndex = 10;
            // 
            // cbMuveletek
            // 
            this.cbMuveletek.FormattingEnabled = true;
            this.cbMuveletek.Items.AddRange(new object[] {
            "Összeadás",
            "Kivonás",
            "Szorzás",
            "Osztás"});
            this.cbMuveletek.Location = new System.Drawing.Point(194, 28);
            this.cbMuveletek.Name = "cbMuveletek";
            this.cbMuveletek.Size = new System.Drawing.Size(121, 23);
            this.cbMuveletek.TabIndex = 8;
            this.cbMuveletek.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btMegoldas
            // 
            this.btMegoldas.Location = new System.Drawing.Point(152, 263);
            this.btMegoldas.Name = "btMegoldas";
            this.btMegoldas.Size = new System.Drawing.Size(78, 23);
            this.btMegoldas.TabIndex = 7;
            this.btMegoldas.Text = "Megoldas";
            this.btMegoldas.UseVisualStyleBackColor = true;
            // 
            // btUjKerdes
            // 
            this.btUjKerdes.Location = new System.Drawing.Point(236, 263);
            this.btUjKerdes.Name = "btUjKerdes";
            this.btUjKerdes.Size = new System.Drawing.Size(78, 23);
            this.btUjKerdes.TabIndex = 6;
            this.btUjKerdes.Text = "Új Kérdés";
            this.btUjKerdes.UseVisualStyleBackColor = true;
            this.btUjKerdes.Click += new System.EventHandler(this.btUjKerdes_Click);
            // 
            // lKerdes
            // 
            this.lKerdes.AutoSize = true;
            this.lKerdes.Location = new System.Drawing.Point(9, 13);
            this.lKerdes.Name = "lKerdes";
            this.lKerdes.Size = new System.Drawing.Size(48, 15);
            this.lKerdes.TabIndex = 5;
            this.lKerdes.Text = "Feladat:";
            // 
            // tbValasz
            // 
            this.tbValasz.Location = new System.Drawing.Point(8, 88);
            this.tbValasz.Name = "tbValasz";
            this.tbValasz.Size = new System.Drawing.Size(121, 23);
            this.tbValasz.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 331);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Alap Műveletek";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMuveletek;
        private System.Windows.Forms.Button btMegoldas;
        private System.Windows.Forms.Button btUjKerdes;
        private System.Windows.Forms.Label lKerdes;
        private System.Windows.Forms.TextBox tbValasz;
        private System.Windows.Forms.Button btEllenoriz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFeladat;
        private System.Windows.Forms.ListBox lbStatisztika;
        private System.Windows.Forms.TextBox tbEredmeny;
        private System.Windows.Forms.Label label4;
    }
}

