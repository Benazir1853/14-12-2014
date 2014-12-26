namespace CustomerRegApp
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
            this.regNoTextbox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.showAllButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.showAllListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // regNoTextbox
            // 
            this.regNoTextbox.Location = new System.Drawing.Point(156, 79);
            this.regNoTextbox.Name = "regNoTextbox";
            this.regNoTextbox.Size = new System.Drawing.Size(100, 20);
            this.regNoTextbox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(156, 165);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(268, 242);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 4;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(78, 242);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showAllListBox
            // 
            this.showAllListBox.FormattingEnabled = true;
            this.showAllListBox.Location = new System.Drawing.Point(168, 318);
            this.showAllListBox.Name = "showAllListBox";
            this.showAllListBox.Size = new System.Drawing.Size(120, 95);
            this.showAllListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 470);
            this.Controls.Add(this.showAllListBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.regNoTextbox);
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
        private System.Windows.Forms.TextBox regNoTextbox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox showAllListBox;
    }
}

