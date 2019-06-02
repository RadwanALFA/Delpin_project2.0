namespace Delpin_project
{
    partial class Customers_main_control
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
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.AddPrivateCustomerbtn = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Editebtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtextBox.Location = new System.Drawing.Point(386, 41);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(225, 22);
            this.SearchtextBox.TabIndex = 1;
            this.SearchtextBox.Text = "Search for a customer";
            this.SearchtextBox.Click += new System.EventHandler(this.Answer_Enter);
            this.SearchtextBox.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(617, 40);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(75, 23);
            this.Searchbtn.TabIndex = 2;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // AddPrivateCustomerbtn
            // 
            this.AddPrivateCustomerbtn.AutoSize = true;
            this.AddPrivateCustomerbtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPrivateCustomerbtn.Location = new System.Drawing.Point(31, 120);
            this.AddPrivateCustomerbtn.Name = "AddPrivateCustomerbtn";
            this.AddPrivateCustomerbtn.Size = new System.Drawing.Size(151, 26);
            this.AddPrivateCustomerbtn.TabIndex = 3;
            this.AddPrivateCustomerbtn.Text = "Tilføj private kunde";
            this.AddPrivateCustomerbtn.UseVisualStyleBackColor = true;
            this.AddPrivateCustomerbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(211, 78);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(669, 338);
            this.dgvCustomers.TabIndex = 4;
            this.dgvCustomers.DoubleClick += new System.EventHandler(this.dgvCustomers_DoubleClick);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Enabled = false;
            this.Deletebtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(211, 431);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 25);
            this.Deletebtn.TabIndex = 5;
            this.Deletebtn.Text = "Slet";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Editebtn
            // 
            this.Editebtn.Enabled = false;
            this.Editebtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editebtn.Location = new System.Drawing.Point(292, 431);
            this.Editebtn.Name = "Editebtn";
            this.Editebtn.Size = new System.Drawing.Size(75, 25);
            this.Editebtn.TabIndex = 6;
            this.Editebtn.Text = "Redigere";
            this.Editebtn.UseVisualStyleBackColor = true;
            this.Editebtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(31, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 26);
            this.button3.TabIndex = 7;
            this.button3.Text = "Tilføj erhvers kunde";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Customers_main_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Editebtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.AddPrivateCustomerbtn);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.SearchtextBox);
            this.Name = "Customers_main_control";
            this.Size = new System.Drawing.Size(883, 488);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button AddPrivateCustomerbtn;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Editebtn;
        private System.Windows.Forms.Button button3;
    }
}
