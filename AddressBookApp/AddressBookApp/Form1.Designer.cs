namespace AddressBookApp
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.personalContactTextBox = new System.Windows.Forms.TextBox();
            this.homeContactTextBox = new System.Windows.Forms.TextBox();
            this.homeAddressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.showAllListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "personal Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Home Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Home Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(210, 80);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // personalContactTextBox
            // 
            this.personalContactTextBox.Location = new System.Drawing.Point(210, 126);
            this.personalContactTextBox.Name = "personalContactTextBox";
            this.personalContactTextBox.Size = new System.Drawing.Size(100, 20);
            this.personalContactTextBox.TabIndex = 7;
            // 
            // homeContactTextBox
            // 
            this.homeContactTextBox.Location = new System.Drawing.Point(210, 168);
            this.homeContactTextBox.Name = "homeContactTextBox";
            this.homeContactTextBox.Size = new System.Drawing.Size(100, 20);
            this.homeContactTextBox.TabIndex = 8;
            // 
            // homeAddressTextBox
            // 
            this.homeAddressTextBox.Location = new System.Drawing.Point(210, 213);
            this.homeAddressTextBox.Name = "homeAddressTextBox";
            this.homeAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.homeAddressTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(210, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(91, 20);
            this.nameTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(421, 193);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 13;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            // 
            // showAllListBox
            // 
            this.showAllListBox.FormattingEnabled = true;
            this.showAllListBox.Location = new System.Drawing.Point(210, 295);
            this.showAllListBox.Name = "showAllListBox";
            this.showAllListBox.Size = new System.Drawing.Size(120, 95);
            this.showAllListBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 539);
            this.Controls.Add(this.showAllListBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.homeAddressTextBox);
            this.Controls.Add(this.homeContactTextBox);
            this.Controls.Add(this.personalContactTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox personalContactTextBox;
        private System.Windows.Forms.TextBox homeContactTextBox;
        private System.Windows.Forms.TextBox homeAddressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.ListBox showAllListBox;
    }
}

