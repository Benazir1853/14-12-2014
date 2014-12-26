namespace CustomerInfoApp
{
    partial class Form1
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
            this.customerInfoTextBox = new System.Windows.Forms.TextBox();
            this.showAllListBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // customerInfoTextBox
            // 
            this.customerInfoTextBox.Location = new System.Drawing.Point(162, 31);
            this.customerInfoTextBox.Name = "customerInfoTextBox";
            this.customerInfoTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerInfoTextBox.TabIndex = 2;
            // 
            // showAllListBox
            // 
            this.showAllListBox.Location = new System.Drawing.Point(162, 192);
            this.showAllListBox.Multiline = true;
            this.showAllListBox.Name = "showAllListBox";
            this.showAllListBox.Size = new System.Drawing.Size(100, 135);
            this.showAllListBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(294, 31);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(294, 91);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 5;
            this.showAllButton.Text = "ShowAll";
            this.showAllButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 393);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.showAllListBox);
            this.Controls.Add(this.customerInfoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerInfoTextBox;
        private System.Windows.Forms.TextBox showAllListBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showAllButton;
    }
}

