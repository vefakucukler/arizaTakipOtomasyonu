namespace elfcell
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.cmbBoxTelefonMarkası = new System.Windows.Forms.ComboBox();
            this.TxtArıza = new System.Windows.Forms.TextBox();
            this.TxtTamirSuresi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTamirFiyati = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listAdSoyad = new System.Windows.Forms.ListBox();
            this.listTelefon = new System.Windows.Forms.ListBox();
            this.listArıza = new System.Windows.Forms.ListBox();
            this.listTelefonMarkası = new System.Windows.Forms.ListBox();
            this.listTelefonModeli = new System.Windows.Forms.ListBox();
            this.listTamirSuresi = new System.Windows.Forms.ListBox();
            this.listTamirFiyati = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtTelefonModeli = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSeriNumarasi = new System.Windows.Forms.TextBox();
            this.listSeriNumarasi = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtOzelNot = new System.Windows.Forms.TextBox();
            this.listOzelNot = new System.Windows.Forms.ListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELFCELL ARIZA TAKİP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon Markası: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon modeli:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Arıza:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(225, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tahmini Tamir Süresi: ";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(90, 50);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(109, 20);
            this.txtAdSoyad.TabIndex = 8;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(90, 83);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(109, 20);
            this.txtTelefon.TabIndex = 9;
            // 
            // cmbBoxTelefonMarkası
            // 
            this.cmbBoxTelefonMarkası.FormattingEnabled = true;
            this.cmbBoxTelefonMarkası.Items.AddRange(new object[] {
            "İPhone",
            "Samsung",
            "LG",
            "General Mobile",
            "Nokıa",
            "HTC",
            "SONY",
            "ASUS",
            "TURKCELL",
            "VESTEL",
            "Huawei",
            "Motorola",
            ""});
            this.cmbBoxTelefonMarkası.Location = new System.Drawing.Point(380, 50);
            this.cmbBoxTelefonMarkası.Name = "cmbBoxTelefonMarkası";
            this.cmbBoxTelefonMarkası.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxTelefonMarkası.TabIndex = 10;
            this.cmbBoxTelefonMarkası.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TxtArıza
            // 
            this.TxtArıza.Location = new System.Drawing.Point(90, 119);
            this.TxtArıza.Multiline = true;
            this.TxtArıza.Name = "TxtArıza";
            this.TxtArıza.Size = new System.Drawing.Size(109, 63);
            this.TxtArıza.TabIndex = 11;
            // 
            // TxtTamirSuresi
            // 
            this.TxtTamirSuresi.Location = new System.Drawing.Point(380, 146);
            this.TxtTamirSuresi.Name = "TxtTamirSuresi";
            this.TxtTamirSuresi.Size = new System.Drawing.Size(121, 20);
            this.TxtTamirSuresi.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(525, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tamir Fiyatı:";
            // 
            // TxtTamirFiyati
            // 
            this.TxtTamirFiyati.Location = new System.Drawing.Point(613, 50);
            this.TxtTamirFiyati.Name = "TxtTamirFiyati";
            this.TxtTamirFiyati.Size = new System.Drawing.Size(63, 20);
            this.TxtTamirFiyati.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(258, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Kayıt Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(355, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listAdSoyad
            // 
            this.listAdSoyad.FormattingEnabled = true;
            this.listAdSoyad.Location = new System.Drawing.Point(15, 247);
            this.listAdSoyad.Name = "listAdSoyad";
            this.listAdSoyad.Size = new System.Drawing.Size(120, 95);
            this.listAdSoyad.TabIndex = 18;
            // 
            // listTelefon
            // 
            this.listTelefon.FormattingEnabled = true;
            this.listTelefon.Location = new System.Drawing.Point(151, 247);
            this.listTelefon.Name = "listTelefon";
            this.listTelefon.Size = new System.Drawing.Size(120, 95);
            this.listTelefon.TabIndex = 19;
            // 
            // listArıza
            // 
            this.listArıza.FormattingEnabled = true;
            this.listArıza.Location = new System.Drawing.Point(287, 247);
            this.listArıza.Name = "listArıza";
            this.listArıza.Size = new System.Drawing.Size(120, 95);
            this.listArıza.TabIndex = 20;
            // 
            // listTelefonMarkası
            // 
            this.listTelefonMarkası.FormattingEnabled = true;
            this.listTelefonMarkası.Location = new System.Drawing.Point(422, 247);
            this.listTelefonMarkası.Name = "listTelefonMarkası";
            this.listTelefonMarkası.Size = new System.Drawing.Size(120, 95);
            this.listTelefonMarkası.TabIndex = 21;
            // 
            // listTelefonModeli
            // 
            this.listTelefonModeli.FormattingEnabled = true;
            this.listTelefonModeli.Location = new System.Drawing.Point(556, 247);
            this.listTelefonModeli.Name = "listTelefonModeli";
            this.listTelefonModeli.Size = new System.Drawing.Size(120, 95);
            this.listTelefonModeli.TabIndex = 22;
            // 
            // listTamirSuresi
            // 
            this.listTamirSuresi.FormattingEnabled = true;
            this.listTamirSuresi.Location = new System.Drawing.Point(206, 363);
            this.listTamirSuresi.Name = "listTamirSuresi";
            this.listTamirSuresi.Size = new System.Drawing.Size(120, 95);
            this.listTamirSuresi.TabIndex = 23;
            // 
            // listTamirFiyati
            // 
            this.listTamirFiyati.FormattingEnabled = true;
            this.listTamirFiyati.Location = new System.Drawing.Point(366, 363);
            this.listTamirFiyati.Name = "listTamirFiyati";
            this.listTamirFiyati.Size = new System.Drawing.Size(120, 95);
            this.listTamirFiyati.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Adı Soyadı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(170, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Telefon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(319, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Arıza";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(425, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Telefon Markası";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(565, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Telefon modeli";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(200, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "Tahmini Tamir Süresi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(392, 345);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 15);
            this.label15.TabIndex = 31;
            this.label15.Text = "Tamir Fiyatı";
            // 
            // TxtTelefonModeli
            // 
            this.TxtTelefonModeli.Location = new System.Drawing.Point(380, 83);
            this.TxtTelefonModeli.Name = "TxtTelefonModeli";
            this.TxtTelefonModeli.Size = new System.Drawing.Size(121, 20);
            this.TxtTelefonModeli.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(284, 470);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 15);
            this.label16.TabIndex = 33;
            this.label16.Text = "Copyright By VK YAZILIM";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label17.Location = new System.Drawing.Point(251, 467);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 21);
            this.label17.TabIndex = 34;
            this.label17.Text = "© ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(213, 119);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(161, 15);
            this.label18.TabIndex = 35;
            this.label18.Text = "Telefonun Seri Numarası:";
            // 
            // txtSeriNumarasi
            // 
            this.txtSeriNumarasi.Location = new System.Drawing.Point(380, 117);
            this.txtSeriNumarasi.Name = "txtSeriNumarasi";
            this.txtSeriNumarasi.Size = new System.Drawing.Size(121, 20);
            this.txtSeriNumarasi.TabIndex = 36;
            // 
            // listSeriNumarasi
            // 
            this.listSeriNumarasi.FormattingEnabled = true;
            this.listSeriNumarasi.Location = new System.Drawing.Point(65, 363);
            this.listSeriNumarasi.Name = "listSeriNumarasi";
            this.listSeriNumarasi.Size = new System.Drawing.Size(120, 95);
            this.listSeriNumarasi.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(38, 345);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(156, 15);
            this.label19.TabIndex = 38;
            this.label19.Text = "Telefonun Seri Numarası";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(565, 99);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 15);
            this.label20.TabIndex = 39;
            this.label20.Text = "Özel Not:";
            // 
            // txtOzelNot
            // 
            this.txtOzelNot.Location = new System.Drawing.Point(528, 117);
            this.txtOzelNot.Multiline = true;
            this.txtOzelNot.Name = "txtOzelNot";
            this.txtOzelNot.Size = new System.Drawing.Size(148, 49);
            this.txtOzelNot.TabIndex = 40;
            // 
            // listOzelNot
            // 
            this.listOzelNot.FormattingEnabled = true;
            this.listOzelNot.Location = new System.Drawing.Point(502, 363);
            this.listOzelNot.Name = "listOzelNot";
            this.listOzelNot.Size = new System.Drawing.Size(174, 95);
            this.listOzelNot.TabIndex = 41;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("OpenSymbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(553, 345);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 15);
            this.label21.TabIndex = 42;
            this.label21.Text = "Özel Not";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 485);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.listOzelNot);
            this.Controls.Add(this.txtOzelNot);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.listSeriNumarasi);
            this.Controls.Add(this.txtSeriNumarasi);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtTelefonModeli);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listTamirFiyati);
            this.Controls.Add(this.listTamirSuresi);
            this.Controls.Add(this.listTelefonModeli);
            this.Controls.Add(this.listTelefonMarkası);
            this.Controls.Add(this.listArıza);
            this.Controls.Add(this.listTelefon);
            this.Controls.Add(this.listAdSoyad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtTamirFiyati);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtTamirSuresi);
            this.Controls.Add(this.TxtArıza);
            this.Controls.Add(this.cmbBoxTelefonMarkası);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ELFCELL Arıza Takip Programı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ComboBox cmbBoxTelefonMarkası;
        private System.Windows.Forms.TextBox TxtArıza;
        private System.Windows.Forms.TextBox TxtTamirSuresi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTamirFiyati;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listAdSoyad;
        private System.Windows.Forms.ListBox listTelefon;
        private System.Windows.Forms.ListBox listArıza;
        private System.Windows.Forms.ListBox listTelefonMarkası;
        private System.Windows.Forms.ListBox listTelefonModeli;
        private System.Windows.Forms.ListBox listTamirSuresi;
        private System.Windows.Forms.ListBox listTamirFiyati;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtTelefonModeli;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSeriNumarasi;
        private System.Windows.Forms.ListBox listSeriNumarasi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtOzelNot;
        private System.Windows.Forms.ListBox listOzelNot;
        private System.Windows.Forms.Label label21;
    }
}

