namespace Delpin_project
{
    partial class UpdateOrDeleteBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchtxtBox = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Editebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PickUpCheckbox = new System.Windows.Forms.CheckBox();
            this.DeliveryCheckbox = new System.Windows.Forms.CheckBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.deleviryaddressLable = new System.Windows.Forms.Label();
            this.deliveryaddresstxtbox = new System.Windows.Forms.TextBox();
            this.AccessoryComboBox = new System.Windows.Forms.ComboBox();
            this.accessoryStartDate = new System.Windows.Forms.DateTimePicker();
            this.accessoryEndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kunde ID";
            // 
            // SearchtxtBox
            // 
            this.SearchtxtBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtxtBox.Location = new System.Drawing.Point(455, 22);
            this.SearchtxtBox.Name = "SearchtxtBox";
            this.SearchtxtBox.Size = new System.Drawing.Size(142, 22);
            this.SearchtxtBox.TabIndex = 1;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(603, 17);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(82, 33);
            this.Searchbtn.TabIndex = 2;
            this.Searchbtn.Text = "Søg";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(494, 393);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Enabled = false;
            this.Deletebtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(375, 455);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(84, 28);
            this.Deletebtn.TabIndex = 4;
            this.Deletebtn.Text = "Slet";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Editebtn
            // 
            this.Editebtn.Enabled = false;
            this.Editebtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editebtn.Location = new System.Drawing.Point(482, 455);
            this.Editebtn.Name = "Editebtn";
            this.Editebtn.Size = new System.Drawing.Size(84, 28);
            this.Editebtn.TabIndex = 5;
            this.Editebtn.Text = "redigere";
            this.Editebtn.UseVisualStyleBackColor = true;
            this.Editebtn.Click += new System.EventHandler(this.Editebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Res. Start Dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Res. Slut Dato";
            // 
            // PickUpCheckbox
            // 
            this.PickUpCheckbox.AutoSize = true;
            this.PickUpCheckbox.Enabled = false;
            this.PickUpCheckbox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickUpCheckbox.Location = new System.Drawing.Point(32, 304);
            this.PickUpCheckbox.Name = "PickUpCheckbox";
            this.PickUpCheckbox.Size = new System.Drawing.Size(96, 20);
            this.PickUpCheckbox.TabIndex = 8;
            this.PickUpCheckbox.Text = "Afhentning";
            this.PickUpCheckbox.UseVisualStyleBackColor = true;
            this.PickUpCheckbox.CheckedChanged += new System.EventHandler(this.PickUpCheckbox_CheckedChanged);
            // 
            // DeliveryCheckbox
            // 
            this.DeliveryCheckbox.AutoSize = true;
            this.DeliveryCheckbox.Enabled = false;
            this.DeliveryCheckbox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryCheckbox.Location = new System.Drawing.Point(32, 346);
            this.DeliveryCheckbox.Name = "DeliveryCheckbox";
            this.DeliveryCheckbox.Size = new System.Drawing.Size(83, 20);
            this.DeliveryCheckbox.TabIndex = 9;
            this.DeliveryCheckbox.Text = "Levering";
            this.DeliveryCheckbox.UseVisualStyleBackColor = true;
            this.DeliveryCheckbox.CheckedChanged += new System.EventHandler(this.DeliveryCheckbox_CheckedChanged);
            // 
            // StartDate
            // 
            this.StartDate.Enabled = false;
            this.StartDate.Location = new System.Drawing.Point(145, 68);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 20);
            this.StartDate.TabIndex = 10;
            // 
            // EndDate
            // 
            this.EndDate.Enabled = false;
            this.EndDate.Location = new System.Drawing.Point(145, 113);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(200, 20);
            this.EndDate.TabIndex = 11;
            // 
            // deleviryaddressLable
            // 
            this.deleviryaddressLable.AutoSize = true;
            this.deleviryaddressLable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleviryaddressLable.Location = new System.Drawing.Point(29, 389);
            this.deleviryaddressLable.Name = "deleviryaddressLable";
            this.deleviryaddressLable.Size = new System.Drawing.Size(88, 16);
            this.deleviryaddressLable.TabIndex = 12;
            this.deleviryaddressLable.Text = "Lev. Adresse";
            this.deleviryaddressLable.Visible = false;
            // 
            // deliveryaddresstxtbox
            // 
            this.deliveryaddresstxtbox.Location = new System.Drawing.Point(118, 389);
            this.deliveryaddresstxtbox.Multiline = true;
            this.deliveryaddresstxtbox.Name = "deliveryaddresstxtbox";
            this.deliveryaddresstxtbox.Size = new System.Drawing.Size(200, 94);
            this.deliveryaddresstxtbox.TabIndex = 13;
            this.deliveryaddresstxtbox.Visible = false;
            // 
            // AccessoryComboBox
            // 
            this.AccessoryComboBox.Enabled = false;
            this.AccessoryComboBox.FormattingEnabled = true;
            this.AccessoryComboBox.Location = new System.Drawing.Point(145, 157);
            this.AccessoryComboBox.Name = "AccessoryComboBox";
            this.AccessoryComboBox.Size = new System.Drawing.Size(200, 21);
            this.AccessoryComboBox.TabIndex = 14;
            // 
            // accessoryStartDate
            // 
            this.accessoryStartDate.Enabled = false;
            this.accessoryStartDate.Location = new System.Drawing.Point(145, 201);
            this.accessoryStartDate.Name = "accessoryStartDate";
            this.accessoryStartDate.Size = new System.Drawing.Size(200, 20);
            this.accessoryStartDate.TabIndex = 15;
            // 
            // accessoryEndDate
            // 
            this.accessoryEndDate.Enabled = false;
            this.accessoryEndDate.Location = new System.Drawing.Point(145, 246);
            this.accessoryEndDate.Name = "accessoryEndDate";
            this.accessoryEndDate.Size = new System.Drawing.Size(200, 20);
            this.accessoryEndDate.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tilbehør";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tilb. Start Dato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tilb. Slut Dato";
            // 
            // UpdateOrDeleteBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accessoryEndDate);
            this.Controls.Add(this.accessoryStartDate);
            this.Controls.Add(this.AccessoryComboBox);
            this.Controls.Add(this.deliveryaddresstxtbox);
            this.Controls.Add(this.deleviryaddressLable);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.DeliveryCheckbox);
            this.Controls.Add(this.PickUpCheckbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Editebtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.SearchtxtBox);
            this.Controls.Add(this.label1);
            this.Name = "UpdateOrDeleteBooking";
            this.Size = new System.Drawing.Size(883, 488);
            this.Enter += new System.EventHandler(this.button1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchtxtBox;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Editebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox PickUpCheckbox;
        private System.Windows.Forms.CheckBox DeliveryCheckbox;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label deleviryaddressLable;
        private System.Windows.Forms.TextBox deliveryaddresstxtbox;
        private System.Windows.Forms.ComboBox AccessoryComboBox;
        private System.Windows.Forms.DateTimePicker accessoryStartDate;
        private System.Windows.Forms.DateTimePicker accessoryEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
