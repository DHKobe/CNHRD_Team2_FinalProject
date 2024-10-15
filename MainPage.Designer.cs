namespace CNHRD_Team2_FinalProject
{
    partial class MainPage
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
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.pb_mainimage = new System.Windows.Forms.PictureBox();
            this.pnl_imageContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mainimage)).BeginInit();
            this.pnl_imageContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::CNHRD_Team2_FinalProject.Properties.Resources.제목_없음;
            this.pb_logo.Location = new System.Drawing.Point(16, 32);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(256, 64);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 1;
            this.pb_logo.TabStop = false;
            // 
            // pb_mainimage
            // 
            this.pb_mainimage.Location = new System.Drawing.Point(8, 8);
            this.pb_mainimage.Name = "pb_mainimage";
            this.pb_mainimage.Size = new System.Drawing.Size(1232, 504);
            this.pb_mainimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_mainimage.TabIndex = 0;
            this.pb_mainimage.TabStop = false;
            // 
            // pnl_imageContainer
            // 
            this.pnl_imageContainer.Controls.Add(this.pb_mainimage);
            this.pnl_imageContainer.Location = new System.Drawing.Point(8, 152);
            this.pnl_imageContainer.Name = "pnl_imageContainer";
            this.pnl_imageContainer.Size = new System.Drawing.Size(1248, 520);
            this.pnl_imageContainer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_EmployeeManagement);
            this.panel1.Controls.Add(this.bt_OperationAnalysis);
            this.panel1.Controls.Add(this.bt_DowntimeAnalysis);
            this.panel1.Controls.Add(this.bt_ProductionList);
            this.panel1.Controls.Add(this.bt_Monitoring);
            this.panel1.Location = new System.Drawing.Point(336, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 80);
            this.panel1.TabIndex = 3;
            // 
            // bt_Monitoring
            // 
            this.bt_Monitoring.Location = new System.Drawing.Point(16, 16);
            this.bt_Monitoring.Name = "bt_Monitoring";
            this.bt_Monitoring.Size = new System.Drawing.Size(112, 48);
            this.bt_Monitoring.TabIndex = 0;
            this.bt_Monitoring.Text = "모니터링";
            this.bt_Monitoring.UseVisualStyleBackColor = true;
            // 
            // bt_ProductionList
            // 
            this.bt_ProductionList.Location = new System.Drawing.Point(168, 16);
            this.bt_ProductionList.Name = "bt_ProductionList";
            this.bt_ProductionList.Size = new System.Drawing.Size(112, 48);
            this.bt_ProductionList.TabIndex = 1;
            this.bt_ProductionList.Text = "생산목록";
            this.bt_ProductionList.UseVisualStyleBackColor = true;
            // 
            // bt_DowntimeAnalysis
            // 
            this.bt_DowntimeAnalysis.Location = new System.Drawing.Point(328, 16);
            this.bt_DowntimeAnalysis.Name = "bt_DowntimeAnalysis";
            this.bt_DowntimeAnalysis.Size = new System.Drawing.Size(112, 48);
            this.bt_DowntimeAnalysis.TabIndex = 2;
            this.bt_DowntimeAnalysis.Text = "비가동분석";
            this.bt_DowntimeAnalysis.UseVisualStyleBackColor = true;
            // 
            // bt_OperationAnalysis
            // 
            this.bt_OperationAnalysis.Location = new System.Drawing.Point(480, 16);
            this.bt_OperationAnalysis.Name = "bt_OperationAnalysis";
            this.bt_OperationAnalysis.Size = new System.Drawing.Size(112, 48);
            this.bt_OperationAnalysis.TabIndex = 3;
            this.bt_OperationAnalysis.Text = "가동분석";
            this.bt_OperationAnalysis.UseVisualStyleBackColor = true;
            // 
            // bt_EmployeeManagement
            // 
            this.bt_EmployeeManagement.Location = new System.Drawing.Point(624, 16);
            this.bt_EmployeeManagement.Name = "bt_EmployeeManagement";
            this.bt_EmployeeManagement.Size = new System.Drawing.Size(112, 48);
            this.bt_EmployeeManagement.TabIndex = 4;
            this.bt_EmployeeManagement.Text = "직원관리";
            this.bt_EmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnl_imageContainer);
            this.Controls.Add(this.pb_logo);
            this.Name = "MainPage";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mainimage)).EndInit();
            this.pnl_imageContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.PictureBox pb_mainimage;
        private System.Windows.Forms.Panel pnl_imageContainer;
    }
}