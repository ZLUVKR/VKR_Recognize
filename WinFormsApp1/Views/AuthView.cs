using Recognize.BL;
using Recognize.DA;

namespace Recognize.Views
{
    public partial class AuthView : Form
    {

        private Entities.Doctor _currentDoctor;

        private ErrorProvider _errorProvider;

        private DoctorDA _doctorDA;
        private DoctorDA DoctorDA
        {
            get { return _doctorDA ??= new DoctorDA(); }
        }

        private GeneralBL _generalBL;
        private GeneralBL GeneralBL
        {
            get { return _generalBL ??= new GeneralBL(); }
        }

        public AuthView()
        {
            InitializeComponent();
            _errorProvider = new ErrorProvider();
            _errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void authBtn_Click(object sender, EventArgs e)
        {
            _errorProvider.Clear();
            bool check = false;
            if (string.IsNullOrWhiteSpace(authPassTxt.Text))
            {
                _errorProvider.SetError(authPassTxt, "Не введен пароль");
                check = true;
            }
            if (string.IsNullOrWhiteSpace(authLoginTxt.Text))
            {
                _errorProvider.SetError(authLoginTxt, "Не введен логин");
                check = true;
            }
            if (check)
            {
                MessageBox.Show("Проверьте корректность введенных данных", "Предупреждение", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            var login = authLoginTxt.Text;
            var password = GeneralBL.GetMD5Hash(authPassTxt.Text);
            var authResult = DoctorDA.TryAuth(login, password, out _currentDoctor);
            if (authResult)
            {
                MessageBox.Show($"Добро пожаловать, {_currentDoctor.FullName}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PatientView patientView = new PatientView();
                patientView.CurrentDoctor = _currentDoctor;
                patientView.Show();
                Hide();
            }
            else
                MessageBox.Show("Не удалось войти, неверный логин/пароль", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        /// <summary>
        /// Регистрация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReg_Click(object sender, EventArgs e)
        {
            _errorProvider.Clear();
            bool check = false;
            if (string.IsNullOrWhiteSpace(regPasswordTxt.Text))
            {
                _errorProvider.SetError(regPasswordTxt, "Не введен пароль");
                check = true;
            }
            if (string.IsNullOrWhiteSpace(regLoginTxt.Text))
            {
                _errorProvider.SetError(regLoginTxt, "Не введен логин");
                check = true;
            }
            if (string.IsNullOrWhiteSpace(regFioTxt.Text))
            {
                _errorProvider.SetError(regFioTxt, "Не введен ФИО");
                check = true;
            }
            if (check)
            {
                MessageBox.Show("Проверьте корректность введенных данных", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var login = regLoginTxt.Text;
            var password = GeneralBL.GetMD5Hash(regPasswordTxt.Text);
            var fio = regFioTxt.Text;
            if (DoctorDA.TryReg(fio, login, password))
                MessageBox.Show("Пользователь успешно зарегистрирован", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Пользователь с таким логином уже есть в системе", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ;
        }
    }
}
