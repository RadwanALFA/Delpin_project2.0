namespace Delpin_project
{
    partial class CreateBooking
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
            this.deleAddLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.delevCheckBox = new System.Windows.Forms.CheckBox();
            this.pickUpcheckBox = new System.Windows.Forms.CheckBox();
            this.dele_addtextBox = new System.Windows.Forms.TextBox();
            this.MainComboBox = new System.Windows.Forms.ComboBox();
            this.productStartDate = new System.Windows.Forms.DateTimePicker();
            this.productEndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AccessComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AccessEndDate = new System.Windows.Forms.DateTimePicker();
            this.AccessStartDate = new System.Windows.Forms.DateTimePicker();
            this.CatagoryComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.CPR_textBox = new System.Windows.Forms.TextBox();
            this.Errorlabel1 = new System.Windows.Forms.Label();
            this.Errorlabel2 = new System.Windows.Forms.Label();
            this.Errorlabel3 = new System.Windows.Forms.Label();
            this.Errorlabel4 = new System.Windows.Forms.Label();
            this.ErrorLabel5 = new System.Windows.Forms.Label();
            this.ErrorLabel6 = new System.Windows.Forms.Label();
            this.CVRtextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleAddLabel
            // 
            this.deleAddLabel.AutoSize = true;
            this.deleAddLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleAddLabel.Location = new System.Drawing.Point(145, 382);
            this.deleAddLabel.Name = "deleAddLabel";
            this.deleAddLabel.Size = new System.Drawing.Size(87, 16);
            this.deleAddLabel.TabIndex = 1;
            this.deleAddLabel.Text = "Lev. adresse";
            this.deleAddLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Indtaste Cpr.num";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valg Catagory";
            // 
            // delevCheckBox
            // 
            this.delevCheckBox.AutoSize = true;
            this.delevCheckBox.Enabled = false;
            this.delevCheckBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delevCheckBox.Location = new System.Drawing.Point(21, 379);
            this.delevCheckBox.Name = "delevCheckBox";
            this.delevCheckBox.Size = new System.Drawing.Size(83, 20);
            this.delevCheckBox.TabIndex = 9;
            this.delevCheckBox.Text = "Levering";
            this.delevCheckBox.UseVisualStyleBackColor = true;
            this.delevCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // pickUpcheckBox
            // 
            this.pickUpcheckBox.AutoSize = true;
            this.pickUpcheckBox.Enabled = false;
            this.pickUpcheckBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickUpcheckBox.Location = new System.Drawing.Point(21, 334);
            this.pickUpcheckBox.Name = "pickUpcheckBox";
            this.pickUpcheckBox.Size = new System.Drawing.Size(96, 20);
            this.pickUpcheckBox.TabIndex = 11;
            this.pickUpcheckBox.Text = "Afhentning";
            this.pickUpcheckBox.UseVisualStyleBackColor = true;
            this.pickUpcheckBox.CheckedChanged += new System.EventHandler(this.pickUpcheckBox_CheckedChanged);
            // 
            // dele_addtextBox
            // 
            this.dele_addtextBox.Location = new System.Drawing.Point(241, 382);
            this.dele_addtextBox.Multiline = true;
            this.dele_addtextBox.Name = "dele_addtextBox";
            this.dele_addtextBox.Size = new System.Drawing.Size(208, 97);
            this.dele_addtextBox.TabIndex = 13;
            this.dele_addtextBox.Visible = false;
            // 
            // MainComboBox
            // 
            this.MainComboBox.Enabled = false;
            this.MainComboBox.FormattingEnabled = true;
            this.MainComboBox.Location = new System.Drawing.Point(130, 84);
            this.MainComboBox.Name = "MainComboBox";
            this.MainComboBox.Size = new System.Drawing.Size(179, 21);
            this.MainComboBox.TabIndex = 19;
            this.MainComboBox.SelectedIndexChanged += new System.EventHandler(this.MainComboBox_SelectedIndexChanged);
            // 
            // productStartDate
            // 
            this.productStartDate.Enabled = false;
            this.productStartDate.Location = new System.Drawing.Point(436, 182);
            this.productStartDate.Name = "productStartDate";
            this.productStartDate.Size = new System.Drawing.Size(234, 20);
            this.productStartDate.TabIndex = 20;
            this.productStartDate.ValueChanged += new System.EventHandler(this.productStartDate_ValueChanged);
            // 
            // productEndDate
            // 
            this.productEndDate.Enabled = false;
            this.productEndDate.Location = new System.Drawing.Point(436, 232);
            this.productEndDate.Name = "productEndDate";
            this.productEndDate.Size = new System.Drawing.Size(234, 20);
            this.productEndDate.TabIndex = 21;
            this.productEndDate.ValueChanged += new System.EventHandler(this.productEndDate_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(364, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Start date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(364, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "End date";
            // 
            // Savebtn
            // 
            this.Savebtn.Enabled = false;
            this.Savebtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.Location = new System.Drawing.Point(714, 453);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 24;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tilbehør";
            // 
            // AccessComboBox
            // 
            this.AccessComboBox.Enabled = false;
            this.AccessComboBox.FormattingEnabled = true;
            this.AccessComboBox.Location = new System.Drawing.Point(120, 288);
            this.AccessComboBox.Name = "AccessComboBox";
            this.AccessComboBox.Size = new System.Drawing.Size(212, 21);
            this.AccessComboBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "End date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Start date";
            // 
            // AccessEndDate
            // 
            this.AccessEndDate.Enabled = false;
            this.AccessEndDate.Location = new System.Drawing.Point(436, 319);
            this.AccessEndDate.Name = "AccessEndDate";
            this.AccessEndDate.Size = new System.Drawing.Size(234, 20);
            this.AccessEndDate.TabIndex = 28;
            this.AccessEndDate.ValueChanged += new System.EventHandler(this.AccessEndDate_ValueChanged);
            // 
            // AccessStartDate
            // 
            this.AccessStartDate.Enabled = false;
            this.AccessStartDate.Location = new System.Drawing.Point(436, 269);
            this.AccessStartDate.Name = "AccessStartDate";
            this.AccessStartDate.Size = new System.Drawing.Size(234, 20);
            this.AccessStartDate.TabIndex = 27;
            this.AccessStartDate.ValueChanged += new System.EventHandler(this.AccessStartDate_ValueChanged);
            // 
            // CatagoryComboBox
            // 
            this.CatagoryComboBox.Enabled = false;
            this.CatagoryComboBox.FormattingEnabled = true;
            this.CatagoryComboBox.Location = new System.Drawing.Point(130, 131);
            this.CatagoryComboBox.Name = "CatagoryComboBox";
            this.CatagoryComboBox.Size = new System.Drawing.Size(179, 21);
            this.CatagoryComboBox.TabIndex = 32;
            this.CatagoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CatagoryComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Valg Typen";
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.Enabled = false;
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(120, 214);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(212, 21);
            this.ProductComboBox.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Valg produkt*";
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Enabled = false;
            this.Cancelbtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cancelbtn.Location = new System.Drawing.Point(803, 453);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 38;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CPR_textBox
            // 
            this.CPR_textBox.Location = new System.Drawing.Point(130, 13);
            this.CPR_textBox.Name = "CPR_textBox";
            this.CPR_textBox.Size = new System.Drawing.Size(179, 20);
            this.CPR_textBox.TabIndex = 39;
            this.CPR_textBox.Leave += new System.EventHandler(this.CPRtextBox_Leave);
            // 
            // Errorlabel1
            // 
            this.Errorlabel1.AutoSize = true;
            this.Errorlabel1.ForeColor = System.Drawing.Color.Red;
            this.Errorlabel1.Location = new System.Drawing.Point(676, 186);
            this.Errorlabel1.Name = "Errorlabel1";
            this.Errorlabel1.Size = new System.Drawing.Size(66, 13);
            this.Errorlabel1.TabIndex = 41;
            this.Errorlabel1.Text = "*Invalid date";
            this.Errorlabel1.Visible = false;
            // 
            // Errorlabel2
            // 
            this.Errorlabel2.AutoSize = true;
            this.Errorlabel2.ForeColor = System.Drawing.Color.Red;
            this.Errorlabel2.Location = new System.Drawing.Point(676, 238);
            this.Errorlabel2.Name = "Errorlabel2";
            this.Errorlabel2.Size = new System.Drawing.Size(66, 13);
            this.Errorlabel2.TabIndex = 42;
            this.Errorlabel2.Text = "*Invalid date";
            this.Errorlabel2.Visible = false;
            // 
            // Errorlabel3
            // 
            this.Errorlabel3.AutoSize = true;
            this.Errorlabel3.ForeColor = System.Drawing.Color.Red;
            this.Errorlabel3.Location = new System.Drawing.Point(676, 273);
            this.Errorlabel3.Name = "Errorlabel3";
            this.Errorlabel3.Size = new System.Drawing.Size(66, 13);
            this.Errorlabel3.TabIndex = 43;
            this.Errorlabel3.Text = "*Invalid date";
            this.Errorlabel3.Visible = false;
            // 
            // Errorlabel4
            // 
            this.Errorlabel4.AutoSize = true;
            this.Errorlabel4.ForeColor = System.Drawing.Color.Red;
            this.Errorlabel4.Location = new System.Drawing.Point(676, 325);
            this.Errorlabel4.Name = "Errorlabel4";
            this.Errorlabel4.Size = new System.Drawing.Size(66, 13);
            this.Errorlabel4.TabIndex = 44;
            this.Errorlabel4.Text = "*Invalid date";
            this.Errorlabel4.Visible = false;
            // 
            // ErrorLabel5
            // 
            this.ErrorLabel5.AutoSize = true;
            this.ErrorLabel5.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel5.Location = new System.Drawing.Point(315, 18);
            this.ErrorLabel5.Name = "ErrorLabel5";
            this.ErrorLabel5.Size = new System.Drawing.Size(42, 13);
            this.ErrorLabel5.TabIndex = 45;
            this.ErrorLabel5.Text = "*Invalid";
            this.ErrorLabel5.Visible = false;
            // 
            // ErrorLabel6
            // 
            this.ErrorLabel6.AutoSize = true;
            this.ErrorLabel6.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel6.Location = new System.Drawing.Point(315, 54);
            this.ErrorLabel6.Name = "ErrorLabel6";
            this.ErrorLabel6.Size = new System.Drawing.Size(42, 13);
            this.ErrorLabel6.TabIndex = 48;
            this.ErrorLabel6.Text = "*Invalid";
            this.ErrorLabel6.Visible = false;
            // 
            // CVRtextbox
            // 
            this.CVRtextbox.Location = new System.Drawing.Point(130, 49);
            this.CVRtextbox.Name = "CVRtextbox";
            this.CVRtextbox.Size = new System.Drawing.Size(179, 20);
            this.CVRtextbox.TabIndex = 47;
            this.CVRtextbox.Leave += new System.EventHandler(this.CVRtextbox_Leave_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 16);
            this.label11.TabIndex = 46;
            this.label11.Text = "Indtaste Cvr.num";
            // 
            // CreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ErrorLabel6);
            this.Controls.Add(this.CVRtextbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ErrorLabel5);
            this.Controls.Add(this.Errorlabel4);
            this.Controls.Add(this.Errorlabel3);
            this.Controls.Add(this.Errorlabel2);
            this.Controls.Add(this.Errorlabel1);
            this.Controls.Add(this.CPR_textBox);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.ProductComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CatagoryComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AccessEndDate);
            this.Controls.Add(this.AccessStartDate);
            this.Controls.Add(this.AccessComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.productEndDate);
            this.Controls.Add(this.productStartDate);
            this.Controls.Add(this.MainComboBox);
            this.Controls.Add(this.dele_addtextBox);
            this.Controls.Add(this.pickUpcheckBox);
            this.Controls.Add(this.delevCheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleAddLabel);
            this.Name = "CreateBooking";
            this.Size = new System.Drawing.Size(883, 488);
            this.Enter += new System.EventHandler(this.CreateBooking_Enter);
            this.Leave += new System.EventHandler(this.CreateBooking_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label deleAddLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox delevCheckBox;
        private System.Windows.Forms.CheckBox pickUpcheckBox;
        private System.Windows.Forms.TextBox dele_addtextBox;
        private System.Windows.Forms.ComboBox MainComboBox;
        private System.Windows.Forms.DateTimePicker productStartDate;
        private System.Windows.Forms.DateTimePicker productEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AccessComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker AccessEndDate;
        private System.Windows.Forms.DateTimePicker AccessStartDate;
        private System.Windows.Forms.ComboBox CatagoryComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.TextBox CPR_textBox;
        private System.Windows.Forms.Label Errorlabel1;
        private System.Windows.Forms.Label Errorlabel2;
        private System.Windows.Forms.Label Errorlabel3;
        private System.Windows.Forms.Label Errorlabel4;
        private System.Windows.Forms.Label ErrorLabel5;
        private System.Windows.Forms.Label ErrorLabel6;
        private System.Windows.Forms.TextBox CVRtextbox;
        private System.Windows.Forms.Label label11;
    }
}
