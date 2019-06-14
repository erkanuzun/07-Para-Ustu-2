namespace _07_Para_Ustu_2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Yeni = new System.Windows.Forms.Button();
            this.label_Tutar = new System.Windows.Forms.Label();
            this.label_Odenen = new System.Windows.Forms.Label();
            this.label_ParaUstu = new System.Windows.Forms.Label();
            this.button_Odeme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel_Tezgah = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Yeni
            // 
            this.button_Yeni.Location = new System.Drawing.Point(28, 29);
            this.button_Yeni.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_Yeni.Name = "button_Yeni";
            this.button_Yeni.Size = new System.Drawing.Size(73, 96);
            this.button_Yeni.TabIndex = 0;
            this.button_Yeni.Text = "Yeni Müşteri";
            this.button_Yeni.UseVisualStyleBackColor = true;
            this.button_Yeni.Click += new System.EventHandler(this.Button_Yeni_Click);
            // 
            // label_Tutar
            // 
            this.label_Tutar.AutoSize = true;
            this.label_Tutar.ForeColor = System.Drawing.Color.Red;
            this.label_Tutar.Location = new System.Drawing.Point(66, 173);
            this.label_Tutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Tutar.Name = "label_Tutar";
            this.label_Tutar.Size = new System.Drawing.Size(35, 17);
            this.label_Tutar.TabIndex = 1;
            this.label_Tutar.Text = "0,00";
            // 
            // label_Odenen
            // 
            this.label_Odenen.AutoSize = true;
            this.label_Odenen.ForeColor = System.Drawing.Color.Red;
            this.label_Odenen.Location = new System.Drawing.Point(66, 224);
            this.label_Odenen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Odenen.Name = "label_Odenen";
            this.label_Odenen.Size = new System.Drawing.Size(35, 17);
            this.label_Odenen.TabIndex = 2;
            this.label_Odenen.Text = "0,00";
            // 
            // label_ParaUstu
            // 
            this.label_ParaUstu.AutoSize = true;
            this.label_ParaUstu.ForeColor = System.Drawing.Color.Red;
            this.label_ParaUstu.Location = new System.Drawing.Point(66, 287);
            this.label_ParaUstu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ParaUstu.Name = "label_ParaUstu";
            this.label_ParaUstu.Size = new System.Drawing.Size(35, 17);
            this.label_ParaUstu.TabIndex = 3;
            this.label_ParaUstu.Text = "0,00";
            // 
            // button_Odeme
            // 
            this.button_Odeme.Location = new System.Drawing.Point(28, 337);
            this.button_Odeme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_Odeme.Name = "button_Odeme";
            this.button_Odeme.Size = new System.Drawing.Size(73, 67);
            this.button_Odeme.TabIndex = 4;
            this.button_Odeme.Text = "Ödeme";
            this.button_Odeme.UseVisualStyleBackColor = true;
            this.button_Odeme.Click += new System.EventHandler(this.Button_Odeme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ödenen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Para Üstü";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_07_Para_Ustu_2.Properties.Resources.Kagit_200TL;
            this.pictureBox1.Location = new System.Drawing.Point(702, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "20000";
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // flowLayoutPanel_Tezgah
            // 
            this.flowLayoutPanel_Tezgah.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_Tezgah.Location = new System.Drawing.Point(134, 25);
            this.flowLayoutPanel_Tezgah.Name = "flowLayoutPanel_Tezgah";
            this.flowLayoutPanel_Tezgah.Size = new System.Drawing.Size(546, 419);
            this.flowLayoutPanel_Tezgah.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_07_Para_Ustu_2.Properties.Resources.Kagit_100TL;
            this.pictureBox2.Location = new System.Drawing.Point(702, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "10000";
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_07_Para_Ustu_2.Properties.Resources.Kagit_50TL;
            this.pictureBox3.Location = new System.Drawing.Point(702, 141);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "5000";
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::_07_Para_Ustu_2.Properties.Resources.Kagit_20TL;
            this.pictureBox4.Location = new System.Drawing.Point(702, 197);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "2000";
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::_07_Para_Ustu_2.Properties.Resources.Kagit_10TL;
            this.pictureBox5.Location = new System.Drawing.Point(702, 254);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "1000";
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::_07_Para_Ustu_2.Properties.Resources.Kagit_5TL;
            this.pictureBox6.Location = new System.Drawing.Point(702, 310);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "500";
            this.pictureBox6.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::_07_Para_Ustu_2.Properties.Resources.Madeni_1TL;
            this.pictureBox7.Location = new System.Drawing.Point(702, 366);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(43, 43);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "100";
            this.pictureBox7.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::_07_Para_Ustu_2.Properties.Resources.Madeni_1Kr;
            this.pictureBox8.Location = new System.Drawing.Point(803, 417);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(27, 27);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "1";
            this.pictureBox8.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::_07_Para_Ustu_2.Properties.Resources.Madeni_25Kr;
            this.pictureBox9.Location = new System.Drawing.Point(796, 366);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(34, 34);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 17;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "25";
            this.pictureBox9.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::_07_Para_Ustu_2.Properties.Resources.Madeni_50Kr;
            this.pictureBox10.Location = new System.Drawing.Point(751, 366);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(39, 39);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 18;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "50";
            this.pictureBox10.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::_07_Para_Ustu_2.Properties.Resources.Madeni_10Kr;
            this.pictureBox11.Location = new System.Drawing.Point(702, 415);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(30, 30);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 19;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "10";
            this.pictureBox11.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::_07_Para_Ustu_2.Properties.Resources.Madeni_5Kr;
            this.pictureBox12.Location = new System.Drawing.Point(751, 417);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(29, 29);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox12.TabIndex = 20;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "5";
            this.pictureBox12.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 466);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.flowLayoutPanel_Tezgah);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Odeme);
            this.Controls.Add(this.label_ParaUstu);
            this.Controls.Add(this.label_Odenen);
            this.Controls.Add(this.label_Tutar);
            this.Controls.Add(this.button_Yeni);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Sharp Market";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Yeni;
        private System.Windows.Forms.Label label_Tutar;
        private System.Windows.Forms.Label label_Odenen;
        private System.Windows.Forms.Label label_ParaUstu;
        private System.Windows.Forms.Button button_Odeme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Tezgah;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}

