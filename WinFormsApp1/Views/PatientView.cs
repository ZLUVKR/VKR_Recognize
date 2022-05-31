namespace Recognize.Views
{
    public partial class PatientView : Form
    {
        public Entities.Doctor CurrentDoctor;
        public PatientView()
        {
            InitializeComponent();
            Presenter.GetDocument();
            this.dataSource = new BindingSource();
            dataSource.DataSource = Presenter.Document;
            dataGridView1.DataSource = dataSource;
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();
        }

        private PatientViewPresenter _presenter;
        private PatientViewPresenter Presenter
        {
            get { return _presenter ??= new PatientViewPresenter(); }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnReport.Enabled = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ProcessingState"].Value) == 0;
                lblReport.Enabled = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ProcessingState"].Value) == 0;
            }
                
        }

        private void cmbProcState_SelectedIndexChanged(object sender, EventArgs e)
        {
            chBox.Checked = false;
            if (cmbProcState.SelectedIndex == 1)
                chBox.Visible = true;
            else
                chBox.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var changedDocument = Presenter.Document;
            //Сортировка по состоянию обработки
            switch (cmbProcState.SelectedIndex)
            {
                case 0:
                    changedDocument = changedDocument.Where(x => x.ProcessingState != 0).ToList();
                    break;
                case 1:
                    changedDocument = changedDocument.Where(x => x.ProcessingState == 0).ToList();
                    if (chBox.Checked)
                        changedDocument = changedDocument.Where(x => x.DoctorName == CurrentDoctor.FullName).ToList();
                    break;
                default:
                    break;
            }

            //Сортировка по фамилии пациента
            if (!string.IsNullOrEmpty(txtPatientName.Text))
                changedDocument = changedDocument.Where(x => x.PatientName == txtPatientName.Text).ToList();

            //Сортировка по дате
            switch (cmbInputDate.SelectedIndex)
            {
                case 0:
                    changedDocument = changedDocument.OrderByDescending(x => x.InputDate).ToList();
                    break;
                case 1:
                    changedDocument = changedDocument.OrderBy(x => x.InputDate).ToList();
                    break;
                default:
                    break;
            }

            //Обновляем
            dataSource.DataSource = changedDocument;
            dataGridView1.DataSource = dataSource;
            dataGridView1.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Обновляем
            dataSource.DataSource = Presenter.Document;
            dataGridView1.DataSource = dataSource;
            dataGridView1.Refresh();

            cmbProcState.SelectedIndex = -1;
            cmbInputDate.SelectedIndex = -1;
            txtPatientName.Clear();
            chBox.Visible = false;
            chBox.Checked = false;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Необходимо выбрать строку, которую нужно открыть", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var imagePath = dataGridView1.SelectedRows[0].Cells["ImagePath"].Value.ToString();
            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Запись не привязана к рентгеновскому снимку, открыть форму невозможно", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());

            var record = Presenter.Document.Where(x => x.Id == id).First();

            DetailImageView detailImageView = new DetailImageView(record, CurrentDoctor);
            detailImageView.FormClosed += FormClosed;
            detailImageView.Show();
            Hide();
        }

        public void FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}