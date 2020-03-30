namespace AnalizatorSzereguPotęgowego_Huseyin_Gulecen
{
    partial class Analizator
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_X = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_EpsSzeregu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_SZeregu = new System.Windows.Forms.TextBox();
            this.btn_Oblizc_Wartosc_szeregu = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.text_Licznik_Szeregu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_Dolna_GranicaN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_Gorna_Granica_N = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_Dokladnosc_N = new System.Windows.Forms.TextBox();
            this.cmb_Metody_Calkowania = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.text_Wartosc_Calki = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textLicznik_Podprzezial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analizator szeregu potęgowego";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wartość zmieniej  X ";
            // 
            // text_X
            // 
            this.text_X.Location = new System.Drawing.Point(72, 132);
            this.text_X.Name = "text_X";
            this.text_X.Size = new System.Drawing.Size(116, 20);
            this.text_X.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Doklanasc\r\n obliczeniu wartosc ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text_EpsSzeregu
            // 
            this.text_EpsSzeregu.Location = new System.Drawing.Point(72, 219);
            this.text_EpsSzeregu.Name = "text_EpsSzeregu";
            this.text_EpsSzeregu.Size = new System.Drawing.Size(116, 20);
            this.text_EpsSzeregu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(790, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "OBliczeniu wartość\r\n szeregiuu potęgowego";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text_SZeregu
            // 
            this.text_SZeregu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_SZeregu.Location = new System.Drawing.Point(800, 153);
            this.text_SZeregu.Name = "text_SZeregu";
            this.text_SZeregu.ReadOnly = true;
            this.text_SZeregu.Size = new System.Drawing.Size(116, 20);
            this.text_SZeregu.TabIndex = 6;
            this.text_SZeregu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Oblizc_Wartosc_szeregu
            // 
            this.btn_Oblizc_Wartosc_szeregu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Oblizc_Wartosc_szeregu.Location = new System.Drawing.Point(800, 192);
            this.btn_Oblizc_Wartosc_szeregu.Name = "btn_Oblizc_Wartosc_szeregu";
            this.btn_Oblizc_Wartosc_szeregu.Size = new System.Drawing.Size(161, 71);
            this.btn_Oblizc_Wartosc_szeregu.TabIndex = 7;
            this.btn_Oblizc_Wartosc_szeregu.Text = "Obliscy wartosz \r\nseregu \r\npotengowego ";
            this.btn_Oblizc_Wartosc_szeregu.UseVisualStyleBackColor = true;
            this.btn_Oblizc_Wartosc_szeregu.Click += new System.EventHandler(this.btn_Oblizc_Wartosc_szeregu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(785, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 57);
            this.label5.TabIndex = 8;
            this.label5.Text = "Licznik z sumawanych  \r\nwynazow szeregu \r\npotegowego ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text_Licznik_Szeregu
            // 
            this.text_Licznik_Szeregu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Licznik_Szeregu.Location = new System.Drawing.Point(790, 86);
            this.text_Licznik_Szeregu.Name = "text_Licznik_Szeregu";
            this.text_Licznik_Szeregu.Size = new System.Drawing.Size(116, 20);
            this.text_Licznik_Szeregu.TabIndex = 9;
            this.text_Licznik_Szeregu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dolna granica calkowania n:";
            // 
            // text_Dolna_GranicaN
            // 
            this.text_Dolna_GranicaN.Location = new System.Drawing.Point(594, 377);
            this.text_Dolna_GranicaN.Name = "text_Dolna_GranicaN";
            this.text_Dolna_GranicaN.Size = new System.Drawing.Size(100, 20);
            this.text_Dolna_GranicaN.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gorna granica calkowania n:";
            // 
            // text_Gorna_Granica_N
            // 
            this.text_Gorna_Granica_N.Location = new System.Drawing.Point(597, 425);
            this.text_Gorna_Granica_N.Name = "text_Gorna_Granica_N";
            this.text_Gorna_Granica_N.Size = new System.Drawing.Size(100, 20);
            this.text_Gorna_Granica_N.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dokladnosc obliczenia calki:";
            // 
            // text_Dokladnosc_N
            // 
            this.text_Dokladnosc_N.Location = new System.Drawing.Point(597, 465);
            this.text_Dokladnosc_N.Name = "text_Dokladnosc_N";
            this.text_Dokladnosc_N.Size = new System.Drawing.Size(100, 20);
            this.text_Dokladnosc_N.TabIndex = 15;
            // 
            // cmb_Metody_Calkowania
            // 
            this.cmb_Metody_Calkowania.FormattingEnabled = true;
            this.cmb_Metody_Calkowania.Items.AddRange(new object[] {
            "metoda prosta kontrol ",
            "metoda trempotow",
            "metoda symsena ",
            "metoda gavusa "});
            this.cmb_Metody_Calkowania.Location = new System.Drawing.Point(819, 361);
            this.cmb_Metody_Calkowania.Name = "cmb_Metody_Calkowania";
            this.cmb_Metody_Calkowania.Size = new System.Drawing.Size(142, 21);
            this.cmb_Metody_Calkowania.TabIndex = 16;
            this.cmb_Metody_Calkowania.Text = "Wybierz metody calki";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(830, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Obliczc calke  \r\noznaczena ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(830, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Wartosc obliczenie calki\r\n oznaczena ";
            // 
            // text_Wartosc_Calki
            // 
            this.text_Wartosc_Calki.Location = new System.Drawing.Point(833, 501);
            this.text_Wartosc_Calki.Name = "text_Wartosc_Calki";
            this.text_Wartosc_Calki.Size = new System.Drawing.Size(100, 20);
            this.text_Wartosc_Calki.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1002, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "Liczba\r\n podprzedzialkow\r\n";
            // 
            // textLicznik_Podprzezial
            // 
            this.textLicznik_Podprzezial.Location = new System.Drawing.Point(1005, 500);
            this.textLicznik_Podprzezial.Name = "textLicznik_Podprzezial";
            this.textLicznik_Podprzezial.Size = new System.Drawing.Size(100, 20);
            this.textLicznik_Podprzezial.TabIndex = 21;
            // 
            // Analizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 567);
            this.Controls.Add(this.textLicznik_Podprzezial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text_Wartosc_Calki);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_Metody_Calkowania);
            this.Controls.Add(this.text_Dokladnosc_N);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_Gorna_Granica_N);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_Dolna_GranicaN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_Licznik_Szeregu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Oblizc_Wartosc_szeregu);
            this.Controls.Add(this.text_SZeregu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_EpsSzeregu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_X);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Analizator";
            this.Text = "Analizator szeregu potęgowego";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_EpsSzeregu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_SZeregu;
        private System.Windows.Forms.Button btn_Oblizc_Wartosc_szeregu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox text_Licznik_Szeregu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textLicznik_Podprzezial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_Wartosc_Calki;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_Metody_Calkowania;
        private System.Windows.Forms.TextBox text_Dokladnosc_N;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_Gorna_Granica_N;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_Dolna_GranicaN;
        private System.Windows.Forms.Label label6;
    }
}

