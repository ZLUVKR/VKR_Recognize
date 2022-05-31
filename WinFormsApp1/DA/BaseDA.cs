using System.Data.Odbc;

namespace Recognize.DA
{
    /// <summary>
    /// Базовый дата аксес 
    /// </summary>
    internal class BaseDA
    {
        private const string DbName = @"C:\temp\db.xlsx;";
        internal const string DbConnStr = @"Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};Dsn=Excel Files;dbq=" + DbName + "ReadOnly=0;";

        internal OdbcCommand ExcelCmd(string command)
        {
            return new OdbcCommand(command, new OdbcConnection(DbConnStr));
        }

        internal void CmdExecutor(OdbcCommand cmd, Action action)
        {
            try
            {
                cmd.Connection.Open();
                action();
            }
            catch { throw; }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
