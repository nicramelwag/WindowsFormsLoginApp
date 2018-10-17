namespace WindowsFormsLoginApp
{
    partial class MainForm
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
            this.dataLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.ChellengeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ChellengeComboBox = new System.Windows.Forms.ComboBox();
            this.ChellengeListBox = new System.Windows.Forms.ListBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(29, 31);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(10, 13);
            this.dataLabel.TabIndex = 0;
            this.dataLabel.Text = " ";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(44, 109);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(179, 29);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit your Personal Data";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(44, 165);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(179, 30);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete Your Account";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ChellengeTextBox
            // 
            this.ChellengeTextBox.Location = new System.Drawing.Point(47, 278);
            this.ChellengeTextBox.Name = "ChellengeTextBox";
            this.ChellengeTextBox.Size = new System.Drawing.Size(301, 20);
            this.ChellengeTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Chellenge";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChellengeComboBox
            // 
            this.ChellengeComboBox.FormattingEnabled = true;
            this.ChellengeComboBox.Location = new System.Drawing.Point(395, 99);
            this.ChellengeComboBox.Name = "ChellengeComboBox";
            this.ChellengeComboBox.Size = new System.Drawing.Size(393, 21);
            this.ChellengeComboBox.TabIndex = 5;
            // 
            // ChellengeListBox
            // 
            this.ChellengeListBox.FormattingEnabled = true;
            this.ChellengeListBox.Location = new System.Drawing.Point(395, 155);
            this.ChellengeListBox.Name = "ChellengeListBox";
            this.ChellengeListBox.Size = new System.Drawing.Size(372, 238);
            this.ChellengeListBox.TabIndex = 6;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(47, 385);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(174, 33);
            this.ShowButton.TabIndex = 7;
            this.ShowButton.Text = "Show All Users";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.ChellengeListBox);
            this.Controls.Add(this.ChellengeComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChellengeTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.dataLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox ChellengeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ChellengeComboBox;
        private System.Windows.Forms.ListBox ChellengeListBox;
        private System.Windows.Forms.Button ShowButton;
    }
}