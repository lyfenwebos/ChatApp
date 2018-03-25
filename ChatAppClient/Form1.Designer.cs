namespace ChatAppClient
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.textPanel = new System.Windows.Forms.Panel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.messagePanel.SuspendLayout();
            this.textPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.AutoScroll = true;
            this.leftPanel.Controls.Add(this.panel1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(189, 503);
            this.leftPanel.TabIndex = 0;
            // 
            // messagePanel
            // 
            this.messagePanel.Controls.Add(this.messageTextBox);
            this.messagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.messagePanel.Location = new System.Drawing.Point(189, 0);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(463, 390);
            this.messagePanel.TabIndex = 1;
            // 
            // textPanel
            // 
            this.textPanel.Controls.Add(this.textBox);
            this.textPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPanel.Location = new System.Drawing.Point(189, 390);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(463, 113);
            this.textPanel.TabIndex = 2;
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextBox.Location = new System.Drawing.Point(0, 0);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(463, 390);
            this.messageTextBox.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.AcceptsTab = true;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(463, 113);
            this.textBox.TabIndex = 0;
            this.textBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 113);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(652, 503);
            this.Controls.Add(this.textPanel);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.leftPanel.ResumeLayout(false);
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.textPanel.ResumeLayout(false);
            this.textPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Panel textPanel;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel panel1;
    }
}

