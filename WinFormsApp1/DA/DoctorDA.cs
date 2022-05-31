using Recognize.DA;
using System.Data;
using System.Data.Odbc;

namespace Recognize
{
    internal class DoctorDA : BaseDA
    {
        /// <summary>
        /// Попытка авторизации текущим доктором
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="password">пароль</param>
        /// <param name="currentDoctor">сущность доктора при успехе иначе null</param>
        /// <returns>true - нашли логин/пароль false - не нашли</returns>
        public bool TryAuth(string login, string password, out Entities.Doctor currentDoctor)
        {
            Entities.Doctor doctor = null;

            var result = false;
            using (var cmd = ExcelCmd("select id, login, fullname from [doctor$] WHERE login = ? AND password = ?"))
            {
                CmdExecutor(cmd, delegate
                {
                    cmd.Parameters.Add("@login", OdbcType.VarChar).Value = login;
                    cmd.Parameters.Add("@password", OdbcType.VarChar).Value = password;
                    OdbcDataReader dr = cmd.ExecuteReader();
                    foreach (IDataRecord item in dr)
                    {
                        result = true;
                        doctor = new Entities.Doctor()
                        {
                            Id = long.Parse(item["id"].ToString()),
                            Login = login,
                            FullName = item["fullname"].ToString()
                        };
                    }
                });
            }
            currentDoctor = doctor;

            return result;
        }

        /// <summary>
        /// Попытаться зарегать доктора
        /// </summary>
        /// <param name="fio">фио</param>
        /// <param name="login">логин</param>
        /// <param name="password">пароль</param>
        /// <returns>false - пользователь существует, true - зарегали</returns>
        public bool TryReg(string fio, string login, string password)
        {
            if (IsUserExists(login))
                return false;

            var id = GetSeqNextVal();

            using (var cmd = ExcelCmd($"insert into [doctor$] (id, login, password, fullname) values(?, ?, ?, ?)"))
            {
                CmdExecutor(cmd, delegate
                {
                    cmd.Parameters.Add("@id", OdbcType.Int).Value = id;
                    cmd.Parameters.Add("@login", OdbcType.VarChar).Value = login;
                    cmd.Parameters.Add("@password", OdbcType.VarChar).Value = password;
                    cmd.Parameters.Add("@fullname", OdbcType.VarChar).Value = fio;

                    cmd.ExecuteNonQuery();
                });
            }
            return true;
        }


        /// <summary>
        /// Проверка на существование юзера с таким логином
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        private bool IsUserExists(string login)
        {
            var result = false;
            using (var cmd = ExcelCmd("select 1 from [doctor$] WHERE login = ?"))
            {
                CmdExecutor(cmd, delegate
                {
                    cmd.Parameters.Add("@login", OdbcType.VarChar).Value = login;
                    OdbcDataReader dr = cmd.ExecuteReader();
                    foreach (IDataRecord item in dr)
                    {
                        result = true;
                    }
                });

            }
            return result;
        }

        /// <summary>
        /// Получение ида для очередного доктора
        /// </summary>
        /// <returns></returns>
        private long GetSeqNextVal()
        {
            long result = 0;
            using (var cmd = ExcelCmd("select doctor_sequence from[settings$]"))
            {
                CmdExecutor(cmd, delegate
                {
                    OdbcDataReader dr = cmd.ExecuteReader();
                    foreach (IDataRecord item in dr)
                    {
                        result = long.Parse(item["doctor_sequence"].ToString());
                    }
                });

            }
            return result;
        }
    }
}
