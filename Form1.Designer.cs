namespace LLMAntivirusChatbot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUserInput = new TextBox();
            btnSend = new Button();
            rtbChat = new RichTextBox();
            SuspendLayout();
            // 
            // txtUserInput
            // 
            txtUserInput.Dock = DockStyle.Bottom;
            txtUserInput.Location = new Point(0, 423);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(800, 27);
            txtUserInput.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.Dock = DockStyle.Bottom;
            btnSend.Location = new Point(0, 394);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(800, 29);
            btnSend.TabIndex = 1;
            btnSend.Text = "Gönder";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // rtbChat
            // 
            rtbChat.Dock = DockStyle.Top;
            rtbChat.Location = new Point(0, 0);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(800, 388);
            rtbChat.TabIndex = 2;
            rtbChat.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbChat);
            Controls.Add(btnSend);
            Controls.Add(txtUserInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserInput;
        private Button btnSend;
        private RichTextBox rtbChat;
    }
}
