namespace Delpin_project
{
    partial class CreateBooking2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_navn = new System.Windows.Forms.TextBox();
            this.textBox_adato = new System.Windows.Forms.TextBox();
            this.textBox_udato = new System.Windows.Forms.TextBox();
            this.textBox_knr = new System.Windows.Forms.TextBox();
            this.textBox_adr = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_levadresse = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navn*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kundenr*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Udl. dato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Afl. dato";
            // 
            // textBox_navn
            // 
            this.textBox_navn.Location = new System.Drawing.Point(112, 104);
            this.textBox_navn.Name = "textBox_navn";
            this.textBox_navn.Size = new System.Drawing.Size(247, 22);
            this.textBox_navn.TabIndex = 5;
            // 
            // textBox_adato
            // 
            this.textBox_adato.Location = new System.Drawing.Point(112, 325);
            this.textBox_adato.Name = "textBox_adato";
            this.textBox_adato.Size = new System.Drawing.Size(247, 22);
            this.textBox_adato.TabIndex = 6;
            // 
            // textBox_udato
            // 
            this.textBox_udato.Location = new System.Drawing.Point(112, 292);
            this.textBox_udato.Name = "textBox_udato";
            this.textBox_udato.Size = new System.Drawing.Size(247, 22);
            this.textBox_udato.TabIndex = 7;
            // 
            // textBox_knr
            // 
            this.textBox_knr.Location = new System.Drawing.Point(112, 239);
            this.textBox_knr.Name = "textBox_knr";
            this.textBox_knr.Size = new System.Drawing.Size(247, 22);
            this.textBox_knr.TabIndex = 8;
            // 
            // textBox_adr
            // 
            this.textBox_adr.Location = new System.Drawing.Point(112, 138);
            this.textBox_adr.Multiline = true;
            this.textBox_adr.Name = "textBox_adr";
            this.textBox_adr.Size = new System.Drawing.Size(247, 83);
            this.textBox_adr.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(45, 442);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 21);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Kræver kørekort";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(44, 469);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 21);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Levering";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(44, 496);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(98, 21);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Afhentning";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 564);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lev. adresse";
            this.label6.Visible = false;
            this.label6.VisibleChanged += new System.EventHandler(this.label6_VisibleChanged);
            // 
            // textBox_levadresse
            // 
            this.textBox_levadresse.Location = new System.Drawing.Point(141, 565);
            this.textBox_levadresse.Multiline = true;
            this.textBox_levadresse.Name = "textBox_levadresse";
            this.textBox_levadresse.Size = new System.Drawing.Size(218, 79);
            this.textBox_levadresse.TabIndex = 14;
            this.textBox_levadresse.Visible = false;
            this.textBox_levadresse.TextChanged += new System.EventHandler(this.textBox_levadresse_TextChanged);
            this.textBox_levadresse.VisibleChanged += new System.EventHandler(this.label6_VisibleChanged);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(1243, 548);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(172, 76);
            this.button_save.TabIndex = 15;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(774, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Vælg produkt*";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(777, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(638, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(794, 175);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 18;
            // 
            // CreateBooking2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 655);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_levadresse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox_adr);
            this.Controls.Add(this.textBox_knr);
            this.Controls.Add(this.textBox_udato);
            this.Controls.Add(this.textBox_adato);
            this.Controls.Add(this.textBox_navn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateBooking2";
            this.Text = "CreateBooking2";
            this.Load += new System.EventHandler(this.CreateBooking2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_navn;
        private System.Windows.Forms.TextBox textBox_adato;
        private System.Windows.Forms.TextBox textBox_udato;
        private System.Windows.Forms.TextBox textBox_knr;
        private System.Windows.Forms.TextBox textBox_adr;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_levadresse;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}