namespace Delpin_project
{
    partial class ProductOverView
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
            this.label3 = new System.Windows.Forms.Label();
            this.MaincomboBox = new System.Windows.Forms.ComboBox();
            this.ProductcomboBox = new System.Windows.Forms.ComboBox();
            this.CatagorycomboBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catagory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resorce";
            // 
            // MaincomboBox
            // 
            this.MaincomboBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaincomboBox.FormattingEnabled = true;
            this.MaincomboBox.Location = new System.Drawing.Point(152, 34);
            this.MaincomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaincomboBox.Name = "MaincomboBox";
            this.MaincomboBox.Size = new System.Drawing.Size(224, 22);
            this.MaincomboBox.TabIndex = 3;
            this.MaincomboBox.SelectedIndexChanged += new System.EventHandler(this.MaincomboBox_SelectedIndexChanged);
            // 
            // ProductcomboBox
            // 
            this.ProductcomboBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductcomboBox.FormattingEnabled = true;
            this.ProductcomboBox.Location = new System.Drawing.Point(152, 144);
            this.ProductcomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductcomboBox.Name = "ProductcomboBox";
            this.ProductcomboBox.Size = new System.Drawing.Size(224, 22);
            this.ProductcomboBox.TabIndex = 4;
            this.ProductcomboBox.SelectedIndexChanged += new System.EventHandler(this.ProductcomboBox_SelectedIndexChanged);
            // 
            // CatagorycomboBox
            // 
            this.CatagorycomboBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatagorycomboBox.FormattingEnabled = true;
            this.CatagorycomboBox.Location = new System.Drawing.Point(152, 89);
            this.CatagorycomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CatagorycomboBox.Name = "CatagorycomboBox";
            this.CatagorycomboBox.Size = new System.Drawing.Size(224, 22);
            this.CatagorycomboBox.TabIndex = 5;
            this.CatagorycomboBox.SelectedIndexChanged += new System.EventHandler(this.CatagorycomboBox_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(66, 176);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(471, 292);
            this.listBox1.TabIndex = 7;
            // 
            // ProductOverView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CatagorycomboBox);
            this.Controls.Add(this.ProductcomboBox);
            this.Controls.Add(this.MaincomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductOverView";
            this.Size = new System.Drawing.Size(883, 488);
            this.Load += new System.EventHandler(this.ProductOverView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MaincomboBox;
        private System.Windows.Forms.ComboBox ProductcomboBox;
        private System.Windows.Forms.ComboBox CatagorycomboBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}
