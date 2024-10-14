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