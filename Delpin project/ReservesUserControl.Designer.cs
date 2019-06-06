namespace Delpin_project
{
    partial class ReservesUserControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.FromcomboBox = new System.Windows.Forms.ComboBox();
            this.TocomboBox = new System.Windows.Forms.ComboBox();
            this.CreateDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Editebtn = new System.Windows.Forms.Button();
            this.editeDatelabel = new System.Windows.Forms.Label();
            this.EditeDate = new System.Windows.Forms.DateTimePicker();
            this.EditeTocomboBox = new System.Windows.Forms.ComboBox();
            this.editeTolabel = new System.Windows.Forms.Label();
            this.EditeSavebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ResourceIdtxtbox = new System.Windows.Forms.TextBox();
            this.ErrorLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "til";
            // 
            // FromcomboBox
            // 
            this.FromcomboBox.FormattingEnabled = true;
            this.FromcomboBox.Location = new System.Drawing.Point(67, 105);
            this.FromcomboBox.Name = "FromcomboBox";
            this.FromcomboBox.Size = new System.Drawing.Size(156, 21);
            this.FromcomboBox.TabIndex = 2;
            this.FromcomboBox.Click += new System.EventHandler(this.FromcomboBox_Click);
            // 
            // TocomboBox
            // 
            this.TocomboBox.FormattingEnabled = true;
            this.TocomboBox.Location = new System.Drawing.Point(277, 105);
            this.TocomboBox.Name = "TocomboBox";
            this.TocomboBox.Size = new System.Drawing.Size(156, 21);
            this.TocomboBox.TabIndex = 3;
            this.TocomboBox.Click += new System.EventHandler(this.TocomboBox_Click);
            // 
            // CreateDate
            // 
            this.CreateDate.Location = new System.Drawing.Point(502, 106);
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Size = new System.Drawing.Size(200, 20);
            this.CreateDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dato";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(343, 236);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Enabled = false;
            this.Deletebtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Deletebtn.Location = new System.Drawing.Point(34, 434);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 27);
            this.Deletebtn.TabIndex = 7;
            this.Deletebtn.Text = "Slet";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Editebtn
            // 
            this.Editebtn.Enabled = false;
            this.Editebtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editebtn.Location = new System.Drawing.Point(115, 434);
            this.Editebtn.Name = "Editebtn";
            this.Editebtn.Size = new System.Drawing.Size(75, 27);
            this.Editebtn.TabIndex = 8;
            this.Editebtn.Text = "Redigere";
            this.Editebtn.UseVisualStyleBackColor = true;
            this.Editebtn.Click += new System.EventHandler(this.Editebtn_Click);
            // 
            // editeDatelabel
            // 
            this.editeDatelabel.AutoSize = true;
            this.editeDatelabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editeDatelabel.Location = new System.Drawing.Point(594, 192);
            this.editeDatelabel.Name = "editeDatelabel";
            this.editeDatelabel.Size = new System.Drawing.Size(37, 16);
            this.editeDatelabel.TabIndex = 12;
            this.editeDatelabel.Text = "Date";
            this.editeDatelabel.Visible = false;
            // 
            // EditeDate
            // 
            this.EditeDate.Location = new System.Drawing.Point(633, 190);
            this.EditeDate.Name = "EditeDate";
            this.EditeDate.Size = new System.Drawing.Size(200, 20);
            this.EditeDate.TabIndex = 11;
            this.EditeDate.Visible = false;
            // 
            // EditeTocomboBox
            // 
            this.EditeTocomboBox.FormattingEnabled = true;
            this.EditeTocomboBox.Location = new System.Drawing.Point(411, 189);
            this.EditeTocomboBox.Name = "EditeTocomboBox";
            this.EditeTocomboBox.Size = new System.Drawing.Size(156, 21);
            this.EditeTocomboBox.TabIndex = 10;
            this.EditeTocomboBox.Visible = false;
            this.EditeTocomboBox.Click += new System.EventHandler(this.EditeTocomboBox_Click);
            // 
            // editeTolabel
            // 
            this.editeTolabel.AutoSize = true;
            this.editeTolabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editeTolabel.Location = new System.Drawing.Point(382, 190);
            this.editeTolabel.Name = "editeTolabel";
            this.editeTolabel.Size = new System.Drawing.Size(23, 16);
            this.editeTolabel.TabIndex = 9;
            this.editeTolabel.Text = "To";
            this.editeTolabel.Visible = false;
            // 
            // EditeSavebtn
            // 
            this.EditeSavebtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditeSavebtn.Location = new System.Drawing.Point(411, 216);
            this.EditeSavebtn.Name = "EditeSavebtn";
            this.EditeSavebtn.Size = new System.Drawing.Size(75, 23);
            this.EditeSavebtn.TabIndex = 13;
            this.EditeSavebtn.Text = "Gem";
            this.EditeSavebtn.UseVisualStyleBackColor = true;
            this.EditeSavebtn.Visible = false;
            this.EditeSavebtn.Click += new System.EventHandler(this.EditeSavebtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(729, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Gem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(502, 216);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 15;
            this.Cancelbtn.Text = "fortryde";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Visible = false;
            this.Cancelbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Resource Id";
            // 
            // ResourceIdtxtbox
            // 
            this.ResourceIdtxtbox.Location = new System.Drawing.Point(108, 27);
            this.ResourceIdtxtbox.Name = "ResourceIdtxtbox";
            this.ResourceIdtxtbox.Size = new System.Drawing.Size(115, 20);
            this.ResourceIdtxtbox.TabIndex = 17;
            this.ResourceIdtxtbox.Leave += new System.EventHandler(this.ResourceIdtxtbox_Leave);
            // 
            // ErrorLabel1
            // 
            this.ErrorLabel1.AutoSize = true;
            this.ErrorLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel1.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel1.Location = new System.Drawing.Point(229, 29);
            this.ErrorLabel1.Name = "ErrorLabel1";
            this.ErrorLabel1.Size = new System.Drawing.Size(68, 16);
            this.ErrorLabel1.TabIndex = 18;
            this.ErrorLabel1.Text = "Invalid ID";
            this.ErrorLabel1.Visible = false;
            // 
            // ReservesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ErrorLabel1);
            this.Controls.Add(this.ResourceIdtxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EditeSavebtn);
            this.Controls.Add(this.editeDatelabel);
            this.Controls.Add(this.EditeDate);
            this.Controls.Add(this.EditeTocomboBox);
            this.Controls.Add(this.editeTolabel);
            this.Controls.Add(this.Editebtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateDate);
            this.Controls.Add(this.TocomboBox);
            this.Controls.Add(this.FromcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReservesUserControl";
            this.Size = new System.Drawing.Size(883, 488);
            this.Leave += new System.EventHandler(this.ReservesUserControl_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FromcomboBox;
        private System.Windows.Forms.ComboBox TocomboBox;
        private System.Windows.Forms.DateTimePicker CreateDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Editebtn;
        private System.Windows.Forms.Label editeDatelabel;
        private System.Windows.Forms.DateTimePicker EditeDate;
        private System.Windows.Forms.ComboBox EditeTocomboBox;
        private System.Windows.Forms.Label editeTolabel;
        private System.Windows.Forms.Button EditeSavebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ResourceIdtxtbox;
        private System.Windows.Forms.Label ErrorLabel1;
    }
}
