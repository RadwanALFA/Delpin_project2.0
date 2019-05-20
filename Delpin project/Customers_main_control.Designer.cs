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
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.AddPrivateCustomerbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Location = new System.Drawing.Point(450, 58);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.ReadOnly = true;
            this.CustomersDataGridView.Size = new System.Drawing.Size(402, 220);
            this.CustomersDataGridView.TabIndex = 0;
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtextBox.Location = new System.Drawing.Point(450, 21);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(225, 22);
            this.SearchtextBox.TabIndex = 1;
            this.SearchtextBox.Text = "Search for a customer";
            this.SearchtextBox.Click += new System.EventHandler(this.Answer_Enter);
            this.SearchtextBox.TextChanged += new System.EventHandler(this.Answer_Enter);
            this.SearchtextBox.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(708, 21);
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
            this.AddPrivateCustomerbtn.Location = new System.Drawing.Point(18, 15);
            this.AddPrivateCustomerbtn.Name = "AddPrivateCustomerbtn";
            this.AddPrivateCustomerbtn.Size = new System.Drawing.Size(184, 26);
            this.AddPrivateCustomerbtn.TabIndex = 3;
            this.AddPrivateCustomerbtn.Text = "Add new private customer";
            this.AddPrivateCustomerbtn.UseVisualStyleBackColor = true;
            this.AddPrivateCustomerbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Customers_main_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AddPrivateCustomerbtn);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.CustomersDataGridView);
            this.Name = "Customers_main_control";
            this.Size = new System.Drawing.Size(883, 488);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersDataGridView;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button AddPrivateCustomerbtn;
    }
}
