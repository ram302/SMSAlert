
namespace SMSAlert
{
    partial class Main
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
            this.SMS_Input = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SMS_Input
            // 
            this.SMS_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMS_Input.Location = new System.Drawing.Point(31, 37);
            this.SMS_Input.Margin = new System.Windows.Forms.Padding(5);
            this.SMS_Input.Name = "SMS_Input";
            this.SMS_Input.Size = new System.Drawing.Size(737, 49);
            this.SMS_Input.TabIndex = 0;
            this.SMS_Input.Text = "Enter your message here...";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(567, 110);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(201, 44);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 166);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SMS_Input);
            this.Name = "Main";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SMS_Input;
        private System.Windows.Forms.Button SendButton;
    }
}

