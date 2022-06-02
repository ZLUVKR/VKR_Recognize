namespace Recognize.Views
{
    partial class PatientView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReport = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblOpen = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpFind = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chBox = new System.Windows.Forms.CheckBox();
            this.cmbInputDate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.cmbProcState = new System.Windows.Forms.ComboBox();
            this.lblProcState = new System.Windows.Forms.Label();
            this.ProcessingStateAsText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessingState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сonclusionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СonclusionOfNeural = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource)).BeginInit();
            this.grpFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblReport);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.lblOpen);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 90);
            this.panel1.TabIndex = 0;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(79, 64);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(88, 13);
            this.lblReport.TabIndex = 3;
            this.lblReport.Text = "Показать отчет";
            this.lblReport.Visible = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.Location = new System.Drawing.Point(90, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(57, 58);
            this.btnReport.TabIndex = 2;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Visible = false;
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Location = new System.Drawing.Point(6, 63);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(53, 13);
            this.lblOpen.TabIndex = 1;
            this.lblOpen.Text = "Открыть";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreate.BackgroundImage")));
            this.btnCreate.Location = new System.Drawing.Point(9, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(50, 60);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessingStateAsText,
            this.patientNameDataGridViewTextBoxColumn,
            this.Id,
            this.ProcessingState,
            this.inputDateDataGridViewTextBoxColumn,
            this.ImagePath,
            this.сonclusionDataGridViewTextBoxColumn,
            this.СonclusionOfNeural,
            this.doctorNameDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 234);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(844, 306);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataSource
            // 
            this.dataSource.DataSource = typeof(Recognize.Entities.Record);
            // 
            // grpFind
            // 
            this.grpFind.Controls.Add(this.btnClear);
            this.grpFind.Controls.Add(this.btnRefresh);
            this.grpFind.Controls.Add(this.chBox);
            this.grpFind.Controls.Add(this.cmbInputDate);
            this.grpFind.Controls.Add(this.label1);
            this.grpFind.Controls.Add(this.txtPatientName);
            this.grpFind.Controls.Add(this.lblPatientName);
            this.grpFind.Controls.Add(this.cmbProcState);
            this.grpFind.Controls.Add(this.lblProcState);
            this.grpFind.Location = new System.Drawing.Point(4, 92);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(829, 134);
            this.grpFind.TabIndex = 2;
            this.grpFind.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(727, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Сбросить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(727, 89);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chBox
            // 
            this.chBox.AutoSize = true;
            this.chBox.Location = new System.Drawing.Point(266, 25);
            this.chBox.Name = "chBox";
            this.chBox.Size = new System.Drawing.Size(129, 17);
            this.chBox.TabIndex = 6;
            this.chBox.Text = "Обработанные мной";
            this.chBox.UseVisualStyleBackColor = true;
            this.chBox.Visible = false;
            // 
            // cmbInputDate
            // 
            this.cmbInputDate.FormattingEnabled = true;
            this.cmbInputDate.Items.AddRange(new object[] {
            "по убыванию",
            "по возрастанию"});
            this.cmbInputDate.Location = new System.Drawing.Point(114, 91);
            this.cmbInputDate.Name = "cmbInputDate";
            this.cmbInputDate.Size = new System.Drawing.Size(121, 21);
            this.cmbInputDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата приема";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(114, 58);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(220, 21);
            this.txtPatientName.TabIndex = 3;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(8, 61);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(81, 13);
            this.lblPatientName.TabIndex = 2;
            this.lblPatientName.Text = "ФИО пациента";
            // 
            // cmbProcState
            // 
            this.cmbProcState.FormattingEnabled = true;
            this.cmbProcState.Items.AddRange(new object[] {
            "не обработано",
            "обработано"});
            this.cmbProcState.Location = new System.Drawing.Point(114, 23);
            this.cmbProcState.Name = "cmbProcState";
            this.cmbProcState.Size = new System.Drawing.Size(121, 21);
            this.cmbProcState.TabIndex = 1;
            this.cmbProcState.SelectedIndexChanged += new System.EventHandler(this.cmbProcState_SelectedIndexChanged);
            // 
            // lblProcState
            // 
            this.lblProcState.AutoSize = true;
            this.lblProcState.Location = new System.Drawing.Point(8, 26);
            this.lblProcState.Name = "lblProcState";
            this.lblProcState.Size = new System.Drawing.Size(100, 13);
            this.lblProcState.TabIndex = 0;
            this.lblProcState.Text = "Статус обработки";
            // 
            // ProcessingStateAsText
            // 
            this.ProcessingStateAsText.DataPropertyName = "ProcessingStateAsText";
            this.ProcessingStateAsText.HeaderText = "Статус обработки";
            this.ProcessingStateAsText.Name = "ProcessingStateAsText";
            this.ProcessingStateAsText.ReadOnly = true;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "ФИО пациента";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            this.patientNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ProcessingState
            // 
            this.ProcessingState.DataPropertyName = "ProcessingState";
            this.ProcessingState.HeaderText = "ProcessingState";
            this.ProcessingState.Name = "ProcessingState";
            this.ProcessingState.ReadOnly = true;
            this.ProcessingState.Visible = false;
            // 
            // inputDateDataGridViewTextBoxColumn
            // 
            this.inputDateDataGridViewTextBoxColumn.DataPropertyName = "InputDate";
            this.inputDateDataGridViewTextBoxColumn.HeaderText = "Дата приема";
            this.inputDateDataGridViewTextBoxColumn.Name = "inputDateDataGridViewTextBoxColumn";
            // 
            // ImagePath
            // 
            this.ImagePath.DataPropertyName = "ImagePath";
            this.ImagePath.HeaderText = "R - снимок";
            this.ImagePath.Name = "ImagePath";
            // 
            // сonclusionDataGridViewTextBoxColumn
            // 
            this.сonclusionDataGridViewTextBoxColumn.DataPropertyName = "Сonclusion";
            this.сonclusionDataGridViewTextBoxColumn.HeaderText = "Заключение";
            this.сonclusionDataGridViewTextBoxColumn.Name = "сonclusionDataGridViewTextBoxColumn";
            this.сonclusionDataGridViewTextBoxColumn.Width = 110;
            // 
            // СonclusionOfNeural
            // 
            this.СonclusionOfNeural.DataPropertyName = "СonclusionOfNeural";
            this.СonclusionOfNeural.HeaderText = "Заключение НС";
            this.СonclusionOfNeural.Name = "СonclusionOfNeural";
            this.СonclusionOfNeural.Width = 110;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "ФИО доктора";
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Дата заключения";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // PatientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(839, 540);
            this.Controls.Add(this.grpFind);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PatientView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LungCare";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource)).EndInit();
            this.grpFind.ResumeLayout(false);
            this.grpFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblReport;
        private Button btnReport;
        private Label lblOpen;
        private Button btnCreate;
        private DataGridView dataGridView1;
        private BindingSource dataSource;
        private GroupBox grpFind;
        private Label lblProcState;
        private Button btnRefresh;
        private CheckBox chBox;
        private ComboBox cmbInputDate;
        private Label label1;
        private TextBox txtPatientName;
        private Label lblPatientName;
        private ComboBox cmbProcState;
        private Button btnClear;
        private DataGridViewTextBoxColumn ProcessingStateAsText;
        private DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProcessingState;
        private DataGridViewTextBoxColumn inputDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ImagePath;
        private DataGridViewTextBoxColumn сonclusionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn СonclusionOfNeural;
        private DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
    }
}