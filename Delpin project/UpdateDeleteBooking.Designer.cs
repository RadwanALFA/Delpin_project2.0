namespace Delpin_project
{
    partial class UpdateDeleteBooking
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
            this.textBox_bnr = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indtast bookingnr.";
            // 
            // textBox_bnr
            // 
            this.textBox_bnr.Location = new System.Drawing.Point(242, 99);
            this.textBox_bnr.Name = "textBox_bnr";
            this.textBox_bnr.Size = new System.Drawing.Size(288, 22);
            this.textBox_bnr.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(117, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 335);
            this.dataGridView1.TabIndex = 2;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(117, 550);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(168, 82);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(659, 550);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(155, 82);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "CANCEL";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(1211, 550);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(161, 82);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // UpdateDeleteBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 655);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_bnr);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDeleteBooking";
            this.Text = "UpdateDeleteBooking";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_bnr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
    }
}