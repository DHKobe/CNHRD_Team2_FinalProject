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
            this.pnl_imageContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_mainimage = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.cb_monitoring = new System.Windows.Forms.ComboBox();
            this.cb_productionlist = new System.Windows.Forms.ComboBox();
            this.cb_operation = new System.Windows.Forms.ComboBox();
            this.cb_employees = new System.Windows.Forms.ComboBox();
            this.pnl_imageContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mainimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.cb_employees);
            this.panel1.Controls.Add(this.cb_operation);
            this.panel1.Controls.Add(this.cb_productionlist);
            this.panel1.Controls.Add(this.cb_monitoring);
            this.panel1.Location = new System.Drawing.Point(296, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 112);
            this.panel1.TabIndex = 3;
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
            // pb_logo
            // 
            this.pb_logo.Image = global::CNHRD_Team2_FinalProject.Properties.Resources.제목_없음1;
            this.pb_logo.Location = new System.Drawing.Point(16, 24);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(296, 88);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 1;
            this.pb_logo.TabStop = false;
            // 
            // cb_monitoring
            // 
            this.cb_monitoring.BackColor = System.Drawing.Color.White;
            this.cb_monitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_monitoring.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_monitoring.ForeColor = System.Drawing.Color.DarkBlue;
            this.cb_monitoring.FormattingEnabled = true;
            this.cb_monitoring.Location = new System.Drawing.Point(40, 40);
            this.cb_monitoring.Name = "cb_monitoring";
            this.cb_monitoring.Size = new System.Drawing.Size(136, 32);
            this.cb_monitoring.TabIndex = 1;
            this.cb_monitoring.TabStop = false;
            this.cb_monitoring.Text = "모니터링";
            // 
            // cb_productionlist
            // 
            this.cb_productionlist.BackColor = System.Drawing.Color.White;
            this.cb_productionlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_productionlist.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_productionlist.ForeColor = System.Drawing.Color.DarkBlue;
            this.cb_productionlist.FormattingEnabled = true;
            this.cb_productionlist.Location = new System.Drawing.Point(208, 40);
            this.cb_productionlist.Name = "cb_productionlist";
            this.cb_productionlist.Size = new System.Drawing.Size(136, 32);
            this.cb_productionlist.TabIndex = 2;
            this.cb_productionlist.TabStop = false;
            this.cb_productionlist.Text = "생산목록";
            // 
            // cb_operation
            // 
            this.cb_operation.BackColor = System.Drawing.Color.White;
            this.cb_operation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_operation.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_operation.ForeColor = System.Drawing.Color.DarkBlue;
            this.cb_operation.FormattingEnabled = true;
            this.cb_operation.Location = new System.Drawing.Point(376, 40);
            this.cb_operation.Name = "cb_operation";
            this.cb_operation.Size = new System.Drawing.Size(136, 32);
            this.cb_operation.TabIndex = 3;
            this.cb_operation.TabStop = false;
            this.cb_operation.Text = "가동분석";
            // 
            // cb_employees
            // 
            this.cb_employees.BackColor = System.Drawing.Color.White;
            this.cb_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_employees.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_employees.ForeColor = System.Drawing.Color.DarkBlue;
            this.cb_employees.FormattingEnabled = true;
            this.cb_employees.Location = new System.Drawing.Point(544, 40);
            this.cb_employees.Name = "cb_employees";
            this.cb_employees.Size = new System.Drawing.Size(136, 32);
            this.cb_employees.TabIndex = 4;
            this.cb_employees.TabStop = false;
            this.cb_employees.Text = "직원관리";
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
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_imageContainer);
            this.Controls.Add(this.pb_logo);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.pnl_imageContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_mainimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.PictureBox pb_mainimage;
        private System.Windows.Forms.Panel pnl_imageContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_monitoring;
        private System.Windows.Forms.ComboBox cb_employees;
        private System.Windows.Forms.ComboBox cb_operation;
        private System.Windows.Forms.ComboBox cb_productionlist;
    }
}