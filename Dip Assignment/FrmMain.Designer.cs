﻿namespace Dip_Assignment
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.imgCamUser = new Emgu.CV.UI.ImageBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.picCapturedUser = new Emgu.CV.UI.ImageBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAuthenticate = new System.Windows.Forms.Button();
            this.bckGroundTrainer = new System.ComponentModel.BackgroundWorker();
            this.lblTrainingStatus = new System.Windows.Forms.Label();
            this.btnTrain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamUser)).BeginInit();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCapturedUser)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCamUser
            // 
            this.imgCamUser.Location = new System.Drawing.Point(12, 72);
            this.imgCamUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.imgCamUser.Name = "imgCamUser";
            this.imgCamUser.Size = new System.Drawing.Size(571, 984);
            this.imgCamUser.TabIndex = 2;
            this.imgCamUser.TabStop = false;
            this.imgCamUser.Click += new System.EventHandler(this.imgCamUser_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(137, 69);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(16, 23);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "..";
            // 
            // grpOptions
            // 
            this.grpOptions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpOptions.Controls.Add(this.btnBack);
            this.grpOptions.Controls.Add(this.picCapturedUser);
            this.grpOptions.Controls.Add(this.btnSave);
            this.grpOptions.Controls.Add(this.btnClear);
            this.grpOptions.Controls.Add(this.btnAuthenticate);
            this.grpOptions.Controls.Add(this.lblMessage);
            this.grpOptions.Location = new System.Drawing.Point(599, 72);
            this.grpOptions.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpOptions.Size = new System.Drawing.Size(367, 490);
            this.grpOptions.TabIndex = 5;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(247, 265);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 53);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picCapturedUser
            // 
            this.picCapturedUser.Location = new System.Drawing.Point(29, 74);
            this.picCapturedUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picCapturedUser.Name = "picCapturedUser";
            this.picCapturedUser.Size = new System.Drawing.Size(200, 354);
            this.picCapturedUser.TabIndex = 2;
            this.picCapturedUser.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(247, 138);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 53);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(247, 202);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 53);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthenticate.Location = new System.Drawing.Point(247, 74);
            this.btnAuthenticate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(96, 53);
            this.btnAuthenticate.TabIndex = 6;
            this.btnAuthenticate.Text = "Authenticate";
            this.btnAuthenticate.UseVisualStyleBackColor = true;
            this.btnAuthenticate.Click += new System.EventHandler(this.btnAuthenticate_Click);
            // 
            // bckGroundTrainer
            // 
            this.bckGroundTrainer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckGroundTrainer_DoWork);
            this.bckGroundTrainer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bckGroundTrainer_RunWorkerCompleted);
            // 
            // lblTrainingStatus
            // 
            this.lblTrainingStatus.AutoSize = true;
            this.lblTrainingStatus.Location = new System.Drawing.Point(12, 1079);
            this.lblTrainingStatus.Name = "lblTrainingStatus";
            this.lblTrainingStatus.Size = new System.Drawing.Size(16, 23);
            this.lblTrainingStatus.TabIndex = 6;
            this.lblTrainingStatus.Text = "..";
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(451, 1067);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(132, 41);
            this.btnTrain.TabIndex = 7;
            this.btnTrain.Text = "Train Recognizer";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 615);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.lblTrainingStatus);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.imgCamUser);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCamUser)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCapturedUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgCamUser;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Button btnAuthenticate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private Emgu.CV.UI.ImageBox picCapturedUser;
        private System.ComponentModel.BackgroundWorker bckGroundTrainer;
        private System.Windows.Forms.Label lblTrainingStatus;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnBack;
    }
}

