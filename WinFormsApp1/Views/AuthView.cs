﻿using Recognize.BL;
using Recognize.DA;

namespace Recognize.Views
{
    public partial class AuthView : Form
    {

        private Entities.Doctor _currentDoctor;

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
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            var errProvider = new ErrorProvider();
            if (string.IsNullOrWhiteSpace(authPassTxt.Text))
            {
                errProvider.SetError(authPassTxt, "Не введен пароль");
                return;
            }
            if (string.IsNullOrWhiteSpace(authLoginTxt.Text))
            {
                errProvider.SetError(authLoginTxt, "Не введен логин");
                return;
            }
            var login = authLoginTxt.Text;
            var password = GeneralBL.GetMD5Hash(authPassTxt.Text);
            var authResult = DoctorDA.TryAuth(login, password, out _currentDoctor);
            if (authResult)
                MessageBox.Show($"Добро пожаловать, {_currentDoctor.FullName}");
            else
                MessageBox.Show("Не удалось войти, неверный логин/пароль");

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            var errProvider = new ErrorProvider();
            if (string.IsNullOrWhiteSpace(regPasswordTxt.Text))
            {
                errProvider.SetError(regPasswordTxt, "Не введен пароль");
                return;
            }
            if (string.IsNullOrWhiteSpace(regLoginTxt.Text))
            {
                errProvider.SetError(regLoginTxt, "Не введен логин");
                return;
            }
            if (string.IsNullOrWhiteSpace(regFioTxt.Text))
            {
                errProvider.SetError(regFioTxt, "Не введен ФИО");
                return;
            }

            var login = regLoginTxt.Text;
            var password = GeneralBL.GetMD5Hash(regPasswordTxt.Text);
            var fio = regFioTxt.Text;
            DoctorDA.TryReg(fio, login, password);
        }
    }
}
