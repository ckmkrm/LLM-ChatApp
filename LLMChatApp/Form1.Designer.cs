namespace LLMChatApp
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(23, 474);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(715, 106);
            this.txtInput.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSend.Location = new System.Drawing.Point(744, 487);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(78, 33);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Gönder";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(23, 30);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbOutput.Size = new System.Drawing.Size(833, 408);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblStatus.Location = new System.Drawing.Point(776, 560);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Hazır";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(890, 601);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label lblStatus;
    }
}

