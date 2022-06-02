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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailImageView));
            this.zoomPictureBox1 = new Recognize.Views.ZoomPictureBox();
            this.txtConclusion = new System.Windows.Forms.TextBox();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSave = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpNeuralResult = new System.Windows.Forms.GroupBox();
            this.lblValGood = new System.Windows.Forms.Label();
            this.blbValFibr = new System.Windows.Forms.Label();
            this.lblValPlTh = new System.Windows.Forms.Label();
            this.lblValCard = new System.Windows.Forms.Label();
            this.pbFibr = new Recognize.Views.CustomProgressBar();
            this.pbPlTh = new Recognize.Views.CustomProgressBar();
            this.pbCardiom = new Recognize.Views.CustomProgressBar();
            this.lblGood = new System.Windows.Forms.Label();
            this.lblFibr = new System.Windows.Forms.Label();
            this.lblPlTh = new System.Windows.Forms.Label();
            this.lblCardiomegaly = new System.Windows.Forms.Label();
            this.pbGood = new Recognize.Views.CustomProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbLoad = new Recognize.Views.CustomProgressBar();
            this.lblWait = new System.Windows.Forms.Label();
            this.txtNeural = new System.Windows.Forms.TextBox();
            this.lblOfNeural = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.grpNeuralResult.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.txtConclusion.Location = new System.Drawing.Point(28, 442);
            this.txtConclusion.Multiline = true;
            this.txtConclusion.Name = "txtConclusion";
            this.txtConclusion.Size = new System.Drawing.Size(523, 75);
            this.txtConclusion.TabIndex = 2;
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Location = new System.Drawing.Point(30, 426);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(103, 13);
            this.lblConclusion.TabIndex = 3;
            this.lblConclusion.Text = "Заключение врача";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSave);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblBack);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 82);
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
            // grpNeuralResult
            // 
            this.grpNeuralResult.Controls.Add(this.lblValGood);
            this.grpNeuralResult.Controls.Add(this.blbValFibr);
            this.grpNeuralResult.Controls.Add(this.lblValPlTh);
            this.grpNeuralResult.Controls.Add(this.lblValCard);
            this.grpNeuralResult.Controls.Add(this.pbFibr);
            this.grpNeuralResult.Controls.Add(this.pbPlTh);
            this.grpNeuralResult.Controls.Add(this.pbCardiom);
            this.grpNeuralResult.Controls.Add(this.lblGood);
            this.grpNeuralResult.Controls.Add(this.lblFibr);
            this.grpNeuralResult.Controls.Add(this.lblPlTh);
            this.grpNeuralResult.Controls.Add(this.lblCardiomegaly);
            this.grpNeuralResult.Location = new System.Drawing.Point(579, 143);
            this.grpNeuralResult.Name = "grpNeuralResult";
            this.grpNeuralResult.Size = new System.Drawing.Size(459, 210);
            this.grpNeuralResult.TabIndex = 5;
            this.grpNeuralResult.TabStop = false;
            // 
            // lblValGood
            // 
            this.lblValGood.AutoSize = true;
            this.lblValGood.Location = new System.Drawing.Point(340, 170);
            this.lblValGood.Name = "lblValGood";
            this.lblValGood.Size = new System.Drawing.Size(13, 13);
            this.lblValGood.TabIndex = 10;
            this.lblValGood.Text = "0";
            // 
            // blbValFibr
            // 
            this.blbValFibr.AutoSize = true;
            this.blbValFibr.Location = new System.Drawing.Point(339, 129);
            this.blbValFibr.Name = "blbValFibr";
            this.blbValFibr.Size = new System.Drawing.Size(13, 13);
            this.blbValFibr.TabIndex = 9;
            this.blbValFibr.Text = "0";
            // 
            // lblValPlTh
            // 
            this.lblValPlTh.AutoSize = true;
            this.lblValPlTh.Location = new System.Drawing.Point(338, 86);
            this.lblValPlTh.Name = "lblValPlTh";
            this.lblValPlTh.Size = new System.Drawing.Size(13, 13);
            this.lblValPlTh.TabIndex = 8;
            this.lblValPlTh.Text = "0";
            // 
            // lblValCard
            // 
            this.lblValCard.AutoSize = true;
            this.lblValCard.Location = new System.Drawing.Point(337, 42);
            this.lblValCard.Name = "lblValCard";
            this.lblValCard.Size = new System.Drawing.Size(13, 13);
            this.lblValCard.TabIndex = 7;
            this.lblValCard.Text = "0";
            // 
            // pbFibr
            // 
            this.pbFibr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbFibr.BorderColor = System.Drawing.Color.Black;
            this.pbFibr.BorderWidth = 0;
            this.pbFibr.ForeColor = System.Drawing.Color.Black;
            this.pbFibr.Location = new System.Drawing.Point(126, 121);
            this.pbFibr.MaxValue = 100;
            this.pbFibr.MinValue = 0;
            this.pbFibr.Name = "pbFibr";
            this.pbFibr.ProgressColor = System.Drawing.Color.SteelBlue;
            this.pbFibr.ProgressTextType = Recognize.Views.CustomProgressBar.FsProgressTextType.AsIs;
            this.pbFibr.ShowProgressText = false;
            this.pbFibr.Size = new System.Drawing.Size(200, 30);
            this.pbFibr.TabIndex = 6;
            this.pbFibr.Value = 0;
            // 
            // pbPlTh
            // 
            this.pbPlTh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbPlTh.BorderColor = System.Drawing.Color.Black;
            this.pbPlTh.BorderWidth = 0;
            this.pbPlTh.ForeColor = System.Drawing.Color.Black;
            this.pbPlTh.Location = new System.Drawing.Point(126, 78);
            this.pbPlTh.MaxValue = 100;
            this.pbPlTh.MinValue = 0;
            this.pbPlTh.Name = "pbPlTh";
            this.pbPlTh.ProgressColor = System.Drawing.Color.SteelBlue;
            this.pbPlTh.ProgressTextType = Recognize.Views.CustomProgressBar.FsProgressTextType.AsIs;
            this.pbPlTh.ShowProgressText = false;
            this.pbPlTh.Size = new System.Drawing.Size(200, 30);
            this.pbPlTh.TabIndex = 5;
            this.pbPlTh.Value = 0;
            // 
            // pbCardiom
            // 
            this.pbCardiom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbCardiom.BorderColor = System.Drawing.Color.Black;
            this.pbCardiom.BorderWidth = 0;
            this.pbCardiom.ForeColor = System.Drawing.Color.Black;
            this.pbCardiom.Location = new System.Drawing.Point(126, 35);
            this.pbCardiom.MaxValue = 100;
            this.pbCardiom.MinValue = 0;
            this.pbCardiom.Name = "pbCardiom";
            this.pbCardiom.ProgressColor = System.Drawing.Color.SteelBlue;
            this.pbCardiom.ProgressTextType = Recognize.Views.CustomProgressBar.FsProgressTextType.AsIs;
            this.pbCardiom.ShowProgressText = false;
            this.pbCardiom.Size = new System.Drawing.Size(200, 30);
            this.pbCardiom.TabIndex = 4;
            this.pbCardiom.Value = 10;
            // 
            // lblGood
            // 
            this.lblGood.AutoSize = true;
            this.lblGood.Location = new System.Drawing.Point(24, 173);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(80, 13);
            this.lblGood.TabIndex = 3;
            this.lblGood.Text = "Без патологий";
            // 
            // lblFibr
            // 
            this.lblFibr.AutoSize = true;
            this.lblFibr.Location = new System.Drawing.Point(24, 135);
            this.lblFibr.Name = "lblFibr";
            this.lblFibr.Size = new System.Drawing.Size(44, 13);
            this.lblFibr.TabIndex = 2;
            this.lblFibr.Text = "Фиброз";
            // 
            // lblPlTh
            // 
            this.lblPlTh.AutoSize = true;
            this.lblPlTh.Location = new System.Drawing.Point(20, 82);
            this.lblPlTh.Name = "lblPlTh";
            this.lblPlTh.Size = new System.Drawing.Size(74, 26);
            this.lblPlTh.TabIndex = 1;
            this.lblPlTh.Text = "Плевральное\r\n утолщение";
            // 
            // lblCardiomegaly
            // 
            this.lblCardiomegaly.AutoSize = true;
            this.lblCardiomegaly.Location = new System.Drawing.Point(19, 40);
            this.lblCardiomegaly.Name = "lblCardiomegaly";
            this.lblCardiomegaly.Size = new System.Drawing.Size(86, 13);
            this.lblCardiomegaly.TabIndex = 0;
            this.lblCardiomegaly.Text = "Кардиомегалия";
            // 
            // pbGood
            // 
            this.pbGood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbGood.BorderColor = System.Drawing.Color.Black;
            this.pbGood.BorderWidth = 0;
            this.pbGood.ForeColor = System.Drawing.Color.Black;
            this.pbGood.Location = new System.Drawing.Point(705, 304);
            this.pbGood.MaxValue = 100;
            this.pbGood.MinValue = 0;
            this.pbGood.Name = "pbGood";
            this.pbGood.ProgressColor = System.Drawing.Color.SteelBlue;
            this.pbGood.ProgressTextType = Recognize.Views.CustomProgressBar.FsProgressTextType.AsIs;
            this.pbGood.ShowProgressText = false;
            this.pbGood.Size = new System.Drawing.Size(200, 30);
            this.pbGood.TabIndex = 6;
            this.pbGood.Value = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbLoad);
            this.panel2.Controls.Add(this.lblWait);
            this.panel2.Location = new System.Drawing.Point(218, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 200);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // pbLoad
            // 
            this.pbLoad.BackColor = System.Drawing.SystemColors.Control;
            this.pbLoad.BorderColor = System.Drawing.Color.Black;
            this.pbLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLoad.BorderWidth = 0;
            this.pbLoad.ForeColor = System.Drawing.Color.Black;
            this.pbLoad.Location = new System.Drawing.Point(258, 67);
            this.pbLoad.MaxValue = 100;
            this.pbLoad.MinValue = 0;
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.ProgressColor = System.Drawing.Color.SkyBlue;
            this.pbLoad.ProgressTextType = Recognize.Views.CustomProgressBar.FsProgressTextType.AsIs;
            this.pbLoad.ShowProgressText = false;
            this.pbLoad.Size = new System.Drawing.Size(200, 30);
            this.pbLoad.TabIndex = 1;
            this.pbLoad.Value = 0;
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWait.Location = new System.Drawing.Point(258, 37);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(201, 25);
            this.lblWait.TabIndex = 0;
            this.lblWait.Text = "Ожидайте загрузки";
            // 
            // txtNeural
            // 
            this.txtNeural.BackColor = System.Drawing.SystemColors.Window;
            this.txtNeural.Location = new System.Drawing.Point(579, 442);
            this.txtNeural.Multiline = true;
            this.txtNeural.Name = "txtNeural";
            this.txtNeural.Size = new System.Drawing.Size(456, 75);
            this.txtNeural.TabIndex = 8;
            // 
            // lblOfNeural
            // 
            this.lblOfNeural.AutoSize = true;
            this.lblOfNeural.Location = new System.Drawing.Point(579, 426);
            this.lblOfNeural.Name = "lblOfNeural";
            this.lblOfNeural.Size = new System.Drawing.Size(153, 13);
            this.lblOfNeural.TabIndex = 9;
            this.lblOfNeural.Text = "Заключение нейронной сети";
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // DetailImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 555);
            this.Controls.Add(this.lblOfNeural);
            this.Controls.Add(this.txtNeural);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbGood);
            this.Controls.Add(this.grpNeuralResult);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetailImageView_FormClosing);
            this.Shown += new System.EventHandler(this.DetailImageView_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpNeuralResult.ResumeLayout(false);
            this.grpNeuralResult.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private GroupBox grpNeuralResult;
        private Label lblCardiomegaly;
        private Label lblGood;
        private Label lblFibr;
        private Label lblPlTh;
        private Label lblValPlTh;
        private Label lblValCard;
        private CustomProgressBar pbFibr;
        private CustomProgressBar pbPlTh;
        private CustomProgressBar pbCardiom;
        private CustomProgressBar pbGood;
        private Label lblValGood;
        private Label blbValFibr;
        private Panel panel2;
        private Label lblWait;
        private CustomProgressBar pbLoad;
        private TextBox txtNeural;
        private Label lblOfNeural;
        private ToolTip toolTip1;
    }
}