using System.Diagnostics;
using System.Globalization;

namespace Recognize.Views
{
    public partial class DetailImageView : Form
    {
        private string _imagePath;
        private Entities.Record CurrentRecord { get; set; }

        private Entities.Doctor CurrentDoctor { get; set; }

        string sourcePath = @"c:\temp\images\";

        string targetPath = @"c:\temp\db";

        string predictionPath = @"c:\temp\predict.txt";

        string pythonExe = @"C:\Users\roma\PycharmProjects\pythonProject\dist\prediction.exe";

        string[] labels = { "Good", "Pleural Thickening", "Fibrosis" , "Cardiomegaly" };

        string[] russianLabels = { "Без патологий", "Плевральное утолщение",  "Фиброз легких", "Кардиомегалия" };

        private DetailImageViewPresenter _presenter;
        private DetailImageViewPresenter Presenter
        {
            get { return _presenter ??= new DetailImageViewPresenter(); }
        }

        private bool _pythonScriptOnExecute = true;

        public DetailImageView(Entities.Record record, Entities.Doctor currentDoctor)
        {
            CurrentRecord = record;
            CurrentDoctor = currentDoctor;
            _imagePath = sourcePath + record.ImagePath;
            InitializeComponent();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите перейти на предыдущую форму? Несохраненные изменения будут утеряны", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
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
            CurrentRecord.СonclusionOfNeural = txtNeural.Text;

            if (string.IsNullOrEmpty(txtConclusion.Text))
            {
                if (MessageBox.Show("Вы уверены, что хотите сохранить без заключения?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Presenter.SaveRecord(CurrentRecord);
                    Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                Presenter.SaveRecord(CurrentRecord);
                Close();
            }
        }

        private async void CopyImgAsync(Action doOnStart, Action doOnSuccessFinish, Action doOnFailedFinish, Action doOnFinish)
        {
            doOnStart();
            if (File.Exists(_imagePath))
            {
                if (Directory.Exists(targetPath))
                {
                    Directory.Delete(targetPath, true);
                    Directory.CreateDirectory(targetPath);
                }
                else
                {
                    Directory.CreateDirectory(targetPath);
                }
                File.Copy(_imagePath, Path.Combine(targetPath, CurrentRecord.ImagePath));

                await Task.Run(() => RunPython());
                doOnSuccessFinish();
            }
            else
            {
                doOnFailedFinish();
            }
            doOnFinish();
        }

        private void DetailImageView_Shown(object sender, EventArgs e)
        {
            btnBack.Enabled = false;
            toolTip1.SetToolTip(txtNeural, "Нейросеть была написана на основе архитектуры MobileNetV2 с помощью метода трансферного обучения. Точность обучения достигла 84%.");
            CopyImgAsync(delegate ()
            {
                panel2.Visible = true;
            },
            delegate ()
            {
                if (zoomPictureBox1.Image != null)
                    zoomPictureBox1.Image.Dispose();
                zoomPictureBox1.Image = null;
                zoomPictureBox1.Refresh();
                zoomPictureBox1.UpdateImage(new Bitmap(_imagePath));
            },
            delegate ()
            {
                if (MessageBox.Show("Изображение не найдено в источнике", "Предупреждение", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Close();
                }
            },
            delegate ()
            {
                _pythonScriptOnExecute = false;
                btnBack.Enabled = true;
                panel2.Visible = false;
                if (!string.IsNullOrEmpty(CurrentRecord.Сonclusion))
                    txtConclusion.Text = CurrentRecord.Сonclusion;
            }
            );
        }


        private void ParsingOfResult()
        {
            using (StreamReader sr = new StreamReader(predictionPath))
            {
                string line = sr.ReadLine();

                line = line.Trim('[', ']');

                string[] results = line.Split(' ');

                double[] predictions = new double[results.Length];

                Dictionary<string, double> predictDict = new Dictionary<string, double>();

                for (int i = 0; i < results.Length; i++)
                {
                    predictions[i] = double.Parse(results[i], NumberStyles.AllowExponent | NumberStyles.Float, CultureInfo.InvariantCulture);
                    predictDict.Add(labels[i], predictions[i]);
                }

                foreach (string key in predictDict.Keys)
                {
                    switch (key)
                    {
                        case "Cardiomegaly":
                            pbCardiom.Invoke(new Action (() => pbCardiom.Value = Convert.ToInt32(Math.Round(predictDict[key] * 100, 0))));
                            lblValCard.Invoke(new Action(() => lblValCard.Text = predictDict[key].ToString()));
                            break;
                        case "Good":
                            pbGood.Invoke(new Action(() => pbGood.Value = Convert.ToInt32(Math.Round(predictDict[key] * 100, 0))));
                            lblValGood.Invoke(new Action(() => lblValCard.Text = predictDict[key].ToString()));
                            break;
                        case "Pleural Thickening":
                            pbPlTh.Invoke(new Action(() => pbPlTh.Value = Convert.ToInt32(Math.Round(predictDict[key] * 100, 0))));
                            lblValPlTh.Invoke(new Action(() => lblValPlTh.Text = predictDict[key].ToString()));
                            break;
                        case "Fibrosis":
                            pbFibr.Invoke(new Action(() => pbFibr.Value = Convert.ToInt32(Math.Round(predictDict[key] * 100, 0))));
                            blbValFibr.Invoke(new Action(() => blbValFibr.Text = predictDict[key].ToString()));
                            break;
                        default:
                            break;

                    }
                }
                txtNeural.Invoke(new Action(() => txtNeural.Text = russianLabels[Array.IndexOf(predictions, predictions.Max())]));
            }
        }

        private async Task RunPython()
        {
            var process = new ProcessStartInfo();
            process.CreateNoWindow = true;
            process.FileName = pythonExe;
            process.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(process);
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            //Даем время на создание файла с предсказанием
            while (!File.Exists(predictionPath))
            {
                pbLoad.Value = pbLoad.Value == 100 ?  0 : pbLoad.Value += 5;
                if (stopWatch.Elapsed.Minutes > 1)
                    throw new Exception("Не удалось загрузить");
                else
                    Thread.Sleep(100);
            }
            stopWatch.Stop();
            //Даем пол секунды на запись текста в файл
            Thread.Sleep(500);
            using (var reader = new StreamReader(predictionPath))
            {
                var line = reader.ReadLine();
            }
            ParsingOfResult();
        }

        private void DetailImageView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = _pythonScriptOnExecute;
            if (!_pythonScriptOnExecute)
            {
                if (File.Exists(predictionPath))
                {
                    File.Delete(predictionPath);
                }
                if (Directory.Exists(targetPath))
                {
                    Directory.Delete(targetPath, true);
                }
            }
        }
    }
}
