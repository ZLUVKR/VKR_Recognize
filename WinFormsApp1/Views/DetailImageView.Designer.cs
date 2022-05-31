namespace Recognize.Views
{
    partial class DetailImageView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailImageView));
            this.zoomPictureBox1 = new Recognize.Views.ZoomPictureBox();
            this.txtConclusion = new System.Windows.Forms.TextBox();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSave = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zoomPictureBox1
            // 
            this.zoomPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoomPictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
            this.zoomPictureBox1.InterpolationModeZoomOut = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
            this.zoomPictureBox1.Location = new System.Drawing.Point(76, 99);
            this.zoomPictureBox1.Name = "zoomPictureBox1";
            this.zoomPictureBox1.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.zoomPictureBox1.Size = new System.Drawing.Size(399, 311);
            this.zoomPictureBox1.TabIndex = 1;
            this.zoomPictureBox1.VisibleCenter = ((System.Drawing.PointF)(resources.GetObject("zoomPictureBox1.VisibleCenter")));
            // 
            // txtConclusion
            // 
            this.txtConclusion.BackColor = System.Drawing.SystemColors.Window;
            this.txtConclusion.Location = new System.Drawing.Point(35, 442);
            this.txtConclusion.Multiline = true;
            this.txtConclusion.Name = "txtConclusion";
            this.txtConclusion.Size = new System.Drawing.Size(560, 75);
            this.txtConclusion.TabIndex = 2;
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Location = new System.Drawing.Point(35, 426);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(70, 13);
            this.lblConclusion.TabIndex = 3;
            this.lblConclusion.Text = "Заключение";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSave);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblBack);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 82);
            this.panel1.TabIndex = 4;
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(79, 64);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(62, 13);
            this.lblSave.TabIndex = 3;
            this.lblSave.Text = "Сохранить";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.Location = new System.Drawing.Point(93, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 58);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(10, 63);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(38, 13);
            this.lblBack.TabIndex = 1;
            this.lblBack.Text = "Назад";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Location = new System.Drawing.Point(6, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 60);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DetailImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.zoomPictureBox1);
            this.Controls.Add(this.txtConclusion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DetailImageView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LungCare - Заключение";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZoomPictureBox zoomPictureBox1;
        private TextBox txtConclusion;
        private Label lblConclusion;
        private Panel panel1;
        private Label lblSave;
        private Button btnSave;
        private Label lblBack;
        private Button btnBack;
    }
}