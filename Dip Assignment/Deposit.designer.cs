namespace Dip_Assignment
{
    partial class Deposit
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
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(58, 36);
            this.txtWithdraw.Multiline = true;
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(225, 51);
            this.txtWithdraw.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 196);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWithdraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Deposit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}