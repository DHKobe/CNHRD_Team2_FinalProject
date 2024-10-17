namespace CNHRD_Team2_FinalProject
{
    partial class ProductionList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_login = new System.Windows.Forms.Button();
            this.cb_employees = new System.Windows.Forms.ComboBox();
            this.cb_operation = new System.Windows.Forms.ComboBox();
            this.cb_productionlist = new System.Windows.Forms.ComboBox();
            this.cb_monitoring = new System.Windows.Forms.ComboBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.생산시작시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.생산완료시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.색깔 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_login);
            this.panel1.Controls.Add(this.cb_employees);
            this.panel1.Controls.Add(this.cb_operation);
            this.panel1.Controls.Add(this.cb_productionlist);
            this.panel1.Controls.Add(this.cb_monitoring);
            this.panel1.Location = new System.Drawing.Point(408, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 112);
            this.panel1.TabIndex = 4;
            // 
            // bt_login
            // 
            this.bt_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_login.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_login.Location = new System.Drawing.Point(720, 56);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(80, 24);
            this.bt_login.TabIndex = 7;
            this.bt_login.Text = "로그인";
            this.bt_login.UseVisualStyleBackColor = true;
            // 
            // cb_employees
            // 
            this.cb_employees.BackColor = System.Drawing.Color.White;
            this.cb_employees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_employees.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_employees.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cb_employees.FormattingEnabled = true;
            this.cb_employees.Location = new System.Drawing.Point(520, 48);
            this.cb_employees.Name = "cb_employees";
            this.cb_employees.Size = new System.Drawing.Size(136, 34);
            this.cb_employees.TabIndex = 6;
            this.cb_employees.TabStop = false;
            this.cb_employees.Text = "직원관리";
            // 
            // cb_operation
            // 
            this.cb_operation.BackColor = System.Drawing.Color.White;
            this.cb_operation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_operation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_operation.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_operation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cb_operation.FormattingEnabled = true;
            this.cb_operation.ItemHeight = 26;
            this.cb_operation.Location = new System.Drawing.Point(368, 48);
            this.cb_operation.Name = "cb_operation";
            this.cb_operation.Size = new System.Drawing.Size(136, 34);
            this.cb_operation.TabIndex = 5;
            this.cb_operation.TabStop = false;
            this.cb_operation.Text = "가동현황";
            // 
            // cb_productionlist
            // 
            this.cb_productionlist.BackColor = System.Drawing.Color.White;
            this.cb_productionlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_productionlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_productionlist.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_productionlist.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cb_productionlist.FormattingEnabled = true;
            this.cb_productionlist.Location = new System.Drawing.Point(208, 48);
            this.cb_productionlist.Name = "cb_productionlist";
            this.cb_productionlist.Size = new System.Drawing.Size(136, 34);
            this.cb_productionlist.TabIndex = 4;
            this.cb_productionlist.TabStop = false;
            this.cb_productionlist.Text = "생산목록";
            // 
            // cb_monitoring
            // 
            this.cb_monitoring.BackColor = System.Drawing.Color.White;
            this.cb_monitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_monitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_monitoring.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_monitoring.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cb_monitoring.FormattingEnabled = true;
            this.cb_monitoring.Location = new System.Drawing.Point(48, 48);
            this.cb_monitoring.Name = "cb_monitoring";
            this.cb_monitoring.Size = new System.Drawing.Size(136, 34);
            this.cb_monitoring.TabIndex = 3;
            this.cb_monitoring.TabStop = false;
            this.cb_monitoring.Text = "모니터링";
            // 
            // pb_logo
            // 
            this.pb_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_logo.Image = global::CNHRD_Team2_FinalProject.Properties.Resources.HDlogo;
            this.pb_logo.Location = new System.Drawing.Point(16, 16);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(384, 112);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 3;
            this.pb_logo.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 168);
            this.dateTimePicker1.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 10, 16, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 30);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.생산시작시간,
            this.생산완료시간,
            this.색깔});
            this.dataGridView1.Location = new System.Drawing.Point(76, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(427, 78);
            this.dataGridView1.TabIndex = 6;
            // 
            // 생산시작시간
            // 
            this.생산시작시간.HeaderText = "생산시작시간";
            this.생산시작시간.MinimumWidth = 6;
            this.생산시작시간.Name = "생산시작시간";
            this.생산시작시간.Width = 125;
            // 
            // 생산완료시간
            // 
            this.생산완료시간.HeaderText = "생산완료시간";
            this.생산완료시간.MinimumWidth = 6;
            this.생산완료시간.Name = "생산완료시간";
            this.생산완료시간.Width = 125;
            // 
            // 색깔
            // 
            this.색깔.HeaderText = "색깔";
            this.색깔.MinimumWidth = 6;
            this.색깔.Name = "색깔";
            this.색깔.Width = 125;
            // 
            // ProductionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_logo);
            this.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductionList";
            this.Text = "생산목록";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.ComboBox cb_employees;
        private System.Windows.Forms.ComboBox cb_operation;
        private System.Windows.Forms.ComboBox cb_productionlist;
        private System.Windows.Forms.ComboBox cb_monitoring;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생산시작시간;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생산완료시간;
        private System.Windows.Forms.DataGridViewTextBoxColumn 색깔;
    }
}