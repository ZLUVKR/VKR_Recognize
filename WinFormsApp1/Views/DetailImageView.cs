using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recognize.Views
{
    public partial class DetailImageView : Form
    {
        private string _imagePath;
        private Entities.Record CurrentRecord { get; set; }

        private Entities.Doctor CurrentDoctor { get; set; }

        string path = @"c:\temp\images\";

        private DetailImageViewPresenter _presenter;
        private DetailImageViewPresenter Presenter
        {
            get { return _presenter ??= new DetailImageViewPresenter(); }
        }

        public DetailImageView(Entities.Record record, Entities.Doctor currentDoctor)
        {
            CurrentRecord = record;
            CurrentDoctor = currentDoctor;
            _imagePath = path + record.ImagePath;
            InitializeComponent();

            if (zoomPictureBox1.Image != null)
                zoomPictureBox1.Image.Dispose();
            zoomPictureBox1.Image = null;
            zoomPictureBox1.Refresh();

            zoomPictureBox1.UpdateImage(new Bitmap(_imagePath));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите перейти на предыдущую форму? Несохраненные изменения будут утеряны", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentRecord.DoctorName = CurrentDoctor.FullName;
            CurrentRecord.EndDate = DateTime.Now;
            CurrentRecord.Сonclusion = txtConclusion.Text;

            if (String.IsNullOrEmpty(txtConclusion.Text))
            {
                if (MessageBox.Show("Вы уверены, что хотите сохранить без заключения?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Presenter.SaveRecord(CurrentRecord);
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                Presenter.SaveRecord(CurrentRecord);
                this.Close();
            }

        }
    }
}
