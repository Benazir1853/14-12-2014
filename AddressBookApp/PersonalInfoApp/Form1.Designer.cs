namespace PersonalInfoApp
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
            this.showAllListBox = new System.Windows.Forms.ListBox();
            this.showAllButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.homeAddressTextBox = new System.Windows.Forms.TextBox();
            this.homeContactTextBox = new System.Windows.Forms.TextBox();
            this.personalContactTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showAllListBox
            // 
            this.showAllListBox.FormattingEnabled = true;
            this.showAllListBox.Location = new System.Drawing.Point(146, 218);
            this.showAllListBox.Name = "showAllListBox";
            this.showAllListBox.Size = new System.Drawing.Size(120, 95);
            this.showAllListBox.TabIndex = 28;
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(357, 119);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 27;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(146, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(91, 20);
            this.nameTextBox.TabIndex = 25;
            // 
            // homeAddressTextBox
            // 
            this.homeAddressTextBox.Location = new System.Drawing.Point(146, 169);
            this.homeAddressTextBox.Name = "homeAddressTextBox";
            this.homeAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.homeAddressTextBox.TabIndex = 24;
            // 
            // homeContactTextBox
            // 
            this.homeContactTextBox.Location = new System.Drawing.Point(146, 137);
            this.homeContactTextBox.Name = "homeContactTextBox";
            this.homeContactTextBox.Size = new System.Drawing.Size(100, 20);
            this.homeContactTextBox.TabIndex = 23;
            // 
            // personalContactTextBox
            // 
            this.personalContactTextBox.Location = new System.Drawing.Point(146, 92);
            this.personalContactTextBox.Name = "personalContactTextBox";
            this.personalContactTextBox.Size = new System.Drawing.Size(100, 20);
            this.personalContactTextBox.TabIndex = 22;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(146, 56);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Home Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Home Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "personal Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 544);
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

        private System.Windows.Forms.ListBox showAllListBox;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox homeAddressTextBox;
        private System.Windows.Forms.TextBox homeContactTextBox;
        private System.Windows.Forms.TextBox personalContactTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

